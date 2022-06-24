/*
 *                              ADD PASSWORD FORM
 *                      
 *       This form is the form that handle both adding and editing of passwords
 *       to the database
 */

/// NOTE: Username and profile, platform and website are used interchangeably

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using password_manager_CSharpLibrary;

namespace password_manager_CSharpGUI
{
    public partial class frmAddPassword : Form
    {
        /// <summary>
        /// This form is the form that handle both adding and editing of passwords
        /// to the database
        /// </summary>

        frmMain parent = null; // Parent form
        bool mode = false; // Form mode { False: Add Password, True: Edit Password
        string passcode = ""; // Authentication passcode

        // Location of the application
        string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Icons
        Image mainIcon = null; // Icon of the main done button (AddIcon if Add, EditIcon if Edit)
        Image copyIcon = null; // Copy button icon
        Image[] loading = null; // Loading icons { Loading, Success, Fail }

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        // Status of the password
        // { Status (True: Working, False: Not working), Success (0: Success,
        // 1: Already exist for Add Password and not exist for Edit Password,
        // 2: Failed for unknown reason) }
        public Tuple<bool, int> taskStatus = new Tuple<bool, int>(false, 2);

        // Settings sent by parent
        Tuple<int, bool, bool, bool> settings = null;

        /// <summary>
        /// Initialize the form, add strings, icons and load settingss
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="_passcode">Authentication passcode</param>
        /// <param name="_mode">Mode Add or Edit</param>
        /// <param name="_settings">Settings</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        public frmAddPassword(frmMain _parent, string _passcode, bool _mode, Tuple<int, bool, bool, bool> _settings, string platform = "", string username = "", string password = "")
        {
            InitializeComponent();

            parent = _parent;
            mode = _mode;
            passcode = _passcode;
            settings = _settings;

            this.Icon = parent.Icon;

            selectedLanguage = parent.selectedLanguage; // Language selection

            // Adding the platform and username to textboxes
            txtPlatform.MainText = platform;
            if (mode)
                txtUsername.MainText = username;

            // Loading strings
            loadStrings();

            loadIcons(); // Loading iconss

            spcButton.Panel2Collapsed = true;
            spcButton.Panel1Collapsed = false;

            // Initialize the password generator control
            passwordGenerator.initialize(this, loadIcon("refresh"), new Image[] { loadIcon("switch-off"), loadIcon("switch-on") });

            // According to the mode, we set the password generator and text boxes
            if (mode)
            {
                passwordGenerator.setPassword(password);
                txtPlatform.ReadOnly = txtUsername.ReadOnly = true;
            }
            else
            {
                passwordGenerator.refreshSettings(new Tuple<int, bool, bool, bool>(settings.Item1, settings.Item2, settings.Item3, settings.Item4));
                passwordGenerator.refreshPassword();
            }
        }

        /// <summary>
        /// Load function of form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void frmAddPassword_Load(object sender, EventArgs e)
        {
            passwordGenerator.updateSlider(); // We update the slider
            // NOTE: We can't add this code to the initializer function
            //       because at that time, the form is not yet created
        }

        /// <summary>
        /// Main timer tick
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If the copy button is on check icon, we turn it back to copy
            // icon
            if (btnCopy.Image == loading[2])
            {
                btnCopy.Image = copyIcon;
                tmrMain.Stop();
            }

            // If image of add/edit button is not default
            if (btnApply.Image != mainIcon)
            {
                // We set the default image and stop the timer
                btnApply.Image = mainIcon;
                tmrMain.Stop();

                // If the status is set to 0 (Success), we know that the add/edit
                // was successful and thus we close the form
                if (taskStatus.Item2 == 0)
                    this.Close();
            }

            // Everytime we run this function, we rotate the loading animation and reapply
            // it to the fake add/edit button label
            loading[0].RotateFlip(RotateFlipType.Rotate90FlipNone);
            lblApply.Image = loading[0];

            // If the first item of task status is true, we know that the background
            // work is complete
            if (taskStatus.Item1)
            {
                // If so, we hide the button and replace it with the fake button label
                spcButton.Panel2Collapsed = taskStatus.Item1;

                // If the status is set to 0(Successful), the login is successful
                if (taskStatus.Item2 == 0)
                {
                    // We set the success image on button and set the password
                    btnApply.Image = loading[2];
                    //success = true;
                }
                else
                {
                    // Otherwise we set the error image, enable controls and show error
                    btnApply.Image = loading[1];
                    if (mode)
                    {
                        if (taskStatus.Item2 == MuragalaLibrary.error_list.non_existent_platform)
                            tltMain.Show(lang.get("04x0049"), btnApply);
                        else if (taskStatus.Item2 == MuragalaLibrary.error_list.non_existent_username)
                            tltMain.Show(lang.get("04x0050"), btnApply);
                        else if (taskStatus.Item2 == MuragalaLibrary.error_list.same_password_to_edit)
                            tltMain.Show(lang.get("04x0051"), btnApply);
                        else
                            tltMain.Show(lang.get("04x0052"), btnApply);
                    }
                    else
                    {
                        if (taskStatus.Item2 == 1)
                            tltMain.Show(lang.get("04x0047"), btnApply);
                        else
                            tltMain.Show(lang.get("04x0048"), btnApply);
                    }

                    enable(true);
                }

                // We set the status to not authenticating
                taskStatus = new Tuple<bool, int>(false, taskStatus.Item2);

                Cursor = DefaultCursor; // Reset the cursor
            }

            this.Refresh(); // Refresh the form
        }

        /// <summary>
        /// When button copy is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Copies the password and change copy image
            Clipboard.SetText(passwordGenerator.getPassword());
            btnCopy.Image = loading[2];
            tmrMain.Start();
        }

        /// <summary>
        /// Click on the Add password
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting; // Change the cursor

            // Reset password status
            taskStatus = new Tuple<bool, int>(false, 2);

            // Disable all controls
            enable(false);

            // Change to loading animation
            lblApply.Image = loading[0];

            // Hide button and show fake button label
            spcButton.Panel1Collapsed = true;

            tmrMain.Start(); // Start timer
            bgwAdd.RunWorkerAsync(); // Start the add/edit background task
        }

        /// <summary>
        /// Background worker
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            // Adds the password and set the status
            int errorCode = parent.addPassword(passcode, txtPlatform.MainText, txtUsername.MainText, passwordGenerator.getPassword());
            taskStatus = new Tuple<bool, int>(true, errorCode);
        }

        /// <summary>
        /// When user type in the text box
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        public void MyTextChanged(object sender, EventArgs e)
        {

            // We enable the Add/Edit button if both platform and username are provided
            // and the password length is > 0
            btnApply.Enabled = !((txtPlatform.MainText == "") || (txtUsername.MainText == "") || (passwordGenerator.getPassword().Length == 0));
        }

        /// <summary>
        /// Suppress the keypresses of invalid characters
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguements</param>
        private new void KeyDown(object sender, KeyEventArgs e)
        {
            // The following keys are rejected: Enter, Space
            // Shows a tooltip with warning
            Keys[] suppress = { Keys.Space, Keys.Enter };
            if (suppress.Contains(e.KeyCode))
            {
                //tltMain.Show(lang.get("03x0011"), btnAdd);
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == txtPlatform) // Platform Textbox
                tltMain.ToolTipTitle = lang.get("04x0006");
            else if (e.AssociatedControl == txtUsername) // Username Textbox
                tltMain.ToolTipTitle = lang.get("04x0008");
            else if (e.AssociatedControl == btnApply) // Add/Edit Button
                if (mode)
                    tltMain.ToolTipTitle = lang.get("04x0012");
                else
                    tltMain.ToolTipTitle = lang.get("04x0010");
            else if (e.AssociatedControl == btnCopy) // Copy Button
                tltMain.ToolTipTitle = lang.get("04x0014");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        ///////////////////////////////////////////////////////////////
        /// PRIMARY FUNCTIONS

        /// <summary>
        /// Returns a random password to the password generator
        /// </summary>
        /// <param name="size">Length of the password</param>
        /// <param name="uppercase">Enable uppercase</param>
        /// <param name="numbers">Enable numbers</param>
        /// <param name="symbols">Enable symbols</param>
        /// <returns>Returns a random password as string</returns>
        public string getRandomPassword(int size, bool uppercase, bool numbers, bool symbols)
        {
            return parent.getRandomPassword(size, uppercase, numbers, symbols);
        }

        /// <summary>
        /// Returns the platform info
        /// </summary>
        /// <returns>Tuple with Platform and username as string</returns>
        public Tuple<string, string> getPlatformInfo()
        {
            return new Tuple<string, string>(txtPlatform.Text, txtUsername.Text);
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // List Icons
            loading = new Image[] { loadIcon("loading"), loadIcon("cross"), loadIcon("tick") };

            // Buttons
            if (mode)
                mainIcon = btnApply.Image = loadIcon("edit");
            else
                mainIcon = btnApply.Image = loadIcon("add");
            copyIcon = btnCopy.Image = loadIcon("copy");

            // Profile
            pcbIcon.Image = loadIcon("user");
        }

        /// <summary>
        /// Loads the text strings needed
        /// </summary>
        private void loadStrings()
        {
            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("04");

            // Strings of Password generator
            List<string> PGStrings = new List<string>();
            string[] stringIDs = { "04x0016", "04x0017", "04x0018", "04x0019", "04x0020", "04x0021",
            "04x0022", "04x0023", "04x0024", "04x0025", "04x0026", "04x0027", "04x0028", "04x0029",
            "04x0030", "04x0031", "04x0032", "04x0033", "04x0034", "04x0035", "04x0036", "04x0037",
            "04x0038", "04x0039", "04x0040", "04x0041", "04x0042", "04x0043", "04x0044", "04x0045",
            "04x0046"};
            foreach (var item in stringIDs)
            { PGStrings.Add(lang.get(item)); }

            passwordGenerator.loadStrings(PGStrings.ToArray());

            // This form
            if (mode)
            {
                this.Text = LanguageManagement.parse(lang.get("04x0001"), new string[] { txtPlatform.Text, txtUsername.Text });
                lblApply.Text = btnApply.Text = lang.get("04x0005");

                // Tooltips
                tltMain.SetToolTip(btnApply, lang.get("04x0013"));
                tltMain.SetToolTip(lblApply, lang.get("04x0013"));
            } 
            else
            {
                this.Text = lang.get("04x0000");
                lblApply.Text = btnApply.Text = lang.get("04x0004");

                // Tooltips
                tltMain.SetToolTip(btnApply, lang.get("04x0011"));
                tltMain.SetToolTip(lblApply, lang.get("04x0011"));
            }
                
            
            txtPlatform.ApplyWatermark(lang.get("04x0002"));
            txtUsername.ApplyWatermark(lang.get("04x0003"));

            // Tooltips
            tltMain.SetToolTip(txtPlatform, lang.get("04x0007"));
            tltMain.SetToolTip(txtUsername, lang.get("04x0009"));
            tltMain.SetToolTip(btnCopy, lang.get("04x0015"));
        }

        ///////////////////////////////////////////////////////////////
        /// MISCELLANEOUS FUNCTIONS

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
            catch (Exception) { icon = SystemIcons.Error.ToBitmap(); }

            return icon;
        }

        /// <summary>
        /// Enable/Disable controls
        /// </summary>
        /// <param name="state"></param>
        private void enable(bool state)
        {
            txtPlatform.Enabled = txtUsername.Enabled = btnCopy.Enabled = passwordGenerator.Enabled = state;
        }
    }
}
