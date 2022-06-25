/*
 *                              MAIN FORM
 *                      
 *       This form is the main form that loads
 */

/// NOTE: Username and profile, platform and website are used interchangeably

/// Pallette: https://adobe.ly/2ssVWAc
/// IconSet: https://iconarchive.com/show/button-ui-system-folders-alt-icons-by-blackvariant.html
/// IconSet: https://iconarchive.com/show/beautiful-flat-one-color-icons-by-elegantthemes.1.html

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
using password_manager_CSharpLibrary; // Muragala Library (.NET Edition Only)

namespace password_manager_CSharpGUI
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// This is the GUI application of Muragala. This runs on
        /// top of the Muragala Password Manager library.
        /// NOTE: Only the .NET Framework edition is supported
        /// </summary>

        // Accessing the main Library
        public static MuragalaLibrary library = new MuragalaLibrary();

        // Loading strings
        public string selectedLanguage = "English"; // MUST BE LOADED FROM PREFERENCES
        public LanguageManagement lang = new LanguageManagement();

        ///////////////////////////////////////////////////////////////////
        ////// GLOBAL VARIABLES

        // Global information needed
        // TODO: Remove manager info if not important
        public static Dictionary<string, string> managerInfo = new Dictionary<string, string>(); // Application information
        public static Dictionary<string, string> strVals = new Dictionary<string, string>(); // Output strings

        // Location of core files
        public static string myLocation = AppDomain.CurrentDomain.BaseDirectory;
        // Location of user data
        public static string dataLocation = AppDomain.CurrentDomain.BaseDirectory;

        // Colour Pallettes
        // Palette of the List: <Panel, Deselected, Hovered, Selected>
        public Color[] itemColourPalette = {
            Color.FromArgb(240, 255, 249), // Panel
            Color.FromArgb(232, 249, 241), // Deselected
            Color.FromArgb(222, 239, 231), // Hovered
            Color.FromArgb(21, 154, 156) // Selected
        };

        // Icons
        //List Icons: { Platform, User }
        public Image[] listIcons = null;
        //List Icons: { Working, Done, error }
        private Image[] statusIcons = null;
        // UsernameListItem Icons: { View, Delete }
        public Image[] usernameListItemIcons = null;

        // Tooltips for UsernameListItem
        public string[] tooltipTitles = null;
        public string[] tooltipStrings = null;

        // Variable for the background worker to share progress with
        // the main thread
        // <Processed Platforms, Total Platforms, Processed Usernames>
        // NOTE: Processed Platforms > Total Platforms when done
        //       <0, 0, 0> when reading the database started
        //       null when not working
        Tuple<int, int, int> platformProgress = null;

        // All the loaded platforms as PlatformListItems
        List<PlatformListItem> platforms = new List<PlatformListItem>();

        // Variable to keep track of which items the user has clicked
        // <Platform, Username> (-1 - Not selected)
        private int[] selectedItem = { -1, -1 };

        // Password of the user
        // TODO: Make blank before pushing
        Tuple<string, bool> userPasscode = new Tuple<string, bool>("", false);

        Tuple<int, bool, bool, bool> passwordSettings = new Tuple<int, bool, bool, bool>(12, true, true, true);

        /// <summary>
        /// Initializes the application
        /// This function will load the necessary components for the application
        /// to work
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            initialize(); // Initializes the application

            // TODO: Remove dummy loading when done
            //loadDummies(); // Loads dummy data to the variables
            loadData();
        }

        /// <summary>
        /// What to do when the form is resized
        /// 01. Resize the items in the lists
        /// 02. Resize the banner image (*TODO*)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void frmMain_Resize(object sender, EventArgs e)
        {
            resizeItems(); // Resizes the items in the lists

            // TODO: Resize the banner image
        }

        /// <summary>
        /// What to do each time the timer is ticked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            // We first check if the platformProgress is not null
            // This indicates that we have the background worker running
            if (platformProgress != null)
            {
                // We need to load each new item the background worker has loaded
                // into the lists
                // NOTE: The reason why we load them one by one is because decrypting
                //       the database takes a long time and the user must not wait
                //       THIS APPROACH STILL NEEDS OPTIMIZING
                statusIcons[0].RotateFlip(RotateFlipType.Rotate90FlipNone);
                tstStatus.Image = statusIcons[0];
                this.Refresh();

                foreach (var item in platforms)
                {
                    // For each item in the platforms list, we first load the platform names
                    // and all usernames under these platforms into  dictionary of lists.
                    // Then we can use it to chech if it already exists in the platforms list.

                    Dictionary<string, List<string>> platformStrings = new Dictionary<string, List<string>>();

                    foreach(PlatformListItem platformItem in flpPlatforms.Controls)
                    {
                        List<string> usernameStrings = new List<string>();

                        foreach (UsernameListItem usernameItem in platformItem.getUsernames())
                        {
                            usernameStrings.Add(usernameItem.getUsername());
                        }

                        platformStrings.Add(platformItem.getPlatform(), usernameStrings);
                    }

                    if (!platformStrings.ContainsKey(item.getPlatform()))
                    {
                        // If the item does not exist in the list, we check if a search
                        // is in place by checking if the text length of the txtSearch
                        // textbox is > 0.
                        if (txtSearch.MainText.Length > 0)
                        {
                            // If so, we check if the platform name matches
                            // the search, we add it to the list
                            if (item.getPlatform().Contains(txtSearch.MainText))
                            {
                                flpPlatforms.Controls.Add(item);
                            }
                            else
                            {
                                // If not, we check each username within that platform
                                foreach (var username in item.getUsernames())
                                {
                                    // If the username matches the search, we add it. Otherwise
                                    // we do nothing
                                    if (username.getUsername().Contains(txtSearch.MainText))
                                        flpPlatforms.Controls.Add(item);
                                }
                            }
                        }
                        else
                        {
                            // If a search is not in place, we simply add it to the list
                            flpPlatforms.Controls.Add(item);
                        }
                    }
                    else
                    {
                        // If the platform is there, we check the  username also exist, if so we
                        // don't add them, otherwise we add it under the platform
                        bool contains = false;

                        foreach (UsernameListItem usernameItem in item.getUsernames())
                        {
                            if (platformStrings[item.getPlatform()].Contains(usernameItem.getUsername()))
                            {
                                contains = true;
                                break;
                            }
                        }

                        if (!contains)
                        {
                            if (item.getPlatform().Contains(txtSearch.MainText))
                            {
                                flpPlatforms.Controls.Add(item);
                            }
                            else
                            {
                                // If not, we check each username within that platform
                                foreach (var username in item.getUsernames())
                                {
                                    // If the username matches the search, we add it. Otherwise
                                    // we do nothing
                                    if (username.getUsername().Contains(txtSearch.MainText))
                                        flpPlatforms.Controls.Add(item);
                                }
                            }
                        }
                    }
                }

                resizeItems(); // We resize items to bring them back to the correct size of the window

                // If the item1 of the platformProgress tuple (Loaded platforms) is
                // > item2 (Total platforms), this indicates that the loading process has completed
                if (platformProgress.Item1 > platformProgress.Item2)
                {
                    // We first reset the progress bar and hide it and show the count string
                    tstProgress.Value = 0;
                    tstProgress.Style = ProgressBarStyle.Marquee;
                    tstProgress.Visible = false; tstCount.Visible = true;

                    // Then we load the count string with the total username count (item3)
                    // and set the status string to complete and stats (Total profiles and platforms)
                    tstCount.Text = countString(platformProgress.Item3, lang.get("00x0005"), lang.get("00x0006"));
                    setStatusStrip(lang.get("00x0010", new string[] { lang.get("00x0013"), countString(platformProgress.Item3, lang.get("00x0005"), lang.get("00x0006")), countString(flpPlatforms.Controls.Count, lang.get("00x0007"), lang.get("00x0008")) }), statusIcons[1]);

                    // We then reset platformProgress to null to indicate that work is complete,
                    // enable reload button and set the default cursor
                    platformProgress = null;
                    btnReload.Enabled = true;
                    Cursor = DefaultCursor;
                }
                else if (platformProgress.Item2 == 0)
                {
                    // If the total platforms are 0, it means that the application is still loading the
                    // database

                    // In this case we first enable and change the progress bar,
                    // hide the count and set the status text to reading database
                    tstProgress.Style = ProgressBarStyle.Marquee;
                    tstProgress.Visible = true; tstCount.Visible = false;
                    tstStatus.Text = lang.get("00x0011");

                    // We set the platformProgress to null to prevent the timer from
                    // redoing this over and over again
                    platformProgress = null;
                }
                else
                {
                    // In other cases, the worker is loading platforms

                    // We enable the progress bar, hide the count, change the progress bar
                    // to continuous and set the maximum to the number of platforms and
                    // value to the decoded items
                    tstProgress.Visible = true; tstCount.Visible = false;
                    tstProgress.Style = ProgressBarStyle.Continuous;
                    tstProgress.Maximum = platformProgress.Item2;
                    tstProgress.Value = platformProgress.Item1;

                    // We also change the status text to say that platforms are loading and the
                    // number of items loaded out of total
                    tstStatus.Text = lang.get("00x0012", new string[] { platformProgress.Item1.ToString(), platformProgress.Item2.ToString() });
                }
            }
            else if (tstStatus.Text.Contains(lang.get("00x0013")))
            {
                // Otherwise, if all is done and the status still reads 'Complete:', we clear
                // it
                tstStatus.Text = "";
            }

            // If platformProgress is null and status text is empty, we do nothing

            // NOTE: Should we disable the timer?
        }

        /// <summary>
        /// What to do when background worker is asked to run
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            // NOTE: Background workers run in a separate thread and has no access to
            // anything in this class except the global variables. So be careful
            // of which items you access!
            loadPlatforms(); // We run the loadPlatforms function
        }

        /// <summary>
        /// What to do when Reload button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData(); // We reload the database
        }

        /// <summary>
        /// What to do when an empty area of the lists are clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void flpPlatforms_Click(object sender, EventArgs e)
        {
            selectPlatform(-1); // Select none in the platform list
        }

        /// <summary>
        /// What to do when user is typing in the search box
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // We need to disable the text box before continuing to
            // prevent additional text. (NOTE: is this a good idea?)
            //txtSearch.Enabled = false;
            Cursor = Cursors.AppStarting;
            refreshPlatforms(txtSearch.MainText); // Refreshes the platform list
            // with the search pattern
        }

        /// Control Buttons

        /// <summary>
        /// Opens the form that handle adding a new password
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userPasscode.Item1 == "")
               loadPassword();

            // If the password was not entered, we skip after showing an error
            if (userPasscode.Item1 != "")
            {
                // We save the passcode to a temporary variable in case the user locks the application
                string tempPassword = userPasscode.Item1;
                if (!userPasscode.Item2)
                    userPasscode = new Tuple<string, bool>("", userPasscode.Item2);

                string platform = "";

                // If a platform is selected, we load its name
                if (selectedItem[0] != -1)
                    platform = platforms[selectedItem[0]].getPlatform();

                // We cancel the background worker
                bgwLoad.CancelAsync();

                // Open the add password form
                frmAddPassword addPassword = new frmAddPassword(this, tempPassword, false, passwordSettings, platform);
                addPassword.ShowDialog();

                // If the add status is 0 (Successful), we load that password to the list
                if (addPassword.taskStatus.Item2 == 0)
                {
                    Cursor = Cursors.AppStarting;

                    Tuple<string, string> addedPlatform = addPassword.getPlatformInfo();

                    bool added = false;

                    foreach (PlatformListItem item in platforms)
                    {
                        if (addedPlatform.Item1 == item.getPlatform())
                        {
                            UsernameListItem newUsername = new UsernameListItem(this, item.getUsernames().Count(), addedPlatform.Item2);
                            item.Controls.Add(newUsername);
                            added = true;
                            break;
                        }
                    }

                    // If it doesn't exist, we add it
                    if (!added)
                    {
                        UsernameListItem newUsername = new UsernameListItem(this, 0, addedPlatform.Item2);
                        List<UsernameListItem> newUsernameList = new List<UsernameListItem>();
                        newUsernameList.Add(newUsername);
                        PlatformListItem newPlatform = new PlatformListItem(this, flpPlatforms.Controls.Count, addedPlatform.Item1, newUsernameList.ToArray());
                        platforms.Add(newPlatform);
                    }

                    setStatusStrip(lang.get("00x0044"), statusIcons[1]);

                    // Rerun the platform loading
                    refreshPlatforms(txtSearch.MainText);
                    resizeItems();
                    Cursor = DefaultCursor;
                }
            }
            else
            {
                setStatusStrip(lang.get("00x0038"), statusIcons[2]);
            }
        }

        /// <summary>
        /// Immediately removes the password from memory
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnLock_Click(object sender, EventArgs e)
        {
            userPasscode = new Tuple<string, bool>("", false);
            btnLock.Visible = false;

            setStatusStrip(lang.get("00x0040"), loadIcon("lock"));
        }

        /// <summary>
        /// Opens the Settings form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            comingSoon();
        }

        /// <summary>
        /// Opens the About form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguements</param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            comingSoon();
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == btnReload) // Reload button title
                tltMain.ToolTipTitle = lang.get("00x0020");
            else if (e.AssociatedControl == btnAbout) // About button
                tltMain.ToolTipTitle = lang.get("00x0021");
            else if (e.AssociatedControl == btnSettings) // Settings button
                tltMain.ToolTipTitle = lang.get("00x0023");
            else if (e.AssociatedControl == btnLock) // Lock button
                tltMain.ToolTipTitle = lang.get("00x0041");
            else if (e.AssociatedControl == flpPlatforms) // Platforms button
                tltMain.ToolTipTitle = lang.get("00x0025");
            else if (e.AssociatedControl == txtSearch) // Search button
                tltMain.ToolTipTitle = lang.get("00x0027");
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        ////////////////////////////////////////////////////////////////
        ////// LOADING COMPONENTS

        /// <summary>
        /// Initializes the application. Loads all the additional components
        /// necessary
        /// </summary>
        private void initialize()
        {
            Cursor = Cursors.AppStarting; // Set the cursor

            loadStrings(); // Loads all the strings into memory

            loadIcons(); // Load Icons

            loadPreference(); // Load preference file

            loadDatabase(); // Load the main password database

            loadSettings(); // Load the settings

            Cursor = DefaultCursor; // Revert cursor
        }

        /// <summary>
        /// Loads a set of dummy data to the memory for testing
        /// </summary>
        private void loadDummies()
        {
            Cursor = Cursors.AppStarting; // Set the cursor
            btnReload.Enabled = false; // Disable reload button
            platforms.Clear(); // Clear the platform list

            // DUMMY DATA ------------------------------------------------------------------
            // These data can be helpful for debugging
            List<UsernameListItem> a = new List<UsernameListItem>();
            a.Add(new UsernameListItem(this, 0, "ABCD"));
            a.Add(new UsernameListItem(this, 1, "EFGH", SystemIcons.Warning.ToBitmap()));
            a.Add(new UsernameListItem(this, 2, "IJKL"));
            a.Add(new UsernameListItem(this, 3, "MNOP"));
            PlatformListItem b = new PlatformListItem(this, 0, "Facebook", a.ToArray());
            platforms.Add(b);

            a = new List<UsernameListItem>();
            a.Add(new UsernameListItem(this, 0, "AAA", null));
            PlatformListItem c = new PlatformListItem(this, 1, "Instagram", a.ToArray());
            platforms.Add(c);

            a = new List<UsernameListItem>();
            a.Add(new UsernameListItem(this, 0, "BBBB"));
            PlatformListItem d = new PlatformListItem(this, 2, "Twitter", a.ToArray());
            platforms.Add(d);

            a = new List<UsernameListItem>();
            a.Add(new UsernameListItem(this, 0, "CCCC", SystemIcons.Warning.ToBitmap()));
            PlatformListItem f = new PlatformListItem(this, 3, "Tiktok", a.ToArray());
            platforms.Add(f);

            // -----------------------------------------------------------------------------

            refreshPlatforms(); // Refresh the list of platforms
            resizeItems(); // Resize all items
            btnReload.Enabled = true; // Disable reload button
            Cursor = DefaultCursor; // Revert cursor
        }

        /// <summary>
        /// Loads all the platforms and their profiles from the loaded database
        /// NOTE: This calls the async background worker so that the main thread
        /// doesn't get busy allowing the list to update in real time
        /// </summary>
        private void loadData()
        {
            // Load password
            if (userPasscode.Item1 == "")
                loadPassword();

            // If password was added successfully, we run background worker
            if (userPasscode.Item1 != "")
            {
                Cursor = Cursors.AppStarting;
                btnReload.Enabled = false; // Disable reload button
                platforms.Clear();

                bgwLoad.RunWorkerAsync();
            }
            else
                // Error message
                setStatusStrip(lang.get("00x0038"), statusIcons[2]);
        }

        /// <summary>
        /// Loads the password to decrypt the database
        /// </summary>
        private void loadPassword()
        {
            // Setting the status indications
            setStatusStrip(lang.get("00x0039"), statusIcons[0]);

            // Creating the login form and setting up the password
            frmLogin login = new frmLogin(this);
            login.ShowDialog();
            userPasscode = login.getPassword();

            // Enable the lock button
            btnLock.Visible = (userPasscode.Item2);
        }

        /// <summary>
        /// Loads all the platforms and their profiles from the loaded database
        /// NOTE: This does the actual loading and is the function called by the
        /// async worker
        /// </summary>
        private void loadPlatforms()
        {
            if (bgwLoad.CancellationPending)
                bgwLoad.Dispose();
            // We save the passcode to a temporary variable in case the user locks the application
            string tempPassword = userPasscode.Item1;
            if (!userPasscode.Item2)
                userPasscode = new Tuple<string, bool>("", userPasscode.Item2);

            // Set the platformProgress variable to let the main thread know
            // that worker is active
            platformProgress = new Tuple<int, int, int>(0, 0, 0);

            // Get all the platforms from the database
            List<string> getPlatforms = library.getPlatformNames(tempPassword);

            // Variable to hold total usernames and incrementer x
            int usernameCount = 0; int x = 0;

            // For each platform we load the usernames
            foreach (var item in getPlatforms)
            {
                // Update the progress
                platformProgress = new Tuple<int, int, int>(x + 1, getPlatforms.Count, usernameCount);

                // Get a list of all the usernames under this platform
                List<string> getUsernames = library.getUsernamesInPlatform(tempPassword, item, "");

                // List of UsernameListItems to hold usernames
                List<UsernameListItem> usernames = new List<UsernameListItem>();

                int y = 0; // Incrementer for usernames

                // For each usermame we create a UsernameListItem and add it to the list
                foreach (var username in getUsernames)
                {
                    usernames.Add(new UsernameListItem(this, y, username));
                    y++; // increment y
                }
                usernameCount += y; // Add number of new usernames to the user count

                // Create a new PlatformListItem and add it to the platforms list
                PlatformListItem newPlatforms = new PlatformListItem(this, x, item, usernames.ToArray());
                platforms.Add(newPlatforms);

                x++; // Increment x
            }

            // Update progress to show that loading is done
            platformProgress = new Tuple<int, int, int>(getPlatforms.Count + 1, getPlatforms.Count, usernameCount);
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
            lang.loadStrings("00");

            // Setting the strings
            // Control texts
            this.Text = lang.get("00x0000");
            grpPasswords.Text = lang.get("00x0001");
            btnAdd.Text = lang.get("00x0002");
            tstCount.Text = countString(0, lang.get("00x0003"), lang.get("00x0004"));
            txtSearch.ApplyWatermark(lang.get("00x0043"));

            // Tool tips
            tltMain.SetToolTip(btnReload, lang.get("00x0018"));
            tltMain.SetToolTip(btnAdd, lang.get("00x0019"));
            tltMain.SetToolTip(btnAbout, lang.get("00x0022"));
            tltMain.SetToolTip(btnSettings, lang.get("00x0024"));
            tltMain.SetToolTip(btnSettings, lang.get("00x0026"));
            tltMain.SetToolTip(txtSearch, lang.get("00x0028"));
            tltMain.SetToolTip(btnLock, lang.get("00x0042"));

            // Tool tips of UsernameListItem and PlatformListItem
            tooltipTitles = new string[] { lang.get("00x0029"), lang.get("00x0031") };
            tooltipStrings = new string[] { lang.get("00x0030"), lang.get("00x0032"), lang.get("00x0033"), lang.get("00x0034") };
        }

        /// <summary>
        /// Loads the database to the library
        /// </summary>
        private void loadDatabase()
        {
            // Loads the database and error check
            int error = library.loadDatabase(dataLocation + "database.en");

            if (error == MuragalaLibrary.error_list.database_created)
                // TODO: New database is created
                //printf(strVals["no_database_found"]);
                ;
            else if (error == MuragalaLibrary.error_list.database_load_failed)
            {
                // TODO: Error loading database
                //printf(strVals["fatal_error"].Replace("<l>", "Database loading").Replace("<e>", "Could not load database."));
                Environment.Exit(-1);
            }
        }

        /// <summary>
        /// Loads the preferences to the library
        /// </summary>
        private void loadPreference()
        {
            // Loads the preferences and check for errors
            int error = library.loadPreference(dataLocation + "preferences.en");

            // If failed to load the preferences we create a new preference
            if (error == MuragalaLibrary.error_list.preference_load_failed)
            {
                frmSetup newPasscode = new frmSetup(this);
                newPasscode.ShowDialog();

                // If we succeeded we continue
                if (newPasscode.getStatus())
                { tstStatus.Text = lang.get("00x0035"); tstStatus.Image = statusIcons[1]; error = MuragalaLibrary.error_list.success; }
            }

            // In case the user cancelled, we show an error and exist. Same for an error
            if (error == MuragalaLibrary.error_list.preference_load_failed)
            {
                frmMessage message = new frmMessage(this, lang.get("00x0047"), lang.get("00x0048"), selectedLanguage, MessageBoxIcon.Error, MessageBoxButtons.OK);
                message.ShowDialog();
                Environment.Exit(-1);
            }
            else if (error != MuragalaLibrary.error_list.success)
            {
                frmMessage message = new frmMessage(this, lang.get("00x0036"), lang.get("00x0037", "Could not load the preference file."), selectedLanguage, MessageBoxIcon.Error, MessageBoxButtons.OK);
                message.ShowDialog();
                Environment.Exit(-1);
            }
        }

        // TODO: Need to work on the settings
        /// <summary>
        /// Loads the settings
        /// </summary>
        private void loadSettings()
        {
            // Colour pallette
            spcMain.BackColor = itemColourPalette[0];
        }

        /// <summary>
        /// Creates a new preference file
        /// </summary>
        /// <param name="passcode">Authentication passcode</param>
        /// <returns>Error status as in library</returns>
        public int newPreference(string passcode)
        {
            passcode myPasscode = new passcode((passcode != ""), passcode);

            return library.createPreference(dataLocation + "preferences.en", myPasscode.password, myPasscode.password);
        }

        /// <summary>
        /// Loads the icons needed for the application from the resources folder
        /// </summary>
        private void loadIcons()
        {
            this.Icon = Icon.ExtractAssociatedIcon(myLocation + "icon.ico");
            // List Icons
            listIcons = new Image[] { loadIcon("platform"), loadIcon("user") };

            // Status Icons
            statusIcons = new Image[] { loadIcon("working"), loadIcon("done"), loadIcon("error") };

            // UsernameListItem Icons
            usernameListItemIcons = new Image[] { loadIcon("view"), loadIcon("delete") };

            // Buttons
            btnAdd.Image = loadIcon("add");
            btnAbout.Image = loadIcon("about");
            btnSettings.Image = loadIcon("settings");
            btnReload.Image = loadIcon("refresh");
            btnLock.Image = loadIcon("lock");
        }

        /// <summary>
        /// Refresh the list of platforms in the listbox
        /// </summary>
        /// <param name="keyword">Search term to search. Blank if no search</param>
        public void refreshPlatforms(string keyword = "")
        {
            // We first clear the listbox
            flpPlatforms.Controls.Clear();

            // For each item in the platforms list we load it to the listbox
            foreach (var item in platforms)
            {
                // If the platform name matches the keyword, we add it to the listbox
                if (item.getPlatform().Contains(keyword))
                {
                    flpPlatforms.Controls.Add(item);
                }
                else if (keyword.Length > 0)
                {
                    // If not, if the keyword length is > 0, we check the usernamrd
                    // If length is 0, then the if statement must've already handled it
                    foreach (var username in item.getUsernames())
                    {
                        // For each username we see if the username matches the search AND
                        // the list doesn't already contain the platform. If so we add it
                        if (username.getUsername().Contains(keyword) && !flpPlatforms.Contains(item))
                            flpPlatforms.Controls.Add(item);
                    }
                }
            }

            // If the search text is not empty (No searching done by user), we update status text
            // with the number of matches. Otherwise we empty it
            if (txtSearch.MainText != "")
                setStatusStrip(lang.get("00x0014", countString(flpPlatforms.Controls.Count, lang.get("00x0015"), lang.get("00x0016"))), usernameListItemIcons[0]);
            else
                setStatusStrip("", null);

            Cursor = DefaultCursor;
        }

        /// <summary>
        /// Add all usernames in the selected platform to the usernames listbox
        /// </summary>
        public void refreshUsernames()
        {
            // First we clear the listbox
            flpUsernames.Controls.Clear();

            if (platforms.Count > selectedItem[0])
            {
                // For each username item in the selected platform, we add it to the list
                foreach (var item in platforms[selectedItem[0]].getUsernames())
                {
                    flpUsernames.Controls.Add(item);
                }
            }

            // If no loading is happening, we show number of profiles and the platform name
            if (platformProgress == null)
                tstStatus.Text = lang.get("00x0017", new string[] { countString(flpUsernames.Controls.Count, lang.get("00x0005"), lang.get("00x0006")), platforms[selectedItem[0]].getPlatform() });
        }


        /// <summary>
        /// Selects a platform when requested
        /// </summary>
        /// <param name="ID">ID of the platform to be selected</param>
        public void selectPlatform(int ID)
        {
            // If the ID is less than the number of platforms we select it
            if (ID < flpPlatforms.Controls.Count)
            {
                // If first number in the selectedItem (Selected platform) is not -1
                // and it is also equal to the ID or ID is -1, we deselect
                // NOTE: Above all means that either user clicked on the selected item,
                //       or clicked on an empty space
                if (((selectedItem[0] != -1) && (selectedItem[0] == ID)) || ID == -1)
                {
                    selectedItem[0] = selectedItem[1] = -1; // Resetting selections
                    spcMain.Panel2Collapsed = true; // Collapse username list panel

                    // If loading is not onngoing, we clear the status
                    if (platformProgress == null)
                        tstStatus.Text = "";
                }
                else
                {
                    // Otherwise we set the selection of the platform to ID and reset
                    // the username selections and show the username listbox and refresh
                    // the username listbox
                    selectedItem[0] = ID; selectedItem[1] = -1;
                    spcMain.Panel2Collapsed = false;

                    refreshUsernames();
                }

                // Then for each platforms, we deselect usernames if not belonging to the
                // selected platform and select the ones that do belong
                foreach (var platform in platforms)
                {
                    // If the selectedItem 0 match the ID of the platform, we
                    // select it. Otherwise we deselect it
                    if (platform.getID() == selectedItem[0])
                        platform.select();
                    else
                        platform.deselect();

                    // For each username we deselect them
                    foreach (var username in platform.getUsernames())
                    {
                        username.deselect();
                    }
                }

                // Resize all items and enable buttons
                resizeItems();
                enableButtons();
            }
        }

        /// <summary>
        /// Selecting a username
        /// </summary>
        /// <param name="ID">ID to be selected</param>
        public void selectUsername(int ID)
        {
            // If the ID is less than the items in the listBox, it is valid
            if (ID < flpUsernames.Controls.Count)
            {
                // If the selectedItem 1 (Username) is not -1 and ID is selectedItem 1,
                // then we set the selectedItem 1 to -1
                // NOTE: We check if the item is already selected and if so we deselect it
                if ((selectedItem[1] != -1) && (selectedItem[1] == ID))
                    selectedItem[1] = -1;
                else
                    // Otherwise we set the ID as the selectedItem 1
                    selectedItem[1] = ID;

                // For each item in the usernames in the selected platform, we select or deselect
                // them
                foreach (var item in platforms[selectedItem[0]].getUsernames())
                {
                    // If the ID match with selectedItem 1, we select and deselect otherwise
                    if (item.getID() == selectedItem[1])
                        item.select();
                    else
                        item.deselect();
                }

                // Resize and enable buttons
                resizeItems();
                enableButtons();
            }
        }



        /// <summary>
        /// If a profile is requested to be viewed
        /// </summary>
        public void viewProfile(int ID)
        {
            // If the ID is less than the items in the listBox, it is valid
            if (ID < flpUsernames.Controls.Count)
            {
                if (userPasscode.Item1 == "")
                    loadPassword();

                // We save the passcode to a temporary variable in case the user locks the application
                string tempPassword = userPasscode.Item1;
                if (!userPasscode.Item2)
                    userPasscode = new Tuple<string, bool>("", userPasscode.Item2);

                string platform = platforms[selectedItem[0]].getPlatform();
                string username = platforms[selectedItem[0]].getUsernames()[ID].getUsername();
                // TODO: View profile
                frmView view = new frmView(this, tempPassword, platform, username);
                view.ShowDialog();

                if (view.getNext() == 1)
                {
                    editProfile(ID, view.getPassword());
                } else if (view.getNext() == 2)
                {
                    deleteProfile(ID);
                }
            }
        }

        /// <summary>
        /// If a profile is requested to be Edited
        /// </summary>
        public void editProfile(int ID, string password)
        {
            // If the ID is less than the items in the listBox, it is valid
            if (ID < flpUsernames.Controls.Count)
            {
                if (userPasscode.Item1 == "")
                    loadPassword();

                // We save the passcode to a temporary variable in case the user locks the application
                string tempPassword = userPasscode.Item1;
                if (!userPasscode.Item2)
                    userPasscode = new Tuple<string, bool>("", userPasscode.Item2);

                string platform = platforms[selectedItem[0]].getPlatform();
                string username = platforms[selectedItem[0]].getUsernames()[ID].getUsername();

                // Loads the add password form with mode 1 (Edit mode)
                frmAddPassword addProfile = new frmAddPassword(this, tempPassword, true, passwordSettings, platform, username, password);
                addProfile.ShowDialog();
            }
        }

        /// <summary>
        /// Loads the profile information (password and added date) from database
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        /// <returns>Error as in library</returns>
        public List<string> viewProfile(string password, string platform, string username)
        {
            return library.getUserInformation(password, platform, username);
        }

        /// <summary>
        /// If a profile is requested to be deleted
        /// </summary>
        public void deleteProfile(int ID)
        {
            // If the ID is less than the items in the listBox, it is valid
            if (ID < flpUsernames.Controls.Count)
            {
                // TODO: Delete profile
                if (userPasscode.Item1 == "")
                    loadPassword();

                // If the password was not entered, we skip after showing an error
                if (userPasscode.Item1 != "")
                {
                    // We save the passcode to a temporary variable in case the user locks the application
                    string tempPassword = userPasscode.Item1;
                    if (!userPasscode.Item2)
                        userPasscode = new Tuple<string, bool>("", userPasscode.Item2);

                    // We cancel the background worker
                    bgwLoad.CancelAsync();

                    string platform = platforms[selectedItem[0]].getPlatform();
                    string username = platforms[selectedItem[0]].getUsernames()[ID].getUsername();

                    // Open the delete password form
                    frmDelete deletePassword = new frmDelete(this, tempPassword, platform, username);
                    deletePassword.ShowDialog();

                    // If the delete status is 0 (Successful), we load that password to the list
                    if (deletePassword.taskStatus.Item2 == 0)
                    {
                        Cursor = Cursors.AppStarting;

                        for (int i = 0; i < platforms.Count; i++)
                        {
                            if (platforms[i].getPlatform() == platform)
                            {
                                if (platforms[i].getUsernames().Count() < 2)
                                {
                                    platforms.RemoveAt(i);
                                }
                                else
                                {
                                    List<UsernameListItem> newList = platforms[i].getUsernames().ToList();

                                    for (int j = 0; j < newList.Count(); j++)
                                    {
                                        if (newList[j].getUsername() == username)
                                        {
                                            newList.RemoveAt(j);
                                            platforms[i].setUsernames(newList.ToArray());
                                            break;
                                        }
                                    }
                                }

                                break;
                            }
                        }

                        selectPlatform(-1);

                        setStatusStrip(lang.get("00x0044"), statusIcons[1]);

                        // Rerun the platform loading
                        refreshPlatforms(txtSearch.MainText);
                        resizeItems();
                        Cursor = DefaultCursor;
                    }
                }
                else
                {
                    setStatusStrip(lang.get("00x0038"), statusIcons[2]);
                }
            }
        }

        /// <summary>
        /// Deletes a profile
        /// </summary>
        /// <param name="passcode">Authentication passcode</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        /// <returns>Error status according to the error list in library</returns>
        public int deleteProfile(string passcode, string platform, string username)
        {
            return library.deletePassword(passcode, platform, username);
        }

        /// <summary>
        /// Edits a profile
        /// </summary>
        /// <param name="passcode">Authentication passcode</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Error as in the library</returns>
        public int editProfile(string passcode, string platform, string username, string password)
        {
            return library.editPassword(passcode, platform, username, password);
        }

        /// <summary>
        /// Adds a new password to the database
        /// </summary>
        /// <param name="passcode">Passcode to authenticate</param>
        /// <param name="platform">Platform</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Error as integer { 0: success, 1: exist, 2: error }</returns>
        public int addPassword(string passcode, string platform, string username, string password)
        {
            int error = 0;

            // If password does not already exist in the database, we add it to the database
            // and return an error
            if (library.getUserData(passcode, platform, username).Count == 0)
            {
                if (!library.addPassword(passcode, platform, username, password))
                    error = 2;
            }
            else
                error = 1;

            return error;
        }

        /// <summary>
        /// Returns a random password
        /// </summary>
        /// <param name="size">Length of the password</param>
        /// <param name="uppercase">Enable uppercase</param>
        /// <param name="numbers">Enable numbers</param>
        /// <param name="symbols">Enable symbols</param>
        /// <returns>Returns the random password</returns>
        public string getRandomPassword(int size, bool uppercase, bool numbers, bool symbols)
        {
            return library.randomPassword(size, uppercase, numbers, symbols);
        }

        ///////////////////////////////////////////////////////////////
        /// PASSWORD RELATED FUNCTIONS

        /// <summary>
        /// Checks if the password entered by the user is valid.
        /// TODO: Needs work
        /// </summary>
        /// <param name="password">Password the user entered</param>
        /// <returns>passcode class of passed or failed as bool and password as string</returns>
        public bool checkPassword(string password)
        {
            return library.checkPassword(password);
        }

        /// <summary>
        /// This class is a data type to hold the user password
        /// It informs if the password is an accepted password and the actual password itself
        /// </summary>
        class passcode
        {
            public bool progress = false;
            public string password = "";

            public passcode(bool _progress = false, string _password = "")
            {
                // Initialization
                progress = _progress;
                password = _password;
            }
        }

        ///////////////////////////////////////////////////////////////
        /// MISCELLANEOUS FUNCTIONS

        /// <summary>
        /// Resizes all the items in the listBoxes
        /// </summary>
        private void resizeItems()
        {
            // Creates a temporary platform list and add the actual list
            // to it. This is to prevent collisions between threads
            List<PlatformListItem> tempPlatforms = platforms;

            // For each item, we resize them according to the size of the
            // listBox
            foreach (var platform in tempPlatforms)
            {
                // Platforms
                platform.resize(flpPlatforms.Size.Width - 30);
                flpPlatforms.FlowDirection = FlowDirection.TopDown;

                foreach (var username in platform.getUsernames())
                {
                    // Usernames in each platform
                    username.resize(flpUsernames.Size.Width - 30);
                    flpUsernames.FlowDirection = FlowDirection.TopDown;
                }
            }
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
            catch (Exception) { icon = pcbBanner.ErrorImage; }

            return icon;
        }

        /// <summary>
        /// Enables/Disables all the buttons
        /// </summary>
        /// <param name="enable">Enable/Disable</param>
        private void enableButtons(bool enable = true)
        {
            // TODO: Do we need this?
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
                return lang.get("00x0009", new string[] { count.ToString(), singularForm });
            else
                return lang.get("00x0009", new string[] { count.ToString(), pluralForm });
        }

        /// <summary>
        /// Set the status strip text and image
        /// </summary>
        /// <param name="status">Status text</param>
        /// <param name="icon">Status icon</param>
        private void setStatusStrip(string status, Image icon)
        {
            tstStatus.Text = status; tstStatus.Image = icon;
        }

        /// <summary>
        /// Shows a coming soon message
        /// </summary>
        public void comingSoon()
        {
            frmMessage message = new frmMessage(this, lang.get("00x0045"), lang.get("00x0046"), loadIcon("walle"), selectedLanguage);
            message.ShowDialog();
        }
    }
}
