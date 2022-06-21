using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devolutions.Zxcvbn;

// ZXCVBN Project: https://github.com/Devolutions/Zxcvbn

namespace password_manager_CSharpGUI
{
    /// <summary>
    /// A meter that displays the strength of a password
    /// </summary>
    public partial class PasswordStrengthMeter : UserControl
    {
        string[] text = new string[12]; // Display text strings

        // Colour pallette of the meter
        Color[] colourPalette = {
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(255, 216, 0),
            Color.FromArgb(44, 177, 23),
            Color.FromArgb(44, 177, 23)
        };

        /// <summary>
        /// Loads the user control
        /// </summary>
        public PasswordStrengthMeter()
        {
            InitializeComponent();
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
                if (e.AssociatedControl == lblCount) // Count label
                    tltMain.ToolTipTitle = text[12];
                else if (e.AssociatedControl == lblLowercase) // Lowercase label
                    tltMain.ToolTipTitle = text[14];
                else if (e.AssociatedControl == lblUppercase) // Uppercase label
                    tltMain.ToolTipTitle = text[16];
                else if (e.AssociatedControl == lblNumbers) // Numbers label
                    tltMain.ToolTipTitle = text[18];
                else if (e.AssociatedControl == lblSymbols) // Symbols label
                    tltMain.ToolTipTitle = text[20];
                else if (e.AssociatedControl == lblStrength) // Strength label
                    tltMain.ToolTipTitle = text[22];
                else
                    tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Adds the password to be checked of strength
        /// </summary>
        /// <param name="password">Password to be checked</param>
        /// <returns>Strength as an int from 0 to 4</returns>
        public int changePassword(string password)
        {
            // Number of each types of characters
            int lowercase = 0; int uppercase = 0;
            int numbers = 0; int symbols = 0;

            // Overall score
            int score = getScore(password);

            // For each character we increment the relevant type
            foreach (var item in password)
            {
                // If a space character is there, we stop counting and return null
                if (item == ' ')
                { password = ""; break; }

                int charVal = (int)item; // Gets the ASCII ID of the character

                if ((charVal >= 97) && (charVal <= 122))
                    lowercase++;
                else if ((charVal >= 65) && (charVal <= 90))
                    uppercase++;
                else if ((charVal >= 48) && (charVal <= 57))
                    numbers++;
                else
                    symbols++;
            }

            // Updates the number of characters of the password
            updateCount(password.Length);

            // Update each character type with its relevant count
            updateComponent(lblLowercase, lowercase);
            updateComponent(lblUppercase, uppercase);
            updateComponent(lblNumbers, numbers);
            updateComponent(lblSymbols, symbols);

            // Draw the overall score
            drawScore(score);

            return score; // Return the score
        }

        /// <summary>
        /// Updates the number of characters in the password displayed
        /// </summary>
        /// <param name="count"></param>
        private void updateCount(int count)
        {
            // For each number of characters we update the text, apply a back colour
            // and a fore colour
            if (count < 1) // No characters
            {
                lblCount.Text = text[0];
                lblCount.BackColor = colourPalette[0];
                lblCount.ForeColor = Color.White;
            }
            else if (count < 5) // Very weak
            {
                lblCount.Text = LanguageManagement.parse(text[3], countString(count, text[1], text[2]));
                lblCount.BackColor = colourPalette[1];
                lblCount.ForeColor = Color.White;
            }
            else if (count < 8) // Weak
            {
                lblCount.Text = LanguageManagement.parse(text[4], count.ToString());
                lblCount.BackColor = colourPalette[2];
                lblCount.ForeColor = Color.Black;
            }
            else if (count < 12) // Good
            {
                lblCount.Text = LanguageManagement.parse(text[5], count.ToString());
                lblCount.BackColor = colourPalette[3];
                lblCount.ForeColor = Color.White;
            }
            else // Strong
            {
                lblCount.Text = LanguageManagement.parse(text[6], count.ToString());
                lblCount.BackColor = colourPalette[4];
                lblCount.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Updates the number characters of each type
        /// </summary>
        /// <param name="updateLabel">The label associated</param>
        /// <param name="count">Number of characters as int</param>
        private void updateComponent(Label updateLabel, int count)
        {
            // For each case, we change the display colours
            if (count > 1) // Greater than 1
            { updateLabel.BackColor = colourPalette[4]; updateLabel.ForeColor = Color.White; }
            else if (count > 0) // Only one
            { updateLabel.BackColor = colourPalette[2]; updateLabel.ForeColor = Color.Black; }
            else // None
            { updateLabel.BackColor = colourPalette[0]; updateLabel.ForeColor = Color.White; }
        }

        /// <summary>
        /// Returns the overall score of a password
        /// </summary>
        /// <param name="password">Password as string</param>
        /// <returns>Score as int from 0 to 4</returns>
        private int getScore(string password)
        {
            // If the length of the password is above 0, we check the score
            // using the Zxcvbn library and return the score
            if (password.Length > 0)
            {
                ZxcvbnResult result = Zxcvbn.Evaluate(password);
                return result.Score; // Score from 0 to 4
            }
            else
                return 0;
        }

        /// <summary>
        /// Draws the overall score
        /// </summary>
        /// <param name="score">The score as an int</param>
        private void drawScore(int score)
        {
            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(lblStrength.Size.Width, lblStrength.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Width and height to be displayed
            int height = BitmapImage.Size.Height - 8;
            int width = BitmapImage.Size.Width - 8;

            // Draws the background, progress and a border
            GraphicsFromImage.FillRectangle(new SolidBrush(Color.FromArgb(191, 191, 191)), 4, 4, width, height);
            GraphicsFromImage.FillRectangle(new SolidBrush(colourPalette[score]), 4, 4, (width * score) / 4, height);
            GraphicsFromImage.DrawRectangle(new Pen(Color.FromArgb(89, 89, 89), 2), 4, 4, width, height);

            // For each case of score, we display the text
            if (score == 0)
                lblStrength.Text = text[7]; // Very Weak
            else if (score == 1)
                lblStrength.Text = text[8]; // Weak
            else if (score == 2)
                lblStrength.Text = text[9]; // Normal
            else if (score == 3)
                lblStrength.Text = text[10]; // Strong
            else
                lblStrength.Text = text[11]; // Very Strong

            // Applying to the label
            lblStrength.Image = BitmapImage;
        }

        /// <summary>
        /// Update the tooltips of the labels
        /// </summary>
        public void updateTooltips()
        {
            tltMain.SetToolTip(lblCount, text[13]); // Count
            tltMain.SetToolTip(lblLowercase, text[15]); // Lowercase
            tltMain.SetToolTip(lblUppercase, text[17]); // Uppercase
            tltMain.SetToolTip(lblNumbers, text[19]); // Numbers
            tltMain.SetToolTip(lblSymbols, text[21]); // Symbols
            tltMain.SetToolTip(lblStrength, text[23]); // Strength score
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
                return LanguageManagement.parse(text[24], new string[] { count.ToString(), singularForm });
            else
                return LanguageManagement.parse(text[24], new string[] { count.ToString(), pluralForm });
        }

        /// <summary>
        /// Sets the title text of the form
        /// </summary>
        /// <param name="_text"></param>
        public void setText(string[] _text)
        {
            text = _text;
        }
    }
}
