
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSettingsSubMenu = new System.Windows.Forms.Panel();
            this.buttonBinds = new System.Windows.Forms.Button();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonDropDownSettings = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSettingsAudioWindow = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSettingsSubMenu.SuspendLayout();
            this.panelSettingsAudioWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(279, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(279, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "AudioSources";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(578, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.panelSettingsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonDropDownSettings);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 355);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelSettingsSubMenu
            // 
            this.panelSettingsSubMenu.Controls.Add(this.buttonBinds);
            this.panelSettingsSubMenu.Controls.Add(this.buttonAudio);
            this.panelSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelSettingsSubMenu.Name = "panelSettingsSubMenu";
            this.panelSettingsSubMenu.Size = new System.Drawing.Size(250, 81);
            this.panelSettingsSubMenu.TabIndex = 2;
            // 
            // buttonBinds
            // 
            this.buttonBinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonBinds.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBinds.FlatAppearance.BorderSize = 0;
            this.buttonBinds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBinds.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBinds.ForeColor = System.Drawing.Color.Silver;
            this.buttonBinds.Location = new System.Drawing.Point(0, 40);
            this.buttonBinds.Name = "buttonBinds";
            this.buttonBinds.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBinds.Size = new System.Drawing.Size(250, 40);
            this.buttonBinds.TabIndex = 1;
            this.buttonBinds.Text = "Binds";
            this.buttonBinds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBinds.UseVisualStyleBackColor = false;
            this.buttonBinds.Click += new System.EventHandler(this.buttonBinds_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAudio.FlatAppearance.BorderSize = 0;
            this.buttonAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAudio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAudio.ForeColor = System.Drawing.Color.Silver;
            this.buttonAudio.Location = new System.Drawing.Point(0, 0);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAudio.Size = new System.Drawing.Size(250, 40);
            this.buttonAudio.TabIndex = 0;
            this.buttonAudio.Text = "Audio";
            this.buttonAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAudio.UseVisualStyleBackColor = false;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonDropDownSettings
            // 
            this.buttonDropDownSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDropDownSettings.FlatAppearance.BorderSize = 0;
            this.buttonDropDownSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDropDownSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDropDownSettings.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDropDownSettings.Location = new System.Drawing.Point(0, 100);
            this.buttonDropDownSettings.Name = "buttonDropDownSettings";
            this.buttonDropDownSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDropDownSettings.Size = new System.Drawing.Size(250, 45);
            this.buttonDropDownSettings.TabIndex = 1;
            this.buttonDropDownSettings.Text = "Settings";
            this.buttonDropDownSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDropDownSettings.UseVisualStyleBackColor = true;
            this.buttonDropDownSettings.Click += new System.EventHandler(this.buttonDropDownSettings_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelSettingsAudioWindow
            // 
            this.panelSettingsAudioWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSettingsAudioWindow.Controls.Add(this.label2);
            this.panelSettingsAudioWindow.Controls.Add(this.listBox1);
            this.panelSettingsAudioWindow.Controls.Add(this.comboBox1);
            this.panelSettingsAudioWindow.Controls.Add(this.label1);
            this.panelSettingsAudioWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsAudioWindow.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsAudioWindow.Name = "panelSettingsAudioWindow";
            this.panelSettingsAudioWindow.Size = new System.Drawing.Size(792, 355);
            this.panelSettingsAudioWindow.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(487, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toggle Notification Voice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(792, 355);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelSettingsAudioWindow);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSettingsSubMenu.ResumeLayout(false);
            this.panelSettingsAudioWindow.ResumeLayout(false);
            this.panelSettingsAudioWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSettingsSubMenu;
        private System.Windows.Forms.Button buttonBinds;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonDropDownSettings;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSettingsAudioWindow;
        private System.Windows.Forms.Label label2;
    }
}

