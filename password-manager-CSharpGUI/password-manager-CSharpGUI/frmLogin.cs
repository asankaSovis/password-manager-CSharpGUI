/*
 *                              LOGIN FORM
 *                      
 *       This form logs a user in. It accepts the password, authenticate the user and sends
 *       it to the main form
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

namespace password_manager_CSharpGUI
{
    public partial class frmLogin : Form
    {
        // Location of core files
        public static string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Loading strings
        public string selectedLanguage = "English"; // MUST BE LOADED FROM PREFERENCES
        public LanguageManagement lang = new LanguageManagement();

        frmMain parent = null; // Parent form

        // Icons
        Image[] lockIcons = null;
        Image[] showIcons = null;
        Image[] loading = null;
        Image loginIcon = null;

        // Status of the password
        // { Authenticating, Validity }
        Tuple<bool, bool> passwordStatus = new Tuple<bool, bool>(false, false);

        // Authenticated password (Empty if not authenticated)
        string password = "";

        /// <summary>
        /// This form accepts the password from the user in order to log the user
        /// into the system.
        /// </summary>
        /// <param name="_parent">Parent form as frmMain</param>
        public frmLogin(frmMain _parent)
        {
            InitializeComponent();

            parent = _parent; // Parent

            // Setting up the interface from parent
            this.ShowInTaskbar = !parent.Visible;
            this.Icon = parent.Icon;
            selectedLanguage = parent.selectedLanguage; // Language selection

            // Loading strings
            loadStrings();

            // Loading icons
            loadIcons();

            // Drawing user profile
            drawUser();
            lblUser.Text = Environment.UserName.ToUpper();

            // Enabling/disabling controls
            chkKeep.Checked = false; chkShow.Checked = false;
            spcButton.Panel2Collapsed = true;
            spcButton.Panel1Collapsed = false;
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
                tltMain.Show(lang.get("03x0011"), btnLogin);
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// When user type in the text box
        /// </summary>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // If the textbox is not empty and text is set to hide, we hide the
            // text
            txtPassword.UseSystemPasswordChar = (!chkShow.Checked && !txtPassword.WatermarkActive);

            // We enable the login button if user has entered text or the text contain a space
            // NOTE: The watermark text is also a text and can be counted, since we anyway don't
            //       allow passwords to have spaces, we surely know that the text is the watermark
            //       if it contains a space
            btnLogin.Enabled = ((txtPassword.Text.Length > 0) && (!txtPassword.Text.Contains(" ")));

        }

        /// <summary>
        /// Check/uncheck the keep button
        /// Checking this will leave the user logged in
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguements</param>
        private void chkKeep_CheckedChanged(object sender, EventArgs e)
        {
            // Just change the icon
            if (chkKeep.Checked)
                chkKeep.Image = lockIcons[1];
            else
                chkKeep.Image = lockIcons[0];
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
            txtPassword.UseSystemPasswordChar = (!chkShow.Checked && !txtPassword.WatermarkActive);

            // We change the icons according to the state
            if (chkShow.Checked)
                chkShow.Image = showIcons[0];
            else
                chkShow.Image = showIcons[1];
        }

        /// <summary>
        /// Timer ticks and checks for the progress
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If image of login button is not default and status 1 is set to false
            if (!(btnLogin.Image == loginIcon) && !passwordStatus.Item1)
            {
                // We set the default image and stop the timer
                btnLogin.Image = loginIcon;
                tmrMain.Stop();

                // If the password text is also set, we know that the authentication
                // was successful and thus we close the form
                if (txtPassword.Text != "")
                    this.Close();
            }

            // Everytime we run this function, we rotate the loading animation and reapply
            // it to the fake login button label
            loading[0].RotateFlip(RotateFlipType.Rotate90FlipNone);
            lblLogin.Image = loading[0];

            // If the first item of password status is true, we know that the background
            // work is complete
            if (passwordStatus.Item1)
            {
                // If so, we hide the button and replace it with the fake button label
                spcButton.Panel2Collapsed = passwordStatus.Item1;

                // If the item 2 is set to true, the login is successful
                if (passwordStatus.Item2)
                {
                    // We set the success image on button and set the password
                    btnLogin.Image = loading[2];
                    password = txtPassword.Text;
                }
                else
                {
                    // Otherwise we set the error image and explicitly set the password
                    // to be empty and enable the controls again
                    btnLogin.Image = loading[1];
                    tltMain.Show(lang.get("03x0012"), btnLogin);
                    txtPassword.Text = "";
                    enable(true);
                }

                // We set the status to not authenticating
                passwordStatus = new Tuple<bool, bool>(false, true);

                bgwPassword.CancelAsync(); // Cancel the worker just in case
                Cursor = DefaultCursor; // Reset the cursor
            }

            this.Refresh(); // Refresh the form
        }

        /// <summary>
        /// Background worker that does the authentication
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwPassword_DoWork(object sender, DoWorkEventArgs e)
        {
            // Call checkPassword function from parent and update the passwordStatus
            // according to the result
            passwordStatus = new Tuple<bool, bool>(true, parent.checkPassword(txtPassword.Text));
        }

        /// <summary>
        /// Authenticates and log a user in
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting; // Change the cursor

            // Reset password status
            passwordStatus = new Tuple<bool, bool>(false, false);

            // Disable all controls
            enable(false);

            // Change to login animation
            lblLogin.Image = loading[0];

            // Hide button and show fake button label
            spcButton.Panel1Collapsed = true;
            chkShow.Checked = false; // Hide password

            tmrMain.Start(); // Start timer
            bgwPassword.RunWorkerAsync(); // Start the authentication background task
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == chkShow) // Show/ Hide button
                tltMain.ToolTipTitle = lang.get("03x0003");
            else if (e.AssociatedControl == chkKeep) // Keep/Discard password button
                tltMain.ToolTipTitle = lang.get("03x0005");
            else if (e.AssociatedControl == txtPassword) // Password text
                tltMain.ToolTipTitle = lang.get("03x0007");
            else if (e.AssociatedControl == btnLogin) // Login button
                tltMain.ToolTipTitle = lang.get("03x0009");
            else if (e.AssociatedControl == lblLogin) // Fake login button label
                tltMain.ToolTipTitle = lang.get("03x0009");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        ///////////////////////////////////////////////////////////////
        /// LOADING FORM

        /// <summary>
        /// Draws the Profile image
        /// </summary>
        private void drawUser()
        {
            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(lblUser.Size.Width, lblUser.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            const int margin = 10; // Margin to keep from the edges of the picturebox
            // Width and height to be displayed
            int height = BitmapImage.Size.Height - (margin * 2);
            int width = BitmapImage.Size.Width - (margin * 2);

            // Draws the user profile image
            GraphicsFromImage.DrawImage(loadIcon("user"), ((width - height + (margin * 4)) / 2) + 10, 10, height - (margin * 4), height - (margin * 4));

            // Applying to the label
            lblUser.Image = BitmapImage;
        }

        /// <summary>
        /// Loads the strings needed for outputs and errors
        /// Loads the languages.json file and uses it to select the language and the strings
        /// from that relevant language file is loaded and then used
        /// </summary>
        private void loadStrings()
        {
            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("03");

            // Setting the strings
            // Control texts
            this.Text = lang.get("03x0000");
            btnLogin.Text = lblLogin.Text = lang.get("03x0002");
            txtPassword.ApplyWatermark(lang.get("03x0001"));

            // Tool tips
            tltMain.SetToolTip(chkShow, lang.get("03x0004"));
            tltMain.SetToolTip(chkKeep, lang.get("03x0006"));
            tltMain.SetToolTip(txtPassword, lang.get("03x0008"));
            tltMain.SetToolTip(btnLogin, lang.get("03x0010"));
            tltMain.SetToolTip(lblLogin, lang.get("03x0010"));
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // List Icons
            lockIcons = new Image[] { loadIcon("lock"), loadIcon("unlock") };
            showIcons = new Image[] { loadIcon("show"), loadIcon("hide") };
            loading = new Image[] { loadIcon("loading"), loadIcon("cross"), loadIcon("tick") };

            // Buttons
            loginIcon = btnLogin.Image = loadIcon("login");
        }

        ///////////////////////////////////////////////////////////////
        /// RETURN FUNCTIONS

        /// <summary>
        /// Returns the authenticated password with lock state
        /// </summary>
        /// <returns>Password, lock state as tuple</returns>
        public Tuple<string, bool> getPassword()
        {
            return new Tuple<string, bool>(password, (chkKeep.Checked && (password != "")));
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
            chkShow.Enabled = chkKeep.Enabled = txtPassword.Enabled = state;
        }
    }
}
