/*
 *                              SETUP FORM
 *                      
 *       This form sets up a new password to encrypt the database of the user
 */

/// NOTE: Username and profile, platform and website are used interchangeably
/// PSM - Password Strength Meter

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
    public partial class frmSetup : Form
    {
        /// <summary>
        /// This is the form that sets up a new password to encrypt the database of the user
        /// </summary>
        
        // Location of the application
        string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Parent form
        frmMain parent = null;

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        // Status of the password
        // { Creating, Success }
        Tuple<bool, bool> passwordStatus = new Tuple<bool, bool>(false, false);
        int passwordStrength = 0; // Strength as returned by the password
        
        // Icons
        private Image[] icons = null; // Iconset to be used by the show/hide button { Show, Hide }
        private Image setupIcon = null; // Icon on the Done button
        private Image[] loading = null; // Loading animation

        /// <summary>
        /// Initializes the application
        /// This function will load the necessary components for the application
        /// to work
        /// </summary>
        public frmSetup(frmMain _parent)
        {
            InitializeComponent();

            loadStrings(); // Loads the strings

            // Loads from parent
            parent = _parent;
            selectedLanguage = parent.selectedLanguage;
            this.Icon = parent.Icon;

            psmMain.changePassword(""); // Sends an empty password to the Strength Meter to
            // update its content

            // Loads the icons
            loadIcons();

            // Uncheck the show button
            chkShow.Checked = false;

            // Collapse button labels
            spcButton.Panel2Collapsed = true;
            spcButton.Panel1Collapsed = false;

            pcbMain.Load(myLocation + "\\tutorial\\setup.png");
        }

        /// <summary>
        /// When checkstate of Show/Hide button is changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            // We enable password char if textboxes are empty
            // NOTE: This is because when the textbox is empty, we show a watermar text
            txtType.UseSystemPasswordChar = (!chkShow.Checked && !txtType.WatermarkActive);
            txtRetype.UseSystemPasswordChar = (!chkShow.Checked && !txtRetype.WatermarkActive);

            // We change the icons according to the state
            if (chkShow.Checked)
                chkShow.Image = icons[0];
            else
                chkShow.Image = icons[1];
        }

        /// <summary>
        /// When user type in the text box
        /// </summary>
        private void txtType_TextChanged(object sender, EventArgs e)
        {
            // If the textbox is not empty and text is set to hide, we hide the
            // text
            txtType.UseSystemPasswordChar = (!chkShow.Checked && !txtType.WatermarkActive);

            // If the watermark is active, we send an empty string, otherwise we send
            // the contents of the typing password
            // NOTE: This is because when the textbox is empty, we show a watermar text
            if (txtType.WatermarkActive)
                passwordStrength = psmMain.changePassword(" ");
            else
                passwordStrength = psmMain.changePassword(txtType.MainText);

            // We enable the proceed button if both texts are the same and strength is above 1
            btnDone.Enabled = ((txtRetype.MainText == txtType.MainText) && (passwordStrength > 1));

        }

        /// <summary>
        /// When user type in the password reenter textbox
        /// </summary>
        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            // If the textbox is not empty and text is set to hide, we hide the
            // text
            txtRetype.UseSystemPasswordChar = (!chkShow.Checked && !txtRetype.WatermarkActive);

            // We enable the proceed button if both texts are the same and strength is above 1
            btnDone.Enabled = ((txtRetype.MainText == txtType.MainText) && (passwordStrength > 1));
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            try
            {
                if (e.AssociatedControl == txtType) // Password textbox
                    tltMain.ToolTipTitle = lang.get("01x0017");
                else if (e.AssociatedControl == txtRetype) // Reenter password textbox
                    tltMain.ToolTipTitle = lang.get("01x0019");
                else if (e.AssociatedControl == btnDone) // Proceed button
                    tltMain.ToolTipTitle = lang.get("01x0021");
                else if (e.AssociatedControl == lblDone) // Proceed button Label
                    tltMain.ToolTipTitle = lang.get("01x0021");
                else if (e.AssociatedControl == chkShow) // Show/Hide password button
                    tltMain.ToolTipTitle = lang.get("01x0023");
                else
                    tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
            }
            catch (Exception) { }
        }

        /// <summary>
        /// When Proceed button is pressed
        /// </summary>
        private void btnDone_Click(object sender, EventArgs e)
        {
            // We set the password to the password entered by the user and close the application
            // The reason why we do this here is because if the user did not click on proceed
            // and closed the form in another way, we must not accept the password entered
            if (txtType.MainText == txtRetype.MainText)
            {
                Cursor = Cursors.AppStarting; // Change the cursor

                // Reset password status
                passwordStatus = new Tuple<bool, bool>(false, false);

                // Disable all controls
                enable(false);

                // Change to login animation
                lblDone.Image = loading[0];

                // Hide button and show fake button label
                spcButton.Panel1Collapsed = true;
                chkShow.Checked = false; // Hide password

                bgwMain.RunWorkerAsync(); // Run BGW
                tmrMain.Start(); // Start timer
            }

            //this.Close();
        }

        /// <summary>
        /// Timer ticks and checks for the progress
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If image of setup button is not default and status 1 is set to false
            if ((btnDone.Image != setupIcon) && !passwordStatus.Item1)
            {
                // We set the default image and stop the timer
                btnDone.Image = setupIcon;
                tmrMain.Stop();

                // If the password text is also set, we know that the setup
                // was successful and thus we close the form
                if (passwordStatus.Item2)
                    this.Close();
            }

            // Everytime we run this function, we rotate the loading animation and reapply
            // it to the fake setup button label
            loading[0].RotateFlip(RotateFlipType.Rotate90FlipNone);
            lblDone.Image = loading[0];

            // If the first item of password status is true, we know that the background
            // work is complete
            if (passwordStatus.Item1)
            {
                // If so, we hide the button and replace it with the fake button label
                spcButton.Panel2Collapsed = passwordStatus.Item1;

                // If the item 2 is set to true, the login is successful
                if (passwordStatus.Item2)
                {
                    // We set the success image on button
                    btnDone.Image = loading[2];
                }
                else
                {
                    // Otherwise we set the error image and explicitly set the password
                    // to be empty and enable the controls again
                    btnDone.Image = loading[1];
                    tltMain.Show(lang.get("01x0039"), btnDone);
                    txtType.MainText = txtRetype.MainText = "";
                    enable(true);
                }

                // We set the status to not working
                passwordStatus = new Tuple<bool, bool>(false, passwordStatus.Item2);

                bgwMain.CancelAsync(); // Cancel the worker just in case
                Cursor = DefaultCursor; // Reset the cursor
            }

            this.Refresh(); // Refresh the form
        }

        /// <summary>
        /// Suppresses the keypresses of invalid characters
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguements</param>
        private new void KeyDown(object sender, KeyEventArgs e)
        {
            // The following keys are rejected: Enter, Space
            // Shows a tooltip with warning
            Keys[] suppress = { Keys.Space };
            if (suppress.Contains(e.KeyCode))
            {
                tltMain.Show(lang.get("01x0038"), btnDone);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
                btnDone.PerformClick();
        }

        /// <summary>
        /// Runs the BGW to setup authentication
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            passwordStatus = new Tuple<bool, bool>(true, (parent.newPreference(txtType.Text) == MuragalaLibrary.error_list.success));
        }

        ///////////////////////////////////////////////////////////////
        /// MISCELLANEOUS FUNCTIONS

        /// <summary>
        /// Loads the text strings needed
        /// </summary>
        private void loadStrings()
        {
            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("01");

            // Strings of PSM
            List<string> PSMStrings = new List<string>();
            string[] stringIDs = { "01x0005", "01x0006", "01x0007", "01x0008", "01x0009", "01x0010",
            "01x0011", "01x0012", "01x0013", "01x0014", "01x0015", "01x0016", "01x0025", "01x0026",
            "01x0027", "01x0028", "01x0029", "01x0030", "01x0031", "01x0032", "01x0033", "01x0034",
            "01x0035", "01x0036", "01x0037"};
            foreach (var item in stringIDs)
            { PSMStrings.Add(lang.get(item)); }

            psmMain.setText(PSMStrings.ToArray());
            psmMain.updateTooltips();

            // This form
            this.Text = lang.get("01x0001");
            txtType.ApplyWatermark(lang.get("01x0002"));
            txtRetype.ApplyWatermark(lang.get("01x0003"));
            btnDone.Text = lang.get("01x0004");

            // Tooltips
            tltMain.SetToolTip(txtType, lang.get("01x0018"));
            tltMain.SetToolTip(txtRetype, lang.get("01x0020"));
            tltMain.SetToolTip(btnDone, lang.get("01x0022"));
            tltMain.SetToolTip(chkShow, lang.get("01x0024"));
        }

        /// <summary>
        /// Loads the icons
        /// </summary>
        private void loadIcons()
        {
            icons = new Image[] { loadIcon("show"), loadIcon("hide") };
            setupIcon = btnDone.Image = loadIcon("complete");

            loading = new Image[] { loadIcon("loading"), loadIcon("cross"), loadIcon("tick") };
        }

        /// <summary>
        /// Returns the setup status
        /// </summary>
        /// <returns>Success (True)/Fail (False) as bool</returns>
        public bool getStatus()
        {
            return passwordStatus.Item2;
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
            catch (Exception) { icon = SystemIcons.Error.ToBitmap(); }

            return icon;
        }

        /// <summary>
        /// Enable/Disable controls
        /// </summary>
        /// <param name="enabled">Enable (True)/Disable (False) as bool</param>
        private void enable(bool enabled)
        {
            btnDone.Enabled = chkShow.Enabled = txtType.Enabled = txtRetype.Enabled = enabled;
        }
    }
}
