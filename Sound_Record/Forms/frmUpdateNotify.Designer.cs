﻿namespace Sound_Record.Forms
{
    partial class frmUpdateNotify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateNotify));
            this.NotifyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotifyRemindLater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotifyLabel
            // 
            this.NotifyLabel.AutoSize = true;
            this.NotifyLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotifyLabel.ForeColor = System.Drawing.Color.Black;
            this.NotifyLabel.Location = new System.Drawing.Point(12, 59);
            this.NotifyLabel.Name = "NotifyLabel";
            this.NotifyLabel.Size = new System.Drawing.Size(58, 20);
            this.NotifyLabel.TabIndex = 0;
            this.NotifyLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
            this.button1.Image = global::Sound_Record.Properties.Resources.ezgif_5_c012dbf7bf;
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 114);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Install Now";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NotifyRemindLater
            // 
            this.NotifyRemindLater.AutoSize = true;
            this.NotifyRemindLater.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotifyRemindLater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
            this.NotifyRemindLater.Location = new System.Drawing.Point(12, 117);
            this.NotifyRemindLater.Name = "NotifyRemindLater";
            this.NotifyRemindLater.Size = new System.Drawing.Size(111, 16);
            this.NotifyRemindLater.TabIndex = 2;
            this.NotifyRemindLater.Text = "Remind Me Later";
            this.NotifyRemindLater.Click += new System.EventHandler(this.label2_Click);
            this.NotifyRemindLater.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.NotifyRemindLater.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // frmUpdateNotify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(426, 142);
            this.Controls.Add(this.NotifyRemindLater);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NotifyLabel);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateNotify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmUpdateNotify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotifyLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label NotifyRemindLater;
    }
}