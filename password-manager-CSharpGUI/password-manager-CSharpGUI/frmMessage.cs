/*
 *                              MESSAGE FORM
 *                      
 *       Displays the message sent by another form to the user
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
    /// <summary>
    /// This form displays messages to the user that is sent by another form
    /// </summary>
    public partial class frmMessage : Form
    {
        // Location of core files
        public static string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Loading strings
        public string selectedLanguage = "English"; // MUST BE LOADED FROM PREFERENCES
        public LanguageManagement lang = new LanguageManagement();

        // List of icons available
        // { Success, Error, Question, Warning, Error } 
        public Image[] icons = null;

        private DialogResult result = DialogResult.OK; // Selection of the User

        /// <summary>
        /// Displays a message sent by another form
        /// </summary>
        /// <param name="parent">Parent form that called this form</param>
        /// <param name="topic">Topic to be displayed in bold</param>
        /// <param name="message">Message to be displayed</param>
        /// <param name="_selectedLanguage">Language selected</param>
        /// <param name="icon">Icon to be displayed on top left</param>
        /// <param name="buttons">Buttons to be enabled</param>
        public frmMessage(Form parent, string topic, string message, string _selectedLanguage = "English", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();

            loadIcons(); // Loading the icons

            // Title, topic, message and the selected icon
            this.Text = parent.Text;
            this.Icon = parent.Icon;
            lblTitle.Text = topic;
            lblMessage.Text = message;
            pcbIcon.Image = icons[((int)icon / 16)];

            selectedLanguage = _selectedLanguage; // Selected language

            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("02");

            // Load buttons
            loadButtons(buttons);
        }

        /// <summary>
        /// Displays a message sent by another form
        /// </summary>
        /// <param name="parent">Parent form that called this form</param>
        /// <param name="topic">Topic to be displayed in bold</param>
        /// <param name="message">Message to be displayed</param>
        /// <param name="_selectedLanguage">Language selected</param>
        /// <param name="icon">Icon to be displayed on top left</param>
        /// <param name="buttons">Buttons to be enabled</param>
        public frmMessage(Form parent, string topic, string message, Image icon, string _selectedLanguage = "English", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();

            loadIcons(); // Loading the icons

            // Title, topic, message and the selected icon
            this.Text = parent.Text;
            this.Icon = parent.Icon;
            lblTitle.Text = topic;
            lblMessage.Text = message;
            pcbIcon.Image = icon;

            selectedLanguage = _selectedLanguage; // Selected language

            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("02");

            // Load buttons
            loadButtons(buttons);
        }

        /// <summary>
        /// Form loading
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private void frmMessage_Load(object sender, EventArgs e)
        {
            // Resizing according to the text
            this.ClientSize = new Size(this.Width, lblMessage.Location.Y + lblMessage.Height + btnOne.Height + 60);
        }

        /// <summary>
        /// Click event that is called by both buttons
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private new void Click(object sender, EventArgs e)
        {
            // Sets the appropriate DialogResult and exit
            if (((Button)sender).Text == "Ok")
                result = DialogResult.OK;
            else if (((Button)sender).Text == "Cancel")
                result = DialogResult.Cancel;
            else if (((Button)sender).Text == "No")
                result = DialogResult.No;
            else if (((Button)sender).Text == "Yes")
                result = DialogResult.Yes;

            this.Close();

        }

        /// <summary>
        /// When tooltip is displayed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if ((sender == btnOne) && (btnOne.Text == "Cancel")) // If button one is Cancel
                tltMain.ToolTipTitle = lang.get("02x0002");
            else if ((sender == btnOne) && (btnOne.Text == "No")) // If button one is No
                tltMain.ToolTipTitle = lang.get("02x0006");
            else if ((sender == btnOne) && (btnOne.Text == "Ok")) // If button one is Ok
                tltMain.ToolTipTitle = lang.get("02x0000");
            else if ((sender == btnTwo) && (btnTwo.Text == "Ok")) // If button two is Ok
                tltMain.ToolTipTitle = lang.get("02x0000");
            else if ((sender == btnTwo) && (btnTwo.Text == "Yes")) // If button two is Ok
                tltMain.ToolTipTitle = lang.get("02x0004");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        /// <summary>
        /// Returns the result selected by the user
        /// </summary>
        /// <returns>Result as DialogResult</returns>
        public DialogResult getResult()
        {
            return result;
        }

        /// <summary>
        /// Loads the buttons
        /// </summary>
        /// <param name="buttons">Buttons as MessageBoxButtons</param>
        private void loadButtons(MessageBoxButtons buttons)
        {
            // Enabling the buttons according to the selection of the client
            if (buttons == MessageBoxButtons.OKCancel)
            {
                btnOne.Text = "Cancel";
                btnTwo.Text = "Ok";
                result = DialogResult.Cancel;
                tltMain.SetToolTip(btnOne, lang.get("02x0003"));
                tltMain.SetToolTip(btnTwo, lang.get("02x0001"));
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnOne.Text = "No";
                btnTwo.Text = "Yes";
                result = DialogResult.No;
                tltMain.SetToolTip(btnOne, lang.get("02x0007"));
                tltMain.SetToolTip(btnTwo, lang.get("02x0005"));
            }
            else
            {
                btnOne.Text = "Ok";
                btnTwo.Hide();
                tltMain.SetToolTip(btnOne, lang.get("02x0001"));
            }
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // List Icons
            icons = new Image[] { loadIcon("success"), loadIcon("error"), loadIcon("question"), loadIcon("warning"), loadIcon("information") };
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
            catch (Exception) { icon = pcbIcon.ErrorImage; }

            return icon;
        }
    }
}
