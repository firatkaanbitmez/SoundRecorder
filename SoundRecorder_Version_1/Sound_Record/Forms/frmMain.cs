using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Diagnostics;
using Squirrel;
using System.Text;
using System.Linq;
using System.Threading;
using System.Drawing;
using MaterialSkin.Controls;
namespace Sound_Record
{
    public partial class frmMain : Form
    {
        

        private WaveOut waveOut = new WaveOut();


        Stopwatch stopwatch;
        private string outputFileName;
        private WasapiLoopbackCapture capture;

        public frmMain()
        {
            
            
            string filePath = Application.StartupPath+"\\data.txt";
            if (!File.Exists(filePath))
            {                
                using (FileStream fs = File.Create(filePath))
                {
                    
                }
            }          

            InitializeComponent();
                             

            listView1.MouseDown += new MouseEventHandler(listView1_MouseDown);
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
           


            AddVersionNumber();
            CheckForUpdates();
            this.Text = "Sound Recorder " + versionNum;
            listView1.Items.Clear();
            SettingLoad();


        }






        public void SettingLoad()
        {
            comboBoxLanguage.Text = Properties.Settings.Default.language;

            if (comboBoxLanguage.Text.ToString() == "tr-TR")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                this.Controls.Clear();
                
                InitializeComponent();

            }
            if (comboBoxLanguage.Text.ToString() == "en-US")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                this.Controls.Clear();
                
                this.InitializeComponent();
            }

            if (Properties.Settings.Default.language == "tr-TR")
            {
                comboBoxLanguage.SelectedIndex = 0;
            }
            if (Properties.Settings.Default.language == "en-US")
            {
                comboBoxLanguage.SelectedIndex = 1;
            }
            
            ComboboxOpenFile.Text = Properties.Settings.Default.OpenFiles;
            comboboxSaveDialog.Text = Properties.Settings.Default.savedialog;
            combobitrate.Text = Properties.Settings.Default.bitrate;
            comboExtension.Text = Properties.Settings.Default.extension;


            panelFileSettings.Visible = false;
            panelLanguageSettings.Visible = false;
            ProgressBarColor.SetState(progressbar1, 2);
            radioMono.Checked = true;
            
            
            LoadData();

            if ("1" == Properties.Settings.Default.radiobutton.ToString())
            {
                radioMono.Checked = true;
            }
            if ("2" == Properties.Settings.Default.radiobutton.ToString())
            {
                radioStereo.Checked = true;
            }
            

            if (Properties.Settings.Default.savedialog =="On")
            {
                comboboxSaveDialog.SelectedIndex = 0;
            }
            if ( Properties.Settings.Default.savedialog =="Off")
            {
                comboboxSaveDialog.SelectedIndex = 1;
            }





            txtFileLocation.Text = Properties.Settings.Default.txtPath;
            combobitrate.SelectedIndex = 2;
            comboExtension.SelectedIndex = 0;
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.txtPath))
            {
                txtFileLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            }
            
            comboExtension.Text = Properties.Settings.Default.extension;
           
            combobitrate.Text = Properties.Settings.Default.bitrate;

            panelSoundSettings.Visible = false;
            stopwatch = new Stopwatch();

            if (Properties.Settings.Default.OpenFiles =="On")
            {
                ComboboxOpenFile.SelectedIndex = 0;
            }
            if ( Properties.Settings.Default.OpenFiles =="Off")
            {
                ComboboxOpenFile.SelectedIndex = 1;
            }
           





        }












        /*********************************************************************************************************************************************/
        /*********************************************************************************************************************************************/
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

        /*********************************************************************************************************************************************/
        /*********************************************************************************************************************************************/


























        private void SaveData()
        {
            string appPath = Application.StartupPath;
            try
            {
                using (StreamWriter writer = new StreamWriter(appPath+"\\"+"data.txt"))
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



        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();

            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = txtFileLocation.Text;
            dialog.FileName = Path.GetRandomFileName();

            dialog.Filter = "wave Files (*." + comboExtension.Text.ToString() + ")|*." + comboExtension.Text.ToString() + "|All Files (*.*)|*.*";
            Thread.Sleep(100);
            if (Properties.Settings.Default.savedialog == "On") { 

                string filePath = dialog.FileName;


                label1.Text = txtFileLocation.Text + "\\" + dialog.FileName + "." + comboExtension.Text;

                ListViewItem item = new ListViewItem(dialog.FileName + "." + comboExtension.Text);
                listView1.Items.Add(item);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add(txtFileLocation.Text + "\\" + dialog.FileName + "." + comboExtension.Text);

                outputFileName = txtFileLocation.Text + "\\" + dialog.FileName + "." + comboExtension.Text;
                btnRecord.Enabled = false;
                btnStop.Enabled = true;
                int btrate = Convert.ToInt32(combobitrate.Text.ToString());
                int radiob = Convert.ToInt32(Properties.Settings.Default.radiobutton.ToString());

                capture = new WasapiLoopbackCapture();
                capture.WaveFormat = new WaveFormat(btrate, radiob);
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
                    }

                    btnRecord.Enabled = true;
                    btnStop.Enabled = false;
                    capture.Dispose();
                };
                stopwatch.Start();
                capture.StartRecording();

                capture.DataAvailable += HandleDataAvailable;

                Properties.Settings.Default.txtPath = txtFileLocation.Text;
                Properties.Settings.Default.Save();
                txtFileLocation.Text = Properties.Settings.Default.txtPath;

                Properties.Settings.Default.bitrate = combobitrate.Text;
                Properties.Settings.Default.Save();
                combobitrate.Text = Properties.Settings.Default.bitrate;

                Properties.Settings.Default.extension = comboExtension.Text;
                Properties.Settings.Default.Save();
                comboExtension.Text = Properties.Settings.Default.extension;

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


                label1.Text = dialog.FileName;

                ListViewItem item = new ListViewItem(System.IO.Path.GetFileName(dialog.FileName));
                listView1.Items.Add(item);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add(dialog.FileName);

                outputFileName = dialog.FileName;
                btnRecord.Enabled = false;
                btnStop.Enabled = true;
                int btrate = Convert.ToInt32(combobitrate.Text.ToString());
                int radiob = Convert.ToInt32(Properties.Settings.Default.radiobutton.ToString());

                capture = new WasapiLoopbackCapture();
                capture.WaveFormat = new WaveFormat(btrate, radiob);
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
                    }

                    btnRecord.Enabled = true;
                    btnStop.Enabled = false;
                    capture.Dispose();
                };
                stopwatch.Start();
                capture.StartRecording();

                capture.DataAvailable += HandleDataAvailable;

                Properties.Settings.Default.txtPath = txtFileLocation.Text;
                Properties.Settings.Default.Save();
                txtFileLocation.Text = Properties.Settings.Default.txtPath;

                Properties.Settings.Default.bitrate = combobitrate.Text;
                Properties.Settings.Default.Save();
                combobitrate.Text = Properties.Settings.Default.bitrate;

                Properties.Settings.Default.extension = comboExtension.Text;
                Properties.Settings.Default.Save();
                comboExtension.Text = Properties.Settings.Default.extension;

                btnPlayPause.Enabled = false;
                lbl_Timer.ForeColor = Color.Red;

            }

        }

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


        }


        private void btnStop_Click(object sender, EventArgs e)
        {


            progressbar1.Value = 0;
            progressbar1.Update();
            Thread.Sleep(100);

            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            capture.StopRecording();
            stopwatch.Stop();

            btnPlayPause.Enabled = true;
            if (outputFileName == null)
            {
                return;
            }
            if (Properties.Settings.Default.OpenFiles=="On")
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
        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            WaveFileReader waveFileReader = new WaveFileReader(label1.Text.ToString());
            if (label1 == null)
            {
                MessageBox.Show("Please make a Record first of all");
                return;
            }

            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
               
                btnPlayPause.Image = Properties.Resources.icons8_play_button_circled_48;
                btnRecord.Enabled = true;
                if (btnRecord.Text=="Kayıt")
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


        



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    txtFileLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioMono.Checked == true)
            {
                Properties.Settings.Default.radiobutton = "1";
                Properties.Settings.Default.Save();
            }
            if (radioStereo.Checked == true)
            {
                Properties.Settings.Default.radiobutton = "2";
                Properties.Settings.Default.Save();
            }
            
           



            if (!string.IsNullOrEmpty(combobitrate.Text))
            {
                Properties.Settings.Default.bitrate = combobitrate.Text;
                Properties.Settings.Default.Save();
                panelSoundSettings.Visible = false;
            }
            if (!string.IsNullOrEmpty(comboExtension.Text))
            {
                Properties.Settings.Default.extension = comboExtension.Text;
                Properties.Settings.Default.Save();
                panelSoundSettings.Visible = false;
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            panelSoundSettings.Visible = false;
            this.Refresh();
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.bitrate))
            {
                combobitrate.Text = Properties.Settings.Default.bitrate;

            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.extension))
            {
                comboExtension.Text = Properties.Settings.Default.extension;

            }


        }







        //GİTHUB UPDATER AND ASSEMBLY VERSİON NUMBER
        #region
        public string versionNum;
        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionNum += $"v.{versionInfo.FileVersion}";


        }
        public string releaseversion;
        private async void CheckForUpdates()
        {

            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/SoundRecorder"))
            {


                try
                {
                    var updateInfo = await mgr.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        var versionCount = updateInfo.ReleasesToApply.Count;
                        var x5 = updateInfo.FutureReleaseEntry.Version.ToString();
                        var versionWord = versionCount > 1 ? "versions" : "version";
                        var message = new StringBuilder().AppendLine($"App is {versionCount} {versionWord} behind. Latest version v.{x5}").
                                                          AppendLine("If you choose to update, changes won't take ").
                                                          AppendLine("effect until App is restarted.").
                                                          AppendLine("Would you like to download and install them?").
                                                          ToString();

                        DialogResult result = MessageBox.Show(message, "App Update", MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                        {

                            //this.logger.Info("update declined by user.");
                            return;
                        }

                        //this.logger.Info("Downloading updates");

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


        #endregion






   

        private void label1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string filePath = label1.Text.ToString();

            System.Diagnostics.Process.Start(filePath);
        }



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop.PerformClick();
            Thread.Sleep(100);
            Application.Exit();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnStop.PerformClick();
            Thread.Sleep(100);
            Application.Exit();
        }

       
        private void btnokey_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
        }

        private void lblClickProjectURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the path to the file
            string filePath = lblClickProjectURL.Text.ToString();
            var ps = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

       
       
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SaveData();
        }

       

        private void btnLanguageSave_Click(object sender, EventArgs e)
        {

            

            if (!string.IsNullOrEmpty(comboBoxLanguage.Text))
            {
                Properties.Settings.Default.language = comboBoxLanguage.Text;
                Properties.Settings.Default.Save();
                panelLanguageSettings.Visible = false;
            }




            Application.Restart();

           
        }

        private void languageSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelFileSettings.Visible = false;
            panelLanguageSettings.Visible = true;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelLanguageSettings.Dock = DockStyle.Fill;

        }

        private void btnLanguageCancel_Click(object sender, EventArgs e)
        {
            panelLanguageSettings.Visible = false;
            this.Refresh();
            
           
        }

        private void soundSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFileSettings.Visible = false;
            panelLanguageSettings.Visible=false;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = true;
            panelSoundSettings.Dock = DockStyle.Fill;

        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
           

            if (!string.IsNullOrEmpty(txtFileLocation.Text))
            {
                Properties.Settings.Default.txtPath = txtFileLocation.Text;
                Properties.Settings.Default.Save();
                panelSoundSettings.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select your path", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }


            if (!string.IsNullOrEmpty(ComboboxOpenFile.Text))
            {
                Properties.Settings.Default.OpenFiles = ComboboxOpenFile.Text;
                Properties.Settings.Default.Save();
             
            }
            if (!string.IsNullOrEmpty(comboboxSaveDialog.Text))
            {
                Properties.Settings.Default.savedialog = comboboxSaveDialog.Text;
                Properties.Settings.Default.Save();

            }

            


            panelFileSettings.Visible = false;

           
        }

        private void btnFileCancel_Click(object sender, EventArgs e)
        {
            panelFileSettings.Visible = false;
            this.Refresh();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.txtPath))
            {
                txtFileLocation.Text = Properties.Settings.Default.txtPath;

            }
            else
            {
                txtFileLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
           
        }

        private void fileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFileSettings.Visible = true;
            panelLanguageSettings.Visible = false;
            panelAbout.Visible = false;
            panelSoundSettings.Visible = false;
            panelFileSettings.Dock = DockStyle.Fill;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFileSettings.Visible = false;
            panelLanguageSettings.Visible = false;
            panelAbout.Visible = true;
            panelSoundSettings.Visible = false;
            panelAbout.Dock = DockStyle.Fill;

        }

       

        private void showRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = txtFileLocation.Text.ToString();

            System.Diagnostics.Process.Start(filePath);

        }

       
    }
    }
