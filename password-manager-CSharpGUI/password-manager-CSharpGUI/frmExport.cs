/*
 *                              EXPORT FORM
 *                      
 *       This form exports the database to a text file
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
    public partial class frmExport : Form
    {
        /// <summary>
        /// Exports the database
        /// </summary>
        // Accessing the main Library
        public static MuragalaLibrary library = new MuragalaLibrary();

        // Success of the operation
        public bool success = false;

        string message = ""; // Display message
        string source = ""; // Source file
        string destination = ""; // Destination file
        string tempPassword = ""; // Passcode

        frmMain parent = null; // Parent form

        Tuple<int, int, int, int, string, string>  platformProgress = null; // BGW progress

        /// <summary>
        /// Exports the database
        /// </summary>
        /// <param name="title">Title of the form</param>
        /// <param name="message1">Initial message</param>
        /// <param name="message2">Progress message</param>
        /// <param name="btnMessage">Message button text</param>
        /// <param name="_source">Source file</param>
        /// <param name="_destination">Destination file</param>
        /// <param name="passcode">Passcode</param>
        /// <param name="_parent">Parent form</param>
        public frmExport(string title, string message1, string message2, string btnMessage, string _source, string _destination, string passcode, frmMain _parent)
        {
            InitializeComponent();

            parent = _parent;

            this.Text = title;
            this.Icon = parent.Icon;

            lblMessage.Text = message1;
            message = message2;
            btnProceed.Text = btnMessage;

            source = _source;
            destination = _destination;
            tempPassword = passcode;

            // Loads the database and preference and error check
            library.loadPreference(source + "\\preferences.en");
            int error = library.loadDatabase(source + "\\database.en");

            spcMain.Panel2Collapsed = true;
        }

        /// <summary>
        /// Proceed button clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnProceed_Click(object sender, EventArgs e)
        {
            // We start the BGW and timer
            bgwMain.RunWorkerAsync();
            tmrMain.Start();
            spcMain.Panel1Collapsed = true;
        }

        /// <summary>
        /// BGW that do the work
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            // We try the writing, if successful we set the progress to success
            // or else fail
            try
            {
                writeDatabase();
                success = true;
            }
            catch { success = false; }
        }

        /// <summary>
        /// Timer to monitor progress
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // If the value is > max, then the worker has completed the work successfully
            // In this case we exit the application
            if (platformProgress.Item1 >= platformProgress.Item2)
            {
                // Otherwise we update the progress markers
                prgPlatforms.Style = prgUsernames.Style = ProgressBarStyle.Continuous;
                prgPlatforms.Maximum = platformProgress.Item1;
                prgPlatforms.Value = platformProgress.Item2;
                prgUsernames.Maximum = platformProgress.Item3;
                prgUsernames.Value = platformProgress.Item4;

                lblMessage.Text = LanguageManagement.parse(message, new string[] { prgPlatforms.Value.ToString(), prgPlatforms.Maximum.ToString(), platformProgress.Item5, platformProgress.Item6 });
                this.Refresh();
            }
            else
                this.Close();
        }

        /// <summary>
        /// Loads all the platforms and their profiles from the loaded database
        /// and write them to the file
        /// NOTE: This does the actual loading and is the function called by the
        /// async worker
        /// </summary>
        private void writeDatabase()
        {
            // Set the platformProgress variable to let the main thread know
            // that worker is active
            platformProgress = new Tuple<int, int, int, int, string, string>(0, 0, 0, 0, "-", "-");

            // Initialize writer and add header texts
            System.IO.StreamWriter writer = new System.IO.StreamWriter(destination);
            writer.WriteLine("Muragala Password Manager " + MuragalaLibrary.About.version);
            writer.WriteLine("Password Dump---");
            writer.WriteLine("");

            // Get all the platforms from the database
            List<string> getPlatforms = library.getPlatformNames(tempPassword);

            // Variable to hold total usernames and incrementer x
            int x = 0;

            // For each platform we load the usernames
            foreach (string item in getPlatforms)
            {
                // Get a list of all the usernames under this platform
                List<string> getUsernames = library.getUsernamesInPlatform(tempPassword, item, "");

                // List of UsernameListItems to hold usernames
                List<UsernameListItem> usernames = new List<UsernameListItem>();

                int y = 0; // Incrementer for usernames

                // Write the platform name
                writer.WriteLine(item);

                platformProgress = new Tuple<int, int, int, int, string, string>(getPlatforms.Count, x + 1, getUsernames.Count, y, item, "-");

                // For each usermame we create a UsernameListItem and add it to the list
                foreach (string username in getUsernames)
                {
                    // Update the progress
                    platformProgress = new Tuple<int, int, int, int, string, string>(getPlatforms.Count, x + 1, getUsernames.Count, y + 1, item, username);

                    // Load password and creation date
                    List<string> password = library.getUserInformation(tempPassword, item, username);

                    // Write username
                    writer.WriteLine("  " + username + ": " + password[0] + " (" + password[1] + ")");

                    y++; // increment y
                }

                writer.WriteLine("");

                x++; // Increment x
            }

            // Update progress to show that loading is done
            platformProgress = new Tuple<int, int, int, int, string, string>(getPlatforms.Count, getPlatforms.Count + 1, 0, 0, "", "");
            
            // End writing
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
    }
}
