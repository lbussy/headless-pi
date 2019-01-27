' Copyright (C) 2019  Lee C. Bussy (@LBussy)
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <https://www.gnu.org/licenses/>.

Imports System.IO
Imports System.Text

Public Class Main
    ' Hold path to SD Card
    Dim sdcard As String = ""
    ' Hold supplicant configuration
    Dim supplicant As String = ""
    ' Country codes and text for wireless configuration
    Dim countryCode() As String = {"AD", "AE", "AF", "AG", "AI", "AL", "AM", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BL", "BM", "BN", "BO", "BQ", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GB", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JE", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "ME", "MF", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RS", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SS", "ST", "SV", "SX", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "ZA", "ZM", "ZW"}
    Dim countryText() As String = {"Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Åland Islands", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Saint Barthélemy", "Bermuda", "Brunei Darussalam", "Bolivia (Plurinational State of)", "Bonaire, Sint Eustatius and Saba", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Côte d'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cabo Verde", "Curaçao", "Christmas Island", "Cyprus", "Czechia", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia (Federated States of)", "Faroe Islands", "France", "Gabon", "United Kingdom of Great Britain and Northern Ireland", "Grenada", "Georgia", "French Guiana", "Guernsey", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "Isle of Man", "India", "British Indian Ocean Territory", "Iraq", "Iran (Islamic Republic of)", "Iceland", "Italy", "Jersey", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea (Democratic People's Republic of)", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Montenegro", "Saint Martin (French part)", "Madagascar", "Marshall Islands", "Macedonia, the former Yugoslav Republic of", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn", "Puerto Rico", "Palestine, State of", "Portugal", "Palau", "Paraguay", "Qatar", "Réunion", "Romania", "Serbia", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena, Ascension and Tristan da Cunha", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "South Sudan", "Sao Tome and Principe", "El Salvador", "Sint Maarten (Dutch part)", "Syrian Arab Republic", "Eswatini", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Timor-Leste", "Turkmenistan", "Tunisia", "Tonga", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan, Province of China", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States of America", "Uruguay", "Uzbekistan", "Holy See", "Saint Vincent and the Grenadines", "Venezuela (Bolivarian Republic of)", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Viet Nam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "South Africa", "Zambia", "Zimbabwe"}

    ''' <summary>
    ''' Main Function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Drive()        ' Find SD Card
        Load_Country()      ' Populate country code dropdown
        Load_SSH()          ' Load status of SSH config from card
        Load_Overlay()      ' Load status of OTG config from card
        Load_Supplicant()   ' Load wpa_supplicant.conf config from card
    End Sub

    ''' <summary>
    ''' Gets SD card information from inserted USB devices.
    ''' Updates global 'sdcard' with drive path.
    ''' </summary>
    Private Sub Load_Drive()
        Dim i As Integer = 0
        Dim c As Integer = 0
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim itemText As String = drive.Name
            Dim Type As String = ""
            Dim ltr As String = drive.Name
            If drive.IsReady AndAlso drive.VolumeLabel <> "" Then
                itemText = drive.VolumeLabel
            Else
                Select Case drive.DriveType
                    Case IO.DriveType.Fixed : itemText = "Local Disk"
                    Case IO.DriveType.CDRom : itemText = "CD-ROM"
                    Case IO.DriveType.Network : itemText = "Network Drive"
                    Case IO.DriveType.Removable : itemText = "Removable Disk"
                    Case IO.DriveType.Unknown : itemText = "Unknown"
                End Select
            End If
            Select Case drive.DriveType
                Case IO.DriveType.Fixed : Type = "Local Disk"
                Case IO.DriveType.CDRom : Type = "CD-ROM"
                Case IO.DriveType.Network : Type = "Network Drive"
                Case IO.DriveType.Removable : Type = "Removable Disk"
                Case IO.DriveType.Unknown : Type = "Unknown"
            End Select
            i += 1
            If itemText = "boot" AndAlso drive.DriveType = IO.DriveType.Removable Then
                If c = 0 Then tsTarget.Text = ""
                sdcard = ltr
                tsTarget.Text = sdcard + " (" + itemText + ") - " + Type
                c += 1
            End If
        Next
        If c > 1 Then
            Dim msg As String = "More than one removable drive has been detected. Please remove all but the Raspberry Pi SD card and re-run the application."
            Dim title As String = "Headless Pi: Multiple Drives Detected"
            Dim style = MsgBoxStyle.Critical
            MsgBox(msg, style, title)
            Application.Exit()
        ElseIf c = 0 Then
            Dim msg As String = "No Raspberry Pi SD cards have been detected. Please insert the proper SD card and re-run the application."
            Dim title As String = "Headless Pi: No Drives Detected"
            Dim style = MsgBoxStyle.Critical
            MsgBox(msg, style, title)
            Application.Exit()
        End If
    End Sub

    ''' <summary>
    ''' Populate combCountry with global country code/text array.
    ''' </summary>
    Private Sub Load_Country()
        Dim dtCountryCodes As DataTable = New DataTable()
        dtCountryCodes.Columns.Add("Code", GetType(String))
        dtCountryCodes.Columns.Add("Country", GetType(String))

        Dim index As Integer
        For index = countryCode.GetLowerBound(0) To countryCode.GetUpperBound(0)
            dtCountryCodes.Rows.Add(countryCode(index), countryText(index))
        Next

        ' Bind the ComboBox to the DataTable
        combCountry.DataSource = dtCountryCodes
        combCountry.ValueMember = "Code"
        combCountry.DisplayMember = "Country"

        ' Enable the owner draw on the ComboBox.
        combCountry.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.

        ' Set behavior of combo box
        combCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combCountry.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    ''' <summary>
    ''' Load status of SSH configuration from card.
    ''' Checks or unchecks cbSSH.
    ''' </summary>
    Private Sub Load_SSH()
        ' Check to see if ssh. file exists, set checkbox appropriately
        Dim sshFile As String = sdcard + "ssh"
        If System.IO.File.Exists(sshFile) Then
            cbSSH.Checked = True
        Else
            cbSSH.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Load status of OTG configuration from card.
    ''' Checks or unchecks cbOTG.
    ''' </summary>
    Private Sub Load_Overlay()
        ' Check to see if entries in config.txt and cmdline.txt supporting OTG exist
        ' Set checkbox appropriately
        Dim configFile As String = sdcard + "config.txt"
        Dim cmdFile As String = sdcard + "cmdline.txt"
        Dim configExist As Boolean = False
        Dim cmdExist As Boolean = False
        Dim objReader As StreamReader

        ' Check if config.txt file, then the dtoverlay statement exists
        Try
            objReader = New StreamReader(configFile)
            Do While objReader.Peek() <> -1
                If objReader.ReadLine() = "dtoverlay=dwc2" Then
                    configExist = True
                End If
            Loop
            objReader.Close()
        Catch ex As Exception
            ' File config.txt does not exist
            configExist = False
            Dim msg As String = "No config.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is not a fatal condition, however some functionality may not be enabled on your Raspberry Pi when it boots. A file will be created as needed."
            Dim title As String = "Headless Pi: No Config File"
            Dim style = MsgBoxStyle.Exclamation
            MsgBox(msg, style, title)
            ' Create a blank file
            Dim fs As FileStream = File.Create(configFile)
            fs.Close()
        End Try

        ' Check if cmdline.txt file, then the dtoverlay statement exists
        Try
            objReader = New StreamReader(cmdFile)
            Do While objReader.Peek() <> -1
                If objReader.ReadLine.Contains("modules-load=dwc2,g_ether") Then
                    cmdExist = True
                End If
            Loop
            objReader.Close()
        Catch ex As Exception
            ' File cmdline.txt does not exist
            cmdExist = False
            Dim msg As String = "No cmdline.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is probaby a fatal condition, unable to proceed."
            Dim title As String = "Headless Pi: No Command Line File"
            Dim style = MsgBoxStyle.Critical
            MsgBox(msg, style, title)
            Application.Exit()
        End Try

        If configExist = True And cmdExist = True Then
            cbOTG.Checked = True
        Else
            cbOTG.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Load wpa_supplicant configuration from card if it exists.
    ''' Populates combCountry, txtSSID, txtPassword.
    ''' </summary>
    Private Sub Load_Supplicant()
        Dim wpaPath As String = sdcard + "wpa_supplicant.conf"
        Dim strLine As String = ""
        Dim strDelimStart As String = ""
        Dim intIndexStart As Integer = -1
        Dim intIndexEnd As Integer = -1
        Dim objReader As StreamReader

        Try
            objReader = New StreamReader(wpaPath)
            cbWireless.Checked = True
            Do While objReader.Peek() <> -1
                strLine = objReader.ReadLine()

                ' Parse out country code
                If strLine.Contains("country=") Then
                    strDelimStart = "country="
                    intIndexStart = strLine.IndexOf(strDelimStart)
                    intIndexEnd = strLine.Length
                    If intIndexStart > -1 AndAlso intIndexEnd > -1 Then
                        strLine = Strings.Mid(strLine, intIndexStart + strDelimStart.Length + 1, intIndexEnd - intIndexStart - strDelimStart.Length)
                        Dim index As Integer
                        For index = 0 To countryCode.GetUpperBound(0)
                            If countryCode(index) = strLine Then
                                ' Select the configured country in combCountry from supplicant file
                                combCountry.SelectedValue = strLine
                            End If
                        Next
                    End If

                    ' Parse out SSID
                ElseIf strLine.Contains("ssid=") Then
                    strDelimStart = "ssid=" + Chr(34)
                    intIndexStart = strLine.IndexOf(strDelimStart)
                    intIndexEnd = strLine.Length - 1 ' Strip off the trailing quote
                    If intIndexStart > -1 AndAlso intIndexEnd > -1 Then
                        ' Populate txtSSID with the SSID from supplicant file
                        txtSSID.Text = Strings.Mid(strLine, intIndexStart + strDelimStart.Length + 1, intIndexEnd - intIndexStart - strDelimStart.Length)
                    End If

                    ' Parse out password
                ElseIf strLine.Contains("psk=") Then
                    strDelimStart = "psk=" + Chr(34)
                    intIndexStart = strLine.IndexOf(strDelimStart)
                    intIndexEnd = strLine.Length - 1 ' Strip off the trailing quote
                    If intIndexStart > -1 AndAlso intIndexEnd > -1 Then
                        ' Populate txtPassword with PSK from supplicant file
                        txtPassword.Text = Strings.Mid(strLine, intIndexStart + strDelimStart.Length + 1, intIndexEnd - intIndexStart - strDelimStart.Length)
                    End If
                End If
            Loop
            objReader.Close()
            Build_Supplicant()
        Catch
            ' Supplicant file does not exist
        End Try
    End Sub

    ''' <summary>
    ''' Build supplicant file as we go along.
    ''' Updates Global supplicant.
    ''' </summary>
    Private Sub Build_Supplicant()
        supplicant = "country=" + combCountry.SelectedValue.ToString + vbLf
        supplicant += "ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev" + vbLf
        supplicant += "update_config=1" + vbLf + vbLf
        supplicant += "network={" + vbLf
        supplicant += "    ssid=" + Chr(34) + txtSSID.Text + Chr(34) + vbLf
        supplicant += "    scan_ssid=1" + vbLf
        supplicant += "    psk=" + Chr(34) + txtPassword.Text + Chr(34) + vbLf
        supplicant += "    key_mgmt=WPA-PSK" + vbLf
        supplicant += "}" + vbLf
        Check_Supplicant()
    End Sub

    ''' <summary>
    ''' Check if we have all items needed for supplicant configuration.
    ''' Enables or disables btnWriteSupplicant.
    ''' </summary>
    Private Sub Check_Supplicant()
        Dim goodEntry As Boolean = True

        If combCountry.Text = "" Then goodEntry = False
        If txtSSID.Text = "" Then goodEntry = False
        If txtPassword.Text = "" Then goodEntry = False

        If goodEntry = True Then
            btnWriteSupplicant.Enabled = True
        Else
            btnWriteSupplicant.Enabled = False
        End If
    End Sub

    ' Event Handlers

    ''' <summary>
    ''' Draw the combCountry box with two columns.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub combCountry_DrawItem(sender As Object, e As DrawItemEventArgs) Handles combCountry.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(combCountry.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim countryCode As String = drv("Code").ToString()
        Dim countryText As String = drv("Country").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = CInt(r1.Width * 0.15)

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(countryCode, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.DarkGray)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = CInt(e.Bounds.Width * 0.15)
        r2.Width = CInt(r2.Width * 0.85)

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(countryText, e.Font, sb, r2)
        End Using
    End Sub

    ''' <summary>
    ''' If cbSSH changes, create or remove ssh. file on card.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbSSH_CheckedChanged(sender As Object, e As EventArgs) Handles cbSSH.CheckedChanged
        ' If OTG is checked and SSH is not turned on, offer to enable SSH
        If cbOTG.Checked = True And cbSSH.Checked = False Then
            Dim msg As String = "OTG is enabled but you have chosen to disable SSH. Generally, communication with the guest is done over SSH.  Would you like to re-enable SSH?"
            Dim title As String = "Headless Pi: SSH Not Confgured"
            Dim style = MsgBoxStyle.YesNo
            If MsgBox(msg, style, title) = MsgBoxResult.Yes Then
                cbSSH.Checked = True
            End If
        End If

        Dim path As String = sdcard + "ssh"
        If cbSSH.Checked = True Then
            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)
            fs.Close()
        Else
            ' Delete the file
            File.Delete(path)
        End If
    End Sub

    ''' <summary>
    ''' If cbOTG changes, update or remove OTG configuration on card.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbOTG_CheckedChanged(sender As Object, e As EventArgs) Handles cbOTG.CheckedChanged
        ' Find the state of the files first, then apply or remove configuration
        ' as appropriate
        Dim configFile As String = sdcard + "config.txt"
        Dim cmdFile As String = sdcard + "cmdline.txt"
        Dim configExist As Boolean = False
        Dim cmdExist As Boolean = False
        Dim objReader As StreamReader
        Dim objWriter As StreamWriter

        ' If both OTG and wireless are configured, warn about weirdness
        If cbWireless.Checked = True And cbOTG.Checked = True Then
            Dim msg As String = "Both OTG and wireless are turned on, this is not typical as OTG generally uses the host computer networking."
            Dim title As String = "Headless Pi: OTG and Wireless Configured"
            Dim style = MsgBoxStyle.Exclamation
            MsgBox(msg, style, title)
        End If

        ' If OTG is checked and SSH is not turned on, offer to enable SSH
        If cbOTG.Checked = True And cbSSH.Checked = False Then
            Dim msg As String = "You have enabled OTG but have not enabled SSH. Generally, communication with the guest is done over SSH.  Would you like to enable SSH?"
            Dim title As String = "Headless Pi: SSH Not Confgured"
            Dim style = MsgBoxStyle.YesNo
            If MsgBox(msg, style, title) = MsgBoxResult.Yes Then
                cbSSH.Checked = True
            End If
        End If

        ' Check if config.txt file, then the dtoverlay statement exists
        Try
            objReader = New StreamReader(configFile)
            Do While objReader.Peek() <> -1
                If objReader.ReadLine() = "dtoverlay=dwc2" Then
                    configExist = True
                End If
            Loop
            objReader.Close()
        Catch ex As Exception
            ' File config.txt does not exist
            configExist = False
            Dim msg As String = "No config.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is not a fatal condition, however some functionality may not be enabled on your Raspberry Pi when it boots. A file will be created as needed."
            Dim title As String = "Headless Pi: No Config File"
            Dim style = MsgBoxStyle.Exclamation
            MsgBox(msg, style, title)
            ' Create a blank file
            Dim fs As FileStream = File.Create(configFile)
            fs.Close()
        End Try

        ' Check if cmdline.txt file, then the dtoverlay statement exists
        Try
            objReader = New StreamReader(cmdFile)
            Do While objReader.Peek() <> -1
                If objReader.ReadLine.Contains("modules-load=dwc2,g_ether") Then
                    cmdExist = True
                End If
            Loop
            objReader.Close()
        Catch ex As Exception
            ' File cmdline.txt does not exist
            cmdExist = False
            Dim msg As String = "No cmdline.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is probaby a fatal condition, unable to proceed."
            Dim title As String = "Headless Pi: No Command Line File"
            Dim style = MsgBoxStyle.Critical
            MsgBox(msg, style, title)
            Application.Exit()
        End Try

        If cbOTG.Checked = True Then
            ' Make sure configurations get set appropriately
            '
            ' Handle configuration file
            If configExist = False Then
                Dim configText As String = vbLf
                configText += "# Selects the dwc2 USB controller driver (OTG functionality)" + vbLf
                configText += "dtoverlay=dwc2"
                ' Write config text to end of file
                objWriter = New StreamWriter(configFile, True)
                objWriter.WriteLine(configText)
                objWriter.Close()
            End If
            ' Handle the command line parameters
            If cmdExist = False Then
                Dim textReader As New StreamReader(cmdFile)
                Dim cmdText As String = textReader.ReadToEnd
                textReader.Close()
                Dim cmdAdded As String = "modules-load=dwc2,g_ether "
                cmdText = cmdText.Replace("rootwait ", "rootwait " + cmdAdded)
                ' Write new cmdText over existing file
                objWriter = New StreamWriter(cmdFile, False)
                objWriter.Write(cmdText)
                objWriter.Close()
            End If
        Else
            ' Make sure configurations get un-set
            '
            ' Handle configuration file
            If configExist = True Then
                Dim textReader As New StreamReader(configFile)
                Dim configText As String = textReader.ReadToEnd
                textReader.Close()
                Dim configRemove As String = vbLf
                configRemove += "# Selects the dwc2 USB controller driver (OTG functionality)" + vbLf
                configRemove += "dtoverlay=dwc2"
                configText = configText.Remove(configText.IndexOf(configRemove), configRemove.Length + 2)
                ' Write new config over existing file
                objWriter = New StreamWriter(configFile, False)
                objWriter.Write(configText)
                objWriter.Close()
            End If
            ' Handle the command line parameters
            If cmdExist = True Then
                Dim textReader As New StreamReader(cmdFile)
                Dim cmdText As String = textReader.ReadToEnd
                textReader.Close()
                Dim cmdRemoved As String = "modules-load=dwc2,g_ether "
                cmdText = cmdText.Remove(cmdText.IndexOf(cmdRemoved), cmdRemoved.Length)
                ' Write new cmdText over existing file
                objWriter = New StreamWriter(cmdFile, False)
                objWriter.Write(cmdText)
                objWriter.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' If cbWireless changes, enable or disable configuration items.
    ''' If cbWireless is unchecked, remove wpa_supplicant.conf file from card.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbWireless_CheckedChanged(sender As Object, e As EventArgs) Handles cbWireless.CheckedChanged

        ' If both OTG and wireless are configured, warn about weirdness
        If cbWireless.Checked = True And cbOTG.Checked = True Then
            Dim msg As String = "Both OTG and wireless are turned on, this is not typical as OTG generally uses the host computer networking."
            Dim title As String = "Headless Pi: OTG and Wireless Configured"
            Dim style = MsgBoxStyle.Exclamation
            MsgBox(msg, style, title)
        End If

        If cbWireless.Checked = True Then
            combCountry.Enabled = True
            txtSSID.Enabled = True
            txtPassword.Enabled = True
            lblCountry.Enabled = True
            lblSSID.Enabled = True
            lblPassword.Enabled = True
            Check_Supplicant()
        Else
            Dim path As String = sdcard + "wpa_supplicant.conf"
            File.Delete(path)
            combCountry.Enabled = False
            txtSSID.Enabled = False
            txtPassword.Enabled = False
            lblCountry.Enabled = False
            lblSSID.Enabled = False
            lblPassword.Enabled = False
            btnWriteSupplicant.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Call Build_Supplicant() as information changes. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub combCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combCountry.SelectedIndexChanged
        Build_Supplicant()
    End Sub

    ''' <summary>
    ''' Call Build_Supplicant() as information changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtSSID_TextChanged(sender As Object, e As EventArgs) Handles txtSSID.TextChanged
        Build_Supplicant()
    End Sub

    ''' <summary>
    ''' Call Build_Supplicant() as information changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Build_Supplicant()
    End Sub

    ''' <summary>
    ''' Write out wpa_supplicant.conf file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnWriteSupplicant_Click(sender As Object, e As EventArgs) Handles btnWriteSupplicant.Click
        Dim path As String = sdcard + "wpa_supplicant.conf"

        ' Start with a new file
        File.Delete(path)

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(supplicant)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    ''' <summary>
    ''' Exits application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
