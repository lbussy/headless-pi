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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.gbSSH = New System.Windows.Forms.GroupBox()
        Me.cbSSH = New System.Windows.Forms.CheckBox()
        Me.gbWireless = New System.Windows.Forms.GroupBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWriteSupplicant = New System.Windows.Forms.Button()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.combKey = New System.Windows.Forms.ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.lblSSID = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.combCountry = New System.Windows.Forms.ComboBox()
        Me.cbWireless = New System.Windows.Forms.CheckBox()
        Me.gbSSH.SuspendLayout()
        Me.gbWireless.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSSH
        '
        Me.gbSSH.Controls.Add(Me.cbSSH)
        Me.gbSSH.Location = New System.Drawing.Point(12, 12)
        Me.gbSSH.Name = "gbSSH"
        Me.gbSSH.Size = New System.Drawing.Size(117, 49)
        Me.gbSSH.TabIndex = 0
        Me.gbSSH.TabStop = False
        Me.gbSSH.Text = "SSH"
        '
        'cbSSH
        '
        Me.cbSSH.AutoSize = True
        Me.cbSSH.Location = New System.Drawing.Point(7, 20)
        Me.cbSSH.Name = "cbSSH"
        Me.cbSSH.Size = New System.Drawing.Size(84, 17)
        Me.cbSSH.TabIndex = 0
        Me.cbSSH.Text = "Enable SSH"
        Me.cbSSH.UseVisualStyleBackColor = True
        '
        'gbWireless
        '
        Me.gbWireless.Controls.Add(Me.lblTarget)
        Me.gbWireless.Controls.Add(Me.Label1)
        Me.gbWireless.Controls.Add(Me.btnWriteSupplicant)
        Me.gbWireless.Controls.Add(Me.lblKey)
        Me.gbWireless.Controls.Add(Me.combKey)
        Me.gbWireless.Controls.Add(Me.lblPassword)
        Me.gbWireless.Controls.Add(Me.txtPassword)
        Me.gbWireless.Controls.Add(Me.txtSSID)
        Me.gbWireless.Controls.Add(Me.lblSSID)
        Me.gbWireless.Controls.Add(Me.lblCountry)
        Me.gbWireless.Controls.Add(Me.combCountry)
        Me.gbWireless.Controls.Add(Me.cbWireless)
        Me.gbWireless.Location = New System.Drawing.Point(135, 12)
        Me.gbWireless.Name = "gbWireless"
        Me.gbWireless.Size = New System.Drawing.Size(277, 195)
        Me.gbWireless.TabIndex = 1
        Me.gbWireless.TabStop = False
        Me.gbWireless.Text = "Wireless"
        '
        'lblTarget
        '
        Me.lblTarget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(96, 150)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(38, 13)
        Me.lblTarget.TabIndex = 10
        Me.lblTarget.Text = "Target"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Target Device"
        '
        'btnWriteSupplicant
        '
        Me.btnWriteSupplicant.Enabled = False
        Me.btnWriteSupplicant.Location = New System.Drawing.Point(6, 166)
        Me.btnWriteSupplicant.Name = "btnWriteSupplicant"
        Me.btnWriteSupplicant.Size = New System.Drawing.Size(264, 23)
        Me.btnWriteSupplicant.TabIndex = 11
        Me.btnWriteSupplicant.Text = "Write Supplicant File"
        Me.btnWriteSupplicant.UseVisualStyleBackColor = True
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Enabled = False
        Me.lblKey.Location = New System.Drawing.Point(7, 125)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(90, 13)
        Me.lblKey.TabIndex = 9
        Me.lblKey.Text = "Key Management"
        '
        'combKey
        '
        Me.combKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.combKey.Enabled = False
        Me.combKey.FormattingEnabled = True
        Me.combKey.Items.AddRange(New Object() {"WPA-PSK"})
        Me.combKey.Location = New System.Drawing.Point(99, 122)
        Me.combKey.Name = "combKey"
        Me.combKey.Size = New System.Drawing.Size(172, 21)
        Me.combKey.TabIndex = 8
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
        Me.txtPassword.TabIndex = 5
        '
        'txtSSID
        '
        Me.txtSSID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSSID.Enabled = False
        Me.txtSSID.Location = New System.Drawing.Point(99, 69)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(172, 20)
        Me.txtSSID.TabIndex = 4
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
        Me.lblCountry.Size = New System.Drawing.Size(71, 13)
        Me.lblCountry.TabIndex = 2
        Me.lblCountry.Text = "Country Code"
        '
        'combCountry
        '
        Me.combCountry.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.combCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combCountry.Enabled = False
        Me.combCountry.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combCountry.FormattingEnabled = True
        Me.combCountry.Location = New System.Drawing.Point(99, 41)
        Me.combCountry.Name = "combCountry"
        Me.combCountry.Size = New System.Drawing.Size(172, 19)
        Me.combCountry.TabIndex = 1
        '
        'cbWireless
        '
        Me.cbWireless.AutoSize = True
        Me.cbWireless.Location = New System.Drawing.Point(7, 20)
        Me.cbWireless.Name = "cbWireless"
        Me.cbWireless.Size = New System.Drawing.Size(114, 17)
        Me.cbWireless.TabIndex = 0
        Me.cbWireless.Text = "Configure Wireless"
        Me.cbWireless.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(418, 212)
        Me.Controls.Add(Me.gbWireless)
        Me.Controls.Add(Me.gbSSH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Headless Pi"
        Me.gbSSH.ResumeLayout(False)
        Me.gbSSH.PerformLayout()
        Me.gbWireless.ResumeLayout(False)
        Me.gbWireless.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSSH As GroupBox
    Friend WithEvents gbWireless As GroupBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents combCountry As ComboBox
    Friend WithEvents cbWireless As CheckBox
    Friend WithEvents lblKey As Label
    Friend WithEvents combKey As ComboBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents lblSSID As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents cbSSH As CheckBox
    Friend WithEvents btnWriteSupplicant As Button
    Friend WithEvents Label1 As Label
End Class
