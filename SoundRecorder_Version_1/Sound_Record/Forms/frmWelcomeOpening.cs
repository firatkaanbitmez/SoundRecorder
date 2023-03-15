using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sound_Record
{
    public partial class frmWelcomeOpening : Form
    {
        private bool isDragging = false;
        private Point lastLocation;

        public frmWelcomeOpening()
        {

            InitializeComponent();

        }


        private void welcomeform_Load(object sender, EventArgs e)
        {
            if ("tr-TR" == Properties.Settings.Default.language.ToString())
            {
                
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                this.Controls.Clear();

                InitializeComponent();
                LoadDevices();
                LoadSettings();
                btnLanguage.Text = "English";
                btnLanguage.Image = Properties.Resources.english_flag;
            }
            if ("en-US" == Properties.Settings.Default.language.ToString())
            {

                

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                this.Controls.Clear();

                InitializeComponent();
                LoadDevices();
                LoadSettings();
                btnLanguage.Text = "Türkçe"; ;
                btnLanguage.Image = Properties.Resources.turkish_flag;
            }


        }



        private void LoadSettings()
        {
            panelWelcomeFirst.Visible = true;
            panelWelcomeFirst.Dock = DockStyle.Fill;
            comboDevies.SelectedIndex = 0;
            comboExtension.SelectedIndex = 0;
            comboChannels.SelectedIndex = 1;
            comboOutRate.SelectedIndex = 1;
            comboConfimation.SelectedIndex = 1;
            comboOpenFileAfter.SelectedIndex = 1;
            textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        }




        private void btnExpress_Click(object sender, EventArgs e)
        {
            if ("tr-TR" == Properties.Settings.Default.language.ToString())
            {
                DialogResult result = MessageBox.Show("Hızlı kurulumla Devam etmek istiyor musunuz?", "Hızlı Kurulum", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("evet");
                }
                else
                {
                    MessageBox.Show("hayır");
                }
            }
            if ("en-US" == Properties.Settings.Default.language.ToString())
            {
                DialogResult result = MessageBox.Show("Do you want to Continue with Express Installation?", "Express Installation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("no");
                }
            }
            
        }


        private void btnCustom_Click(object sender, EventArgs e)
        {
            panelWelcomeFirst.Visible=false;
        }

        //Button Back Custom Menu
        #region
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelWelcomeFirst.Visible = true;
            panelWelcomeFirst.Dock = DockStyle.Fill;
        }
        #endregion

        //Load Devies
        #region
        private void LoadDevices()
        {
            var enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            comboDevies.Items.AddRange(devices.ToArray());
        }
        #endregion

        //Move panel to form
        #region
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        #endregion

        //ComboBoxes Selections
        #region
        private void comboDevies_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboSaveLocation_SelectedIndexChanged(object sender, EventArgs e)
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

        #endregion

        //Language
        #region
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (btnLanguage.Text.ToString() == "Türkçe")
            {
                Properties.Settings.Default.language = "tr-TR";
                Properties.Settings.Default.Save();

                Application.Restart();
            }
            if (btnLanguage.Text.ToString() == "English")
            {
                Properties.Settings.Default.language = "en-US";
                Properties.Settings.Default.Save();

                Application.Restart();
            }

        }
        #endregion

        //Buton Browse
        #region
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    textBox1.Text = fbd.SelectedPath;
            }
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

    }
}
