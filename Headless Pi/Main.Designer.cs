namespace Headless_Pi
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gbSSH = new System.Windows.Forms.GroupBox();
            this.cbSSH = new System.Windows.Forms.CheckBox();
            this.gbOTG = new System.Windows.Forms.GroupBox();
            this.cbOTG = new System.Windows.Forms.CheckBox();
            this.gbWireless = new System.Windows.Forms.GroupBox();
            this.lbNetworks = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.combCountry = new System.Windows.Forms.ComboBox();
            this.btnWriteSupplicant = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSSID = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbWireless = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDrive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtSupplicant = new System.Windows.Forms.TextBox();
            this.lblKnownNetworks = new System.Windows.Forms.Label();
            this.gbSSH.SuspendLayout();
            this.gbOTG.SuspendLayout();
            this.gbWireless.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSSH
            // 
            this.gbSSH.Controls.Add(this.cbSSH);
            this.gbSSH.Location = new System.Drawing.Point(12, 12);
            this.gbSSH.Name = "gbSSH";
            this.gbSSH.Size = new System.Drawing.Size(117, 73);
            this.gbSSH.TabIndex = 0;
            this.gbSSH.TabStop = false;
            this.gbSSH.Text = "SSH";
            // 
            // cbSSH
            // 
            this.cbSSH.AutoSize = true;
            this.cbSSH.Location = new System.Drawing.Point(17, 32);
            this.cbSSH.Name = "cbSSH";
            this.cbSSH.Size = new System.Drawing.Size(84, 17);
            this.cbSSH.TabIndex = 0;
            this.cbSSH.Text = "Enable SSH";
            this.toolTip.SetToolTip(this.cbSSH, "Enables SSH on first boot by writing a temporary file named \"\"ssh\"\" in the /boot " +
        "patition.");
            this.cbSSH.UseVisualStyleBackColor = true;
            this.cbSSH.CheckedChanged += new System.EventHandler(this.cbSSH_CheckedChanged);
            // 
            // gbOTG
            // 
            this.gbOTG.Controls.Add(this.cbOTG);
            this.gbOTG.Location = new System.Drawing.Point(12, 91);
            this.gbOTG.Name = "gbOTG";
            this.gbOTG.Size = new System.Drawing.Size(117, 73);
            this.gbOTG.TabIndex = 1;
            this.gbOTG.TabStop = false;
            this.gbOTG.Text = "On The Go";
            // 
            // cbOTG
            // 
            this.cbOTG.AutoSize = true;
            this.cbOTG.Location = new System.Drawing.Point(17, 32);
            this.cbOTG.Name = "cbOTG";
            this.cbOTG.Size = new System.Drawing.Size(85, 17);
            this.cbOTG.TabIndex = 0;
            this.cbOTG.Text = "Enable OTG";
            this.toolTip.SetToolTip(this.cbOTG, "Enables On The Go (OTG) functionality for Raspberry Pi Zero and Zero W cards by l" +
        "oading dtoverlay dwc2 on boot.");
            this.cbOTG.UseVisualStyleBackColor = true;
            this.cbOTG.CheckedChanged += new System.EventHandler(this.cbOTG_CheckedChanged);
            // 
            // gbWireless
            // 
            this.gbWireless.Controls.Add(this.lblKnownNetworks);
            this.gbWireless.Controls.Add(this.lbNetworks);
            this.gbWireless.Controls.Add(this.txtPassword);
            this.gbWireless.Controls.Add(this.txtSSID);
            this.gbWireless.Controls.Add(this.combCountry);
            this.gbWireless.Controls.Add(this.btnWriteSupplicant);
            this.gbWireless.Controls.Add(this.btnExit);
            this.gbWireless.Controls.Add(this.lblPassword);
            this.gbWireless.Controls.Add(this.lblSSID);
            this.gbWireless.Controls.Add(this.lblCountry);
            this.gbWireless.Controls.Add(this.cbWireless);
            this.gbWireless.Location = new System.Drawing.Point(135, 12);
            this.gbWireless.Name = "gbWireless";
            this.gbWireless.Size = new System.Drawing.Size(404, 152);
            this.gbWireless.TabIndex = 2;
            this.gbWireless.TabStop = false;
            this.gbWireless.Text = "Wireless";
            // 
            // ListBoxNetworks
            // 
            this.lbNetworks.FormattingEnabled = true;
            this.lbNetworks.Location = new System.Drawing.Point(276, 34);
            this.lbNetworks.Name = "ListBoxNetworks";
            this.lbNetworks.ScrollAlwaysVisible = true;
            this.lbNetworks.Size = new System.Drawing.Size(120, 82);
            this.lbNetworks.TabIndex = 9;
            this.toolTip.SetToolTip(this.lbNetworks, "Select from this computer\'s currently configured networks to use saved informaito" +
        "n.");
            this.lbNetworks.SelectedIndexChanged += new System.EventHandler(this.lbNetworks_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtPassword, "Enter the WPA-PSK password for your wireless network.");
            this.txtPassword.TextChanged += new System.EventHandler(this.Build_Supplicant);
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(99, 69);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(172, 20);
            this.txtSSID.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtSSID, "Enter your wireless network name.  This is case-sensitive.");
            this.txtSSID.TextChanged += new System.EventHandler(this.Build_Supplicant);
            // 
            // combCountry
            // 
            this.combCountry.FormattingEnabled = true;
            this.combCountry.Location = new System.Drawing.Point(99, 41);
            this.combCountry.Name = "combCountry";
            this.combCountry.Size = new System.Drawing.Size(171, 21);
            this.combCountry.TabIndex = 6;
            this.toolTip.SetToolTip(this.combCountry, "A wireless country must be configured in order to use the proper radio channels.");
            this.combCountry.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.combCountry_DrawItem);
            this.combCountry.SelectedIndexChanged += new System.EventHandler(this.Build_Supplicant);
            // 
            // btnWriteSupplicant
            // 
            this.btnWriteSupplicant.Location = new System.Drawing.Point(6, 122);
            this.btnWriteSupplicant.Name = "btnWriteSupplicant";
            this.btnWriteSupplicant.Size = new System.Drawing.Size(170, 23);
            this.btnWriteSupplicant.TabIndex = 5;
            this.btnWriteSupplicant.Text = "Write Supplicant File";
            this.toolTip.SetToolTip(this.btnWriteSupplicant, "Writes the wpa_supplicant.conf file to the SD card.");
            this.btnWriteSupplicant.UseVisualStyleBackColor = true;
            this.btnWriteSupplicant.Click += new System.EventHandler(this.btnWriteSupplicant_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Eject and Exit";
            this.toolTip.SetToolTip(this.btnExit, "Eject SD card and exit.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblSSID
            // 
            this.lblSSID.AutoSize = true;
            this.lblSSID.Location = new System.Drawing.Point(7, 72);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(32, 13);
            this.lblSSID.TabIndex = 2;
            this.lblSSID.Text = "SSID";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(7, 44);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Wireless Country";
            // 
            // cbWireless
            // 
            this.cbWireless.AutoSize = true;
            this.cbWireless.Location = new System.Drawing.Point(7, 20);
            this.cbWireless.Name = "cbWireless";
            this.cbWireless.Size = new System.Drawing.Size(114, 17);
            this.cbWireless.TabIndex = 0;
            this.cbWireless.Text = "Configure Wireless";
            this.toolTip.SetToolTip(this.cbWireless, "Enable wireless networking configuration.");
            this.cbWireless.UseVisualStyleBackColor = true;
            this.cbWireless.CheckedChanged += new System.EventHandler(this.cbWireless_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelDrive,
            this.toolStripStatusLabelName,
            this.toolStripStatusLabelType});
            this.statusStrip.Location = new System.Drawing.Point(0, 176);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(550, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel.Text = "Target Drive:";
            // 
            // toolStripStatusLabelDrive
            // 
            this.toolStripStatusLabelDrive.Name = "toolStripStatusLabelDrive";
            this.toolStripStatusLabelDrive.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabelDrive.Text = "X:\\";
            // 
            // toolStripStatusLabelName
            // 
            this.toolStripStatusLabelName.Name = "toolStripStatusLabelName";
            this.toolStripStatusLabelName.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelName.Text = "Name";
            // 
            // toolStripStatusLabelType
            // 
            this.toolStripStatusLabelType.Name = "toolStripStatusLabelType";
            this.toolStripStatusLabelType.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabelType.Text = "Type";
            // 
            // txtSupplicant
            // 
            this.txtSupplicant.Location = new System.Drawing.Point(12, 202);
            this.txtSupplicant.Multiline = true;
            this.txtSupplicant.Name = "txtSupplicant";
            this.txtSupplicant.Size = new System.Drawing.Size(117, 20);
            this.txtSupplicant.TabIndex = 4;
            this.txtSupplicant.TabStop = false;
            this.txtSupplicant.Text = "I\'m hidden for a reason";
            this.txtSupplicant.Visible = false;
            this.txtSupplicant.WordWrap = false;
            // 
            // lblKnownNetworks
            // 
            this.lblKnownNetworks.AutoSize = true;
            this.lblKnownNetworks.Location = new System.Drawing.Point(273, 16);
            this.lblKnownNetworks.Name = "lblKnownNetworks";
            this.lblKnownNetworks.Size = new System.Drawing.Size(91, 13);
            this.lblKnownNetworks.TabIndex = 10;
            this.lblKnownNetworks.Text = "Known Networks:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 198);
            this.Controls.Add(this.txtSupplicant);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbWireless);
            this.Controls.Add(this.gbOTG);
            this.Controls.Add(this.gbSSH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Headless Pi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbSSH.ResumeLayout(false);
            this.gbSSH.PerformLayout();
            this.gbOTG.ResumeLayout(false);
            this.gbOTG.PerformLayout();
            this.gbWireless.ResumeLayout(false);
            this.gbWireless.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSSH;
        private System.Windows.Forms.CheckBox cbSSH;
        private System.Windows.Forms.GroupBox gbOTG;
        private System.Windows.Forms.CheckBox cbOTG;
        private System.Windows.Forms.GroupBox gbWireless;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.ComboBox combCountry;
        private System.Windows.Forms.Button btnWriteSupplicant;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.CheckBox cbWireless;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDrive;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelType;
        private System.Windows.Forms.TextBox txtSupplicant;
        private System.Windows.Forms.ListBox lbNetworks;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblKnownNetworks;
    }
}

