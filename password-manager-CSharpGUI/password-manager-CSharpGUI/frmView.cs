/*
 *                              VIEW FORM
 *                      
 *       This form lets the user view the profile information for that particular
 *       website and profile selected
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
    public partial class frmView : Form
    {
        /// <summary>
        /// This form is the form that handle the deletion of a profile 
        /// in the database
        /// </summary>
        frmMain parent = null; // Parent form
        string passcode = ""; // Authentication passcode

        // Location of the application
        string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Icons
        Image copyIcon = null; // Icon of the copy button
        Image[] loading = null; // Loading icons { Loading, Success, Fail }

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        // Strings
        private string[] loadingStrings = null; // Loading strings

        // Password data
        public List<string> passwordData = new List<string>();

        private int next = 0; // Option selected by the user when closing
        // { None, Open edit, Open delete }

        const int spcPanelHeight = 199; // Fixed height of the Advanced panel

        /// <summary>
        /// View form that displays the password
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="_passcode">Authentication passcode</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        public frmView(frmMain _parent, string _passcode, string platform, string username)
        {
            InitializeComponent();

            parent = _parent;
            passcode = _passcode;

            this.Icon = parent.Icon;

            selectedLanguage = parent.selectedLanguage; // Language selection

            // Adding the platform and username to textboxes
            txtPlatform.Text = platform;
            txtUsername.Text = username;

            // Loading strings
            loadStrings();

            loadIcons(); // Loading icons

            spcPassword.Panel2Collapsed = true; // Collapse the password panel so that
            // the loading label is shown

            // Running the BGW to load the information and starting the timer
            bgwWork.RunWorkerAsync();
            tmrMain.Start();
        }

        /// <summary>
        /// Loading the view form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void frmView_Load(object sender, EventArgs e)
        {
            // Perform a click on btnCollapse to hide the advanced panel and
            // disable that button
            // NOTE: The reason why we need this is because in frmView, all controls
            //       are not yet loaded to memory
            btnCollapse.PerformClick();
            btnCollapse.Enabled = false;
        }

        /// <summary>
        /// Returns the user preference (Open edit form next, delete form next or none)
        /// </summary>
        /// <returns>Preference as int (0: none, 1: Open Edit, 2: Open Delete</returns>
        public int getNext()
        {
            return next;
        }

        /// <summary>
        /// Returns the loaded password
        /// </summary>
        /// <returns>Password as string</returns>
        public string getPassword()
        {
            return txtPassword.Text;
        }


        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == btnCollapse) // Collapse button
                tltMain.ToolTipTitle = lang.get("06x0002");
            else if (e.AssociatedControl == btnCopy) // Copy button
                tltMain.ToolTipTitle = lang.get("06x0004");
            else if (e.AssociatedControl == btnDelete) // Delete Button
                tltMain.ToolTipTitle = lang.get("06x0006");
            else if (e.AssociatedControl == btnEdit) // Edit button
                tltMain.ToolTipTitle = lang.get("06x0008");
            else if (e.AssociatedControl == txtPlatform) // Platform textbox
                tltMain.ToolTipTitle = lang.get("06x0010");
            else if (e.AssociatedControl == txtUsername) // Username textbox
                tltMain.ToolTipTitle = lang.get("06x0012");
            else if (e.AssociatedControl == txtPassword) // Password textbox
                tltMain.ToolTipTitle = lang.get("06x0014");
            else if (e.AssociatedControl == lblDate) // Date label
                tltMain.ToolTipTitle = lang.get("06x0016");
            else if (e.AssociatedControl == btnDone) // Done Button
                tltMain.ToolTipTitle = lang.get("06x0043");
            else if (e.AssociatedControl == btnVisit) // Visit Button
                tltMain.ToolTipTitle = lang.get("06x0045");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        /// <summary>
        /// Timer
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

            // If the label string says Done but the label panel is still not collapsed
            // we set the password to text, date to text, set password in PSM, collapse the
            // panel, enable the buttons, stop the timer and set the default cursor
            if ((lblMessage.Text == loadingStrings[1]) && (spcPassword.Panel2Collapsed))
            {
                txtPassword.Text = passwordData[0];
                lblDate.Text = passwordData[1];
                psmMain.changePassword(txtPassword.Text);
                spcPassword.Panel1Collapsed = true;
                enableButtons(true);
                tmrMain.Stop();
                Cursor = DefaultCursor;
            }

            // If the BGW is busy, we keep rotating the loading icon and refresh the form
            if (bgwWork.IsBusy)
            {
                lblMessage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.Refresh();
            }
            else // Otherwise we set the errors
            {
                if (passwordData.Count == 0)
                {
                    // If passwordData contain data, we mark it as success
                    lblMessage.Text = loadingStrings[0];
                    lblMessage.Image = loading[1];
                }
                else
                {
                    // Otherwise error
                    lblMessage.Text = loadingStrings[1];
                    lblMessage.Image = loading[2];
                }
            }
        }

        /// <summary>
        /// Background worker
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwWork_DoWork(object sender, DoWorkEventArgs e)
        {
            // Loads the password information from the library on main form
            passwordData = parent.viewProfile(passcode, txtPlatform.Text, txtUsername.Text);
        }

        // Buttons
        /// <summary>
        /// Collapse button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            // If the panel is collapsed, we set the icon to up arrow and adjust the size
            // otherwise opposite
            if (spcMore.Panel1Collapsed)
            {
                btnCollapse.Text = "🔼";
                this.Size = new Size(this.Size.Width, this.Size.Height + spcPanelHeight);
            }
            else
            {
                btnCollapse.Text = "🔽";
                this.Size = new Size(this.Size.Width, this.Size.Height - spcPanelHeight);
            }

            // Oppose the collapse state
            spcMore.Panel1Collapsed = !spcMore.Panel1Collapsed;
        }

        /// <summary>
        /// Copy button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Copies the password and change copy image
            Clipboard.SetText(txtPassword.Text);
            btnCopy.Image = loading[2];
            tmrMain.Start();
        }

        /// <summary>
        /// Edit button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // We set the next state to 1 (Edit when closed) and close the form
            next = 1;
            this.Close();
        }

        /// <summary>
        /// Delete button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // We set the next state to 2 (Delete when closed) and close
            next = 2;
            this.Close();
        }

        /// <summary>
        /// Done button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close(); // Simply close the form
        }

        /// <summary>
        /// Visit button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnVisit_Click(object sender, EventArgs e)
        {
            // TODO: Implement a way to visit the website
            parent.comingSoon();
        }

        ///////////////////////////////////////////////////////////////
        /// PRIMARY FUNCTIONS

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // Icon Lists
            // List Icons
            loading = new Image[] { loadIcon("loading"), loadIcon("cross"), loadIcon("tick") };

            // Label Icons
            lblMessage.Image = loading[0];
            lblDate.Image = loadIcon("calendar");

            // Buttons
            btnDone.Image = loadIcon("complete");
            btnCopy.Image = copyIcon = loadIcon("copy");
            btnEdit.Image = loadIcon("edit");
            btnDelete.Image = loadIcon("delete");
            btnVisit.Image = loadIcon("visit");

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
            lang.loadStrings("06");

            // This form
            this.Text = LanguageManagement.parse(lang.get("06x0000"), new string[] { txtPlatform.Text, txtUsername.Text });
            btnDone.Text = lang.get("06x0001");

            // Strings of PSM
            List<string> PSMStrings = new List<string>();
            string[] stringIDs = { "06x0018", "06x0019", "06x0020", "06x0021", "06x0022", "06x0023",
            "06x0024", "06x0025", "06x0026", "06x0027", "06x0028", "06x0029", "06x0030", "06x0031",
            "06x0032", "06x0033", "06x0034", "06x0035", "06x0036", "06x0037", "06x0038", "06x0039",
            "06x0040", "06x0041", "06x0042"};
            foreach (var item in stringIDs)
            { PSMStrings.Add(lang.get(item)); }

            psmMain.setText(PSMStrings.ToArray());
            psmMain.updateTooltips();

            // Tooltips
            tltMain.SetToolTip(btnCollapse, lang.get("06x0003"));
            tltMain.SetToolTip(btnCopy, lang.get("06x0005"));
            tltMain.SetToolTip(btnDelete, lang.get("06x0007"));
            tltMain.SetToolTip(btnEdit, lang.get("06x0009"));
            tltMain.SetToolTip(btnDone, lang.get("06x0044"));
            tltMain.SetToolTip(btnDone, lang.get("06x0044"));

            // Tooltips
            tltMain.SetToolTip(txtPlatform, lang.get("06x0011"));
            tltMain.SetToolTip(txtUsername, lang.get("06x0013"));
            tltMain.SetToolTip(txtPassword, lang.get("06x0015"));
            tltMain.SetToolTip(btnVisit, LanguageManagement.parse(lang.get("06x0046"), txtPlatform.Text));

            // Loading strings
            lblMessage.Text = lang.get("06x0047");
            loadingStrings = new string[]{ lang.get("06x0048"), lang.get("06x0049") };
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
        /// Enables/Disables the buttons
        /// </summary>
        /// <param name="enable">Enable(True)/Disable(False) as bool</param>
        private void enableButtons(bool enable)
        {
            btnCollapse.Enabled = btnCopy.Enabled = btnDelete.Enabled = 
                btnDone.Enabled = btnEdit.Enabled = btnVisit.Enabled = enable;
        }
    }
}
