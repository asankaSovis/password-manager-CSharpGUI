/*
 *                              Platform Structure
 *                      
 *       This user control define how the platform list item must be displayed and
 *       what data is needed
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
    public partial class PlatformListItem : UserControl
    {
        int myID = 0; // ID of the  platform loaded
        string Platform = null; // Platform name
        UsernameListItem[] Usernames = null; // List of usernames
        
        frmMain parent = null; // Parent form
        bool selected = false; // If selected or not

        /// <summary>
        /// This user control define how the platform list item must be displayed and
        /// what data is needed
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="_myID">Id of the platform</param>
        /// <param name="_platform">Name of the platform</param>
        /// <param name="_usernames">List of usernames</param>
        /// <param name="_icon">Icon to be displayed</param>
        public PlatformListItem(frmMain _parent, int _myID, string _platform, UsernameListItem[] _usernames, Image _icon = null)
        {
            InitializeComponent();

            // Global variable assigning
            parent = _parent; myID = _myID; Platform = _platform; Usernames = _usernames;
            lblPlatform.Text = _platform;
            
            // Calculate the height of the control
            int tempSize = this.Size.Height;

            // For each username in the list we add it to the usernames
            // label and add a fixed size to the size
            foreach (var item in _usernames)
            {
                lblUsernames.Text += item.getUsername() + "\n";
                tempSize += 17;
            }

            // Sets the new size of the control and the back colour
            this.Size = new Size(this.Size.Width, tempSize + 5);
            this.BackColor = parent.itemColourPalette[1];

            // Sets the icon
            if (_icon == null)
                pcbIcon.Image = parent.listIcons[0];
            else
                pcbIcon.Image = _icon;

            // Adding tooltips
            tltMain.SetToolTip(lblPlatform, LanguageManagement.parse(parent.tooltipStrings[3], new string[] { Usernames.Count().ToString(), Platform }));
        }

        /// <summary>
        /// Returns the ID of this platform
        /// </summary>
        /// <returns>Platform ID</returns>
        public int getID()
        {
            return myID;
        }

        /// <summary>
        /// Returns the platform name
        /// </summary>
        /// <returns>Platform name</returns>
        public string getPlatform()
        {
            return Platform;
        }

        /// <summary>
        /// Returns the list of usernames
        /// </summary>
        /// <returns>List of usernames</returns>
        public UsernameListItem[] getUsernames()
        {
            return Usernames;
        }

        /// <summary>
        /// If the mouse enters, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseEnter(object sender, EventArgs e)
        {
            lblArrow.Text = ">";

            if(!selected)
                this.BackColor = parent.itemColourPalette[2];
        }

        /// <summary>
        /// If the mouse leaves, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
            { 
                this.BackColor = parent.itemColourPalette[1];
                lblArrow.Text = "";
            }
        }

        /// <summary>
        /// If the mouse is pressed, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void MousePressed(object sender, EventArgs e)
        {
            parent.selectPlatform(myID);
        }

        /// <summary>
        /// Function called by the parent to select this platform
        /// </summary>
        public void select()
        {
            // We set the back colour and mark this as selected
            this.BackColor = parent.itemColourPalette[3];
            selected = true;
        }

        /// <summary>
        /// Function called by the parent to deselect this platform
        /// </summary>
        public void deselect()
        {
            // We set the back colour and mark this as not selected
            this.BackColor = parent.itemColourPalette[1];
            selected = false;
        }

        /// <summary>
        /// Resizes the width of the control
        /// </summary>
        /// <param name="width">New width</param>
        public void resize(int width)
        {
            this.Size = new Size(width, this.Size.Height);
        }

        /// <summary>
        /// When a popup is being shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == lblPlatform)
                tltMain.ToolTipTitle = lblPlatform.Text;
        }
    }
}
