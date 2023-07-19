using System;
using System.Windows.Forms;
using NAudio.Wave;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Set up the WaveIn source and file writer
            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0; // Use the default microphone
            waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1kHz mono
            waveIn.DataAvailable += WaveIn_DataAvailable;
            writer = new WaveFileWriter("output.wav", waveIn.WaveFormat);

            // Start recording
            lblStatus.Text = "Recording... Press Stop to stop recording.";
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
            waveIn.StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop recording
            waveIn.StopRecording();

            // Clean up resources
            waveIn.Dispose();
            writer.Close();

            var inPath = @"C:\Users\FIRAT\Desktop\WindowsFormsApp1\bin\Debug\output.wav";
            var outPath = @"C:\Users\FIRAT\Desktop\WindowsFormsApp1\bin\Debug\normalized.wav";
            float max = 0;

            using (var reader = new AudioFileReader(inPath))
            {
                // find the max peak
                float[] buffer = new float[reader.WaveFormat.SampleRate];
                int read;
                do
                {
                    read = reader.Read(buffer, 0, buffer.Length);
                    for (int n = 0; n < read; n++)
                    {
                        var abs = Math.Abs(buffer[n]);
                        if (abs > max) max = abs;
                    }
                } while (read > 0);
                Console.WriteLine($"Max sample value: {max}");

                if (max == 0 || max > 1.0f)
                    throw new InvalidOperationException("File cannot be normalized");

                // rewind and amplify
                reader.Position = 0;
                reader.Volume = 0.05f / max;   ////////ARTIŞ MİKTARIII

                // write out to a new WAV file
                WaveFileWriter.CreateWaveFile16(outPath, reader);
            }

            lblStatus.Text = "Recording saved to normalized.wav.";
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Write the audio data to the output file
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        
    
    }
}
