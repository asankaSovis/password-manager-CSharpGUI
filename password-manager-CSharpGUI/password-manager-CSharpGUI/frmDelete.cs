/*
 *                              DELETE PASSWORD FORM
 *                      
 *       This form is the form that handle the deletion of a profile 
 *       in the database
 */

/// NOTE: Username and profile, platform and website are used interchangeably
/// 
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
    public partial class frmDelete : Form
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
        Image mainIcon = null; // Icon of the main done button (AddIcon if Add, EditIcon if Edit)
        Image[] loading = null; // Loading icons { Loading, Success, Fail }

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        // Status of the password
        // { Status (True: Working, False: Not working), Success (0: Success,
        // 1: Not exist for Edit Password, 2: Failed for unknown reason) }
        public Tuple<bool, int> taskStatus = new Tuple<bool, int>(false, 2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_parent"></param>
        /// <param name="_passcode"></param>
        /// <param name="platform"></param>
        /// <param name="username"></param>
        public frmDelete(frmMain _parent, string _passcode, string platform, string username)
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

            loadIcons(); // Loading iconss

            spcButton.Panel2Collapsed = true;
            spcButton.Panel1Collapsed = false;
        }

        /// <summary>
        /// Main timer tick
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If image of delete button is not default
            if (btnDelete.Image != mainIcon)
            {
                // We set the default image and stop the timer
                btnDelete.Image = mainIcon;
                tmrMain.Stop();

                // If the status is set to 0 (Success), we know that the deletion
                // was successful and thus we close the form
                if (taskStatus.Item2 == 0)
                    this.Close();
            }

            // Everytime we run this function, we rotate the loading animation and reapply
            // it to the fake delete button label
            loading[0].RotateFlip(RotateFlipType.Rotate90FlipNone);
            lblDelete.Image = loading[0];

            // If the first item of task status is true, we know that the background
            // work is complete
            if (taskStatus.Item1)
            {
                // If so, we hide the button and replace it with the fake button label
                spcButton.Panel2Collapsed = taskStatus.Item1;

                // If the status is set to 0(Successful), the login is successful
                if (taskStatus.Item2 == MuragalaLibrary.error_list.success)
                {
                    // We set the success image on button and set the password
                    btnDelete.Image = loading[2];
                    //success = true;
                }
                else
                {
                    // Otherwise we set the error image, enable controls and show error
                    btnDelete.Image = loading[1];
                    if (taskStatus.Item2 == MuragalaLibrary.error_list.non_existent_platform)
                        tltMain.Show(lang.get("05x0008"), btnDelete);
                    else if (taskStatus.Item2 == MuragalaLibrary.error_list.non_existent_username)
                        tltMain.Show(lang.get("05x0009"), btnDelete);
                    else
                        tltMain.Show(lang.get("05x0010"), btnDelete);
                }

                // We set the status to not authenticating
                taskStatus = new Tuple<bool, int>(false, taskStatus.Item2);

                Cursor = DefaultCursor; // Reset the cursor
            }

            this.Refresh(); // Refresh the form
        }

        /// <summary>
        /// Click on the Delete password
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting; // Change the cursor

            // Reset password status
            taskStatus = new Tuple<bool, int>(false, 2);

            // Change to loading animation
            lblDelete.Image = loading[0];

            // Hide button and show fake button label
            spcButton.Panel1Collapsed = true;

            tmrMain.Start(); // Start timer
            bgwMain.RunWorkerAsync(); // Start the delete background task
        }

        /// <summary>
        /// Background worker
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            // Deletes the password and set the status
            int errorCode = parent.deleteProfile(passcode, txtPlatform.Text, txtUsername.Text);
            taskStatus = new Tuple<bool, int>(true, errorCode);
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == txtPlatform) // Platform Textbox
                tltMain.ToolTipTitle = lang.get("05x0005");
            else if (e.AssociatedControl == txtUsername) // Username Textbox
                tltMain.ToolTipTitle = lang.get("05x0007");
            else if (e.AssociatedControl == btnDelete) // Delete Button
                tltMain.ToolTipTitle = lang.get("05x0002");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        ///////////////////////////////////////////////////////////////
        /// PRIMARY FUNCTIONS

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // List Icons
            loading = new Image[] { loadIcon("loading"), loadIcon("cross"), loadIcon("tick") };

            // Buttons
            mainIcon = btnDelete.Image = loadIcon("delete");

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
            lang.loadStrings("05");

            // This form
            this.Text = LanguageManagement.parse(lang.get("05x0000"), new string[] { txtPlatform.Text, txtUsername.Text });
            lblDelete.Text = btnDelete.Text = lang.get("05x0001");

            // Tooltips
            tltMain.SetToolTip(btnDelete, lang.get("05x0003"));
            tltMain.SetToolTip(lblDelete, lang.get("05x0003"));

            // Tooltips
            tltMain.SetToolTip(txtPlatform, lang.get("05x0005"));
            tltMain.SetToolTip(txtUsername, lang.get("05x0007"));
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
    }
}
