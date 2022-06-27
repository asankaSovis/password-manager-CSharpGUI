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
    public partial class LanguageItem : UserControl
    {
        // Colour Pallettes
        // Palette of the List: <Panel, Deselected, Hovered, Selected>
        Color[] itemColourPalette = {
            Color.FromArgb(240, 255, 249), // Panel
            Color.FromArgb(232, 249, 241), // Deselected
            Color.FromArgb(222, 239, 231), // Hovered
            Color.FromArgb(21, 154, 156) // Selected
        };

        frmSettings parent = null;
        bool selected = false;
        string language = "";

        public LanguageItem(frmSettings _parent,string _language, string locale, string location, Image flag)
        {
            InitializeComponent();

            language = _language;
            lblLanguage.Text = _language + " (" + locale + ")";
            lblRegion.Text = location;
            pcbIcon.Image = flag;
            parent = _parent;
        }

        public string getID()
        {
            return language;
        }

        /// <summary>
        /// If the mouse enters, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseEnter(object sender, EventArgs e)
        {
            if (!selected)
                this.BackColor = itemColourPalette[2];
        }

        /// <summary>
        /// If the mouse leaves, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private new void MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
                this.BackColor = itemColourPalette[1];
        }

        /// <summary>
        /// If the mouse is pressed, we change the back colour
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void MousePressed(object sender, EventArgs e)
        {
            parent.selectLanguage(language);
        }

        /// <summary>
        /// Function called by the parent to select this platform
        /// </summary>
        public void select()
        {
            this.BackColor = itemColourPalette[3];
            selected = true;
        }

        /// <summary>
        /// Function called by the parent to deselect this platform
        /// </summary>
        public void deselect()
        {
            this.BackColor = itemColourPalette[1];
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
    }
}
