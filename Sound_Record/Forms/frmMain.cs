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
using Newtonsoft.Json.Linq;


namespace Sound_Record.Forms
{
    public partial class frmMain : Form
    {

        private int labelPosition;
        private bool isDragging = false;
        private Point lastLocation;
        public string versionNum;
        Stopwatch stopwatch;
        private WaveOut waveOut = new WaveOut();
        private string outputFileName;
        private WasapiLoopbackCapture capture;


        public frmMain()
        {
            //Install Components and Start
            #region
            string filePath = Application.StartupPath + "\\data.txt";
            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                }
            }
            string FolderPath = Application.StartupPath + "\\Records";
            if (!File.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            if (Directory.Exists(FolderPath))
            {
                string[] files = Directory.GetFiles(FolderPath);

                foreach (string file in files)
                {
                    File.Delete(file);
                }


            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.theme))
            {
                Properties.Settings.Default.theme = "Light";
                Properties.Settings.Default.Save();

            }
            InitializeComponent();

            listView1.MouseDown += new MouseEventHandler(listView1_MouseDown);
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
            #endregion


        }



        private void frmMain_Load(object sender, EventArgs e)
        {           
            Loading();
            AddVersionNumber();
            labelTitle.Text = "Sound Recorder ";
            CFU();


        }


    

        //LoadSettings
        #region

        private void LoadSettings()
        {

            listView1.Items.Clear();
            panelinterface.Visible = false;
            panelAbouts.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelUpdate.Visible = false;
            panelinterface.Visible = false;
            panelVisualizationEffects.Visible = false;
           


         

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
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.savepath))
            {
                Properties.Settings.Default.savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Properties.Settings.Default.Save();

            }
            
            comboChannels.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.channels.ToString());
            comboConfimation.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.confimation.ToString());
            comboDevies.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.devices.ToString());
            comboExtension.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.extension.ToString());
            textBox1.Text = Properties.Settings.Default.savepath;
            comboOpenFileAfter.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.openfileafter.ToString());
            comboOutRate.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.outrate.ToString());



            if (string.IsNullOrEmpty(Properties.Settings.Default.VisColorBase))
            {
                txtVisualizationCbase.Text = "0, 255, 0";
                txtVisualizationCbase.BackColor = Color.Green;
                txtVisualizationCbase.ForeColor = Color.Transparent;

            }
            else
            {
                string rgbValues = Properties.Settings.Default.VisColorBase;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);

               
                txtVisualizationCbase.Text = string.Format("{0}, {1}, {2}", r, g, b);
                txtVisualizationCbase.ForeColor = Color.Transparent; 
                txtVisualizationCbase.BackColor=Color.FromArgb(r, g, b);

            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.VisColorMax))
            {
                txtVisualizationCmax.Text = "255, 0, 0";
                txtVisualizationCmax.ForeColor = Color.Transparent;
                txtVisualizationCmax.BackColor = Color.Red;

            }
            else
            {
                string rgbValues = Properties.Settings.Default.VisColorMax;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);


                txtVisualizationCmax.Text = string.Format("{0}, {1}, {2}", r, g, b);
                txtVisualizationCmax.ForeColor= Color.Transparent;
                txtVisualizationCmax.BackColor=Color.FromArgb (r, g, b);

            }


            if (string.IsNullOrEmpty(Properties.Settings.Default.DarkBackground))
            {
                txtDarkBack.Tag = "29, 33, 41";
                txtDarkBack.Text = "29, 33, 41";
                txtDarkBack.ForeColor = Color.Transparent;
                txtDarkBack.BackColor = Color.FromArgb(29, 33, 41);
            }
            else
            {
                string rgbValues = Properties.Settings.Default.DarkBackground;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);

                txtDarkBack.Tag = $"{r},{g},{b}";
                txtDarkBack.Text = string.Format("{0}, {1}, {2}", r, g, b);
                txtDarkBack.ForeColor = Color.Transparent;
                txtDarkBack.BackColor = Color.FromArgb(r, g, b);

            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.DarkText))
            {
                txtDarkText.Tag = "240, 248, 255";
                txtDarkText.Text = "240, 248, 255";
                txtDarkText.ForeColor = Color.Transparent;
                txtDarkText.BackColor = Color.FromArgb(240, 248, 255);
            }
            else
            {
                string rgbValues = Properties.Settings.Default.DarkText;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);

                txtDarkText.Tag = $"{r},{g},{b}";
                txtDarkText.Text = string.Format("{0}, {1}, {2})", r, g, b);
                txtDarkText.ForeColor = Color.Transparent;
                txtDarkText.BackColor = Color.FromArgb(r,g,b);
            }



            if (string.IsNullOrEmpty(Properties.Settings.Default.LightBackground))
            {
                txtLightBack.Tag = "240, 248, 255";
                txtLightBack.Text = "240, 248, 255";
                txtLightBack.ForeColor = Color.Transparent;
                txtLightBack.BackColor = Color.FromArgb(240, 248, 255);
            }
            else
            {
                string rgbValues = Properties.Settings.Default.LightBackground;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);

                txtLightBack.Tag = $"{r},{g},{b}";
                txtLightBack.Text = string.Format("{0}, {1}, {2}", r, g, b);
                txtLightBack.ForeColor = Color.Transparent;
                txtLightBack.BackColor = Color.FromArgb(r,g,b);
            }


            if (string.IsNullOrEmpty(Properties.Settings.Default.LightText))
            {
                txtLightText.Tag = "29, 33, 41";
                txtLightText.Text = "29, 33, 41";
                txtLightText.ForeColor = Color.Transparent;
                txtLightText.BackColor = Color.FromArgb(29, 33, 41);
            }
            else
            {
                string rgbValues = Properties.Settings.Default.LightText;
                string[] rgbArray = rgbValues.Split(',');

                int r = int.Parse(rgbArray[0]);
                int g = int.Parse(rgbArray[1]);
                int b = int.Parse(rgbArray[2]);

                txtLightText.Tag = $"{r},{g},{b}";
                txtLightText.Text = string.Format("{0}, {1}, {2}", r, g, b);
                txtLightText.ForeColor = Color.Transparent;
                txtLightText.BackColor = Color.FromArgb(r,g,b);
            }



            if ("Light" == Properties.Settings.Default.theme.ToString())
            {
                SetLightTheme();
            }
            if ("Dark" == Properties.Settings.Default.theme.ToString())
            {
                SetDarkTheme();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.VisVisible))
            {
                comboVisualizationVisible.SelectedIndex = 0;
            }
            else
            {
              comboVisualizationVisible.SelectedIndex= Convert.ToInt32(Properties.Settings.Default.VisVisible.ToString());
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.VisQuality))
            {
                comboVisualizationQuality.SelectedIndex = 0;
            }
            else
            {
                comboVisualizationQuality.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.VisQuality.ToString());
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.VisCount))
            {
                txtVisualizationBarCount.Text = "80";
            }
            else
            {
                txtVisualizationBarCount.Text= Properties.Settings.Default.VisCount.ToString();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.VisSpacing))
            {
                txtVisualizationBarSpacing.Text = "2";
            }
            else
            {
                txtVisualizationBarSpacing.Text = Properties.Settings.Default.VisSpacing.ToString();
            }

        }
        #endregion

        public void AudioVis()
        {
            audioVisualization1.Show();
            audioVisualization1.SendToBack();
            panelHider.Visible = false;
            panelHider.SendToBack();
            //Set the device index
            audioVisualization1.DeviceIndex = comboDevies.SelectedIndex;

            if(comboVisualizationQuality.SelectedIndex == 0)
            {
                audioVisualization1.HighQuality = true;
            }
            if (comboVisualizationQuality.SelectedIndex == 1)
            {
                audioVisualization1.HighQuality = false;
            }


            //Set the interval
            string bcount=txtVisualizationBarCount.Text.ToString();
            string vspacing = txtVisualizationBarSpacing.Text.ToString();
            audioVisualization1.BarCount = Convert.ToInt32(bcount.ToString());

            audioVisualization1.BarSpacing = Convert.ToInt32(vspacing.ToString());
            audioVisualization1.IsXLogScale = true;
            audioVisualization1.Visible = true;


            
            string[] lightcolorpart1 = txtVisualizationCmax.Text.Split(',');
            int CmaxR = Int32.Parse(lightcolorpart1[0]);
            int CmaxG = Int32.Parse(lightcolorpart1[1]);
            int CmaxB = Int32.Parse(lightcolorpart1[2]);

           
            string[] lightcolorpart2 = txtVisualizationCbase.Text.Split(',');
            int CbaseR = Int32.Parse(lightcolorpart2[0]);
            int CbaseG = Int32.Parse(lightcolorpart2[1]);
            int CbaseB = Int32.Parse(lightcolorpart2[2]);

            
            
            audioVisualization1.ColorBase = Color.FromArgb(CmaxR, CmaxG, CmaxB);

            
            audioVisualization1.ColorMax = Color.FromArgb(CbaseR, CbaseG, CbaseB);

            //Start
            audioVisualization1.Start();


        }



        //Record Button
        #region
        public int Ch;
        public string fName;
        public string locName;

        private void btnRecord_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
            stopwatch.Reset();
            int outrate = Convert.ToInt32(comboOutRate.Text);
            string extension = comboExtension.Text;
            if (Properties.Settings.Default.channels.ToString() == "0")
            {
                Ch = 1;
            }
            if (Properties.Settings.Default.channels.ToString() == "1")
            {
                Ch = 2;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave Files | *." + extension;
            dialog.InitialDirectory = textBox1.Text;
            dialog.FileName = $"{DateTime.Now:HH.mm.ss_dd_MMMM_yyyy}".Replace(".", "_");

            AudioVis();

            if (Properties.Settings.Default.confimation.ToString() == "1")
            {

                string filePath = dialog.FileName;
                labelFilePathInvsbl.Text = textBox1.Text + "\\" + dialog.FileName + "." + comboExtension.Text;

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


                labelFilePathInvsbl.Text = dialog.FileName;
                ListViewItem item = new ListViewItem(System.IO.Path.GetFileName(dialog.FileName));
                listView1.Items.Add(item);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add(dialog.FileName);

                fName = System.IO.Path.GetFileName(dialog.FileName);
                locName = System.IO.Path.GetDirectoryName(dialog.FileName);

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
            audioVisualization1.Stop();
            
            audioVisualization1.Hide();
            
            foreach (Control control in Controls)
            {
                if (control is ProgressBar progressBar)
                {
                    progressBar.Value = 0;
                    progressBar.Update();
                }
            }


            
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



            if (!File.Exists(labelFilePathInvsbl.Text))
            {
                MessageBox.Show("Please make a Record first of all.");
                return;
            }
            WaveFileReader waveFileReader = new WaveFileReader(labelFilePathInvsbl.Text);

            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();

                btnPlayPause.Image = Properties.Resources.icons8_play_button_circled_48;
                btnRecord.Enabled = true;
                if (btnRecord.Text == "Kayıt")
                {
                    btnPlayPause.Text = "Devam Et";
                }
                else
                {
                    btnPlayPause.Text = "Keep Play";
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
            string sourceFilePath = locName + "\\" + fName;
            string destinationFilePath = Application.StartupPath + "\\Records" + "\\" + fName;
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
           
            labelFilePathInvsbl.Text = destinationFilePath;

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

        // MENÜLERRRR
        #region
        private void SystemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
            panelAbouts.Visible = false;
            panelSoundSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSystemSettings.Visible = true;
            panelSystemSettings.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();
        }
        private void audioVisualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = true;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
            panelAbouts.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = false;
            panelVisualizationEffects.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();
        }

        private void soundSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
            panelAbouts.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = true;
            panelSoundSettings.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();

        }
        private void languageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
            panelAbouts.Visible = false;
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
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
            panelAbouts.Visible = true;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelAbouts.Dock = DockStyle.Fill;
            btnSave.Visible = false;
            btnOk.Visible = true;
            btnOk.BringToFront();
            btnBack.Visible = false;


        }
        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = true;
            panelAbouts.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelUpdate.Dock = DockStyle.Fill;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnBack.Visible = true;
            btnBack.BringToFront();
            btnUpdate.BringToFront() ;
        }



        private void userInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = true;
            panelUpdate.Visible = false;
            panelAbouts.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelSoundSettings.Visible = false;
            panelinterface.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnSave.BringToFront();
            btnBack.Visible = true;
            btnBack.BringToFront();
        }
        #endregion

        //Back Save ok Browse linklabel update showrecord clearlist
        #region
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = Properties.Settings.Default.savepath;
            panelVisualizationEffects.Visible=false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
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
            Properties.Settings.Default.VisVisible = comboVisualizationVisible.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisQuality = comboVisualizationQuality.SelectedIndex.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisCount = txtVisualizationBarCount.Text.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisSpacing = txtVisualizationBarSpacing.Text.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisColorMax = txtVisualizationCmax.Text.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisColorBase = txtVisualizationCbase.Text.ToString();
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

            Properties.Settings.Default.VisColorBase = txtVisualizationCbase.Text.ToString();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.VisColorMax = txtVisualizationCmax.Text.ToString();
            Properties.Settings.Default.Save();

            Properties.Settings.Default.DarkBackground = txtDarkBack.Tag.ToString();
            Properties.Settings.Default.DarkText = txtDarkText.Tag.ToString();
            Properties.Settings.Default.LightBackground = txtLightBack.Tag.ToString();
            Properties.Settings.Default.LightText = txtLightText.Tag.ToString();

            Properties.Settings.Default.Save();


            panelinterface.Visible = false;
            panelAbouts.Visible = false;
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

        private void linkLabelProjectURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = linkLabelProjectURL.Tag.ToString();
            var ps = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }


     
        private void btnOk_Click(object sender, EventArgs e)
        {
            panelAbouts.Visible = false;
            panelSoundSettings.Visible = false;
            panelSystemSettings.Visible = false;
            panelLanguage.Visible = false;
            panelVisualizationEffects.Visible = false;
            panelinterface.Visible = false;
            panelUpdate.Visible = false;
           


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

        //LABEL RESET COLORS 
        #region

        private Size oldSize;  // Eski boyutu tutmak için sınıf alanı tanımlayın
        private string oldText;  // Eski yazıyı tutmak için sınıf alanı tanımlayın


        private void lblRESETCOLOR_MouseEnter(object sender, EventArgs e)
        {

            lblRESETCOLOR.ForeColor = Color.Green;

            oldSize = lblRESETCOLOR.Size;
            oldText = lblRESETCOLOR.Text;

            // Yeni boyutu hesaplayın ve labelı büyütün
            int newWidth = (int)(oldSize.Width * 1.1);
            int newHeight = (int)(oldSize.Height * 1.1);
            lblRESETCOLOR.Size = new Size(newWidth, newHeight);

            // Yazıyı büyütmek için font boyutunu artırın
            Font oldFont = lblRESETCOLOR.Font;
            float newFontSize = oldFont.Size * 1.1f;
            lblRESETCOLOR.Font = new Font(oldFont.FontFamily, newFontSize, oldFont.Style);

            // Yazıyı genişletin
            string newText = oldText;
            while (TextRenderer.MeasureText(newText, lblRESETCOLOR.Font).Width < newWidth)
            {
                newText += " ";
            }
            lblRESETCOLOR.Text = newText;

        }

        private void lblRESETCOLOR_MouseLeave(object sender, EventArgs e)
        {
            lblRESETCOLOR.ForeColor = Color.Red;
            lblRESETCOLOR.Size = oldSize;
            lblRESETCOLOR.Font = new Font(lblRESETCOLOR.Font.FontFamily, oldSize.Height /  2.2f, lblRESETCOLOR.Font.Style);
            lblRESETCOLOR.Text = oldText;
        }

        private void lblRESETCOLOR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All color Settings will be reset Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDarkBack.Tag = "29, 33, 41";
                txtDarkBack.Text = "Background Color RGB (29, 33, 41)";
                txtDarkText.Tag = "240, 248, 255";
                txtDarkText.Text = "Text Color RGB (240, 248, 255)";
                txtLightBack.Tag = "240, 248, 255";
                txtLightBack.Text = "Background Color RGB (240, 248, 255)";
                txtLightText.Tag = "29, 33, 41";
                txtLightText.Text = "Text Color RGB (29, 33, 41)";

                Properties.Settings.Default.DarkBackground = txtDarkBack.Tag.ToString();
                Properties.Settings.Default.DarkText = txtDarkText.Tag.ToString();
                Properties.Settings.Default.LightBackground = txtLightBack.Tag.ToString();
                Properties.Settings.Default.LightText = txtLightText.Tag.ToString();

                Properties.Settings.Default.Save();
                Application.Restart();


            }
            else if (result == DialogResult.No)
            {

            }
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
        private void comboVisualizationVisible_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDefaultWall.Focus();
        }

        private void comboVisualizationQuality_SelectedIndexChanged(object sender, EventArgs e)
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

                    MenuItem delMenuItem = new MenuItem("Remove from List");
                    delMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        DelectAction(sender, e, id);
                    };// your action here
                    m.MenuItems.Add(delMenuItem);


                    MenuItem cashMenuItem3 = new MenuItem("-");
                    m.MenuItems.Add(cashMenuItem3);


                    MenuItem deleteMenuItem = new MenuItem("Delete File");
                    deleteMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        DeleteAction(sender, e, id);
                    };// your action here
                    m.MenuItems.Add(deleteMenuItem);


                    m.Show(listView1, new System.Drawing.Point(e.X, e.Y));

                }
            }
        }


        private void DeleteAction(object sender, MouseEventArgs e, string id)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if ("tr-TR" == Properties.Settings.Default.language.ToString())
                {
                    DialogResult result = MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text + " Silinecek Onaylıyor musunuz?", "Dosya Silme", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        foreach (ListViewItem selectedItem in listView1.SelectedItems)
                        {

                            listView1.Items.Remove(selectedItem);
                            File.Delete(selectedItem.SubItems[2].Text.ToString());
                        }
                    }

                }
                else
                {

                }
                if ("en-US" == Properties.Settings.Default.language.ToString())
                {
                    DialogResult result = MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text + " will be Deleted Do you Confirmed ? ", "File Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        foreach (ListViewItem selectedItem in listView1.SelectedItems)
                        {

                            listView1.Items.Remove(selectedItem);
                            File.Delete(selectedItem.SubItems[2].Text.ToString());
                        }
                    }

                }
                else
                {

                }


            }
            SaveData();
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

        //TimerTick + Output PLAYBACK
        #region
       



        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }



        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (btnRecord.Text == "Kayıt")
            {
                btnPlayPause.Text = "Oynat";
            }
            else
            {
                btnPlayPause.Text = "Play";
            }

            btnPlayPause.Image = Properties.Resources.icons8_play_button_circled_48;
            btnRecord.Enabled = true;
        }

        #endregion

        //GİTHUB UPDATER AND ASSEMBLY VERSİON NUMBER++ TİMER FOR Slader Notification
        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelPosition -= 2;
            if (labelPosition < -labelTitle.Width)
            {
                labelPosition = panelUpper.ClientSize.Width;
            }
            labelTitle.Location = new Point(labelPosition, 10);
            panelUpper.Invalidate();
        }
        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionNum += $"v.{versionInfo.FileVersion}";
            labelCurrentVersion.Text = "Current Version " + versionNum.ToString();


        }
        public string releaseversion;
        public async void CheckForUpdates()
        {
            btnUpdate.Enabled = false;

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





                        timer1.Interval = 50;
                        timer1.Tick += Timer_Tick;
                        timer1.Start();
                        btnUpdate.Visible = true;
                        btnUpdate.Enabled = true;

                        if ("en-US" == Properties.Settings.Default.language.ToString())
                        {
                            this.Alert("New Available version \nInstall Now!");
                            labelTitle.Text = "There Is A New Version Available. Please See Update Section";
                        }
                        if ("tr-TR" == Properties.Settings.Default.language.ToString())
                        {
                            this.Alert("Kullanılabilir Yeni Sürüm Var \nHemen Yükle!");
                            labelTitle.Text = "Kullanılabilir Yeni Sürüm Var. Lütfen Güncelleme Bölümüne Bakın";
                        }

                        var sizeInBytes = updateInfo.FutureReleaseEntry.Filesize;
                        var sizeInMegabytes = (double)sizeInBytes / 1048576;
                        string size = $"{sizeInMegabytes:N2} MB";


                        var repoUrl = "https://api.github.com/repos/firatkaanbitmez/SoundRecorder/releases/latest";

                        var client = new System.Net.Http.HttpClient();
                        client.DefaultRequestHeaders.Add("User-Agent", "SoundRecorderReleaseBot");
                        var response = await client.GetAsync(repoUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = await response.Content.ReadAsStringAsync();
                            var json = JObject.Parse(responseContent);

                            var tagName = json["tag_name"].ToString();
                            var releaseNotes = json["body"].ToString();



                            if ("en-US" == Properties.Settings.Default.language.ToString())
                            {
                                labelAvailableInfo.Text = "New Available Version v." + tagName + " There is a Update Required!" + "\n\nUpdate File Size " + size + "\n\nRelease notes:\n\n" + releaseNotes;
                            }
                            if ("tr-TR" == Properties.Settings.Default.language.ToString())
                            {
                                labelAvailableInfo.Text = "Yeni Kullanılabilir Version v." + tagName + " Güncelleme Gerekiyor!" + "\n\nGüncelleme Dosya Boyutu " + size + "\n\nSürüm Notları:\n\n" + releaseNotes;
                            }

                        }
                        else
                        {
                            labelAvailableInfo.Text = "Error retrieving latest release: " + response.StatusCode + "SoundRecorder Release Notes";
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
            audioVisualization1.Stop();
            audioVisualization1.Dispose();
            btnStop.PerformClick();
            Thread.Sleep(100);
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            audioVisualization1.Stop();
            audioVisualization1.Dispose();
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

        //Listview DELETE PRESS
        #region
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if ("tr-TR" == Properties.Settings.Default.language.ToString())
                    {
                        DialogResult result = MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text + " Silinecek Onaylıyor musunuz?", "Dosya Silme", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            foreach (ListViewItem selectedItem in listView1.SelectedItems)
                            {

                                listView1.Items.Remove(selectedItem);
                                File.Delete(selectedItem.SubItems[2].Text.ToString());
                            }
                        }

                    }
                    else
                    {

                    }
                    if ("en-US" == Properties.Settings.Default.language.ToString())
                    {
                        DialogResult result = MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text + " will be Deleted Do you Confirmed ? ", "File Delete", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            foreach (ListViewItem selectedItem in listView1.SelectedItems)
                            {

                                listView1.Items.Remove(selectedItem);
                                File.Delete(selectedItem.SubItems[2].Text.ToString());
                            }
                        }

                    }
                    else
                    {

                    }




                }
            }
            SaveData();
        }





        #endregion

        //Themes LIGHT DARK THEMES SETTİNGS AND COLORS
        #region
        private void SetLightTheme()
        {
            string tagLightBack = txtLightBack.Tag.ToString();
            string[] lightcolorpart1 = tagLightBack.Split(',');
            int lightBackR = Int32.Parse(lightcolorpart1[0]);
            int lightBackG = Int32.Parse(lightcolorpart1[1]);
            int lightBackB = Int32.Parse(lightcolorpart1[2]);
            string tagLightText = txtLightText.Tag.ToString();
            string[] lightcolorpart2 = tagLightText.Split(',');
            int lightTextR = Int32.Parse(lightcolorpart2[0]);
            int lightTextG = Int32.Parse(lightcolorpart2[1]);
            int lightTextB = Int32.Parse(lightcolorpart2[2]);
            

            ChangeAllPanelBackgroundColors(this, Color.FromArgb(lightBackR, lightBackG, lightBackB));
            ChangeAllLabelForegroundColors(this, Color.FromArgb(lightTextR, lightTextG, lightTextB));
            panelUpper.BackColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            labelTitle.ForeColor = Color.FromArgb(lightBackR, lightBackG, lightBackB);
            menuStrip1.BackColor = Color.FromArgb(lightBackR, lightBackG, lightBackB);
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            }
           

            txtLightBack.ForeColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            txtLightText.ForeColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            txtDarkBack.ForeColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            txtDarkText.ForeColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);

            button1.Image = Properties.Resources.lighttheme;
            listView1.BackColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            listView1.ForeColor = Color.FromArgb(lightBackR, lightBackG, lightBackB);

            btnExit.Image = Properties.Resources.light_exit;
            btnMinimize.Image = Properties.Resources.light_subtract;
            linkLabelProjectURL.LinkColor = Color.FromArgb(lightTextR, lightTextG, lightTextB);
            lblRESETCOLOR.ForeColor = Color.Red;
        }
        private void SetDarkTheme()
        {
            string tagDarkBack = txtDarkBack.Tag.ToString();
            string[] darkBackColorParts = tagDarkBack.Split(',');
            int darkBackR = Int32.Parse(darkBackColorParts[0]);
            int darkBackG = Int32.Parse(darkBackColorParts[1]);
            int darkBackB = Int32.Parse(darkBackColorParts[2]);
            string TagDarkText = txtDarkText.Tag.ToString();
            string[] darkBackColorParts2 = TagDarkText.Split(',');
            int darkTextR = Int32.Parse(darkBackColorParts2[0]);
            int darkTextG = Int32.Parse(darkBackColorParts2[1]);
            int darkTextB = Int32.Parse(darkBackColorParts2[2]);




            ChangeAllPanelBackgroundColors(this, Color.FromArgb(darkBackR, darkBackG, darkBackB));
            ChangeAllLabelForegroundColors(this, Color.FromArgb(darkTextR, darkTextG, darkTextB));
            panelUpper.BackColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            labelTitle.ForeColor = Color.FromArgb(darkBackR, darkBackG, darkBackB);
            

            listView1.BackColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            listView1.ForeColor = Color.FromArgb(darkBackR, darkBackG, darkBackB);
            button1.Image = Properties.Resources.darktheme;
            btnExit.Image = Properties.Resources.dark_exit;
            btnMinimize.Image = Properties.Resources.dark_subtract;
            linkLabelProjectURL.LinkColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            lblRESETCOLOR.ForeColor = Color.Red;


            txtLightBack.ForeColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            txtLightText.ForeColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            txtDarkBack.ForeColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);
            txtDarkText.ForeColor = Color.FromArgb(darkTextR, darkTextG, darkTextB);

        }
        public static void ChangeAllPanelBackgroundColors(Control control, Color color)
        {
            var panels = control.Controls.OfType<Panel>();
            foreach (var panel in panels)
            {
                panel.BackColor = color;
            }

            foreach (Control ctrl in control.Controls)
            {
                ChangeAllPanelBackgroundColors(ctrl, color);
            }
        }
        public static void ChangeAllLabelForegroundColors(Control control, Color color)
        {
            var labels = control.Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.ForeColor = color;
            }

            foreach (Control ctrl in control.Controls)
            {
                ChangeAllLabelForegroundColors(ctrl, color);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if ("Light" == Properties.Settings.Default.theme.ToString())
            {
                SetDarkTheme();
                Properties.Settings.Default.theme = "Dark";
                Properties.Settings.Default.Save();
            }
            else
            {
                SetLightTheme();
                Properties.Settings.Default.theme = "Light";
                Properties.Settings.Default.Save();
            }

        }


        #endregion

      
        

        private void btnColorBASESet_Click(object sender, EventArgs e)
        {
            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtVisualizationCbase.ForeColor = selectedColor;
                txtVisualizationCbase.BackColor = selectedColor;
                txtVisualizationCbase.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtVisualizationCbase.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");
                


            }

        }

        private void btnColorMAXSET_Click(object sender, EventArgs e)
        {

            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtVisualizationCmax.ForeColor = selectedColor;
                txtVisualizationCmax.BackColor = selectedColor;
                txtVisualizationCmax.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtVisualizationCmax.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");


            }
        }

        private void btnDarkBack_Click(object sender, EventArgs e)
        {
            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtDarkBack.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtDarkBack.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");


            }
        }

        private void btnDarkText_Click(object sender, EventArgs e)
        {
            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtDarkText.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtDarkText.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");

            }
        }

        private void btnDarkButton_Click(object sender, EventArgs e)
        {

        }

        private void btnLightBack_Click(object sender, EventArgs e)
        {
            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtLightBack.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtLightBack.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");

            }
        }

        private void btnLightText_Click(object sender, EventArgs e)
        {
            if (kryptonColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = kryptonColorDialog1.Color;
                txtLightText.Tag = $"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}";

                txtLightText.Text = string.Format($"{selectedColor.R}, {selectedColor.G}, {selectedColor.B}");

            }
        }

        private void btnLightButton_Click(object sender, EventArgs e)
        {

        }
    }
}
