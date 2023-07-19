using System.Drawing;
using System.Windows.Forms;

namespace Sound_Record.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.panelAbouts = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabelProjectURL = new System.Windows.Forms.LinkLabel();
            this.panelVisualizationEffects = new System.Windows.Forms.Panel();
            this.btnColorMAXSET = new System.Windows.Forms.Button();
            this.btnColorBASESet = new System.Windows.Forms.Button();
            this.txtVisualizationCmax = new System.Windows.Forms.TextBox();
            this.txtVisualizationCbase = new System.Windows.Forms.TextBox();
            this.txtVisualizationBarSpacing = new System.Windows.Forms.TextBox();
            this.txtVisualizationBarCount = new System.Windows.Forms.TextBox();
            this.comboVisualizationQuality = new System.Windows.Forms.ComboBox();
            this.comboVisualizationVisible = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelinterface = new System.Windows.Forms.Panel();
            this.btnLightButton = new System.Windows.Forms.Button();
            this.btnLightText = new System.Windows.Forms.Button();
            this.btnLightBack = new System.Windows.Forms.Button();
            this.txtLightButton = new System.Windows.Forms.TextBox();
            this.txtLightText = new System.Windows.Forms.TextBox();
            this.txtLightBack = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDarkButton = new System.Windows.Forms.Button();
            this.btnDarkText = new System.Windows.Forms.Button();
            this.btnDarkBack = new System.Windows.Forms.Button();
            this.txtDarkButton = new System.Windows.Forms.TextBox();
            this.txtDarkText = new System.Windows.Forms.TextBox();
            this.txtDarkBack = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRESETCOLOR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelColorScheme = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.labelAvailableInfo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelCurrentVersion = new System.Windows.Forms.Label();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.comboLanguages = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.panelSystemSettings = new System.Windows.Forms.Panel();
            this.comboDevies = new System.Windows.Forms.ComboBox();
            this.labelRecordDevice = new System.Windows.Forms.Label();
            this.labelOpenFile = new System.Windows.Forms.Label();
            this.comboOpenFileAfter = new System.Windows.Forms.ComboBox();
            this.comboConfimation = new System.Windows.Forms.ComboBox();
            this.labelConfirmation = new System.Windows.Forms.Label();
            this.labelFileSaveLocation = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSoundSettings = new System.Windows.Forms.Panel();
            this.comboExtension = new System.Windows.Forms.ComboBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.comboChannels = new System.Windows.Forms.ComboBox();
            this.comboOutRate = new System.Windows.Forms.ComboBox();
            this.labelChannels = new System.Windows.Forms.Label();
            this.labelOutRate = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.soundSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ınterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.audioVisualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.labelFilePathInvsbl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelHider = new System.Windows.Forms.Panel();
            this.audioVisualization1 = new CSAudioVisualization.AudioVisualization();
            this.panelDefaultWall = new System.Windows.Forms.Panel();
            this.kryptonColorDialog1 = new Krypton.Toolkit.KryptonColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpper.SuspendLayout();
            this.panelCustomize.SuspendLayout();
            this.panelAbouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelVisualizationEffects.SuspendLayout();
            this.panelinterface.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.panelSystemSettings.SuspendLayout();
            this.panelSoundSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDefaultWall.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = global::Sound_Record.Properties.Resources.light_subtract;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::Sound_Record.Properties.Resources.light_exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Sound_Record.Properties.Resources.icons8_fiber_smart_record_64px;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Name = "labelTitle";
            // 
            // panelUpper
            // 
            resources.ApplyResources(this.panelUpper, "panelUpper");
            this.panelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panelUpper.Controls.Add(this.button1);
            this.panelUpper.Controls.Add(this.btnMinimize);
            this.panelUpper.Controls.Add(this.btnExit);
            this.panelUpper.Controls.Add(this.pictureBox1);
            this.panelUpper.Controls.Add(this.labelTitle);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseDown);
            this.panelUpper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseMove);
            this.panelUpper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseUp);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Sound_Record.Properties.Resources.lighttheme;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelCustomize
            // 
            resources.ApplyResources(this.panelCustomize, "panelCustomize");
            this.panelCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panelCustomize.Controls.Add(this.panelAbouts);
            this.panelCustomize.Controls.Add(this.panelVisualizationEffects);
            this.panelCustomize.Controls.Add(this.panelinterface);
            this.panelCustomize.Controls.Add(this.panelUpdate);
            this.panelCustomize.Controls.Add(this.panelLanguage);
            this.panelCustomize.Controls.Add(this.panelSystemSettings);
            this.panelCustomize.Controls.Add(this.panelSoundSettings);
            this.panelCustomize.Controls.Add(this.btnPlayPause);
            this.panelCustomize.Controls.Add(this.btnStop);
            this.panelCustomize.Controls.Add(this.btnRecord);
            this.panelCustomize.Controls.Add(this.menuStrip1);
            this.panelCustomize.Controls.Add(this.listView1);
            this.panelCustomize.Controls.Add(this.lbl_Timer);
            this.panelCustomize.Controls.Add(this.labelFilePathInvsbl);
            this.panelCustomize.Controls.Add(this.btnSave);
            this.panelCustomize.Controls.Add(this.btnBack);
            this.panelCustomize.Controls.Add(this.panelHider);
            this.panelCustomize.Controls.Add(this.audioVisualization1);
            this.panelCustomize.ForeColor = System.Drawing.Color.AliceBlue;
            this.panelCustomize.Name = "panelCustomize";
            // 
            // panelAbouts
            // 
            resources.ApplyResources(this.panelAbouts, "panelAbouts");
            this.panelAbouts.Controls.Add(this.btnOk);
            this.panelAbouts.Controls.Add(this.pictureBox2);
            this.panelAbouts.Controls.Add(this.linkLabelProjectURL);
            this.panelAbouts.Name = "panelAbouts";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnOk.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOk.Name = "btnOk";
            this.btnOk.TabStop = false;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::Sound_Record.Properties.Resources.middle_earth_shadow_of_mordo;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // linkLabelProjectURL
            // 
            resources.ApplyResources(this.linkLabelProjectURL, "linkLabelProjectURL");
            this.linkLabelProjectURL.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabelProjectURL.Name = "linkLabelProjectURL";
            this.linkLabelProjectURL.TabStop = true;
            this.linkLabelProjectURL.Tag = "https://github.com/firatkaanbitmez/SoundRecorder";
            this.linkLabelProjectURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProjectURL_LinkClicked);
            // 
            // panelVisualizationEffects
            // 
            resources.ApplyResources(this.panelVisualizationEffects, "panelVisualizationEffects");
            this.panelVisualizationEffects.Controls.Add(this.btnColorMAXSET);
            this.panelVisualizationEffects.Controls.Add(this.btnColorBASESet);
            this.panelVisualizationEffects.Controls.Add(this.txtVisualizationCmax);
            this.panelVisualizationEffects.Controls.Add(this.txtVisualizationCbase);
            this.panelVisualizationEffects.Controls.Add(this.txtVisualizationBarSpacing);
            this.panelVisualizationEffects.Controls.Add(this.txtVisualizationBarCount);
            this.panelVisualizationEffects.Controls.Add(this.comboVisualizationQuality);
            this.panelVisualizationEffects.Controls.Add(this.comboVisualizationVisible);
            this.panelVisualizationEffects.Controls.Add(this.label7);
            this.panelVisualizationEffects.Controls.Add(this.label6);
            this.panelVisualizationEffects.Controls.Add(this.label5);
            this.panelVisualizationEffects.Controls.Add(this.label4);
            this.panelVisualizationEffects.Controls.Add(this.label3);
            this.panelVisualizationEffects.Controls.Add(this.label2);
            this.panelVisualizationEffects.Name = "panelVisualizationEffects";
            // 
            // btnColorMAXSET
            // 
            resources.ApplyResources(this.btnColorMAXSET, "btnColorMAXSET");
            this.btnColorMAXSET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnColorMAXSET.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnColorMAXSET.Name = "btnColorMAXSET";
            this.btnColorMAXSET.TabStop = false;
            this.btnColorMAXSET.UseVisualStyleBackColor = false;
            this.btnColorMAXSET.Click += new System.EventHandler(this.btnColorMAXSET_Click);
            // 
            // btnColorBASESet
            // 
            resources.ApplyResources(this.btnColorBASESet, "btnColorBASESet");
            this.btnColorBASESet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnColorBASESet.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnColorBASESet.Name = "btnColorBASESet";
            this.btnColorBASESet.TabStop = false;
            this.btnColorBASESet.UseVisualStyleBackColor = false;
            this.btnColorBASESet.Click += new System.EventHandler(this.btnColorBASESet_Click);
            // 
            // txtVisualizationCmax
            // 
            resources.ApplyResources(this.txtVisualizationCmax, "txtVisualizationCmax");
            this.txtVisualizationCmax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisualizationCmax.Name = "txtVisualizationCmax";
            this.txtVisualizationCmax.ReadOnly = true;
            this.txtVisualizationCmax.TabStop = false;
            // 
            // txtVisualizationCbase
            // 
            resources.ApplyResources(this.txtVisualizationCbase, "txtVisualizationCbase");
            this.txtVisualizationCbase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisualizationCbase.Name = "txtVisualizationCbase";
            this.txtVisualizationCbase.ReadOnly = true;
            this.txtVisualizationCbase.TabStop = false;
            // 
            // txtVisualizationBarSpacing
            // 
            resources.ApplyResources(this.txtVisualizationBarSpacing, "txtVisualizationBarSpacing");
            this.txtVisualizationBarSpacing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisualizationBarSpacing.Name = "txtVisualizationBarSpacing";
            this.txtVisualizationBarSpacing.TabStop = false;
            // 
            // txtVisualizationBarCount
            // 
            resources.ApplyResources(this.txtVisualizationBarCount, "txtVisualizationBarCount");
            this.txtVisualizationBarCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisualizationBarCount.Name = "txtVisualizationBarCount";
            this.txtVisualizationBarCount.TabStop = false;
            // 
            // comboVisualizationQuality
            // 
            resources.ApplyResources(this.comboVisualizationQuality, "comboVisualizationQuality");
            this.comboVisualizationQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVisualizationQuality.FormattingEnabled = true;
            this.comboVisualizationQuality.Items.AddRange(new object[] {
            resources.GetString("comboVisualizationQuality.Items"),
            resources.GetString("comboVisualizationQuality.Items1")});
            this.comboVisualizationQuality.Name = "comboVisualizationQuality";
            this.comboVisualizationQuality.TabStop = false;
            this.comboVisualizationQuality.SelectedIndexChanged += new System.EventHandler(this.comboVisualizationQuality_SelectedIndexChanged);
            // 
            // comboVisualizationVisible
            // 
            resources.ApplyResources(this.comboVisualizationVisible, "comboVisualizationVisible");
            this.comboVisualizationVisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVisualizationVisible.FormattingEnabled = true;
            this.comboVisualizationVisible.Items.AddRange(new object[] {
            resources.GetString("comboVisualizationVisible.Items"),
            resources.GetString("comboVisualizationVisible.Items1")});
            this.comboVisualizationVisible.Name = "comboVisualizationVisible";
            this.comboVisualizationVisible.TabStop = false;
            this.comboVisualizationVisible.SelectedIndexChanged += new System.EventHandler(this.comboVisualizationVisible_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Name = "label2";
            // 
            // panelinterface
            // 
            resources.ApplyResources(this.panelinterface, "panelinterface");
            this.panelinterface.Controls.Add(this.btnLightButton);
            this.panelinterface.Controls.Add(this.btnLightText);
            this.panelinterface.Controls.Add(this.btnLightBack);
            this.panelinterface.Controls.Add(this.txtLightButton);
            this.panelinterface.Controls.Add(this.txtLightText);
            this.panelinterface.Controls.Add(this.txtLightBack);
            this.panelinterface.Controls.Add(this.label11);
            this.panelinterface.Controls.Add(this.label12);
            this.panelinterface.Controls.Add(this.label13);
            this.panelinterface.Controls.Add(this.btnDarkButton);
            this.panelinterface.Controls.Add(this.btnDarkText);
            this.panelinterface.Controls.Add(this.btnDarkBack);
            this.panelinterface.Controls.Add(this.txtDarkButton);
            this.panelinterface.Controls.Add(this.txtDarkText);
            this.panelinterface.Controls.Add(this.txtDarkBack);
            this.panelinterface.Controls.Add(this.label10);
            this.panelinterface.Controls.Add(this.label9);
            this.panelinterface.Controls.Add(this.label8);
            this.panelinterface.Controls.Add(this.lblRESETCOLOR);
            this.panelinterface.Controls.Add(this.label1);
            this.panelinterface.Controls.Add(this.labelColorScheme);
            this.panelinterface.Name = "panelinterface";
            // 
            // btnLightButton
            // 
            resources.ApplyResources(this.btnLightButton, "btnLightButton");
            this.btnLightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnLightButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLightButton.Name = "btnLightButton";
            this.btnLightButton.TabStop = false;
            this.btnLightButton.UseVisualStyleBackColor = false;
            this.btnLightButton.Click += new System.EventHandler(this.btnLightButton_Click);
            // 
            // btnLightText
            // 
            resources.ApplyResources(this.btnLightText, "btnLightText");
            this.btnLightText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnLightText.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLightText.Name = "btnLightText";
            this.btnLightText.TabStop = false;
            this.btnLightText.UseVisualStyleBackColor = false;
            this.btnLightText.Click += new System.EventHandler(this.btnLightText_Click);
            // 
            // btnLightBack
            // 
            resources.ApplyResources(this.btnLightBack, "btnLightBack");
            this.btnLightBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnLightBack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLightBack.Name = "btnLightBack";
            this.btnLightBack.TabStop = false;
            this.btnLightBack.UseVisualStyleBackColor = false;
            this.btnLightBack.Click += new System.EventHandler(this.btnLightBack_Click);
            // 
            // txtLightButton
            // 
            resources.ApplyResources(this.txtLightButton, "txtLightButton");
            this.txtLightButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLightButton.Name = "txtLightButton";
            this.txtLightButton.ReadOnly = true;
            this.txtLightButton.TabStop = false;
            // 
            // txtLightText
            // 
            resources.ApplyResources(this.txtLightText, "txtLightText");
            this.txtLightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLightText.Name = "txtLightText";
            this.txtLightText.ReadOnly = true;
            this.txtLightText.TabStop = false;
            // 
            // txtLightBack
            // 
            resources.ApplyResources(this.txtLightBack, "txtLightBack");
            this.txtLightBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLightBack.Name = "txtLightBack";
            this.txtLightBack.ReadOnly = true;
            this.txtLightBack.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Name = "label13";
            // 
            // btnDarkButton
            // 
            resources.ApplyResources(this.btnDarkButton, "btnDarkButton");
            this.btnDarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnDarkButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDarkButton.Name = "btnDarkButton";
            this.btnDarkButton.TabStop = false;
            this.btnDarkButton.UseVisualStyleBackColor = false;
            this.btnDarkButton.Click += new System.EventHandler(this.btnDarkButton_Click);
            // 
            // btnDarkText
            // 
            resources.ApplyResources(this.btnDarkText, "btnDarkText");
            this.btnDarkText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnDarkText.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDarkText.Name = "btnDarkText";
            this.btnDarkText.TabStop = false;
            this.btnDarkText.UseVisualStyleBackColor = false;
            this.btnDarkText.Click += new System.EventHandler(this.btnDarkText_Click);
            // 
            // btnDarkBack
            // 
            resources.ApplyResources(this.btnDarkBack, "btnDarkBack");
            this.btnDarkBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnDarkBack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDarkBack.Name = "btnDarkBack";
            this.btnDarkBack.TabStop = false;
            this.btnDarkBack.UseVisualStyleBackColor = false;
            this.btnDarkBack.Click += new System.EventHandler(this.btnDarkBack_Click);
            // 
            // txtDarkButton
            // 
            resources.ApplyResources(this.txtDarkButton, "txtDarkButton");
            this.txtDarkButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDarkButton.Name = "txtDarkButton";
            this.txtDarkButton.ReadOnly = true;
            this.txtDarkButton.TabStop = false;
            // 
            // txtDarkText
            // 
            resources.ApplyResources(this.txtDarkText, "txtDarkText");
            this.txtDarkText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDarkText.Name = "txtDarkText";
            this.txtDarkText.ReadOnly = true;
            this.txtDarkText.TabStop = false;
            // 
            // txtDarkBack
            // 
            resources.ApplyResources(this.txtDarkBack, "txtDarkBack");
            this.txtDarkBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDarkBack.Name = "txtDarkBack";
            this.txtDarkBack.ReadOnly = true;
            this.txtDarkBack.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Name = "label8";
            // 
            // lblRESETCOLOR
            // 
            resources.ApplyResources(this.lblRESETCOLOR, "lblRESETCOLOR");
            this.lblRESETCOLOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRESETCOLOR.ForeColor = System.Drawing.Color.Red;
            this.lblRESETCOLOR.Name = "lblRESETCOLOR";
            this.lblRESETCOLOR.Click += new System.EventHandler(this.lblRESETCOLOR_Click);
            this.lblRESETCOLOR.MouseEnter += new System.EventHandler(this.lblRESETCOLOR_MouseEnter);
            this.lblRESETCOLOR.MouseLeave += new System.EventHandler(this.lblRESETCOLOR_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Name = "label1";
            // 
            // labelColorScheme
            // 
            resources.ApplyResources(this.labelColorScheme, "labelColorScheme");
            this.labelColorScheme.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelColorScheme.Name = "labelColorScheme";
            // 
            // panelUpdate
            // 
            resources.ApplyResources(this.panelUpdate, "panelUpdate");
            this.panelUpdate.Controls.Add(this.labelAvailableInfo);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.labelCurrentVersion);
            this.panelUpdate.Name = "panelUpdate";
            // 
            // labelAvailableInfo
            // 
            resources.ApplyResources(this.labelAvailableInfo, "labelAvailableInfo");
            this.labelAvailableInfo.Name = "labelAvailableInfo";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabStop = false;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelCurrentVersion
            // 
            resources.ApplyResources(this.labelCurrentVersion, "labelCurrentVersion");
            this.labelCurrentVersion.Name = "labelCurrentVersion";
            // 
            // panelLanguage
            // 
            resources.ApplyResources(this.panelLanguage, "panelLanguage");
            this.panelLanguage.Controls.Add(this.comboLanguages);
            this.panelLanguage.Controls.Add(this.labelLanguage);
            this.panelLanguage.Name = "panelLanguage";
            // 
            // comboLanguages
            // 
            resources.ApplyResources(this.comboLanguages, "comboLanguages");
            this.comboLanguages.DisplayMember = "aaa";
            this.comboLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguages.FormattingEnabled = true;
            this.comboLanguages.Items.AddRange(new object[] {
            resources.GetString("comboLanguages.Items"),
            resources.GetString("comboLanguages.Items1")});
            this.comboLanguages.Name = "comboLanguages";
            this.comboLanguages.TabStop = false;
            this.comboLanguages.Tag = "";
            this.comboLanguages.SelectedIndexChanged += new System.EventHandler(this.comboLanguages_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLanguage.Name = "labelLanguage";
            // 
            // panelSystemSettings
            // 
            resources.ApplyResources(this.panelSystemSettings, "panelSystemSettings");
            this.panelSystemSettings.Controls.Add(this.comboDevies);
            this.panelSystemSettings.Controls.Add(this.labelRecordDevice);
            this.panelSystemSettings.Controls.Add(this.labelOpenFile);
            this.panelSystemSettings.Controls.Add(this.comboOpenFileAfter);
            this.panelSystemSettings.Controls.Add(this.comboConfimation);
            this.panelSystemSettings.Controls.Add(this.labelConfirmation);
            this.panelSystemSettings.Controls.Add(this.labelFileSaveLocation);
            this.panelSystemSettings.Controls.Add(this.btnBrowse);
            this.panelSystemSettings.Controls.Add(this.textBox1);
            this.panelSystemSettings.Name = "panelSystemSettings";
            // 
            // comboDevies
            // 
            resources.ApplyResources(this.comboDevies, "comboDevies");
            this.comboDevies.DisplayMember = "aaa";
            this.comboDevies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDevies.FormattingEnabled = true;
            this.comboDevies.Name = "comboDevies";
            this.comboDevies.TabStop = false;
            this.comboDevies.Tag = "";
            this.comboDevies.SelectedIndexChanged += new System.EventHandler(this.comboDevies_SelectedIndexChanged);
            // 
            // labelRecordDevice
            // 
            resources.ApplyResources(this.labelRecordDevice, "labelRecordDevice");
            this.labelRecordDevice.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelRecordDevice.Name = "labelRecordDevice";
            // 
            // labelOpenFile
            // 
            resources.ApplyResources(this.labelOpenFile, "labelOpenFile");
            this.labelOpenFile.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelOpenFile.Name = "labelOpenFile";
            // 
            // comboOpenFileAfter
            // 
            resources.ApplyResources(this.comboOpenFileAfter, "comboOpenFileAfter");
            this.comboOpenFileAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOpenFileAfter.FormattingEnabled = true;
            this.comboOpenFileAfter.Items.AddRange(new object[] {
            resources.GetString("comboOpenFileAfter.Items"),
            resources.GetString("comboOpenFileAfter.Items1")});
            this.comboOpenFileAfter.Name = "comboOpenFileAfter";
            this.comboOpenFileAfter.TabStop = false;
            this.comboOpenFileAfter.SelectedIndexChanged += new System.EventHandler(this.comboOpenFileAfter_SelectedIndexChanged);
            // 
            // comboConfimation
            // 
            resources.ApplyResources(this.comboConfimation, "comboConfimation");
            this.comboConfimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConfimation.FormattingEnabled = true;
            this.comboConfimation.Items.AddRange(new object[] {
            resources.GetString("comboConfimation.Items"),
            resources.GetString("comboConfimation.Items1")});
            this.comboConfimation.Name = "comboConfimation";
            this.comboConfimation.TabStop = false;
            this.comboConfimation.SelectedIndexChanged += new System.EventHandler(this.comboConfimation_SelectedIndexChanged);
            // 
            // labelConfirmation
            // 
            resources.ApplyResources(this.labelConfirmation, "labelConfirmation");
            this.labelConfirmation.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelConfirmation.Name = "labelConfirmation";
            // 
            // labelFileSaveLocation
            // 
            resources.ApplyResources(this.labelFileSaveLocation, "labelFileSaveLocation");
            this.labelFileSaveLocation.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelFileSaveLocation.Name = "labelFileSaveLocation";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnBrowse.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.TabStop = false;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Name = "textBox1";
            this.textBox1.TabStop = false;
            // 
            // panelSoundSettings
            // 
            resources.ApplyResources(this.panelSoundSettings, "panelSoundSettings");
            this.panelSoundSettings.Controls.Add(this.comboExtension);
            this.panelSoundSettings.Controls.Add(this.labelExtension);
            this.panelSoundSettings.Controls.Add(this.comboChannels);
            this.panelSoundSettings.Controls.Add(this.comboOutRate);
            this.panelSoundSettings.Controls.Add(this.labelChannels);
            this.panelSoundSettings.Controls.Add(this.labelOutRate);
            this.panelSoundSettings.Name = "panelSoundSettings";
            // 
            // comboExtension
            // 
            resources.ApplyResources(this.comboExtension, "comboExtension");
            this.comboExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtension.FormattingEnabled = true;
            this.comboExtension.Items.AddRange(new object[] {
            resources.GetString("comboExtension.Items"),
            resources.GetString("comboExtension.Items1"),
            resources.GetString("comboExtension.Items2"),
            resources.GetString("comboExtension.Items3"),
            resources.GetString("comboExtension.Items4"),
            resources.GetString("comboExtension.Items5"),
            resources.GetString("comboExtension.Items6")});
            this.comboExtension.Name = "comboExtension";
            this.comboExtension.TabStop = false;
            this.comboExtension.SelectedIndexChanged += new System.EventHandler(this.comboExtension_SelectedIndexChanged);
            // 
            // labelExtension
            // 
            resources.ApplyResources(this.labelExtension, "labelExtension");
            this.labelExtension.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelExtension.Name = "labelExtension";
            // 
            // comboChannels
            // 
            resources.ApplyResources(this.comboChannels, "comboChannels");
            this.comboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChannels.FormattingEnabled = true;
            this.comboChannels.Items.AddRange(new object[] {
            resources.GetString("comboChannels.Items"),
            resources.GetString("comboChannels.Items1")});
            this.comboChannels.Name = "comboChannels";
            this.comboChannels.TabStop = false;
            this.comboChannels.SelectedIndexChanged += new System.EventHandler(this.comboChannels_SelectedIndexChanged);
            // 
            // comboOutRate
            // 
            resources.ApplyResources(this.comboOutRate, "comboOutRate");
            this.comboOutRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOutRate.FormattingEnabled = true;
            this.comboOutRate.Items.AddRange(new object[] {
            resources.GetString("comboOutRate.Items"),
            resources.GetString("comboOutRate.Items1"),
            resources.GetString("comboOutRate.Items2"),
            resources.GetString("comboOutRate.Items3"),
            resources.GetString("comboOutRate.Items4")});
            this.comboOutRate.Name = "comboOutRate";
            this.comboOutRate.TabStop = false;
            this.comboOutRate.SelectedIndexChanged += new System.EventHandler(this.comboOutRate_SelectedIndexChanged);
            // 
            // labelChannels
            // 
            resources.ApplyResources(this.labelChannels, "labelChannels");
            this.labelChannels.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelChannels.Name = "labelChannels";
            // 
            // labelOutRate
            // 
            resources.ApplyResources(this.labelOutRate, "labelOutRate");
            this.labelOutRate.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelOutRate.Name = "labelOutRate";
            // 
            // btnPlayPause
            // 
            resources.ApplyResources(this.btnPlayPause, "btnPlayPause");
            this.btnPlayPause.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPlayPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btnPlayPause.Image = global::Sound_Record.Properties.Resources.icons8_play_button_circled_48;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btnStop.Image = global::Sound_Record.Properties.Resources.icons8_stop_squared_48px;
            this.btnStop.Name = "btnStop";
            this.btnStop.TabStop = false;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRecord
            // 
            resources.ApplyResources(this.btnRecord, "btnRecord");
            this.btnRecord.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btnRecord.Image = global::Sound_Record.Properties.Resources.icons8_record_48px_7;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.TabStop = false;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.ınterfaceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.showRecordToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // clearListToolStripMenuItem
            // 
            resources.ApplyResources(this.clearListToolStripMenuItem, "clearListToolStripMenuItem");
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // showRecordToolStripMenuItem
            // 
            resources.ApplyResources(this.showRecordToolStripMenuItem, "showRecordToolStripMenuItem");
            this.showRecordToolStripMenuItem.Name = "showRecordToolStripMenuItem";
            this.showRecordToolStripMenuItem.Click += new System.EventHandler(this.showRecordToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.soundSettingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // SystemSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.SystemSettingsToolStripMenuItem, "SystemSettingsToolStripMenuItem");
            this.SystemSettingsToolStripMenuItem.Name = "SystemSettingsToolStripMenuItem";
            this.SystemSettingsToolStripMenuItem.Click += new System.EventHandler(this.SystemSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // soundSettingsToolStripMenuItem1
            // 
            resources.ApplyResources(this.soundSettingsToolStripMenuItem1, "soundSettingsToolStripMenuItem1");
            this.soundSettingsToolStripMenuItem1.Name = "soundSettingsToolStripMenuItem1";
            this.soundSettingsToolStripMenuItem1.Click += new System.EventHandler(this.soundSettingsToolStripMenuItem1_Click);
            // 
            // ınterfaceToolStripMenuItem
            // 
            resources.ApplyResources(this.ınterfaceToolStripMenuItem, "ınterfaceToolStripMenuItem");
            this.ınterfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInterfaceToolStripMenuItem,
            this.toolStripSeparator3,
            this.audioVisualizationToolStripMenuItem,
            this.toolStripSeparator4,
            this.languageToolStripMenuItem1});
            this.ınterfaceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ınterfaceToolStripMenuItem.Name = "ınterfaceToolStripMenuItem";
            // 
            // userInterfaceToolStripMenuItem
            // 
            resources.ApplyResources(this.userInterfaceToolStripMenuItem, "userInterfaceToolStripMenuItem");
            this.userInterfaceToolStripMenuItem.Name = "userInterfaceToolStripMenuItem";
            this.userInterfaceToolStripMenuItem.Click += new System.EventHandler(this.userInterfaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // audioVisualizationToolStripMenuItem
            // 
            resources.ApplyResources(this.audioVisualizationToolStripMenuItem, "audioVisualizationToolStripMenuItem");
            this.audioVisualizationToolStripMenuItem.Name = "audioVisualizationToolStripMenuItem";
            this.audioVisualizationToolStripMenuItem.Click += new System.EventHandler(this.audioVisualizationToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // languageToolStripMenuItem1
            // 
            resources.ApplyResources(this.languageToolStripMenuItem1, "languageToolStripMenuItem1");
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            this.languageToolStripMenuItem1.Click += new System.EventHandler(this.languageToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // updatesToolStripMenuItem
            // 
            resources.ApplyResources(this.updatesToolStripMenuItem, "updatesToolStripMenuItem");
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // lbl_Timer
            // 
            resources.ApplyResources(this.lbl_Timer, "lbl_Timer");
            this.lbl_Timer.Name = "lbl_Timer";
            // 
            // labelFilePathInvsbl
            // 
            resources.ApplyResources(this.labelFilePathInvsbl, "labelFilePathInvsbl");
            this.labelFilePathInvsbl.Name = "labelFilePathInvsbl";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnSave.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(76)))));
            this.btnBack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Name = "btnBack";
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelHider
            // 
            resources.ApplyResources(this.panelHider, "panelHider");
            this.panelHider.Name = "panelHider";
            // 
            // audioVisualization1
            // 
            resources.ApplyResources(this.audioVisualization1, "audioVisualization1");
            this.audioVisualization1.AudioSource = null;
            this.audioVisualization1.BarCount = 80;
            this.audioVisualization1.BarSpacing = 3;
            this.audioVisualization1.ColorBase = System.Drawing.Color.DarkRed;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Snow;
            this.audioVisualization1.DeviceIndex = 0;
            this.audioVisualization1.FileName = null;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.MessageArgs = null;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.pic3DGraph = null;
            this.audioVisualization1.UseAverage = true;
            this.audioVisualization1.UserKey = "Your registration key";
            this.audioVisualization1.UserName = "Your email";
            this.audioVisualization1.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            // 
            // panelDefaultWall
            // 
            resources.ApplyResources(this.panelDefaultWall, "panelDefaultWall");
            this.panelDefaultWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panelDefaultWall.Controls.Add(this.panelCustomize);
            this.panelDefaultWall.Name = "panelDefaultWall";
            // 
            // kryptonColorDialog1
            // 
            this.kryptonColorDialog1.FullOpen = true;
            this.kryptonColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("kryptonColorDialog1.Icon")));
            this.kryptonColorDialog1.ShowIcon = true;
            this.kryptonColorDialog1.Title = null;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDefaultWall);
            this.Controls.Add(this.panelUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.panelCustomize.ResumeLayout(false);
            this.panelCustomize.PerformLayout();
            this.panelAbouts.ResumeLayout(false);
            this.panelAbouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelVisualizationEffects.ResumeLayout(false);
            this.panelVisualizationEffects.PerformLayout();
            this.panelinterface.ResumeLayout(false);
            this.panelinterface.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.panelSystemSettings.ResumeLayout(false);
            this.panelSystemSettings.PerformLayout();
            this.panelSoundSettings.ResumeLayout(false);
            this.panelSoundSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDefaultWall.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCustomize;
        private System.Windows.Forms.Panel panelinterface;
        private System.Windows.Forms.Label lblRESETCOLOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelColorScheme;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label labelAvailableInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelCurrentVersion;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.ComboBox comboLanguages;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Panel panelSystemSettings;
        private System.Windows.Forms.ComboBox comboDevies;
        private System.Windows.Forms.Label labelRecordDevice;
        private System.Windows.Forms.Label labelOpenFile;
        private System.Windows.Forms.ComboBox comboOpenFileAfter;
        private System.Windows.Forms.ComboBox comboConfimation;
        private System.Windows.Forms.Label labelConfirmation;
        private System.Windows.Forms.Label labelFileSaveLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelSoundSettings;
        private System.Windows.Forms.ComboBox comboExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.ComboBox comboChannels;
        private System.Windows.Forms.ComboBox comboOutRate;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.Label labelOutRate;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem soundSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ınterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Label labelFilePathInvsbl;
        private System.Windows.Forms.Panel panelDefaultWall;
        private Krypton.Toolkit.KryptonColorDialog kryptonColorDialog1;
        private CSAudioVisualization.AudioVisualization audioVisualization1;
        private System.Windows.Forms.Panel panelHider;
        private System.Windows.Forms.Panel panelAbouts;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabelProjectURL;
        private System.Windows.Forms.Panel panelVisualizationEffects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem audioVisualizationToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboVisualizationVisible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboVisualizationQuality;
        private System.Windows.Forms.TextBox txtVisualizationCmax;
        private System.Windows.Forms.TextBox txtVisualizationCbase;
        private System.Windows.Forms.TextBox txtVisualizationBarSpacing;
        private System.Windows.Forms.TextBox txtVisualizationBarCount;
        private Button btnColorMAXSET;
        private Button btnColorBASESet;
        private Button btnDarkButton;
        private Button btnDarkText;
        private Button btnDarkBack;
        private TextBox txtDarkButton;
        private TextBox txtDarkText;
        private TextBox txtDarkBack;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnLightButton;
        private Button btnLightText;
        private Button btnLightBack;
        private TextBox txtLightButton;
        private TextBox txtLightText;
        private TextBox txtLightBack;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}