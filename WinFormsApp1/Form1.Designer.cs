using WinFormsApp1.CustomControls;

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
            this.panelSettingsSubMenu = new WinFormsApp1.CustomControls.PanelSubMenu();
            this.buttonSubMenu_Theme = new WinFormsApp1.CustomControls.ButtonSubMenu();
            this.buttonSubMenu_Binds = new WinFormsApp1.CustomControls.ButtonSubMenu();
            this.buttonSubMenu_Audio = new WinFormsApp1.CustomControls.ButtonSubMenu();
            this.buttonMenu_Settings = new WinFormsApp1.CustomControls.ButtonMenu();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSettingsAudioWindow = new WinFormsApp1.CustomControls.PanelWindow();
            this.panelSettingsThemeWindow = new WinFormsApp1.CustomControls.PanelWindow();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSettingsSubMenu.SuspendLayout();
            this.panelSettingsAudioWindow.SuspendLayout();
            this.panelSettingsThemeWindow.SuspendLayout();
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
            this.panelSideMenu.Controls.Add(this.buttonMenu_Settings);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 335);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelSettingsSubMenu
            // 
            this.panelSettingsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSettingsSubMenu.Controls.Add(this.buttonSubMenu_Theme);
            this.panelSettingsSubMenu.Controls.Add(this.buttonSubMenu_Binds);
            this.panelSettingsSubMenu.Controls.Add(this.buttonSubMenu_Audio);
            this.panelSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelSettingsSubMenu.Name = "panelSettingsSubMenu";
            this.panelSettingsSubMenu.Size = new System.Drawing.Size(250, 122);
            this.panelSettingsSubMenu.TabIndex = 2;
            // 
            // buttonSubMenu_Theme
            // 
            this.buttonSubMenu_Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSubMenu_Theme.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubMenu_Theme.FlatAppearance.BorderSize = 0;
            this.buttonSubMenu_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubMenu_Theme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubMenu_Theme.ForeColor = System.Drawing.Color.Silver;
            this.buttonSubMenu_Theme.Location = new System.Drawing.Point(0, 80);
            this.buttonSubMenu_Theme.Name = "buttonSubMenu_Theme";
            this.buttonSubMenu_Theme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSubMenu_Theme.Size = new System.Drawing.Size(250, 40);
            this.buttonSubMenu_Theme.TabIndex = 2;
            this.buttonSubMenu_Theme.Text = "Theme";
            this.buttonSubMenu_Theme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubMenu_Theme.UseVisualStyleBackColor = false;
            this.buttonSubMenu_Theme.Click += new System.EventHandler(this.buttonSubMenu_Theme_Click);
            // 
            // buttonSubMenu_Binds
            // 
            this.buttonSubMenu_Binds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSubMenu_Binds.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubMenu_Binds.FlatAppearance.BorderSize = 0;
            this.buttonSubMenu_Binds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubMenu_Binds.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubMenu_Binds.ForeColor = System.Drawing.Color.Silver;
            this.buttonSubMenu_Binds.Location = new System.Drawing.Point(0, 40);
            this.buttonSubMenu_Binds.Name = "buttonSubMenu_Binds";
            this.buttonSubMenu_Binds.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSubMenu_Binds.Size = new System.Drawing.Size(250, 40);
            this.buttonSubMenu_Binds.TabIndex = 1;
            this.buttonSubMenu_Binds.Text = "Binds";
            this.buttonSubMenu_Binds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubMenu_Binds.UseVisualStyleBackColor = false;
            this.buttonSubMenu_Binds.Click += new System.EventHandler(this.buttonBinds_Click);
            // 
            // buttonSubMenu_Audio
            // 
            this.buttonSubMenu_Audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSubMenu_Audio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubMenu_Audio.FlatAppearance.BorderSize = 0;
            this.buttonSubMenu_Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubMenu_Audio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubMenu_Audio.ForeColor = System.Drawing.Color.Silver;
            this.buttonSubMenu_Audio.Location = new System.Drawing.Point(0, 0);
            this.buttonSubMenu_Audio.Name = "buttonSubMenu_Audio";
            this.buttonSubMenu_Audio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSubMenu_Audio.Size = new System.Drawing.Size(250, 40);
            this.buttonSubMenu_Audio.TabIndex = 0;
            this.buttonSubMenu_Audio.Text = "Audio";
            this.buttonSubMenu_Audio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubMenu_Audio.UseVisualStyleBackColor = false;
            this.buttonSubMenu_Audio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonMenu_Settings
            // 
            this.buttonMenu_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMenu_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu_Settings.FlatAppearance.BorderSize = 0;
            this.buttonMenu_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu_Settings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMenu_Settings.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonMenu_Settings.Location = new System.Drawing.Point(0, 100);
            this.buttonMenu_Settings.Name = "buttonMenu_Settings";
            this.buttonMenu_Settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMenu_Settings.Size = new System.Drawing.Size(250, 45);
            this.buttonMenu_Settings.TabIndex = 1;
            this.buttonMenu_Settings.Text = "Settings";
            this.buttonMenu_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu_Settings.UseVisualStyleBackColor = true;
            this.buttonMenu_Settings.Click += new System.EventHandler(this.buttonDropDownSettings_Click);
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
            this.panelSettingsAudioWindow.Size = new System.Drawing.Size(796, 335);
            this.panelSettingsAudioWindow.TabIndex = 4;
            // 
            // panelSettingsThemeWindow
            // 
            this.panelSettingsThemeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelSettingsThemeWindow.Controls.Add(this.comboBox2);
            this.panelSettingsThemeWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsThemeWindow.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsThemeWindow.Name = "panelSettingsThemeWindow";
            this.panelSettingsThemeWindow.Size = new System.Drawing.Size(796, 335);
            this.panelSettingsThemeWindow.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(279, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
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
            this.ClientSize = new System.Drawing.Size(796, 335);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelSettingsAudioWindow);
            this.Controls.Add(this.panelSettingsThemeWindow);
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
            this.panelSettingsThemeWindow.ResumeLayout(false);
            this.panelSettingsThemeWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        private PanelSubMenu panelSettingsSubMenu;
        private ButtonSubMenu buttonSubMenu_Binds;
        private ButtonSubMenu buttonSubMenu_Audio;
        private ButtonMenu buttonMenu_Settings;
        private System.Windows.Forms.Panel panelLogo;
        private PanelWindow panelSettingsAudioWindow;
        private System.Windows.Forms.Label label2;
        private ButtonSubMenu buttonSubMenu_Theme;
        private PanelWindow panelSettingsThemeWindow;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

