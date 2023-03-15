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
            this.panelDefaultWall = new System.Windows.Forms.Panel();
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.progressbar2 = new Sound_Record.progressbar();
            this.progressbar1 = new Sound_Record.progressbar();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelOnlineVersion = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelCurrentVersion = new System.Windows.Forms.Label();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.comboLanguages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSystemSettings = new System.Windows.Forms.Panel();
            this.comboDevies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboOpenFileAfter = new System.Windows.Forms.ComboBox();
            this.comboConfimation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSoundSettings = new System.Windows.Forms.Panel();
            this.comboExtension = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboChannels = new System.Windows.Forms.ComboBox();
            this.comboOutRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.soundSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpper.SuspendLayout();
            this.panelDefaultWall.SuspendLayout();
            this.panelCustomize.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLanguage.SuspendLayout();
            this.panelSystemSettings.SuspendLayout();
            this.panelSoundSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = global::Sound_Record.Properties.Resources.icons8_subtract_16px_1;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::Sound_Record.Properties.Resources.icons8_x_16px_1;
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
            this.panelUpper.BackColor = System.Drawing.Color.AliceBlue;
            this.panelUpper.Controls.Add(this.btnMinimize);
            this.panelUpper.Controls.Add(this.btnExit);
            this.panelUpper.Controls.Add(this.pictureBox1);
            this.panelUpper.Controls.Add(this.labelTitle);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseDown);
            this.panelUpper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseMove);
            this.panelUpper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUpper_MouseUp);
            // 
            // panelDefaultWall
            // 
            resources.ApplyResources(this.panelDefaultWall, "panelDefaultWall");
            this.panelDefaultWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panelDefaultWall.Controls.Add(this.panelCustomize);
            this.panelDefaultWall.Name = "panelDefaultWall";
            // 
            // panelCustomize
            // 
            resources.ApplyResources(this.panelCustomize, "panelCustomize");
            this.panelCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panelCustomize.Controls.Add(this.panelUpdate);
            this.panelCustomize.Controls.Add(this.progressbar2);
            this.panelCustomize.Controls.Add(this.progressbar1);
            this.panelCustomize.Controls.Add(this.panelAbout);
            this.panelCustomize.Controls.Add(this.panelLanguage);
            this.panelCustomize.Controls.Add(this.panelSystemSettings);
            this.panelCustomize.Controls.Add(this.panelSoundSettings);
            this.panelCustomize.Controls.Add(this.btnPlayPause);
            this.panelCustomize.Controls.Add(this.btnStop);
            this.panelCustomize.Controls.Add(this.btnRecord);
            this.panelCustomize.Controls.Add(this.btnBack);
            this.panelCustomize.Controls.Add(this.menuStrip1);
            this.panelCustomize.Controls.Add(this.btnSave);
            this.panelCustomize.Controls.Add(this.listView1);
            this.panelCustomize.Controls.Add(this.lbl_Timer);
            this.panelCustomize.Controls.Add(this.label3);
            this.panelCustomize.ForeColor = System.Drawing.Color.AliceBlue;
            this.panelCustomize.Name = "panelCustomize";
            // 
            // progressbar2
            // 
            resources.ApplyResources(this.progressbar2, "progressbar2");
            this.progressbar2.Name = "progressbar2";
            // 
            // progressbar1
            // 
            resources.ApplyResources(this.progressbar1, "progressbar1");
            this.progressbar1.Name = "progressbar1";
            // 
            // panelUpdate
            // 
            resources.ApplyResources(this.panelUpdate, "panelUpdate");
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.label13);
            this.panelUpdate.Controls.Add(this.labelOnlineVersion);
            this.panelUpdate.Controls.Add(this.label12);
            this.panelUpdate.Controls.Add(this.labelCurrentVersion);
            this.panelUpdate.Name = "panelUpdate";
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
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // labelOnlineVersion
            // 
            resources.ApplyResources(this.labelOnlineVersion, "labelOnlineVersion");
            this.labelOnlineVersion.Name = "labelOnlineVersion";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // labelCurrentVersion
            // 
            resources.ApplyResources(this.labelCurrentVersion, "labelCurrentVersion");
            this.labelCurrentVersion.Name = "labelCurrentVersion";
            // 
            // panelAbout
            // 
            resources.ApplyResources(this.panelAbout, "panelAbout");
            this.panelAbout.Controls.Add(this.pictureBox2);
            this.panelAbout.Controls.Add(this.linkLabel1);
            this.panelAbout.Controls.Add(this.btnOk);
            this.panelAbout.Name = "panelAbout";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::Sound_Record.Properties.Resources.middle_earth_shadow_of_mordo;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/firatkaanbitmez/SoundRecorder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.btnOk.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOk.Name = "btnOk";
            this.btnOk.TabStop = false;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelLanguage
            // 
            resources.ApplyResources(this.panelLanguage, "panelLanguage");
            this.panelLanguage.Controls.Add(this.comboLanguages);
            this.panelLanguage.Controls.Add(this.label2);
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Name = "label2";
            // 
            // panelSystemSettings
            // 
            resources.ApplyResources(this.panelSystemSettings, "panelSystemSettings");
            this.panelSystemSettings.Controls.Add(this.comboDevies);
            this.panelSystemSettings.Controls.Add(this.label4);
            this.panelSystemSettings.Controls.Add(this.label10);
            this.panelSystemSettings.Controls.Add(this.comboOpenFileAfter);
            this.panelSystemSettings.Controls.Add(this.comboConfimation);
            this.panelSystemSettings.Controls.Add(this.label9);
            this.panelSystemSettings.Controls.Add(this.label8);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Name = "label4";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Name = "label10";
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
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
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
            this.panelSoundSettings.Controls.Add(this.label6);
            this.panelSoundSettings.Controls.Add(this.comboChannels);
            this.panelSoundSettings.Controls.Add(this.comboOutRate);
            this.panelSoundSettings.Controls.Add(this.label7);
            this.panelSoundSettings.Controls.Add(this.label5);
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Name = "label6";
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Name = "label5";
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
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.btnBack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Name = "btnBack";
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
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
            this.soundSettingsToolStripMenuItem1,
            this.toolStripSeparator3,
            this.languageToolStripMenuItem});
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
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
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
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(114)))));
            this.btnSave.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // miniToolStrip
            // 
            resources.ApplyResources(this.miniToolStrip, "miniToolStrip");
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.miniToolStrip.Name = "miniToolStrip";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.panelDefaultWall.ResumeLayout(false);
            this.panelCustomize.ResumeLayout(false);
            this.panelCustomize.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.panelSystemSettings.ResumeLayout(false);
            this.panelSystemSettings.PerformLayout();
            this.panelSoundSettings.ResumeLayout(false);
            this.panelSoundSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panelDefaultWall;
        private System.Windows.Forms.Panel panelCustomize;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panelSystemSettings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboOpenFileAfter;
        private System.Windows.Forms.ComboBox comboConfimation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboDevies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSoundSettings;
        private System.Windows.Forms.ComboBox comboExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboChannels;
        private System.Windows.Forms.ComboBox comboOutRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.ComboBox comboLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRecordToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelOnlineVersion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelCurrentVersion;
        private progressbar progressbar2;
        private progressbar progressbar1;
    }
}