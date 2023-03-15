namespace Sound_Record
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
            this.label1 = new System.Windows.Forms.LinkLabel();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lblSoundType = new System.Windows.Forms.Label();
            this.radioStereo = new System.Windows.Forms.RadioButton();
            this.radioMono = new System.Windows.Forms.RadioButton();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblSoundkhz = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelSoundSettings = new System.Windows.Forms.Panel();
            this.combobitrate = new MaterialSkin.Controls.MaterialComboBox();
            this.comboExtension = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panelAbout = new System.Windows.Forms.Panel();
            this.btnokey = new MaterialSkin.Controls.MaterialButton();
            this.lblProjectURL = new System.Windows.Forms.Label();
            this.lblClickProjectURL = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLanguageSettings = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLanguageCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnLanguageSave = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxLanguage = new MaterialSkin.Controls.MaterialComboBox();
            this.panelFileSettings = new System.Windows.Forms.Panel();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.comboboxSaveDialog = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFileCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnFileSave = new MaterialSkin.Controls.MaterialButton();
            this.ComboboxOpenFile = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFileLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.progressbar1 = new Sound_Record.progressbar();
            this.menuStrip1.SuspendLayout();
            this.panelSoundSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.panelLanguageSettings.SuspendLayout();
            this.panelFileSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.LinkColor = System.Drawing.Color.DarkGreen;
            this.label1.Name = "label1";
            this.label1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label1_LinkClicked);
            // 
            // settingsToolStripMenuItem1
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem1, "settingsToolStripMenuItem1");
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSettingsToolStripMenuItem,
            this.soundSettingsToolStripMenuItem,
            this.languageSettingsToolStripMenuItem1});
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            // 
            // fileSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.fileSettingsToolStripMenuItem, "fileSettingsToolStripMenuItem");
            this.fileSettingsToolStripMenuItem.Name = "fileSettingsToolStripMenuItem";
            this.fileSettingsToolStripMenuItem.Click += new System.EventHandler(this.fileSettingsToolStripMenuItem_Click);
            // 
            // soundSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.soundSettingsToolStripMenuItem, "soundSettingsToolStripMenuItem");
            this.soundSettingsToolStripMenuItem.Name = "soundSettingsToolStripMenuItem";
            this.soundSettingsToolStripMenuItem.Click += new System.EventHandler(this.soundSettingsToolStripMenuItem_Click);
            // 
            // languageSettingsToolStripMenuItem1
            // 
            resources.ApplyResources(this.languageSettingsToolStripMenuItem1, "languageSettingsToolStripMenuItem1");
            this.languageSettingsToolStripMenuItem1.Name = "languageSettingsToolStripMenuItem1";
            this.languageSettingsToolStripMenuItem1.Click += new System.EventHandler(this.languageSettingsToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRecordingToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            // 
            // showRecordingToolStripMenuItem
            // 
            resources.ApplyResources(this.showRecordingToolStripMenuItem, "showRecordingToolStripMenuItem");
            this.showRecordingToolStripMenuItem.Name = "showRecordingToolStripMenuItem";
            this.showRecordingToolStripMenuItem.Click += new System.EventHandler(this.showRecordingToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            resources.ApplyResources(this.clearListToolStripMenuItem, "clearListToolStripMenuItem");
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // btnPlayPause
            // 
            resources.ApplyResources(this.btnPlayPause, "btnPlayPause");
            this.btnPlayPause.Image = global::Sound_Record.Properties.Resources.icons8_play_button_circled_48;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // lblSoundType
            // 
            resources.ApplyResources(this.lblSoundType, "lblSoundType");
            this.lblSoundType.Name = "lblSoundType";
            // 
            // radioStereo
            // 
            resources.ApplyResources(this.radioStereo, "radioStereo");
            this.radioStereo.Name = "radioStereo";
            this.radioStereo.TabStop = true;
            this.radioStereo.UseVisualStyleBackColor = true;
            // 
            // radioMono
            // 
            resources.ApplyResources(this.radioMono, "radioMono");
            this.radioMono.Name = "radioMono";
            this.radioMono.TabStop = true;
            this.radioMono.UseVisualStyleBackColor = true;
            // 
            // lblExtension
            // 
            resources.ApplyResources(this.lblExtension, "lblExtension");
            this.lblExtension.Name = "lblExtension";
            // 
            // lblSoundkhz
            // 
            resources.ApplyResources(this.lblSoundkhz, "lblSoundkhz");
            this.lblSoundkhz.Name = "lblSoundkhz";
            // 
            // btnRecord
            // 
            resources.ApplyResources(this.btnRecord, "btnRecord");
            this.btnRecord.Image = global::Sound_Record.Properties.Resources.icons8_record_48px_7;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Image = global::Sound_Record.Properties.Resources.icons8_stop_squared_48px;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panelSoundSettings
            // 
            resources.ApplyResources(this.panelSoundSettings, "panelSoundSettings");
            this.panelSoundSettings.Controls.Add(this.combobitrate);
            this.panelSoundSettings.Controls.Add(this.comboExtension);
            this.panelSoundSettings.Controls.Add(this.btnCancel);
            this.panelSoundSettings.Controls.Add(this.btnSave);
            this.panelSoundSettings.Controls.Add(this.groupBox1);
            this.panelSoundSettings.Controls.Add(this.lblSoundType);
            this.panelSoundSettings.Controls.Add(this.lblExtension);
            this.panelSoundSettings.Controls.Add(this.lblSoundkhz);
            this.panelSoundSettings.Name = "panelSoundSettings";
  
            // 
            // combobitrate
            // 
            resources.ApplyResources(this.combobitrate, "combobitrate");
            this.combobitrate.AutoResize = false;
            this.combobitrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.combobitrate.Depth = 0;
            this.combobitrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combobitrate.DropDownHeight = 118;
            this.combobitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobitrate.DropDownWidth = 121;
            this.combobitrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combobitrate.FormattingEnabled = true;
            this.combobitrate.Items.AddRange(new object[] {
            resources.GetString("combobitrate.Items"),
            resources.GetString("combobitrate.Items1"),
            resources.GetString("combobitrate.Items2"),
            resources.GetString("combobitrate.Items3"),
            resources.GetString("combobitrate.Items4"),
            resources.GetString("combobitrate.Items5"),
            resources.GetString("combobitrate.Items6"),
            resources.GetString("combobitrate.Items7")});
            this.combobitrate.MouseState = MaterialSkin.MouseState.OUT;
            this.combobitrate.Name = "combobitrate";
            this.combobitrate.StartIndex = 0;
            this.combobitrate.UseTallSize = false;
            // 
            // comboExtension
            // 
            resources.ApplyResources(this.comboExtension, "comboExtension");
            this.comboExtension.AutoResize = false;
            this.comboExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboExtension.Depth = 0;
            this.comboExtension.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboExtension.DropDownHeight = 118;
            this.comboExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtension.DropDownWidth = 121;
            this.comboExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboExtension.FormattingEnabled = true;
            this.comboExtension.Items.AddRange(new object[] {
            resources.GetString("comboExtension.Items"),
            resources.GetString("comboExtension.Items1"),
            resources.GetString("comboExtension.Items2"),
            resources.GetString("comboExtension.Items3")});
            this.comboExtension.MouseState = MaterialSkin.MouseState.OUT;
            this.comboExtension.Name = "comboExtension";
            this.comboExtension.StartIndex = 0;
            this.comboExtension.UseTallSize = false;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = false;
            this.btnCancel.Icon = null;
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = false;
            this.btnSave.Icon = null;
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radioMono);
            this.groupBox1.Controls.Add(this.radioStereo);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbl_Timer
            // 
            resources.ApplyResources(this.lbl_Timer, "lbl_Timer");
            this.lbl_Timer.Name = "lbl_Timer";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panelAbout
            // 
            resources.ApplyResources(this.panelAbout, "panelAbout");
            this.panelAbout.Controls.Add(this.btnokey);
            this.panelAbout.Controls.Add(this.lblProjectURL);
            this.panelAbout.Controls.Add(this.lblClickProjectURL);
            this.panelAbout.Name = "panelAbout";
            // 
            // btnokey
            // 
            resources.ApplyResources(this.btnokey, "btnokey");
            this.btnokey.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnokey.Depth = 0;
            this.btnokey.HighEmphasis = false;
            this.btnokey.Icon = null;
            this.btnokey.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnokey.Name = "btnokey";
            this.btnokey.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnokey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnokey.UseAccentColor = false;
            this.btnokey.UseVisualStyleBackColor = true;
            this.btnokey.Click += new System.EventHandler(this.btnokey_Click);
            // 
            // lblProjectURL
            // 
            resources.ApplyResources(this.lblProjectURL, "lblProjectURL");
            this.lblProjectURL.ForeColor = System.Drawing.Color.Red;
            this.lblProjectURL.Name = "lblProjectURL";
            // 
            // lblClickProjectURL
            // 
            resources.ApplyResources(this.lblClickProjectURL, "lblClickProjectURL");
            this.lblClickProjectURL.LinkColor = System.Drawing.Color.Blue;
            this.lblClickProjectURL.Name = "lblClickProjectURL";
            this.lblClickProjectURL.TabStop = true;
            this.lblClickProjectURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClickProjectURL_LinkClicked);
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
            // panelLanguageSettings
            // 
            resources.ApplyResources(this.panelLanguageSettings, "panelLanguageSettings");
            this.panelLanguageSettings.Controls.Add(this.label6);
            this.panelLanguageSettings.Controls.Add(this.btnLanguageCancel);
            this.panelLanguageSettings.Controls.Add(this.btnLanguageSave);
            this.panelLanguageSettings.Controls.Add(this.comboBoxLanguage);
            this.panelLanguageSettings.Name = "panelLanguageSettings";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnLanguageCancel
            // 
            resources.ApplyResources(this.btnLanguageCancel, "btnLanguageCancel");
            this.btnLanguageCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLanguageCancel.Depth = 0;
            this.btnLanguageCancel.HighEmphasis = false;
            this.btnLanguageCancel.Icon = null;
            this.btnLanguageCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLanguageCancel.Name = "btnLanguageCancel";
            this.btnLanguageCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLanguageCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLanguageCancel.UseAccentColor = false;
            this.btnLanguageCancel.UseVisualStyleBackColor = true;
            this.btnLanguageCancel.Click += new System.EventHandler(this.btnLanguageCancel_Click);
            // 
            // btnLanguageSave
            // 
            resources.ApplyResources(this.btnLanguageSave, "btnLanguageSave");
            this.btnLanguageSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLanguageSave.Depth = 0;
            this.btnLanguageSave.HighEmphasis = false;
            this.btnLanguageSave.Icon = null;
            this.btnLanguageSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLanguageSave.Name = "btnLanguageSave";
            this.btnLanguageSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLanguageSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLanguageSave.UseAccentColor = false;
            this.btnLanguageSave.UseVisualStyleBackColor = true;
            this.btnLanguageSave.Click += new System.EventHandler(this.btnLanguageSave_Click);
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.AutoResize = false;
            this.comboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxLanguage.Depth = 0;
            this.comboBoxLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxLanguage.DropDownHeight = 118;
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.DropDownWidth = 121;
            this.comboBoxLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguage.Items"),
            resources.GetString("comboBoxLanguage.Items1")});
            this.comboBoxLanguage.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.StartIndex = 0;
            this.comboBoxLanguage.UseTallSize = false;
            // 
            // panelFileSettings
            // 
            resources.ApplyResources(this.panelFileSettings, "panelFileSettings");
            this.panelFileSettings.Controls.Add(this.btnBrowse);
            this.panelFileSettings.Controls.Add(this.comboboxSaveDialog);
            this.panelFileSettings.Controls.Add(this.label4);
            this.panelFileSettings.Controls.Add(this.label2);
            this.panelFileSettings.Controls.Add(this.btnFileCancel);
            this.panelFileSettings.Controls.Add(this.btnFileSave);
            this.panelFileSettings.Controls.Add(this.ComboboxOpenFile);
            this.panelFileSettings.Controls.Add(this.txtFileLocation);
            this.panelFileSettings.Controls.Add(this.label5);
            this.panelFileSettings.Controls.Add(this.label3);
            this.panelFileSettings.Controls.Add(this.lblFileLocation);
            this.panelFileSettings.Name = "panelFileSettings";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.HighEmphasis = false;
            this.btnBrowse.Icon = null;
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowse.UseAccentColor = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comboboxSaveDialog
            // 
            resources.ApplyResources(this.comboboxSaveDialog, "comboboxSaveDialog");
            this.comboboxSaveDialog.AutoResize = false;
            this.comboboxSaveDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboboxSaveDialog.Depth = 0;
            this.comboboxSaveDialog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboboxSaveDialog.DropDownHeight = 118;
            this.comboboxSaveDialog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSaveDialog.DropDownWidth = 121;
            this.comboboxSaveDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboboxSaveDialog.FormattingEnabled = true;
            this.comboboxSaveDialog.Items.AddRange(new object[] {
            resources.GetString("comboboxSaveDialog.Items"),
            resources.GetString("comboboxSaveDialog.Items1")});
            this.comboboxSaveDialog.MouseState = MaterialSkin.MouseState.OUT;
            this.comboboxSaveDialog.Name = "comboboxSaveDialog";
            this.comboboxSaveDialog.StartIndex = 0;
            this.comboboxSaveDialog.UseTallSize = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnFileCancel
            // 
            resources.ApplyResources(this.btnFileCancel, "btnFileCancel");
            this.btnFileCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFileCancel.Depth = 0;
            this.btnFileCancel.HighEmphasis = false;
            this.btnFileCancel.Icon = null;
            this.btnFileCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFileCancel.Name = "btnFileCancel";
            this.btnFileCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFileCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFileCancel.UseAccentColor = false;
            this.btnFileCancel.UseVisualStyleBackColor = true;
            this.btnFileCancel.Click += new System.EventHandler(this.btnFileCancel_Click);
            // 
            // btnFileSave
            // 
            resources.ApplyResources(this.btnFileSave, "btnFileSave");
            this.btnFileSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFileSave.Depth = 0;
            this.btnFileSave.HighEmphasis = false;
            this.btnFileSave.Icon = null;
            this.btnFileSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFileSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFileSave.UseAccentColor = false;
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // ComboboxOpenFile
            // 
            resources.ApplyResources(this.ComboboxOpenFile, "ComboboxOpenFile");
            this.ComboboxOpenFile.AutoResize = false;
            this.ComboboxOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboboxOpenFile.Depth = 0;
            this.ComboboxOpenFile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboboxOpenFile.DropDownHeight = 118;
            this.ComboboxOpenFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxOpenFile.DropDownWidth = 121;
            this.ComboboxOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboboxOpenFile.FormattingEnabled = true;
            this.ComboboxOpenFile.Items.AddRange(new object[] {
            resources.GetString("ComboboxOpenFile.Items"),
            resources.GetString("ComboboxOpenFile.Items1")});
            this.ComboboxOpenFile.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboboxOpenFile.Name = "ComboboxOpenFile";
            this.ComboboxOpenFile.StartIndex = 0;
            this.ComboboxOpenFile.UseTallSize = false;
            // 
            // txtFileLocation
            // 
            resources.ApplyResources(this.txtFileLocation, "txtFileLocation");
            this.txtFileLocation.AnimateReadOnly = false;
            this.txtFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileLocation.Depth = 0;
            this.txtFileLocation.LeadingIcon = null;
            this.txtFileLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.TrailingIcon = null;
            this.txtFileLocation.UseTallSize = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblFileLocation
            // 
            resources.ApplyResources(this.lblFileLocation, "lblFileLocation");
            this.lblFileLocation.Name = "lblFileLocation";
            // 
            // progressbar1
            // 
            resources.ApplyResources(this.progressbar1, "progressbar1");
            this.progressbar1.Name = "progressbar1";
            // 
            // frmMain
            // 
            this.AcceptButton = this.label1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFileSettings);
            this.Controls.Add(this.panelLanguageSettings);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSoundSettings);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSoundSettings.ResumeLayout(false);
            this.panelSoundSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.panelLanguageSettings.ResumeLayout(false);
            this.panelLanguageSettings.PerformLayout();
            this.panelFileSettings.ResumeLayout(false);
            this.panelFileSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel label1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lblSoundType;
        private System.Windows.Forms.RadioButton radioStereo;
        private System.Windows.Forms.RadioButton radioMono;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblSoundkhz;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panelSoundSettings;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer Timer;
        private progressbar progressbar1;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.LinkLabel lblClickProjectURL;
        private System.Windows.Forms.Label lblProjectURL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panelLanguageSettings;
        private System.Windows.Forms.ToolStripMenuItem languageSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soundSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Panel panelFileSettings;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxLanguage;
        private MaterialSkin.Controls.MaterialComboBox ComboboxOpenFile;
        private MaterialSkin.Controls.MaterialTextBox txtFileLocation;
        private MaterialSkin.Controls.MaterialButton btnFileCancel;
        private MaterialSkin.Controls.MaterialButton btnFileSave;
        private MaterialSkin.Controls.MaterialButton btnLanguageCancel;
        private MaterialSkin.Controls.MaterialButton btnLanguageSave;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox comboboxSaveDialog;
        private MaterialSkin.Controls.MaterialButton btnBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton btnokey;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox comboExtension;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialComboBox combobitrate;
    }
}