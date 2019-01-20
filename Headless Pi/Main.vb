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
    Dim sdcard As String = ""
    Dim supplicant As String = ""

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Drive()
        Load_Country()
        Build_Supplicant()
    End Sub

    Private Sub cbWireless_CheckedChanged(sender As Object, e As EventArgs) Handles cbWireless.CheckedChanged
        If cbWireless.Checked = True Then
            combCountry.Enabled = True
            combKey.Enabled = True
            txtSSID.Enabled = True
            txtPassword.Enabled = True
            lblCountry.Enabled = True
            lblKey.Enabled = True
            lblSSID.Enabled = True
            lblPassword.Enabled = True
            Check_Supplicant()
        Else
            Dim path As String = sdcard + "wpa_supplicant.conf"
            File.Delete(path)
            combCountry.Enabled = False
            combKey.Enabled = False
            txtSSID.Enabled = False
            txtPassword.Enabled = False
            lblCountry.Enabled = False
            lblKey.Enabled = False
            lblSSID.Enabled = False
            lblPassword.Enabled = False
            btnWriteSupplicant.Enabled = False
        End If
    End Sub

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
                If c = 0 Then lblTarget.Text = ""
                sdcard = ltr
                lblTarget.Text = sdcard + " (" + itemText + ") - " + Type + vbCrLf
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

    Private Sub Load_Country()
        combCountry.Items.Add("AD | Andorra")
        combCountry.Items.Add("AE | United Arab Emirates")
        combCountry.Items.Add("AF | Afghanistan")
        combCountry.Items.Add("AG | Antigua and Barbuda")
        combCountry.Items.Add("AI | Anguilla")
        combCountry.Items.Add("AL | Albania")
        combCountry.Items.Add("AM | Armenia")
        combCountry.Items.Add("AO | Angola")
        combCountry.Items.Add("AQ | Antarctica")
        combCountry.Items.Add("AR | Argentina")
        combCountry.Items.Add("AS | American Samoa")
        combCountry.Items.Add("AT | Austria")
        combCountry.Items.Add("AU | Australia")
        combCountry.Items.Add("AW | Aruba")
        combCountry.Items.Add("AX | Åland Islands")
        combCountry.Items.Add("AZ | Azerbaijan")
        combCountry.Items.Add("BA | Bosnia and Herzegovina")
        combCountry.Items.Add("BB | Barbados")
        combCountry.Items.Add("BD | Bangladesh")
        combCountry.Items.Add("BE | Belgium")
        combCountry.Items.Add("BF | Burkina Faso")
        combCountry.Items.Add("BG | Bulgaria")
        combCountry.Items.Add("BH | Bahrain")
        combCountry.Items.Add("BI | Burundi")
        combCountry.Items.Add("BJ | Benin")
        combCountry.Items.Add("BL | Saint Barthélemy")
        combCountry.Items.Add("BM | Bermuda")
        combCountry.Items.Add("BN | Brunei Darussalam")
        combCountry.Items.Add("BO | Bolivia (Plurinational State of)")
        combCountry.Items.Add("BQ | Bonaire, Sint Eustatius and Saba")
        combCountry.Items.Add("BR | Brazil")
        combCountry.Items.Add("BS | Bahamas")
        combCountry.Items.Add("BT | Bhutan")
        combCountry.Items.Add("BV | Bouvet Island")
        combCountry.Items.Add("BW | Botswana")
        combCountry.Items.Add("BY | Belarus")
        combCountry.Items.Add("BZ | Belize")
        combCountry.Items.Add("CA | Canada")
        combCountry.Items.Add("CC | Cocos (Keeling) Islands")
        combCountry.Items.Add("CD | Congo, Democratic Republic of the")
        combCountry.Items.Add("CF | Central African Republic")
        combCountry.Items.Add("CG | Congo")
        combCountry.Items.Add("CH | Switzerland")
        combCountry.Items.Add("CI | Côte d'Ivoire")
        combCountry.Items.Add("CK | Cook Islands")
        combCountry.Items.Add("CL | Chile")
        combCountry.Items.Add("CM | Cameroon")
        combCountry.Items.Add("CN | China")
        combCountry.Items.Add("CO | Colombia")
        combCountry.Items.Add("CR | Costa Rica")
        combCountry.Items.Add("CU | Cuba")
        combCountry.Items.Add("CV | Cabo Verde")
        combCountry.Items.Add("CW | Curaçao")
        combCountry.Items.Add("CX | Christmas Island")
        combCountry.Items.Add("CY | Cyprus")
        combCountry.Items.Add("CZ | Czechia")
        combCountry.Items.Add("DE | Germany")
        combCountry.Items.Add("DJ | Djibouti")
        combCountry.Items.Add("DK | Denmark")
        combCountry.Items.Add("DM | Dominica")
        combCountry.Items.Add("DO | Dominican Republic")
        combCountry.Items.Add("DZ | Algeria")
        combCountry.Items.Add("EC | Ecuador")
        combCountry.Items.Add("EE | Estonia")
        combCountry.Items.Add("EG | Egypt")
        combCountry.Items.Add("EH | Western Sahara")
        combCountry.Items.Add("ER | Eritrea")
        combCountry.Items.Add("ES | Spain")
        combCountry.Items.Add("ET | Ethiopia")
        combCountry.Items.Add("FI | Finland")
        combCountry.Items.Add("FJ | Fiji")
        combCountry.Items.Add("FK | Falkland Islands (Malvinas)")
        combCountry.Items.Add("FM | Micronesia (Federated States of)")
        combCountry.Items.Add("FO | Faroe Islands")
        combCountry.Items.Add("FR | France")
        combCountry.Items.Add("GA | Gabon")
        combCountry.Items.Add("GB | United Kingdom of Great Britain and Northern Ireland")
        combCountry.Items.Add("GD | Grenada")
        combCountry.Items.Add("GE | Georgia")
        combCountry.Items.Add("GF | French Guiana")
        combCountry.Items.Add("GG | Guernsey")
        combCountry.Items.Add("GH | Ghana")
        combCountry.Items.Add("GI | Gibraltar")
        combCountry.Items.Add("GL | Greenland")
        combCountry.Items.Add("GM | Gambia")
        combCountry.Items.Add("GN | Guinea")
        combCountry.Items.Add("GP | Guadeloupe")
        combCountry.Items.Add("GQ | Equatorial Guinea")
        combCountry.Items.Add("GR | Greece")
        combCountry.Items.Add("GS | South Georgia and the South Sandwich Islands")
        combCountry.Items.Add("GT | Guatemala")
        combCountry.Items.Add("GU | Guam")
        combCountry.Items.Add("GW | Guinea-Bissau")
        combCountry.Items.Add("GY | Guyana")
        combCountry.Items.Add("HK | Hong Kong")
        combCountry.Items.Add("HM | Heard Island and McDonald Islands")
        combCountry.Items.Add("HN | Honduras")
        combCountry.Items.Add("HR | Croatia")
        combCountry.Items.Add("HT | Haiti")
        combCountry.Items.Add("HU | Hungary")
        combCountry.Items.Add("ID | Indonesia")
        combCountry.Items.Add("IE | Ireland")
        combCountry.Items.Add("IL | Israel")
        combCountry.Items.Add("IM | Isle of Man")
        combCountry.Items.Add("IN | India")
        combCountry.Items.Add("IO | British Indian Ocean Territory")
        combCountry.Items.Add("IQ | Iraq")
        combCountry.Items.Add("IR | Iran (Islamic Republic of)")
        combCountry.Items.Add("IS | Iceland")
        combCountry.Items.Add("IT | Italy")
        combCountry.Items.Add("JE | Jersey")
        combCountry.Items.Add("JM | Jamaica")
        combCountry.Items.Add("JO | Jordan")
        combCountry.Items.Add("JP | Japan")
        combCountry.Items.Add("KE | Kenya")
        combCountry.Items.Add("KG | Kyrgyzstan")
        combCountry.Items.Add("KH | Cambodia")
        combCountry.Items.Add("KI | Kiribati")
        combCountry.Items.Add("KM | Comoros")
        combCountry.Items.Add("KN | Saint Kitts and Nevis")
        combCountry.Items.Add("KP | Korea (Democratic People's Republic of)")
        combCountry.Items.Add("KR | Korea, Republic of")
        combCountry.Items.Add("KW | Kuwait")
        combCountry.Items.Add("KY | Cayman Islands")
        combCountry.Items.Add("KZ | Kazakhstan")
        combCountry.Items.Add("LA | Lao People's Democratic Republic")
        combCountry.Items.Add("LB | Lebanon")
        combCountry.Items.Add("LC | Saint Lucia")
        combCountry.Items.Add("LI | Liechtenstein")
        combCountry.Items.Add("LK | Sri Lanka")
        combCountry.Items.Add("LR | Liberia")
        combCountry.Items.Add("LS | Lesotho")
        combCountry.Items.Add("LT | Lithuania")
        combCountry.Items.Add("LU | Luxembourg")
        combCountry.Items.Add("LV | Latvia")
        combCountry.Items.Add("LY | Libya")
        combCountry.Items.Add("MA | Morocco")
        combCountry.Items.Add("MC | Monaco")
        combCountry.Items.Add("MD | Moldova, Republic of")
        combCountry.Items.Add("ME | Montenegro")
        combCountry.Items.Add("MF | Saint Martin (French part)")
        combCountry.Items.Add("MG | Madagascar")
        combCountry.Items.Add("MH | Marshall Islands")
        combCountry.Items.Add("MK | Macedonia, the former Yugoslav Republic of")
        combCountry.Items.Add("ML | Mali")
        combCountry.Items.Add("MM | Myanmar")
        combCountry.Items.Add("MN | Mongolia")
        combCountry.Items.Add("MO | Macao")
        combCountry.Items.Add("MP | Northern Mariana Islands")
        combCountry.Items.Add("MQ | Martinique")
        combCountry.Items.Add("MR | Mauritania")
        combCountry.Items.Add("MS | Montserrat")
        combCountry.Items.Add("MT | Malta")
        combCountry.Items.Add("MU | Mauritius")
        combCountry.Items.Add("MV | Maldives")
        combCountry.Items.Add("MW | Malawi")
        combCountry.Items.Add("MX | Mexico")
        combCountry.Items.Add("MY | Malaysia")
        combCountry.Items.Add("MZ | Mozambique")
        combCountry.Items.Add("NA | Namibia")
        combCountry.Items.Add("NC | New Caledonia")
        combCountry.Items.Add("NE | Niger")
        combCountry.Items.Add("NF | Norfolk Island")
        combCountry.Items.Add("NG | Nigeria")
        combCountry.Items.Add("NI | Nicaragua")
        combCountry.Items.Add("NL | Netherlands")
        combCountry.Items.Add("NO | Norway")
        combCountry.Items.Add("NP | Nepal")
        combCountry.Items.Add("NR | Nauru")
        combCountry.Items.Add("NU | Niue")
        combCountry.Items.Add("NZ | New Zealand")
        combCountry.Items.Add("OM | Oman")
        combCountry.Items.Add("PA | Panama")
        combCountry.Items.Add("PE | Peru")
        combCountry.Items.Add("PF | French Polynesia")
        combCountry.Items.Add("PG | Papua New Guinea")
        combCountry.Items.Add("PH | Philippines")
        combCountry.Items.Add("PK | Pakistan")
        combCountry.Items.Add("PL | Poland")
        combCountry.Items.Add("PM | Saint Pierre and Miquelon")
        combCountry.Items.Add("PN | Pitcairn")
        combCountry.Items.Add("PR | Puerto Rico")
        combCountry.Items.Add("PS | Palestine, State of")
        combCountry.Items.Add("PT | Portugal")
        combCountry.Items.Add("PW | Palau")
        combCountry.Items.Add("PY | Paraguay")
        combCountry.Items.Add("QA | Qatar")
        combCountry.Items.Add("RE | Réunion")
        combCountry.Items.Add("RO | Romania")
        combCountry.Items.Add("RS | Serbia")
        combCountry.Items.Add("RU | Russian Federation")
        combCountry.Items.Add("RW | Rwanda")
        combCountry.Items.Add("SA | Saudi Arabia")
        combCountry.Items.Add("SB | Solomon Islands")
        combCountry.Items.Add("SC | Seychelles")
        combCountry.Items.Add("SD | Sudan")
        combCountry.Items.Add("SE | Sweden")
        combCountry.Items.Add("SG | Singapore")
        combCountry.Items.Add("SH | Saint Helena, Ascension and Tristan da Cunha")
        combCountry.Items.Add("SI | Slovenia")
        combCountry.Items.Add("SJ | Svalbard and Jan Mayen")
        combCountry.Items.Add("SK | Slovakia")
        combCountry.Items.Add("SL | Sierra Leone")
        combCountry.Items.Add("SM | San Marino")
        combCountry.Items.Add("SN | Senegal")
        combCountry.Items.Add("SO | Somalia")
        combCountry.Items.Add("SR | Suriname")
        combCountry.Items.Add("SS | South Sudan")
        combCountry.Items.Add("ST | Sao Tome and Principe")
        combCountry.Items.Add("SV | El Salvador")
        combCountry.Items.Add("SX | Sint Maarten (Dutch part)")
        combCountry.Items.Add("SY | Syrian Arab Republic")
        combCountry.Items.Add("SZ | Eswatini")
        combCountry.Items.Add("TC | Turks and Caicos Islands")
        combCountry.Items.Add("TD | Chad")
        combCountry.Items.Add("TF | French Southern Territories")
        combCountry.Items.Add("TG | Togo")
        combCountry.Items.Add("TH | Thailand")
        combCountry.Items.Add("TJ | Tajikistan")
        combCountry.Items.Add("TK | Tokelau")
        combCountry.Items.Add("TL | Timor-Leste")
        combCountry.Items.Add("TM | Turkmenistan")
        combCountry.Items.Add("TN | Tunisia")
        combCountry.Items.Add("TO | Tonga")
        combCountry.Items.Add("TR | Turkey")
        combCountry.Items.Add("TT | Trinidad and Tobago")
        combCountry.Items.Add("TV | Tuvalu")
        combCountry.Items.Add("TW | Taiwan, Province of China")
        combCountry.Items.Add("TZ | Tanzania, United Republic of")
        combCountry.Items.Add("UA | Ukraine")
        combCountry.Items.Add("UG | Uganda")
        combCountry.Items.Add("UM | United States Minor Outlying Islands")
        combCountry.Items.Add("US | United States of America")
        combCountry.Items.Add("UY | Uruguay")
        combCountry.Items.Add("UZ | Uzbekistan")
        combCountry.Items.Add("VA | Holy See")
        combCountry.Items.Add("VC | Saint Vincent and the Grenadines")
        combCountry.Items.Add("VE | Venezuela (Bolivarian Republic of)")
        combCountry.Items.Add("VG | Virgin Islands (British)")
        combCountry.Items.Add("VI | Virgin Islands (U.S.)")
        combCountry.Items.Add("VN | Viet Nam")
        combCountry.Items.Add("VU | Vanuatu")
        combCountry.Items.Add("WF | Wallis and Futuna")
        combCountry.Items.Add("WS | Samoa")
        combCountry.Items.Add("YE | Yemen")
        combCountry.Items.Add("YT | Mayotte")
        combCountry.Items.Add("ZA | South Africa")
        combCountry.Items.Add("ZM | Zambia")
        combCountry.Items.Add("ZW | Zimbabwe")
    End Sub

    Private Sub cbSSH_CheckedChanged(sender As Object, e As EventArgs) Handles cbSSH.CheckedChanged
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

    Private Sub btnWriteSupplicant_Click(sender As Object, e As EventArgs) Handles btnWriteSupplicant.Click
        Dim path As String = sdcard + "wpa_supplicant.conf"
        Dim linuxSupplicant As String = ""

        ' Start with a new file
        File.Delete(path)

        ' Convert to Linux format
        linuxSupplicant = supplicant.Replace(vbCrLf, vbLf)

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(linuxSupplicant)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Private Sub Build_Supplicant()
        supplicant = ""
        supplicant = "country=" + Strings.Left(combCountry.Text, 2) + vbCrLf
        supplicant += "ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev" + vbCrLf
        supplicant += "update_config=1" + vbCrLf + vbCrLf
        supplicant += "network={" + vbCrLf
        supplicant += "    ssid=" + Chr(34) + txtSSID.Text + Chr(34) + vbCrLf
        supplicant += "    scan_ssid=1" + vbCrLf
        supplicant += "    psk=" + Chr(34) + txtPassword.Text + Chr(34) + vbCrLf
        supplicant += "    key_mgmt=" + combKey.Text + vbCrLf
        supplicant += "}" + vbCrLf
        Check_Supplicant()
    End Sub

    Private Sub combCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combCountry.SelectedIndexChanged
        Build_Supplicant()
    End Sub

    Private Sub txtSSID_TextChanged(sender As Object, e As EventArgs) Handles txtSSID.TextChanged
        Build_Supplicant()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Build_Supplicant()
    End Sub

    Private Sub combKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combKey.SelectedIndexChanged
        Build_Supplicant()
    End Sub

    Private Sub Check_Supplicant()
        Dim AllGood As Boolean = True

        If combCountry.Text = "" Then AllGood = False
        If txtSSID.Text = "" Then AllGood = False
        If txtPassword.Text = "" Then AllGood = False
        If combKey.Text = "" Then AllGood = False

        If AllGood = True Then
            btnWriteSupplicant.Enabled = True
        Else
            btnWriteSupplicant.Enabled = False
        End If
    End Sub

End Class
