/*
 *                              SETTINGS FORM
 *                      
 *       This form handles all the tasks related to settings
 */

/// NOTE: Username and profile, platform and website are used interchangeably
// Iconset: https://iconarchive.com/show/flags-icons-by-wikipedia.2.html
// Iconset: https://icons8.com/icons/authors/3ayxolOIttPV/xnimrodx/external-xnimrodx-lineal-xnimrodx

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager_CSharpGUI
{
    public partial class frmSettings : Form
    {
        /// <summary>
        /// Settings form that handle all the settings
        /// </summary>

        // Location of core files
        public static string myLocation = AppDomain.CurrentDomain.BaseDirectory;
        // Location of user data
        public static string dataLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Language
        LanguageManagement lang = new LanguageManagement();
        Dictionary<string, List<string>> languages = new Dictionary<string, List<string>>();
        string selectedLanguage = "";

        // Settings management
        SettingsManagement set = new SettingsManagement();

        // Length of a password
        int passwordLength = 8;
        int[] lengthRange = { 0, 32 };

        // Colour pallette of the meter
        Color[] colourPalette = {
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(255, 216, 0),
            Color.FromArgb(44, 177, 23),
            Color.FromArgb(44, 177, 23)
        };

        frmMain parent = null; // Parent form

        /// <summary>
        /// Handles everything related to settings
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="_dataLocation">Location of data</param>
        public frmSettings(frmMain _parent, string _dataLocation)
        {
            InitializeComponent();

            // Global variables
            parent = _parent;
            selectedLanguage = parent.selectedLanguage;
            dataLocation = _dataLocation;
            this.Icon = parent.Icon;

            // Default checkbox settings
            chkCache.Uncheck();
            chkCopy.Uncheck();
            chkKeepLogged.Uncheck();
            chkNumbers.Check();
            chkSymbols.Check();
            chkUppercase.Check();

            loadLanguages(); // Load the language list
            loadStrings(); // Load the text data

            // Load the settings and update dials
            set.loadSettings(dataLocation).ToList();
            loadSettings();
            updateSlider();

            loadIcons(); // Load icons
        }

        /// <summary>
        /// Apply button click. Applies the settings and close the form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            saveSettings();

            // Notify user
            frmMessage message = new frmMessage(this, lang.get("07x0077"), lang.get("07x0078"), selectedLanguage);
            message.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// Defaults button click. Restores the default values and close the form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnDefaults_Click(object sender, EventArgs e)
        {
            set.setDefaults(); // Sets the defaults

            // Show message
            frmMessage message = new frmMessage(this, lang.get("07x0079"), lang.get("07x0080"), selectedLanguage);
            message.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// Export credentials button clicked. Exports the credentials
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnExportCredential_Click(object sender, EventArgs e)
        {
            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(parent, false);
            login.ShowDialog();
            bool success = (login.getPassword().Item1 != "");

            // Display warning message
            frmMessage message = new frmMessage(this, lang.get("07x0065"), lang.get("07x0066"), selectedLanguage, MessageBoxIcon.Warning);
            message.ShowDialog();

            // If login was successful, we proceed
            if (success)
            {
                // If the preference file exist we show save file dialog to choose location
                if (System.IO.File.Exists(dataLocation + "\\preferences.en"))
                {
                    sfdSaveFile.Title = lang.get("07x0065");
                    sfdSaveFile.FileName = "credentials.en";
                    sfdSaveFile.Filter = "Muragala Encrypted File|*.en";

                    if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        // If save file dialog was successful, we check if the file is open
                        System.IO.Stream myStream;

                        if ((myStream = sfdSaveFile.OpenFile()) != null)
                        {
                            // If so we try to copy the credentials file there
                            try
                            {
                                System.IO.FileStream stream = new System.IO.FileStream(dataLocation + "\\preferences.en", System.IO.FileMode.Open);
                                stream.CopyTo(myStream);

                                // Display success message
                                message = new frmMessage(this, lang.get("07x0065"), lang.get("07x0083"), selectedLanguage);
                                message.ShowDialog();
                            }
                            catch
                            {
                                // Display error message
                                message = new frmMessage(this, lang.get("07x0065"), lang.get("07x0084"), "English", MessageBoxIcon.Error);
                                message.ShowDialog();
                            }

                            myStream.Close(); // Close the data stream
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Reset credentials button. Resets the database and remove login info
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnResetCredentials_Click(object sender, EventArgs e)
        {
            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(parent, false);
            login.ShowDialog();
            bool success = (login.getPassword().Item1 != "");

            // If login was successful, we continue
            if (success)
            {
                // Display a warning message
                frmMessage message = new frmMessage(this, lang.get("07x0071"), lang.get("07x0072"), selectedLanguage, MessageBoxIcon.Warning, MessageBoxButtons.YesNo);
                message.ShowDialog();

                // If user wanted to proceed we continue
                if (message.getResult() == DialogResult.Yes)
                {
                    try
                    {
                        // We try to delete the preference and database files
                        System.IO.File.Delete(dataLocation + "\\preferences.en");
                        System.IO.File.Delete(dataLocation + "\\database.en");
                        //System.IO.File.Delete(dataLocation + "\\cache.en");

                        // Display success message and exit application
                        message = new frmMessage(this, lang.get("07x0071"), lang.get("07x0083"), selectedLanguage);
                        message.ShowDialog();
                        
                        Application.Exit();
                    }
                    catch
                    {
                        // Error message
                        message = new frmMessage(this, lang.get("07x0071"), lang.get("07x0084"), selectedLanguage, MessageBoxIcon.Error);
                        message.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        /// Export database button. We export all profiles in the database to a text file
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnExportDatabase_Click(object sender, EventArgs e)
        {
            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(parent, false);
            login.ShowDialog();
            
            // If login is successful we continue
            if (login.getPassword().Item1 != "")
            {
                // Display a warning message
                frmMessage message = new frmMessage(this, lang.get("07x0081"), lang.get("07x0082"), selectedLanguage, MessageBoxIcon.Warning, MessageBoxButtons.YesNo);
                message.ShowDialog();

                // If user proceed, we continue
                if (message.getResult() == DialogResult.Yes)
                {
                    bool success = false; // Success or fail

                    // We show save file dialog to choose a file location
                    sfdSaveFile.Title = lang.get("07x0081");
                    sfdSaveFile.FileName = "database.txt";
                    sfdSaveFile.Filter = "Text File|*.txt|All Files|*.*";
                    sfdSaveFile.ShowDialog();

                    string destionation = sfdSaveFile.FileName; // Destination

                    // Show export form
                    frmExport export = new frmExport(lang.get("07x0081"), lang.get("07x0067"), lang.get("07x0068"), lang.get("07x0069"), dataLocation, destionation, login.getPassword().Item1, parent);
                    export.ShowDialog();
                    success = export.success;

                    if (success)
                    {
                        // If successful we show message
                        message = new frmMessage(this, lang.get("07x0081"), lang.get("07x0083"), selectedLanguage);
                        message.ShowDialog();
                    }
                    else
                    {
                        // If failed we show message
                        message = new frmMessage(this, lang.get("07x0081"), lang.get("07x0084"), selectedLanguage, MessageBoxIcon.Error);
                        message.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        /// Clear database button. This clears the profiles in the database
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnClearDatabase_Click(object sender, EventArgs e)
        {
            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(parent, false);
            login.ShowDialog();

            // If login successful, we continue
            if (login.getPassword().Item1 != "")
            {
                // Show warning message
                frmMessage message = new frmMessage(this, lang.get("07x0085"), lang.get("07x0086"), selectedLanguage, MessageBoxIcon.Warning, MessageBoxButtons.YesNo);
                message.ShowDialog();

                // If user chose to proceed, we continue
                if (message.getResult() == DialogResult.Yes)
                {
                    bool success = true; // Success

                    try
                    {
                        // We try to delete the database file
                        System.IO.File.Delete(dataLocation + "\\database.en");
                        //System.IO.File.Delete(dataLocation + "\\cache.en");
                    }
                    catch { success = false; }

                    if (success)
                    {
                        // If successful we show message
                        message = new frmMessage(this, lang.get("07x0085"), lang.get("07x0083"), selectedLanguage);
                        message.ShowDialog();
                    }
                    else
                    {
                        // If failed we show message
                        message = new frmMessage(this, lang.get("07x0085"), lang.get("07x0084"), selectedLanguage, MessageBoxIcon.Error);
                        message.ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        /// Backup button clicked. Backs up the database
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(parent, false);
            login.ShowDialog();

            // If login successful we proceed
            if (login.getPassword().Item1 != "")
            {
                bool success = false; // Success

                // Show save file dialog to get location
                sfdSaveFile.Title = lang.get("07x0087");
                sfdSaveFile.FileName = "database.en";
                sfdSaveFile.Filter = "Muragala Encrypted File|*.en";

                // If location chosen we proceed
                if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                {
                    System.IO.Stream myStream; // Create a new data stream

                    if ((myStream = sfdSaveFile.OpenFile()) != null)
                    {
                        // If the file opened successfully, we try to write the database to it
                        try
                        {
                            System.IO.FileStream stream = new System.IO.FileStream(dataLocation + "\\database.en", System.IO.FileMode.Open);
                            stream.CopyTo(myStream);

                            success = true;
                        }
                        catch { }

                        myStream.Close();
                    }
                }

                if (success)
                {
                    // If successful we show message
                    frmMessage message = new frmMessage(this, lang.get("07x0087"), lang.get("07x0083"), selectedLanguage);
                    message.ShowDialog();
                }
                else
                {
                    // If failed we show message
                    frmMessage message = new frmMessage(this, lang.get("07x0087"), lang.get("07x0084"), selectedLanguage, MessageBoxIcon.Error);
                    message.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Move mouse in password length label
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void lblCount_MouseMove(object sender, MouseEventArgs e)
        {
            // If the left mouse button is clicked we calculate the password length according to
            // the mouse position
            if (e.Button == MouseButtons.Left)
            {
                updateLength(updateSlider());
                this.Refresh();
            }
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == btnDefaults)
                tltMain.ToolTipTitle = lang.get("07x0029"); // Default button
            else if (e.AssociatedControl == flpLanguages)
                tltMain.ToolTipTitle = lang.get("07x0000"); // Language panel
            else if (e.AssociatedControl == flpTheme)
                tltMain.ToolTipTitle = lang.get("07x0008"); // Theme panel
            else if (e.AssociatedControl == txtLocation)
                tltMain.ToolTipTitle = lang.get("07x0014"); // Location text
            else if (e.AssociatedControl == btnLocation)
                tltMain.ToolTipTitle = lang.get("07x0014"); // Location button
            else if (e.AssociatedControl is ModernCheckBox)
                tltMain.ToolTipTitle = ((ModernCheckBox)e.AssociatedControl).Text(); // All check boxes
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other
        }

        ////////////////////////////////////////////////////////////////
        ////// FUNCTIONS

        /// <summary>
        /// Selects a language
        /// </summary>
        /// <param name="ID">ID of the selected language</param>
        public void selectLanguage(string ID)
        {
            selectedLanguage = ID; // We set the selection

            // For each languages available we uncheck them except the
            // selected one
            foreach (LanguageItem item in flpLanguages.Controls)
            {
                if (item.getID() != ID)
                    item.deselect();
                else
                    item.select();
            }
        }

        /// <summary>
        /// Updates the slider
        /// </summary>
        /// <returns>Updated values as tuple { value, min, max }</returns>
        private Tuple<int, int, int> updateSlider()
        {
            // Clear the image
            if (lblCount.Image != null)
                lblCount.Image.Dispose();

            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(lblCount.Size.Width, lblCount.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Width and height to be displayed
            int height = BitmapImage.Size.Height - 8;
            int width = BitmapImage.Size.Width - 8;

            int sliderPosition;
            int colourSelection;

            if (passwordLength < 1) // No characters
                colourSelection = 0;
            else if (passwordLength < 5) // Very weak
                colourSelection = 1;
            else if (passwordLength < 8) // Weak
                colourSelection = 2;
            else if (passwordLength < 12) // Good
                colourSelection = 3;
            else // Strong
                colourSelection = 4;

            if (MouseButtons == MouseButtons.Left)
                sliderPosition = MousePosition.X - lblCount.Location.X - this.Location.X;
            else
                sliderPosition = Map(passwordLength, lengthRange[0], lengthRange[1], 0, width);

            if (sliderPosition > width)
                sliderPosition = width;
            if (sliderPosition < 15)
                sliderPosition = 15;

            // Draws the background, progress and a border
            Plasmoid.Extensions.GraphicsExtension.FillRoundedRectangle(GraphicsFromImage, new SolidBrush(Color.FromArgb(191, 191, 191)), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            Plasmoid.Extensions.GraphicsExtension.FillRoundedRectangle(GraphicsFromImage, new SolidBrush(colourPalette[colourSelection]), 4, 4, sliderPosition, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            if (MouseButtons == MouseButtons.Left)
                Plasmoid.Extensions.GraphicsExtension.DrawRoundedRectangle(GraphicsFromImage, new Pen(colourPalette[colourSelection], 3), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            else
                Plasmoid.Extensions.GraphicsExtension.DrawRoundedRectangle(GraphicsFromImage, new Pen(Color.FromArgb(89, 89, 89), 2), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);

            if (passwordLength < 1) // No characters
            {
                lblCount.Text = lang.get("07x0035");
                lblCount.ForeColor = Color.White;
            }
            else if (passwordLength < 5) // Very weak
            {
                lblCount.Text = LanguageManagement.parse(lang.get("07x0036"), countString(passwordLength, lang.get("07x0033"), lang.get("07x0034")));
                lblCount.ForeColor = Color.White;
            }
            else if (passwordLength < 8) // Weak
            {
                lblCount.Text = LanguageManagement.parse(lang.get("07x0037"), passwordLength.ToString());
                lblCount.ForeColor = Color.Black;
            }
            else if (passwordLength < 12) // Good
            {
                lblCount.Text = LanguageManagement.parse(lang.get("07x0038"), passwordLength.ToString());
                lblCount.ForeColor = Color.White;
            }
            else // Strong
            {
                lblCount.Text = LanguageManagement.parse(lang.get("07x0039"), passwordLength.ToString());
                lblCount.ForeColor = Color.White;
            }

            // Applying to the picturebox
            lblCount.Image = BitmapImage;

            return new Tuple<int, int, int>(sliderPosition, 0, width);
        }

        /// <summary>
        /// Updates the length of the password
        /// </summary>
        /// <param name="sliderValue">Value on the slider { value, min, max }</param>
        private void updateLength(Tuple<int, int, int> sliderValue)
        {
            // Maps the slider value to password length
            passwordLength = Map(sliderValue.Item1, sliderValue.Item2, sliderValue.Item3, lengthRange[0], lengthRange[1]);
        }

        ////////////////////////////////////////////////////////////////
        ////// LOADING COMPONENTS

        /// <summary>
        /// Loads all the strings
        /// </summary>
        private void loadStrings()
        {
            // Loading the strings
            lang.loadLanguages(myLocation + "languages");
            lang.selectLanguage("English");
            lang.loadStrings("07");

            // Title of the form
            this.Text = lang.get("07x0017");

            // Tabs
            tabInterface.Text = lang.get("07x0018");
            tabAuthentication.Text = lang.get("07x0019");
            tabPassword.Text = lang.get("07x0020");
            tabUserData.Text = lang.get("07x0021");
            tabBackup.Text = lang.get("07x0022");

            // Groups
            grpLanguage.Text = lang.get("07x0023");
            grpTheme.Text = lang.get("07x0024");
            grpAuthentication.Text = lang.get("07x0025");
            grpGeneration.Text = lang.get("07x0026");
            grpBehavious.Text = lang.get("07x0027");
            grpDatabase.Text = lang.get("07x0028");
            grpLocation.Text = lang.get("07x0030");
            grpBackup.Text = lang.get("07x0031");

            // Buttons
            btnApply.Text = lang.get("07x0032");
            btnExportCredential.Text = lang.get("07x0009");
            btnResetCredentials.Text = lang.get("07x0010");
            btnExportDatabase.Text = lang.get("07x0011");
            btnClearCache.Text = lang.get("07x0012");
            btnClearDatabase.Text = lang.get("07x0013");
            btnBackup.Text = lang.get("07x0015");
            btnRestore.Text = lang.get("07x0016");

            // Check boxes
            chkKeepLogged.Text(lang.get("07x0001"));
            chkUppercase.Text(lang.get("07x0003"));
            chkNumbers.Text(lang.get("07x0004"));
            chkSymbols.Text(lang.get("07x0005"));
            chkCopy.Text(lang.get("07x0006"));
            chkCache.Text(lang.get("07x0007"));

            // Tooltips
            tltMain.SetToolTip(flpLanguages, lang.get("07x0048"));
            tltMain.SetToolTip(flpTheme, lang.get("07x0056"));

            tltMain.SetToolTip(tabInterface, lang.get("07x0058"));
            tltMain.SetToolTip(tabAuthentication, lang.get("07x0059"));
            tltMain.SetToolTip(tabPassword, lang.get("07x0060"));
            tltMain.SetToolTip(tabUserData, lang.get("07x0061"));
            tltMain.SetToolTip(tabBackup, lang.get("07x0062"));

            tltMain.SetToolTip(btnApply, lang.get("07x0063"));
            tltMain.SetToolTip(btnExportCredential, lang.get("07x0041"));
            tltMain.SetToolTip(btnResetCredentials, lang.get("07x0042"));
            tltMain.SetToolTip(btnExportDatabase, lang.get("07x0043"));
            tltMain.SetToolTip(btnClearCache, lang.get("07x0044"));
            tltMain.SetToolTip(btnClearDatabase, lang.get("07x0045"));
            tltMain.SetToolTip(btnBackup, lang.get("07x0046"));
            tltMain.SetToolTip(btnRestore, lang.get("07x0047"));
            tltMain.SetToolTip(btnDefaults, lang.get("07x0064"));

            chkKeepLogged.changeTooltip(lang.get("07x0049"), tltMain);
            chkUppercase.changeTooltip(lang.get("07x0051"), tltMain);
            chkNumbers.changeTooltip(lang.get("07x0052"), tltMain);
            chkSymbols.changeTooltip(lang.get("07x0053"), tltMain);
            chkCopy.changeTooltip(lang.get("07x0054"), tltMain);
            chkCache.changeTooltip(lang.get("07x0055"), tltMain);

            tltMain.SetToolTip(lblCount, lang.get("07x0050"));
            tltMain.SetToolTip(txtLocation, lang.get("07x0062"));
            tltMain.SetToolTip(btnLocation, lang.get("07x0062"));
        }

        /// <summary>
        /// Loads the list of languages
        /// </summary>
        private void loadLanguages()
        {
            // Load the list of languages
            lang.loadLanguages(myLocation + "\\languages");
            languages = lang.getLanguageData();

            // Clear the languages panel
            flpLanguages.Controls.Clear();

            // We add each one to the panel
            foreach (string item in languages.Keys)
            {
                List<string> data = languages[item];
                LanguageItem language = new LanguageItem(this, item, data[1], data[0], Load64Image(data[2]));

                flpLanguages.Controls.Add(language);
            }

            flpLanguages.FlowDirection = FlowDirection.TopDown;
        }

        /// <summary>
        /// Loads all the settings
        /// </summary>
        private void loadSettings()
        {
            if (set.getSettings().Count() != 8)
                saveSettings();

            // Language
            if (set.getSetting("07x0000") != null)
            {
                selectedLanguage = set.getSetting("07x0000");
            }

            foreach (LanguageItem item in flpLanguages.Controls)
            {
                if (item.getID() == selectedLanguage)
                {
                    item.select();
                    break;
                }
            }

            // Location
            if (set.getSetting("07x0007") == null)
                txtLocation.Text = dataLocation;
            else
                txtLocation.Text = set.getSetting("07x0007");

            // Check Boxes
            string[] chkSettings = { "07x0001", "07x0003", "07x0004", "07x0005", "07x0006" };
            bool[] chkDefaults = { false, true, true, true, false };
            ModernCheckBox[] chkBoxes = { chkKeepLogged, chkUppercase, chkNumbers, chkSymbols, chkCopy };

            for (int i = 0; i < chkSettings.Length; i++)
            {
                string value = set.getSetting(chkSettings[i]);

                if (value == null)
                    chkBoxes[i].CheckState(chkDefaults[i]);
                else
                    chkBoxes[i].CheckState(value == "True");
            }

            // Password length
            if (int.TryParse(set.getSetting("07x0002"), out int length))
                passwordLength = length;

            updateLength(new Tuple<int, int, int>(passwordLength, lengthRange[0], lengthRange[1]));
        }

        /// <summary>
        /// Saves the settings
        /// </summary>
        public void saveSettings()
        {
            // Language
            set.setSetting("07x0000", selectedLanguage);

            // Keep me logged
            set.setSetting("07x0001", chkKeepLogged.CheckState().ToString());

            // Password length
            set.setSetting("07x0002", passwordLength.ToString());

            // Uppercase
            set.setSetting("07x0003", chkUppercase.CheckState().ToString());

            // Numbers
            set.setSetting("07x0004", chkNumbers.CheckState().ToString());

            // Symbols
            set.setSetting("07x0005", chkSymbols.CheckState().ToString());

            // Copy
            set.setSetting("07x0006", chkCopy.CheckState().ToString());

            // Location
            set.setSetting("07x0007", txtLocation.Text.ToString());

            // Saving the settings
            set.saveSettings();
        }

        /// <summary>
        /// Returns the setting from an ID
        /// </summary>
        /// <param name="ID">ID of the setting</param>
        /// <returns>Value as string</returns>
        public string getSetting(string ID)
        {
            return set.getSetting(ID);
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // Buttons
            btnApply.Image = loadIcon("complete");
            btnDefaults.Image = loadIcon("default");

            pcbLanguage.Image = loadIcon("language");
            pcbTheme.Image = loadIcon("theme");
            pcbAuthentication.Image = loadIcon("authentication");
            pcbGeneration.Image = loadIcon("password");
            pcbBehaviour.Image = loadIcon("behaviour");
            pcbDatabase.Image = loadIcon("database");
            pcbLocation.Image = loadIcon("location");
            pcbBackup.Image = loadIcon("backup");
        }

        ///////////////////////////////////////////////////////////////
        /// MISCELLANEOUS FUNCTIONS

        /// <summary>
        /// Loads a base64 image
        /// </summary>
        /// <param name="String64">Base64 strings</param>
        /// <returns>Image as an image</returns>
        private Image Load64Image(string String64)
        {
            byte[] bytes = null;
            try { bytes = Convert.FromBase64String(String64); }
            catch { bytes = Convert.FromBase64String("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"); }

            Image image;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        /// <summary>
        /// Maps a value
        /// </summary>
        /// <param name="value">Source Value</param>
        /// <param name="fromLow">Lowest point of source</param>
        /// <param name="fromHigh">Highest point of source</param>
        /// <param name="toLow">Lowest point of destination</param>
        /// <param name="toHigh">Highest point of destination</param>
        /// <returns>Mapped value as integer</returns>
        private static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        /// <summary>
        /// Returns the string with singular form or plural form
        /// </summary>
        /// <param name="count">The value</param>
        /// <param name="singularForm">Singular form of the string</param>
        /// /// <param name="pluralForm">PLural form of the string</param>
        /// <returns></returns>
        private string countString(int count, string singularForm, string pluralForm)
        {
            // If the value is one, we concatanate and return the singular form,
            // otherwise the plural form
            if (count == 1)
                return LanguageManagement.parse(lang.get("07x0040"), new string[] { count.ToString(), singularForm });
            else
                return LanguageManagement.parse(lang.get("07x0040"), new string[] { count.ToString(), pluralForm });
        }

        /// <summary>
        /// Loads the icons from the file system
        /// </summary>
        /// <param name="names">Array of names of the icons to load</param>
        private Image loadIcon(string name)
        {
            Image icon = null; // Create a new icons

            // For each of these items, we load that icon from file system
            try
            { icon = Image.FromFile(myLocation + "/resources/" + name + ".png"); }
            catch (Exception) { icon = pcbAuthentication.ErrorImage; }

            return icon;
        }
    }
}
