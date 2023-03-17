using NAudio.CoreAudioApi;
using NAudio.Lame;
using NAudio.Wave;
using Squirrel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Sound_Record.Forms
{
    public partial class frmMain : Form
    {
        private bool isDragging = false;
        private Point lastLocation;

        public string versionNum;        
        Stopwatch stopwatch;

        private WaveOut waveOut = new WaveOut();
        private string outputFileName;
        private WasapiLoopbackCapture capture;
        

        public frmMain()
        {
            string filePath = Application.StartupPath + "\\data.txt";
            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                }
            }
            InitializeComponent();
            listView1.MouseDown += new MouseEventHandler(listView1_MouseDown);
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);

            //Green Screen
            //    this.BackColor = Color.Green;
            //    this.TransparencyKey=Color.Green;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            Loading();

            AddVersionNumber();         
            labelTitle.Text = "Sound Recorder ";
            CFU();

            //for (int i = -1; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            //{
            //    var caps = NAudio.Wave.WaveIn.GetCapabilities(i);
            //    MessageBox.Show($"{i}: {caps.ProductName}");
            //}


        }

       


        //LoadSettings
        #region

        private void LoadSettings()
        {
           


            listView1.Items.Clear();
            panelAbout.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelUpdate.Visible = false;
            ProgressBarColor.SetState(progressbar1, 2);
            ProgressBarColor.SetState(progressbar2, 2);
            LoadData();

            stopwatch = new Stopwatch();
            if ("tr-TR" == Properties.Settings.Default.language.ToString())
            {
                comboLanguages.SelectedIndex = 0;
            }
            if ("en-US" == Properties.Settings.Default.language.ToString())
            {
                comboLanguages.SelectedIndex = 1;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.volumebar))
            {
                Properties.Settings.Default.volumebar = "0";
                Properties.Settings.Default.Save();


            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.savepath))
            {
                Properties.Settings.Default.savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Properties.Settings.Default.Save();

            }
            comboVolumeBar.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.volumebar.ToString());
            comboChannels.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.channels.ToString());
            comboConfimation.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.confimation.ToString());
            comboDevies.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.devices.ToString());
            comboExtension.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.extension.ToString());
            textBox1.Text = Properties.Settings.Default.savepath;
            comboOpenFileAfter.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.openfileafter.ToString());
            comboOutRate.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.outrate.ToString());
            
            if("0"==Properties.Settings.Default.volumebar.ToString())
            {
                progressbar1.Visible = true;
                progressbar2.Visible = true;

            }
            if( "1" == Properties.Settings.Default.volumebar.ToString())
            {
                progressbar1.Visible = false;
                progressbar2.Visible = false;
            }
            if ("2" == Properties.Settings.Default.volumebar.ToString())
            {
                progressbar1.Visible = false;
                progressbar2.Visible = true;
            }
            if ("3" == Properties.Settings.Default.volumebar.ToString())
            {
                progressbar1.Visible = true;
                progressbar2.Visible = false;
            }






        }
        #endregion

        //Record Button
        #region
        public int Ch;
        public string fName;
        public string locName;

        private void btnRecord_Click(object sender, EventArgs e)
        {
            
            stopwatch.Reset();
            int outrate=Convert.ToInt32(comboOutRate.Text);
            string extension=comboExtension.Text;  
            if (Properties.Settings.Default.channels.ToString() == "0")
            {
                Ch = 1;
            }
            if (Properties.Settings.Default.channels.ToString() == "1")
            {
                Ch = 2;
            }



            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave Files | *."+extension;
            dialog.InitialDirectory = textBox1.Text;
            dialog.FileName = $"{DateTime.Now:HH.mm.ss_dd_MMMM_yyyy}".Replace(".", "_");
            

            if (Properties.Settings.Default.confimation.ToString() =="1")
            {
                
                string filePath = dialog.FileName;
                label3.Text = textBox1.Text + "\\" + dialog.FileName + "." + comboExtension.Text;
             
                ListViewItem item = new ListViewItem(dialog.FileName + "." + comboExtension.Text);
                listView1.Items.Add(item);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add(textBox1.Text + "\\" + dialog.FileName + "." + comboExtension.Text);
                

                outputFileName = textBox1.Text + "\\" + dialog.FileName + "." + comboExtension.Text;
                fName = dialog.FileName + "." + comboExtension.Text;
                locName = textBox1.Text;
                
                btnRecord.Enabled = false;
                btnStop.Enabled = true;
                //outputFileName = dialog.FileName;
                var device = (MMDevice)comboDevies.SelectedItem;
                capture = new WasapiLoopbackCapture(device);
                capture.WaveFormat = new WaveFormat(outrate, 16, Ch);
                var writer = new WaveFileWriter(outputFileName, capture.WaveFormat);
                capture.DataAvailable += async (s, t) =>
                {
                    if (writer != null)
                    {
                        await writer.WriteAsync(t.Buffer, 0, t.BytesRecorded);
                        await writer.FlushAsync();
                    }
                };
                capture.RecordingStopped += (s, t) =>
                {
                    if (writer != null)
                    {
                        writer.Dispose();
                        writer = null;
                        Thread.Sleep(50);
                        CompressFile();

                    }

                    btnRecord.Enabled = true;
                    btnStop.Enabled = false;
                    capture.Dispose();

                };
                stopwatch.Start();
                capture.StartRecording();
                capture.DataAvailable += HandleDataAvailable;
                btnPlayPause.Enabled = false;
                lbl_Timer.ForeColor = Color.Red;
                Thread.Sleep(20);

                return;




            }
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (dialog.FileName != "")
            {
                
                string filePath = dialog.FileName;


                label3.Text = dialog.FileName;
                ListViewItem item = new ListViewItem(System.IO.Path.GetFileName(dialog.FileName));
                listView1.Items.Add(item);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add(dialog.FileName);

                fName = System.IO.Path.GetFileName(dialog.FileName);
                locName=System.IO.Path.GetDirectoryName(dialog.FileName);
                
                outputFileName = dialog.FileName;
                btnRecord.Enabled = false;
                btnStop.Enabled = true;
                var device = (MMDevice)comboDevies.SelectedItem;
                capture = new WasapiLoopbackCapture(device);
                capture.WaveFormat = new WaveFormat(outrate, 16, Ch);
                var writer = new WaveFileWriter(outputFileName, capture.WaveFormat);
                capture.DataAvailable += async (s, t) =>
                {
                    if (writer != null)
                    {
                        await writer.WriteAsync(t.Buffer, 0, t.BytesRecorded);
                        await writer.FlushAsync();
                    }
                };
                capture.RecordingStopped += (s, t) =>
                {
                    if (writer != null)
                    {
                        writer.Dispose();
                        writer = null;
                        Thread.Sleep(50);
                        CompressFile();
                    }

                    btnRecord.Enabled = true;
                    btnStop.Enabled = false;               

                    capture.Dispose();

                };
                stopwatch.Start();
                capture.StartRecording();
                capture.DataAvailable += HandleDataAvailable;
                btnPlayPause.Enabled = false;
                lbl_Timer.ForeColor = Color.Red;
                Thread.Sleep(20);


            }
           
        }
        #endregion

        //Stop Button
        #region

        private void btnStop_Click(object sender, EventArgs e)
        {
            
            progressbar1.Value = 0;
            progressbar1.Update();
            progressbar2.Value = 0;
            progressbar2.Update();
            Thread.Sleep(100);
            btnRecord.Enabled = true;
            btnStop.Enabled = false;


            if (capture != null)
                capture.StopRecording();
                  
            stopwatch.Stop();
            
            btnPlayPause.Enabled = true;
            if (outputFileName == null)
            {
                return;
            }

            if (Properties.Settings.Default.openfileafter == "0")
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(outputFileName),
                    UseShellExecute = true
                };

                Process.Start(processStartInfo);

            }
            lbl_Timer.ForeColor = Color.Green;
            SaveData();



           

        }
        #endregion

        //PlayPause Button
        #region
        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            WaveFileReader waveFileReader = new WaveFileReader(label3.Text.ToString());
            if (label3 == null)
            {
                MessageBox.Show("Please make a Record first of all");
                return;
            }

            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();

                btnPlayPause.Image = Properties.Resources.icons8_play_button_circled_48;
                btnRecord.Enabled = true;
                if (btnRecord.Text == "Kayıt")
                {
                    btnPlayPause.Text = "Çal";
                }
                else
                {
                    btnPlayPause.Text = "Play";
                }

            }
            else if (waveOut.PlaybackState == PlaybackState.Paused)
            {
                waveOut.Play();

                btnPlayPause.Image = Properties.Resources.icons8_pause_squared_48;
                btnRecord.Enabled = false;
                waveOut.PlaybackStopped += OutputDevice_PlaybackStopped;
                if (btnRecord.Text == "Kayıt")
                {
                    btnPlayPause.Text = "Duraklat";
                }
                else
                {
                    btnPlayPause.Text = "Pause";
                }
            }
            else
            {
                waveOut.Init(waveFileReader);
                waveOut.Play();

                btnPlayPause.Image = Properties.Resources.icons8_pause_squared_48;
                btnRecord.Enabled = false;
                waveOut.PlaybackStopped += OutputDevice_PlaybackStopped;
                if (btnRecord.Text == "Kayıt")
                {
                    btnPlayPause.Text = "Duraklat";
                }
                else
                {
                    btnPlayPause.Text = "Pause";
                }
            }
        }
        #endregion

        //CompressFile
        #region
        private void CompressFile()
        {
            //fname asdı.extetion
            //locat c:user:desktop
            string sourceFilePath =locName+"\\"+ fName;
            string destinationFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\"+fName;
            Thread.Sleep(25);
            File.Copy(sourceFilePath, destinationFilePath, true);
            File.Delete(sourceFilePath);
            Thread.Sleep(25);
            using (var reader = new AudioFileReader(destinationFilePath))
            {

                var writer2 = new LameMP3FileWriter(sourceFilePath, reader.WaveFormat, 128);

                reader.CopyTo(writer2);

                writer2.Close();
                writer2.Dispose();


            }
            Thread.Sleep(25);
            File.Delete(destinationFilePath);
        }
        #endregion

        //LoadDevies
        #region
        private void LoadDevices()
        {
            var enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            comboDevies.Items.AddRange(devices.ToArray());
          
        }
        #endregion

        // Loading func
        #region
        private void Loading()
        {


            if ("tr-TR" == Properties.Settings.Default.language.ToString())
            {


                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                this.Controls.Clear();

                InitializeComponent();
                LoadDevices();
                LoadSettings();
              
            }
            if ("en-US" == Properties.Settings.Default.language.ToString())
            {



                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                this.Controls.Clear();

                InitializeComponent();
                LoadDevices();
                LoadSettings();
                
            }
        }
        #endregion

        //Move panel to form
        #region        
        private void panelUpper_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;

        }

        private void panelUpper_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point diff = new Point(
                    e.Location.X - lastLocation.X,
                    e.Location.Y - lastLocation.Y);
                this.Location = new Point(
                    this.Location.X + diff.X,
                    this.Location.Y + diff.Y);
            }

        }

        private void panelUpper_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        #endregion

        //Exit and Minimize Buttons
        #region
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Menuler System+Sound+Language+About+Update 
        #region
        private void SystemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSystemSettings.Visible = true;
            panelSystemSettings.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();
        }

        private void soundSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelAbout.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = true;
            panelSoundSettings.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();

        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = true;
            panelLanguage.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelAbout.Visible = true;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelAbout.Dock = DockStyle.Fill;
            btnSave.Visible = false;

            btnBack.Visible = false;


        }
        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelUpdate.Visible = true;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelUpdate.Dock = DockStyle.Fill;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnBack.Visible = true;
            btnBack.BringToFront();
        }
        #endregion

        //Back save ok Browse linklabel update showrecord clearlist
        #region
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible=false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            btnSave.Visible = false;
            btnBack.Visible = false;
            btnUpdate.Visible = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.devices = comboDevies.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.extension = comboExtension.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.channels = comboChannels.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.outrate = comboOutRate.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.confimation = comboConfimation.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.openfileafter = comboOpenFileAfter.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.savepath = textBox1.Text.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.volumebar = comboVolumeBar.SelectedIndex.ToString();
            Properties.Settings.Default.Save();

            if ("Turkish" == comboLanguages.Text.ToString())
            {
                Properties.Settings.Default.language = "tr-TR";
                Properties.Settings.Default.Save();

            }
            if ("English" == comboLanguages.Text.ToString())
            {
                Properties.Settings.Default.language = "en-US";
                Properties.Settings.Default.Save();

            }
            if ("Türkçe" == comboLanguages.Text.ToString())
            {
                Properties.Settings.Default.language = "tr-TR";
                Properties.Settings.Default.Save();

            }
            if ("İngilizce" == comboLanguages.Text.ToString())
            {
                Properties.Settings.Default.language = "en-US";
                Properties.Settings.Default.Save();

            }

            panelAbout.Visible = false;
            btnSave.Visible = false;
            btnBack.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            LoadSettings();
            Thread.Sleep(100);

            
            Application.Restart();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    textBox1.Text = fbd.SelectedPath;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = linkLabel1.Tag.ToString();
            var ps = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;


        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SaveData();
        }

        private void showRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text.ToString();

            System.Diagnostics.Process.Start(filePath);
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }


        #endregion

        //ComboBoxes SelectedIndex
        #region
        private void comboLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();

        }

        private void comboExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboOutRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboDevies_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboConfimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboOpenFileAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }
        private void comboVolumeBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }
        #endregion

        //SaveDATA  LoadDATA
        #region



        private void SaveData()
        {
            string appPath = Application.StartupPath;
            try
            {
                using (StreamWriter writer = new StreamWriter(appPath + "\\" + "data.txt"))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        writer.WriteLine(item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void LoadData()
        {

            try
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[2]);
                        listView1.Items.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        #endregion
                
        //TEST Listview Right CLİCK
        #region
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = "xxx";//extra value

            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem != null && listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    ContextMenu m = new ContextMenu();
                    MenuItem cashMenuItem = new MenuItem("Open with Player");
                    cashMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        ActionClick(sender, e, id);
                    };// your action here 
                    m.MenuItems.Add(cashMenuItem);

                    MenuItem cashMenuItem2 = new MenuItem("-");
                    m.MenuItems.Add(cashMenuItem2);

                    MenuItem delMenuItem = new MenuItem("Delete from List");
                    delMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        DelectAction(sender, e, id);
                    };// your action here
                    m.MenuItems.Add(delMenuItem);
                    

                    m.Show(listView1, new System.Drawing.Point(e.X, e.Y));

                }
            }
        }
       

        private void DelectAction(object sender, MouseEventArgs e, string id)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {

                listView1.SelectedItems[0].Remove();







            }
            SaveData();
        }

        private void ActionClick(object sender, MouseEventArgs e, string id)
        {

            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {


                ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;


                if (listView1.SelectedItems.Count == 0)
                    return;

                // Get the path to the file from the selected ListViewItem's Tag property
                string filePath = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                listView1.SelectedItems[0].ForeColor = Color.Blue;

                // Launch the file using the default associated application

                System.Diagnostics.Process.Start(filePath);





            }
            SaveData();



        }

        public static string GetTextByHeaderAndIndex(System.Windows.Forms.ListView listViewControl, string headerName, int index)
        {
            int headerIndex = -1;
            foreach (ColumnHeader header in listViewControl.Columns)
            {
                if (header.Name == headerName)
                {
                    headerIndex = header.Index;
                    break;
                }
            }
            if (headerIndex > -1)
            {
                return listViewControl.Items[index].SubItems[headerIndex].Text;
            }
            return null;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;


            if (listView1.SelectedItems.Count == 0)
                return;

            // Get the path to the file from the selected ListViewItem's Tag property
            string filePath = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            listView1.SelectedItems[0].ForeColor = Color.Blue;

            // Launch the file using the default associated application

            System.Diagnostics.Process.Start(filePath);
        }

        private void listView1_MouseRightClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("No Item is selected");

        }



        void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;


            ////if (item != null)
            ////{
            ////    this.searchbox.Text = item.Text;
            ////}
            ////else
            ////{
            ////    this.listView1.SelectedItems.Clear();
            ////    this.searchbox.Text = "No Item is Selected";
            ////}
        }







        #endregion


        //HandleDataAvailable(For progressbar)+ TimerTick + Output PLAYBACK
        #region
        private void HandleDataAvailable(object sender, WaveInEventArgs e)
        {
            // Calculate the volume level of the incoming audio data
            float max = 0;
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = (short)((e.Buffer[i + 1] << 8) | e.Buffer[i]);
                float sample32 = sample / 32768f;
                if (sample32 < 0) sample32 = -sample32;
                if (sample32 > max) max = sample32;
            }
            
            
            progressbar1.Value = (int)(max * 100);

            progressbar2.Value = (int)(max * 100);
            
        }





        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

      

        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (btnRecord.Text == "Kayıt")
            {
                btnPlayPause.Text = "Çal";
            }
            else
            {
                btnPlayPause.Text = "Play";
            }

            btnPlayPause.Image = Properties.Resources.icons8_play_button_circled_48;
            btnRecord.Enabled = true;
        }

        #endregion


        //GİTHUB UPDATER AND ASSEMBLY VERSİON NUMBER
        #region

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionNum += $"v.{versionInfo.FileVersion}";
            label12.Text =versionNum.ToString();


        }
        public string releaseversion;
        public async void CheckForUpdates()
        {

            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/SoundRecorder"))
            {


                try
                {
                    var updateInfo = await mgr.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        

                        var updateResult = await mgr.UpdateApp();

                        UpdateManager.RestartApp();



                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                }
            }


        }

        public async void CFU()//Verilen github linki üzerinden Updateleri kontrol edecek fonksiyon
        {

            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/SoundRecorder"))
            {
                //this.logger.Info("Checking for updates");

                try
                {
                    var updateInfo = await mgr.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        var versionCount = updateInfo.ReleasesToApply.Count;
                        //this.logger.Info($"{versionCount} update(s) found.");

                        var x5 = updateInfo.FutureReleaseEntry.Version.ToString();

                        labelOnlineVersion.Text = "v." + x5;
                        labelOnlineVersion.Text = "v." + x5;
                        var versionWord = versionCount > 1 ? "versions" : "version";
                        labelTitle.Text = "New Available version. Please Look the Update Section";
                        btnUpdate.Visible = true;
                        btnUpdate.Enabled = true;

                        if ("en-US" == Properties.Settings.Default.language.ToString())
                        {
                            this.Alert("New Available version \nInstall Now!");
                        }
                        if ("tr-TR" == Properties.Settings.Default.language.ToString())
                        {
                            this.Alert("Kullanılabilir Yeni Sürüm Var \nHemen Yükle!");
                        }




                    }
                }
                catch (Exception)
                {

                }
            }



        }


        #endregion

        //Form Closed and Closing
        #region

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnStop.PerformClick();
            Thread.Sleep(100);
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop.PerformClick();
            Thread.Sleep(100);
            Application.Exit();

        }
        #endregion

        //Alert Notify
        #region

        public void Alert(string msg)
        {
            frmUpdateNotify frm = new frmUpdateNotify();
            frm.showAlert(msg);
        }
        #endregion
    }
}
