<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.gbSSH = New System.Windows.Forms.GroupBox()
        Me.cbSSH = New System.Windows.Forms.CheckBox()
        Me.gbWireless = New System.Windows.Forms.GroupBox()
        Me.combCountry = New System.Windows.Forms.ComboBox()
        Me.btnWriteSupplicant = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.lblSSID = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cbWireless = New System.Windows.Forms.CheckBox()
        Me.gbOTG = New System.Windows.Forms.GroupBox()
        Me.cbOTG = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsTargetLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsTarget = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbSSH.SuspendLayout()
        Me.gbWireless.SuspendLayout()
        Me.gbOTG.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSSH
        '
        Me.gbSSH.Controls.Add(Me.cbSSH)
        Me.gbSSH.Location = New System.Drawing.Point(12, 12)
        Me.gbSSH.Name = "gbSSH"
        Me.gbSSH.Size = New System.Drawing.Size(117, 73)
        Me.gbSSH.TabIndex = 0
        Me.gbSSH.TabStop = False
        Me.gbSSH.Text = "SSH"
        '
        'cbSSH
        '
        Me.cbSSH.AutoSize = True
        Me.cbSSH.Location = New System.Drawing.Point(17, 32)
        Me.cbSSH.Name = "cbSSH"
        Me.cbSSH.Size = New System.Drawing.Size(84, 17)
        Me.cbSSH.TabIndex = 0
        Me.cbSSH.Text = "Enable SSH"
        Me.ToolTip.SetToolTip(Me.cbSSH, "Enables SSH on first boot by writing a temporary file named ""ssh"" in the /boot pa" &
        "rtition.")
        Me.cbSSH.UseVisualStyleBackColor = True
        '
        'gbWireless
        '
        Me.gbWireless.Controls.Add(Me.btnExit)
        Me.gbWireless.Controls.Add(Me.combCountry)
        Me.gbWireless.Controls.Add(Me.btnWriteSupplicant)
        Me.gbWireless.Controls.Add(Me.lblPassword)
        Me.gbWireless.Controls.Add(Me.txtPassword)
        Me.gbWireless.Controls.Add(Me.txtSSID)
        Me.gbWireless.Controls.Add(Me.lblSSID)
        Me.gbWireless.Controls.Add(Me.lblCountry)
        Me.gbWireless.Controls.Add(Me.cbWireless)
        Me.gbWireless.Location = New System.Drawing.Point(135, 12)
        Me.gbWireless.Name = "gbWireless"
        Me.gbWireless.Size = New System.Drawing.Size(277, 152)
        Me.gbWireless.TabIndex = 2
        Me.gbWireless.TabStop = False
        Me.gbWireless.Text = "Wireless"
        '
        'combCountry
        '
        Me.combCountry.Enabled = False
        Me.combCountry.FormattingEnabled = True
        Me.combCountry.Location = New System.Drawing.Point(99, 41)
        Me.combCountry.Name = "combCountry"
        Me.combCountry.Size = New System.Drawing.Size(171, 21)
        Me.combCountry.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.combCountry, "A wireless country must be configured to use the proper radio channels.")
        '
        'btnWriteSupplicant
        '
        Me.btnWriteSupplicant.Enabled = False
        Me.btnWriteSupplicant.Location = New System.Drawing.Point(6, 122)
        Me.btnWriteSupplicant.Name = "btnWriteSupplicant"
        Me.btnWriteSupplicant.Size = New System.Drawing.Size(183, 23)
        Me.btnWriteSupplicant.TabIndex = 4
        Me.btnWriteSupplicant.Text = "Write Supplicant File"
        Me.ToolTip.SetToolTip(Me.btnWriteSupplicant, "Writes the wpa_supplicant.conf file to the SD card.")
        Me.btnWriteSupplicant.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Enabled = False
        Me.lblPassword.Location = New System.Drawing.Point(7, 99)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(99, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 20)
        Me.txtPassword.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txtPassword, "Enter the WPA-PSK password for your wireless network.")
        '
        'txtSSID
        '
        Me.txtSSID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSSID.Enabled = False
        Me.txtSSID.Location = New System.Drawing.Point(99, 69)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(172, 20)
        Me.txtSSID.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.txtSSID, "Enter your wireless network name.  This is case-sensitive.")
        '
        'lblSSID
        '
        Me.lblSSID.AutoSize = True
        Me.lblSSID.Enabled = False
        Me.lblSSID.Location = New System.Drawing.Point(7, 72)
        Me.lblSSID.Name = "lblSSID"
        Me.lblSSID.Size = New System.Drawing.Size(32, 13)
        Me.lblSSID.TabIndex = 3
        Me.lblSSID.Text = "SSID"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Enabled = False
        Me.lblCountry.Location = New System.Drawing.Point(7, 44)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(86, 13)
        Me.lblCountry.TabIndex = 2
        Me.lblCountry.Text = "Wireless Country"
        '
        'cbWireless
        '
        Me.cbWireless.AutoSize = True
        Me.cbWireless.Location = New System.Drawing.Point(7, 20)
        Me.cbWireless.Name = "cbWireless"
        Me.cbWireless.Size = New System.Drawing.Size(114, 17)
        Me.cbWireless.TabIndex = 0
        Me.cbWireless.Text = "Configure Wireless"
        Me.ToolTip.SetToolTip(Me.cbWireless, "Enable wireless networking configuration.")
        Me.cbWireless.UseVisualStyleBackColor = True
        '
        'gbOTG
        '
        Me.gbOTG.Controls.Add(Me.cbOTG)
        Me.gbOTG.Location = New System.Drawing.Point(12, 91)
        Me.gbOTG.Name = "gbOTG"
        Me.gbOTG.Size = New System.Drawing.Size(117, 73)
        Me.gbOTG.TabIndex = 1
        Me.gbOTG.TabStop = False
        Me.gbOTG.Text = "On The Go"
        '
        'cbOTG
        '
        Me.cbOTG.AutoSize = True
        Me.cbOTG.Location = New System.Drawing.Point(17, 32)
        Me.cbOTG.Name = "cbOTG"
        Me.cbOTG.Size = New System.Drawing.Size(85, 17)
        Me.cbOTG.TabIndex = 0
        Me.cbOTG.Text = "Enable OTG"
        Me.ToolTip.SetToolTip(Me.cbOTG, "Enables On The Go (OTG) functionality for Raspberry Pi Zero and Zero W cards by l" &
        "oading dtoverlay dwc2 on boot.")
        Me.cbOTG.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(195, 122)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTargetLabel, Me.tsTarget})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 169)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(418, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tsTargetLabel
        '
        Me.tsTargetLabel.Name = "tsTargetLabel"
        Me.tsTargetLabel.Size = New System.Drawing.Size(73, 17)
        Me.tsTargetLabel.Text = "Target Drive:"
        '
        'tsTarget
        '
        Me.tsTarget.Name = "tsTarget"
        Me.tsTarget.Size = New System.Drawing.Size(40, 17)
        Me.tsTarget.Text = "Target"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(418, 191)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.gbOTG)
        Me.Controls.Add(Me.gbWireless)
        Me.Controls.Add(Me.gbSSH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Headless Pi"
        Me.gbSSH.ResumeLayout(False)
        Me.gbSSH.PerformLayout()
        Me.gbWireless.ResumeLayout(False)
        Me.gbWireless.PerformLayout()
        Me.gbOTG.ResumeLayout(False)
        Me.gbOTG.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbSSH As GroupBox
    Friend WithEvents gbWireless As GroupBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents cbWireless As CheckBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents lblSSID As Label
    Friend WithEvents cbSSH As CheckBox
    Friend WithEvents btnWriteSupplicant As Button
    Friend WithEvents gbOTG As GroupBox
    Friend WithEvents cbOTG As CheckBox
    Friend WithEvents combCountry As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents tsTargetLabel As ToolStripStatusLabel
    Friend WithEvents tsTarget As ToolStripStatusLabel
End Class
