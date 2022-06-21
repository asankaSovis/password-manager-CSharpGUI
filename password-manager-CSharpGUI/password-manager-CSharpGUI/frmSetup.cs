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

namespace password_manager_CSharpGUI
{
    public partial class frmSetup : Form
    {
        /// <summary>
        /// This is the form that sets up a new password to encrypt the database of the user
        /// </summary>
        
        // Location of the application
        string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        private string password = ""; // Password entered by the user

        int passwordStrength = 0; // Strength as returned by the password
        
        private Image[] icons = null; // Iconset to be used by the show/hide button { Show, Hide }

        /// <summary>
        /// Initializes the application
        /// This function will load the necessary components for the application
        /// to work
        /// </summary>
        public frmSetup(frmMain parent)
        {
            InitializeComponent();

            loadStrings(); // Loads the strings

            // Loads from parent
            selectedLanguage = parent.selectedLanguage;
            this.Icon = parent.Icon;

            psmMain.changePassword(password); // Sends an empty password to the Strength Meter to
            // update its content

            // Loads the icons
            try
            {
                icons = new Image[] { loadIcon("show"), loadIcon("hide") };
            } catch (Exception) { icons = new Image[] { SystemIcons.Error.ToBitmap(), SystemIcons.Error.ToBitmap() }; }
            btnDone.Image = loadIcon("complete");

            // Uncheck the show button
            chkShow.Checked = false;
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
                passwordStrength = psmMain.changePassword(txtType.Text);

            // We enable the proceed button if both texts are the same and strength is above 1
            btnDone.Enabled = (txtRetype.Text == txtType.Text && (passwordStrength > 1));

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
            btnDone.Enabled = ((txtRetype.Text == txtType.Text) && (passwordStrength > 1));
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
                else if (e.AssociatedControl == chkShow) // Show/Hide password button
                    tltMain.ToolTipTitle = lang.get("01x0023");
                else
                    tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
            }
            catch (Exception) { }
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
            Keys[] suppress = { Keys.Space, Keys.Enter };
            if (suppress.Contains(e.KeyCode))
            {
                tltMain.Show(lang.get("01x0038"), btnDone);
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// When Proceed button is pressed
        /// </summary>
        private void btnDone_Click(object sender, EventArgs e)
        {
            // We set the password to the password entered by the user and close the application
            // The reason why we do this here is because if the user did not click on proceed
            // and closed the form in another way, we must not accept the password entered
            if (txtType.Text == txtRetype.Text)
                password = txtType.Text;

            this.Close();
        }



        /// <summary>
        /// Returns the password the user has entered
        /// </summary>
        /// <returns>Password as string</returns>
        public string getPassword()
        {
            return password;
        }

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
    }
}
