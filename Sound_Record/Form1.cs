using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Diagnostics;

namespace Sound_Record
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        private string outputFileName;
        private WasapiLoopbackCapture capture;

        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = Properties.Settings.Default.txtPath;
            label2.Visible= false;           
            panel1.Visible= false;
            stopwatch = new Stopwatch();

            if (Properties.Settings.Default.FileOpen == "true")
            {
                checkBox1.Checked= true;
            }
            if (Properties.Settings.Default.FileOpen == "false")
            {
                checkBox1.Checked= false;
            }

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Timer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = textBox1.Text;
            dialog.FileName = Path.GetRandomFileName();
            
            dialog.Filter = "wave Files (*.wav)|*.wav|All Files (*.*)|*.*";
            


            if(dialog.ShowDialog() != DialogResult.OK) 
            {
                return;
            }
            if (dialog.FileName != "")
            {
                
                string filePath = dialog.FileName;

                label2.Visible = true;
                label1.Text = dialog.FileName;
                outputFileName = dialog.FileName;
                btnStart.Enabled = false;
                btnStop.Enabled = true;

                capture = new WasapiLoopbackCapture();
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

                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    capture.Dispose();
                };

                capture.StartRecording();
                stopwatch.Start();
                Properties.Settings.Default.txtPath = textBox1.Text;
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.txtPath;

            }


              
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            capture.StopRecording();
            stopwatch.Stop();
            stopwatch.Reset();

            if (outputFileName == null)
            {
                return;
            }
            if(checkBox1.Checked)
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(outputFileName),
                    UseShellExecute = true
                };

                Process.Start(processStartInfo);

            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Properties.Settings.Default.FileOpen = "true";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                
            }
            else
            {
                Properties.Settings.Default.FileOpen = "false";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock= DockStyle.Fill;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    textBox1.Text = fbd.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Properties.Settings.Default.txtPath = textBox1.Text;
                Properties.Settings.Default.Save();
                panel1.Visible = false;
            }
            else
                MessageBox.Show("Please select your path.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
    }
}
