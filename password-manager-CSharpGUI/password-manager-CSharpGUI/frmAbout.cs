/*
 *                              ABOUT FORM
 *                      
 *       This form is the form that displays the information about
 *       the application
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
using System.Text.Json; // JSON Handling

namespace password_manager_CSharpGUI
{
    public partial class frmAbout : Form
    {
        /// <summary>
        /// This form is the form that displays the information about
        /// the application
        /// </summary>

        // Location of the application
        string myLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Loading strings
        string selectedLanguage = "English"; // Replaced from the parent
        public LanguageManagement lang = new LanguageManagement(); // Language management

        // Icons
        Image[] loading = null; // Loading icons { Loading, update available, Success, Fail }

        // Websites
        string github = "";
        string translate = "";
        string blog = "";
        string issues = "";

        // URL to check for updates
        string updateURL = "";

        // Represent the status of the update checking
        // {-1: Not started, 0: Checking, 1: Update available, 2: No updates available, 3: Error}
        int update = -1;

        /// <summary>
        /// Displays the information about the application
        /// </summary>
        /// <param name="parent">Parent form</param>
        /// <param name="colourPalette">Colour palette</param>
        public frmAbout(frmMain parent, Color[] colourPalette)
        {
            InitializeComponent();

            // Set icon
            this.Icon = parent.Icon;

            // Set colour palette
            this.BackColor = txtLicense.BackColor = colourPalette[0];
            tlpBottom.BackColor = colourPalette[2];

            // Loading strings
            loadStrings(parent.Text);

            loadIcons(); // Loading iconss

            loadAbout(); // About information
        }

        /// <summary>
        /// Background worker does work
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check URL
            if (checkURL())
            {
                // Need to check for updates here in the future
                update = 2;
            }
            else
            {
                // Error
                update = 3;
            }
        }

        /// <summary>
        /// When timer ticks
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // Update loading icon
            lblUpdate.Image = loading[0];
            loading[0].RotateFlip(RotateFlipType.Rotate90FlipNone);

            // If update checking has not yet started, we start it
            if (update < 0)
            {
                bgwUpdate.RunWorkerAsync();
                update = 0;
            }

            // If the update has completed, we check for the status
            if (update != 0)
            {
                if (update == 1) // An update is available
                {
                    lblUpdate.Text = "           " + lang.get("08x0002");
                    lblUpdate.Image = loading[1];
                    lblUpdate.Cursor = Cursors.Hand;
                }
                else if (update == 2) // Upto date
                {
                    lblUpdate.Text = "           " + lang.get("08x0003");
                    lblUpdate.Image = loading[2];
                }
                else if (update == 3) // Could not check for updates
                {
                    lblUpdate.Text = "           " + lang.get("08x0013");
                    lblUpdate.Image = loading[3];
                }

                tmrMain.Stop(); // Stop the timer
            }

            this.Refresh();
        }

        /// <summary>
        /// When one of the links are clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void lnkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor = Cursors.WaitCursor; // Switch to the wait cursor

            // Change the text to loading...
            string lnkText = ((LinkLabel)sender).Text;
            ((LinkLabel)sender).Text = "Loading...";
            this.Refresh();

            if ((LinkLabel)sender == lnkGithub)
                System.Diagnostics.Process.Start(github); // If the link clicked is github, we open the link
            else if ((LinkLabel)sender == lnkTranslate)
                System.Diagnostics.Process.Start(translate); // If the link clicked is translate, we open the link
            else if ((LinkLabel)sender == lnkBlog)
                System.Diagnostics.Process.Start(blog); // If the link clicked is blog, we open the link
            else if ((LinkLabel)sender == lnkIssues)
                System.Diagnostics.Process.Start(issues); // If the link clicked is Report bugs, we open the link
            else
            {
                // Otherwise, it's an internal link
                // If the about panel is not collapsed we collapse it and do opposite to the
                // textbox panel
                spcAbout.Panel1Collapsed = (((LinkLabel)sender).LinkColor != Color.Gray);
                spcAbout.Panel2Collapsed = !spcAbout.Panel1Collapsed;

                txtLicense.Text = ""; // Empty the textbox

                string location = "";

                // Set the location variable to what link was clicked
                if ((LinkLabel)sender == lnkLicense) // License
                    location = myLocation + "\\license";
                else if ((LinkLabel)sender == lnkCopyright) // Copyright notice
                    location = myLocation + "\\aknowledgements";
                else if ((LinkLabel)sender == lnkNotes) // Release notes
                    location = myLocation + "\\release notes";

                // If the colour of the sender link is not gray, we need to 
                // show the information
                if (((LinkLabel)sender).LinkColor != Color.Gray)
                {
                    // So we read the information from the location file and
                    // display it
                    System.IO.StreamReader reader = new System.IO.StreamReader(location);

                    while (!reader.EndOfStream)
                    {
                        txtLicense.Text += reader.ReadLine() + "\r\n";
                    }

                    reader.Dispose();
                }

                // Change the link colours to black (Not clicked)
                lnkCopyright.LinkColor = lnkLicense.LinkColor = lnkNotes.LinkColor = Color.Black;

                // If the about panel is not collapsed, we set the link colour of the
                // sender to gray
                if (spcAbout.Panel1Collapsed)
                    ((LinkLabel)sender).LinkColor = Color.Gray;
            }

            // Set the link text back to normal
            ((LinkLabel)sender).Text = lnkText;

            Cursor = Cursors.Default; // Change to default cursor
        }

        /// <summary>
        /// Loads the text strings needed
        /// </summary>
        private void loadStrings(string title)
        {
            // Loading the strings
            lang.loadLanguages(myLocation + "\\languages");
            lang.selectLanguage(selectedLanguage);
            lang.loadStrings("08");

            // Title
            this.Text = lang.get("08x0000", title);

            // Labels
            lblUpdate.Text = "           " + lang.get("08x0001");
            lblAbout.Text = lang.get("08x0004");
            lblInvolve.Text = lang.get("08x0005");
            lblTrademark.Text = lang.get("08x0012");

            // Links
            lnkGithub.Text = lang.get("08x0006");
            lnkTranslate.Text = lang.get("08x0007");
            lnkLicense.Text = lang.get("08x0008");
            lnkIssues.Text = lang.get("08x0014");
            lnkBlog.Text = lang.get("08x0009");
            lnkCopyright.Text = lang.get("08x0010");
            lnkNotes.Text = lang.get("08x0011");
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            // List Icons
            loading = new Image[] { loadIcon("loading"), loadIcon("download"), loadIcon("tick"), loadIcon("disconnected") };
            lblUpdate.Image = loading[0];

            // Logo
            pcbLogo.Image = loadIcon("muragala");


        }

        /// <summary>
        /// Loads the about information from the files
        /// </summary>
        private void loadAbout()
        {
            // about.json that hold application information
            string json = System.IO.File.ReadAllText(myLocation + "\\about.json");
            Dictionary<string, string> about = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            lblName.Text = about["name"]; // Application name
            lblProduct.Text = about["product"]; // Product name
            github = about["github"]; // Github link
            translate = about["translate"]; // Translate link
            blog = about["blog"]; // Blog link
            lblVersion.Text = about["version"] + " (" + about["architecture"] + ")"; // Version & Architecture
            updateURL = about["update"]; // Update URL
            issues = about["issues"]; // Issue reporting URL
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
        /// Checks a URL to see if the connection to it is working
        /// </summary>
        /// <returns>Success(True) or fail(False) as bool</returns>
        private bool checkURL()
        {
            // Tries to send a ping and if successful, we return true and if failed or timed out,
            // we return false
            try
            {
                System.Net.NetworkInformation.Ping myPing = new System.Net.NetworkInformation.Ping();
                String host = updateURL;
                byte[] buffer = new byte[32];
                int timeout = 2000;
                System.Net.NetworkInformation.PingOptions pingOptions = new System.Net.NetworkInformation.PingOptions();
                System.Net.NetworkInformation.PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                
                return (reply.Status == System.Net.NetworkInformation.IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
