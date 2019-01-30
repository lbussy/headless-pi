// Copyright (C) 2019  Lee C. Bussy (@LBussy)

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using Microsoft.Win32.SafeHandles;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Headless_Pi
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Country codes and text for wireless configuration
        string[] countryCode = { "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BL", "BM", "BN", "BO", "BQ", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GB", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JE", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "ME", "MF", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RS", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SS", "ST", "SV", "SX", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "ZA", "ZM", "ZW" };
        string[] countryText = { "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Åland Islands", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Saint Barthélemy", "Bermuda", "Brunei Darussalam", "Bolivia (Plurinational State of)", "Bonaire, Sint Eustatius and Saba", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Côte d'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cabo Verde", "Curaçao", "Christmas Island", "Cyprus", "Czechia", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia (Federated States of)", "Faroe Islands", "France", "Gabon", "United Kingdom of Great Britain and Northern Ireland", "Grenada", "Georgia", "French Guiana", "Guernsey", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "Isle of Man", "India", "British Indian Ocean Territory", "Iraq", "Iran (Islamic Republic of)", "Iceland", "Italy", "Jersey", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea (Democratic People's Republic of)", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Montenegro", "Saint Martin (French part)", "Madagascar", "Marshall Islands", "Macedonia, the former Yugoslav Republic of", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn", "Puerto Rico", "Palestine, State of", "Portugal", "Palau", "Paraguay", "Qatar", "Réunion", "Romania", "Serbia", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena, Ascension and Tristan da Cunha", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "South Sudan", "Sao Tome and Principe", "El Salvador", "Sint Maarten (Dutch part)", "Syrian Arab Republic", "Eswatini", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Timor-Leste", "Turkmenistan", "Tunisia", "Tonga", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan, Province of China", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States of America", "Uruguay", "Uzbekistan", "Holy See", "Saint Vincent and the Grenadines", "Venezuela (Bolivarian Republic of)", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Viet Nam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "South Africa", "Zambia", "Zimbabwe" };

        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            if ( Load_Drive() ) // Find SD Card
            {
                Load_SSH();         // Load status of SSH config from card
                Load_Overlay();     // Load status of OTG config from card
                Load_Country();     // Populate country code dropdown
                Load_Supplicant();  // Load wpa_supplicant.conf config from card
            }
            else
            {
                Application.Exit();
            }
        }

        ////////////////////
        // General Methods
        ////////////////////

        /// <summary>
        /// Gets SD card information from inserted USB devices.
        /// </summary>
        /// <returns>String containing SD card boot partition</returns>
        private bool Load_Drive()
        {
            int numBoot = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                try
                {
                    // Look for a removable drive named "boot" in FAT32
                    if ((drive.DriveType.ToString() == "Removable") &&
                        (drive.VolumeLabel == "boot") && (drive.IsReady == true) &&
                        (drive.DriveFormat == "FAT32"))
                    {
                        numBoot++;
                        toolStripStatusLabelDrive.Text = drive.Name;
                        toolStripStatusLabelName.Text = $"({drive.VolumeLabel})";
                        toolStripStatusLabelType.Text = drive.DriveType.ToString();
                    }
                }
                catch { } // Discard errors since we have ext4 file systems
            }

            if (numBoot > 1)
            {
                string msg = "More than one removable drive has been detected. Please remove all but the Raspberry Pi SD card and re-run the application.";
                string title = "Headless Pi: Multiple Drives Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(msg, title, buttons, icon);
                return false;
            }
            else if (numBoot == 0)
            {
                string msg = "No Raspberry Pi SD cards have been detected. Please insert the proper SD card and re-run the application.";
                string title = "Headless Pi: No Drives Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(msg, title, buttons, icon);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Load status of SSH configuration from card.
        /// Checks or unchecks cbSSH.
        /// </summary>
        private void Load_SSH()
        {
            //  Check to see if ssh. file exists, set checkbox appropriately
            string sshFile = toolStripStatusLabelDrive.Text + "ssh";
            if (File.Exists(sshFile))
            {
                cbSSH.Checked = true;
            }
            else
            {
                cbSSH.Checked = false;
            }
        }

        /// <summary>
        /// Load status of OTG configuration from card.
        /// Checks or unchecks cbOTG.
        /// </summary>
        private void Load_Overlay()
        {
            string configFile = $"{toolStripStatusLabelDrive.Text}config.txt";
            string cmdFile = $"{toolStripStatusLabelDrive.Text}cmdline.txt";
            bool configExist = false;
            bool cmdExist = false;
            StreamReader objReader;
            //  Check if config.txt file, then the dtoverlay statement exists
            try
            {
                objReader = new StreamReader(configFile);
                while (objReader.Peek() != -1)
                {
                    if (objReader.ReadLine() == "dtoverlay=dwc2")
                    {
                        configExist = true;
                    }

                }

                objReader.Close();
            }
            catch (Exception)
            {
                //  File config.txt does not exist
                configExist = false;
                string msg = "No config.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is not a fatal condition, however some functionality may not be enabled on your Raspberry Pi when it boots. A file will be created as needed.";
                string title = "Headless Pi: No Config File";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(msg, title, buttons, icon);
                //  Create a blank file
                FileStream fs = File.Create(configFile);
                fs.Close();
            }

            //  Check if cmdline.txt file, then the dtoverlay statement exists
            try
            {
                objReader = new StreamReader(cmdFile);
                while (objReader.Peek() != -1)
                {
                    if (objReader.ReadLine().Contains("modules-load=dwc2,g_ether"))
                    {
                        cmdExist = true;
                    }

                }

                objReader.Close();
            }
            catch (Exception)
            {
                //  File cmdline.txt does not exist
                cmdExist = false;
                string msg = "No cmdline.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is probaby a fatal condition, unable to proceed.";
                string title = "Headless Pi: No Command Line File";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult dialogResult = MessageBox.Show(msg, title, buttons, icon);
                Application.Exit();
            }

            if (((configExist == true)
                        && (cmdExist == true)))
            {
                cbOTG.Checked = true;
            }
            else
            {
                cbOTG.Checked = false;
            }
        }

        /// <summary>
        /// Populate combCountry with global country code/text array.
        /// </summary>
        private void Load_Country()
        {
            DataTable dtCountryCodes = new DataTable();
            dtCountryCodes.Columns.Add("Code", typeof(string));
            dtCountryCodes.Columns.Add("Country", typeof(string));
            int index;
            for (index = countryCode.GetLowerBound(0); (index <= countryCode.GetUpperBound(0)); index++)
            {
                dtCountryCodes.Rows.Add(countryCode[index], countryText[index]);
            }

            //  Bind the ComboBox to the DataTable
            combCountry.DataSource = dtCountryCodes;
            combCountry.ValueMember = "Code";
            combCountry.DisplayMember = "Country";
            combCountry.DrawMode = DrawMode.OwnerDrawFixed;
            //  Handle the DrawItem event to draw the items.
            //  Set behavior of combo box
            combCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        /// <summary>
        /// Load wpa_supplicant configuration from card if it exists.
        /// Populates combCountry, txtSSID, txtPassword.
        /// </summary>
        private void Load_Supplicant()
        {
            string wpaPath = $"{toolStripStatusLabelDrive.Text}wpa_supplicant.conf";

            try
            {
                StreamReader file = new StreamReader(wpaPath);
                string strLine = "";
                string strDelimStart = "";
                int intIndexStart = -1;
                int intIndexEnd = -1;
                int startIndex = -1;
                int length = -1;

                while ((strLine = file.ReadLine()) != null)
                {
                    cbWireless.Checked = true;
                    strLine = strLine.Replace("\"", "").Trim(); // Trim whitespace, remove quotes
                    strDelimStart = "="; // Start search after the "=" sign
                    intIndexStart = strLine.IndexOf(strDelimStart) - 1;
                    intIndexEnd = strLine.Length;
                    startIndex = intIndexStart + strDelimStart.Length + 1;
                    length = intIndexEnd - intIndexStart - strDelimStart.Length - 1;

                    if ((intIndexStart > -1) && (intIndexEnd > -1))
                    {
                        switch (Lft(strLine.Trim(), 3))
                        {
                            case "cou":
                                strLine = strLine.Substring(startIndex, length);
                                for (int i = 0; i <= countryCode.GetUpperBound(0); i++)
                                {
                                    if (countryCode[i] == strLine) combCountry.SelectedValue = strLine;
                                }
                                break;
                            case "ssi":
                                txtSSID.Text = strLine.Substring(startIndex, length);
                                break;
                            case "psk":
                                txtPassword.Text = strLine.Substring(startIndex, length);
                                break;
                        }
                    }
                }
                file.Close();
            }
            catch (Exception)
            {
                cbWireless.Checked = false;
                combCountry.Enabled = false;
                txtSSID.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        /// <summary>
        /// Re-make of VB Left() function
        /// </summary>
        /// <param name="value">Input string</param>
        /// <param name="maxLength">(Max) Number of characters to return from left of string</param>
        /// <returns>String containing maxLength characters from left sde of string</returns>
        private static string Lft(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return (value.Length <= maxLength
                   ? value
                   : value.Substring(0, maxLength)
                   );
        }

         ////////////////////
        // Event Handlers
        ////////////////////

        /// <summary>
        /// If cbSSH changes, create or remove ssh file on card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSSH_CheckedChanged(object sender, EventArgs e)
        {
            //  If OTG is checked and SSH is not turned on, offer to enable SSH
            if (((cbOTG.Checked == true)
                        && (cbSSH.Checked == false)))
            {
                // Offer to enable SSH since OTG is enabled
                string msg = "OTG is enabled but you have chosen to disable SSH. Generally, communication with the guest is done over SSH.  Would you like to re-enable SSH?";
                string title = "Headless Pi: SSH Not Confgured";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult dialogResult = MessageBox.Show(msg, title, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    cbSSH.Checked = true;
                }
            }

            // Create or remove file as needed
            string path = $"{toolStripStatusLabelDrive.Text}ssh";
            if (cbSSH.Checked == true)
            {
                //  Create or overwrite the file.
                FileStream fs = File.Create(path);
                fs.Close();
            }
            else
            {
                //  Delete the file
                File.Delete(path);
            }
        }

        /// <summary>
        /// If cbOTG changes, update or remove OTG configuration on card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOTG_CheckedChanged(object sender, EventArgs e)
        {
            string configFile = $"{toolStripStatusLabelDrive.Text}config.txt";
            string cmdFile = $"{toolStripStatusLabelDrive.Text}cmdline.txt";
            bool configExist = false;
            bool cmdExist = false;
            StreamReader objReader;
            StreamWriter objWriter;
            //  If both OTG and wireless are configured, warn about weirdness
            if (((cbWireless.Checked == true)
                        && (cbOTG.Checked == true)))
            {
                string msg = "Both OTG and wireless are turned on, this is not typical as OTG generally uses the host computer networking.";
                string title = "Headless Pi: OTG and Wireless Configured";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(msg, title, buttons, icon);
            }

            //  If OTG is checked and SSH is not turned on, offer to enable SSH
            if ((cbOTG.Checked == true)
                        && (cbSSH.Checked == false))
            {
                string msg = "You have enabled OTG but have not enabled SSH. Generally, communication with the guest is done over SSH.  Would you like to enable SSH?";
                string title = "Headless Pi: SSH Not Confgured";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult dialogResult = MessageBox.Show(msg, title, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    cbSSH.Checked = true;
                }
            }

            //  Check if config.txt file, then the dtoverlay statement exists
            try
            {
                objReader = new StreamReader(configFile);
                while ((objReader.Peek() != -1))
                {
                    if ((objReader.ReadLine() == "dtoverlay=dwc2"))
                    {
                        configExist = true;
                    }

                }

                objReader.Close();
            }
            catch (Exception)
            {
                //  File config.txt does not exist
                configExist = false;
                string msg = "No config.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is not a fatal condition, however some functionality may not be enabled on your Raspberry Pi when it boots. A file will be created as needed.";
                string title = "Headless Pi: No Config File";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(msg, title, buttons, icon);
                //  Create a blank file
                FileStream fs = File.Create(configFile);
                fs.Close();
            }

            //  Check if cmdline.txt file, then the dtoverlay statement exists
            try
            {
                objReader = new StreamReader(cmdFile);
                while ((objReader.Peek() != -1))
                {
                    if (objReader.ReadLine().Contains("modules-load=dwc2,g_ether"))
                    {
                        cmdExist = true;
                    }

                }

                objReader.Close();
            }
            catch (Exception)
            {
                //  File cmdline.txt does not exist
                cmdExist = false;
                string msg = "No cmdline.txt file has been found on the /boot partition.  This should not happen as the file exists on all Raspbian image distributions.  This is probaby a fatal condition, unable to proceed.";
                string title = "Headless Pi: No Command Line File";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(msg, title, buttons, icon);
                Application.Exit();
            }

            if ((cbOTG.Checked == true))
            {
                //  Make sure configurations get set appropriately
                // 
                //  Handle configuration file
                if ((configExist == false))
                {
                    string configText = "\n";
                    configText = (configText + ("# Selects the dwc2 USB controller driver (OTG functionality)" + "\n"));
                    configText += "dtoverlay=dwc2";
                    objWriter = new StreamWriter(configFile, true);
                    objWriter.WriteLine(configText);
                    objWriter.Close();
                }

                //  Handle the command line parameters
                if ((cmdExist == false))
                {
                    StreamReader textReader = new StreamReader(cmdFile);
                    string cmdText = textReader.ReadToEnd();
                    textReader.Close();
                    string cmdAdded = "modules-load=dwc2,g_ether ";
                    cmdText = cmdText.Replace("rootwait ", ("rootwait " + cmdAdded));
                    //  Write new cmdText over existing file
                    objWriter = new StreamWriter(cmdFile, false);
                    objWriter.Write(cmdText);
                    objWriter.Close();
                }

            }
            else
            {
                //  Make sure configurations get un-set
                // 
                //  Handle configuration file
                if ((configExist == true))
                {
                    StreamReader textReader = new StreamReader(configFile);
                    string configText = textReader.ReadToEnd();
                    textReader.Close();
                    string configRemove = "\n";
                    configRemove = (configRemove + ("# Selects the dwc2 USB controller driver (OTG functionality)" + "\n"));
                    configRemove += "dtoverlay=dwc2";
                    configText = configText.Remove(configText.IndexOf(configRemove), (configRemove.Length + 2));
                    //  Write new config over existing file
                    objWriter = new StreamWriter(configFile, false);
                    objWriter.Write(configText);
                    objWriter.Close();
                }

                //  Handle the command line parameters
                if ((cmdExist == true))
                {
                    StreamReader textReader = new StreamReader(cmdFile);
                    string cmdText = textReader.ReadToEnd();
                    textReader.Close();
                    string cmdRemoved = "modules-load=dwc2,g_ether ";
                    cmdText = cmdText.Remove(cmdText.IndexOf(cmdRemoved), cmdRemoved.Length);
                    //  Write new cmdText over existing file
                    objWriter = new StreamWriter(cmdFile, false);
                    objWriter.Write(cmdText);
                    objWriter.Close();
                }

            }
        }

        /// <summary>
        /// If cbWireless changes, enable or disable configuration items.
        /// If cbWireless is unchecked, remove wpa_supplicant.conf file from card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbWireless_CheckedChanged(object sender, EventArgs e)
        {
            //  If both OTG and wireless are configured, warn about weirdness
            if ((cbWireless.Checked == true)
                        && (cbOTG.Checked == true))
            {
                string msg = "Both OTG and wireless are turned on, this is not typical as OTG generally uses the host computer networking.";
                string title = "Headless Pi: OTG and Wireless Configured";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, title, buttons, icon);
            }

            if (cbWireless.Checked == true)
            {
                combCountry.Enabled = true;
                txtSSID.Enabled = true;
                txtPassword.Enabled = true;
                lblCountry.Enabled = true;
                lblSSID.Enabled = true;
                lblPassword.Enabled = true;
                Build_Supplicant(null, null);
            }
            else
            {
                File.Delete($"{toolStripStatusLabelDrive.Text}wpa_supplicant.conf");
                combCountry.Enabled = false;
                txtSSID.Enabled = false;
                txtPassword.Enabled = false;
                lblCountry.Enabled = false;
                lblSSID.Enabled = false;
                lblPassword.Enabled = false;
                btnWriteSupplicant.Enabled = false;
            }
        }

        /// <summary>
        /// Draw the combCountry box with two columns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCountry_DrawItem(object sender, DrawItemEventArgs e)
        {
            //  Draw the default background
            e.DrawBackground();

            var drv = (DataRowView)(combCountry.Items[e.Index]);
            string countryCode = drv["Code"].ToString();
            string countryText = drv["Country"].ToString();

            Rectangle r1 = e.Bounds;
            r1.Width = Convert.ToInt16(Convert.ToDouble(r1.Width) * 0.15);

            // Create brush for text
            SolidBrush sb = new SolidBrush(e.ForeColor);

            // Write first column
            e.Graphics.DrawString(countryCode, e.Font, sb, r1);

            //  Draw a line to isolate the columns 
            Pen p = new Pen(Color.DarkGray);
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom);
            Rectangle r2 = e.Bounds;
            r2.X = Convert.ToInt16(Convert.ToDouble(e.Bounds.Width) * 0.15);
            r2.Width = Convert.ToInt16(Convert.ToDouble(r2.Width) * 0.85);

            // Write second column
            e.Graphics.DrawString(countryText, e.Font, sb, r2);
        }

        /// <summary>
        /// Event handler for supplicant items, stores in txtSupplicant
        /// </summary>
        private void Build_Supplicant(object sender, EventArgs e)
        {
            // Build out text for a supplicant file in the proper format
            txtSupplicant.Text  = $"country={combCountry.SelectedValue.ToString()}\n";
            txtSupplicant.Text += $"ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev" + "\n";
            txtSupplicant.Text += $"update_config=1\n\n";
            txtSupplicant.Text += $"network={{\n";
            txtSupplicant.Text += $"    ssid=\"{txtSSID.Text}\"\n";
            txtSupplicant.Text += $"    scan_ssid=1" + "\n";
            txtSupplicant.Text += $"    psk=\"{txtPassword.Text}\"\n";
            txtSupplicant.Text += $"    key_mgmt=WPA-PSK\n";
            txtSupplicant.Text += $"}}\n";

            // Check to see if we have enough to build a file, enable button if so
            bool goodEntry = true;
            if (combCountry.Text == "") goodEntry = false;
            if (txtSSID.Text == "") goodEntry = false;
            if (txtPassword.Text == "") goodEntry = false;
            if (goodEntry == true) btnWriteSupplicant.Enabled = true;
            else btnWriteSupplicant.Enabled = false;
        }

        /// <summary>
        /// Write out supplicant file to SD card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteSupplicant_Click(object sender, EventArgs e)
        {
            string path = $"{toolStripStatusLabelDrive.Text}wpa_supplicant.conf";
            File.Delete(path);
            FileStream fs = File.Create(path);
            byte[] info = new UTF8Encoding(true).GetBytes(txtSupplicant.Text);
            fs.Write(info, 0, info.Length);
            fs.Close();
        }

        /// <summary>
        /// Exit application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            NativeMethods getUSB = new NativeMethods();
            IntPtr handle = NativeMethods.USBEject(Lft(toolStripStatusLabelDrive.Text, 2));
            if ( getUSB.Eject(handle) )
            {
                string msg = "Your SD card has been safely ejected, you may now remove it.";
                string title = "Headless Pi: Drive Ejected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(msg, title, buttons, icon);
            }
            else
            {
                string msg = "Unable to safely eject SD card.  Be sure to close all windows which may be holding this drive open and eject using the Windows taskbar control before removing drive.";
                string title = "Headless Pi: Unable to Eject";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                MessageBox.Show(msg, title, buttons, icon);
            }
            Application.Exit();
        }
    }
}