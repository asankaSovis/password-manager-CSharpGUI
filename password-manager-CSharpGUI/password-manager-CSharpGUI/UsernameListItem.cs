/*
 *                              Platform Structure
 *                      
 *       This user control define how the profile list item must be displayed and
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
    public partial class UsernameListItem : UserControl
    {
        int myID = 0; // ID of the  Profile loaded
        string Username = null;  // Profile name

        frmMain parent = null; // Parent form
        bool selected = false; // If selected or not

        /// <summary>
        /// This user control define how the profile list item must be displayed and
        /// what data is needed
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="_myID">Id of the profile</param>
        /// <param name="_username">Name of the profile</param>
        /// <param name="_icon">Icon to be displayed</param>
        public UsernameListItem(frmMain _parent, int _myID, string _username, Image _icon = null)
        {
            InitializeComponent();

            // Global variable assigning
            parent = _parent; myID = _myID; Username = _username;
            lblUsername.Text = _username;

            // Sets the back colour
            this.BackColor = parent.itemColourPalette[1];

            // Sets the icon
            if (_icon == null)
                pcbIcon.Image = parent.listIcons[1];
            else
                pcbIcon.Image = _icon;

            btnView.Image = parent.usernameListItemIcons[0];
            btnDelete.Image = parent.usernameListItemIcons[1];

            // Adding tooltips
            tltMain.SetToolTip(btnView, parent.tooltipStrings[0]);
            tltMain.SetToolTip(btnDelete, parent.tooltipStrings[1]);
            tltMain.SetToolTip(lblUsername, parent.tooltipStrings[2]);
        }

        /// <summary>
        /// Returns the ID of this profile
        /// </summary>
        /// <returns>Platform ID</returns>
        public int getID()
        {
            return myID;
        }

        /// <summary>
        /// Returns the profile name
        /// </summary>
        /// <returns>Platform name</returns>
        public string getUsername()
        {
            return Username;
        }

        /// <summary>
        /// If the mouse enters, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseEnter(object sender, EventArgs e)
        {
            if (spcUsername.Panel2Collapsed)
                spcUsername.Panel2Collapsed = false;

            if (!selected)
                this.BackColor = parent.itemColourPalette[2];
        }

        /// <summary>
        /// If the mouse leaves, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseLeave(object sender, EventArgs e)
        {
            if (!spcUsername.Panel2Collapsed)
                spcUsername.Panel2Collapsed = true;

            if (!selected)
                this.BackColor = parent.itemColourPalette[1];
        }

        /// <summary>
        /// If the mouse is pressed, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void MousePressed(object sender, EventArgs e)
        {
            parent.selectUsername(myID);
        }

        /// <summary>
        /// Handle what to do when view button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnView_Click(object sender, EventArgs e)
        {
            parent.viewProfile(myID); // Notify the parent
        }

        /// <summary>
        /// Handle what to do when delete button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.deleteProfile(myID); // Notify the parent
        }

        /// <summary>
        /// Function called by the parent to select this platform
        /// </summary>
        public void select()
        {
            this.BackColor = parent.itemColourPalette[3];
            selected = true;
        }

        /// <summary>
        /// Function called by the parent to deselect this platform
        /// </summary>
        public void deselect()
        {
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
            // We set the title according to the control
            if (e.AssociatedControl == btnView)
                tltMain.ToolTipTitle = parent.tooltipTitles[0];
            else if (e.AssociatedControl == btnDelete)
                tltMain.ToolTipTitle = parent.tooltipTitles[1];
            else if (e.AssociatedControl == lblUsername)
                tltMain.ToolTipTitle = lblUsername.Text;
        }
    }
}
