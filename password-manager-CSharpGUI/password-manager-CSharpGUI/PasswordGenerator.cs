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

namespace password_manager_CSharpGUI
{
    public partial class PasswordGenerator : UserControl
    {
        frmAddPassword parent = null;

        // Text strings
        // Tooltiptitles
        // { 0: Reload button, 1: Textbox, 2: Count label, 3: Lowercase label 4: Uppercase label
        //   5: Number label, 6: Symbol label, 7: Strength label, 8: Count string}
        // Errors
        // { 9: Textbox Error }
        // Parameter strings
        //   10: No characters, 11: character, 12: characters, 13: Only <>, 14: Weak <> characters
        //   15: Good <> characters, 16: Over <> characters, 17: Very weak, 18: Weak, 19: Normal,
        //   20: Strong, 21: Very strong
        string[] text = new string[22]; // Display text strings

        int passwordLength = 12;
        int[] lengthRange = { 0, 32 };

        // Colour pallette of the meter
        Color[] colourPalette = {
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(228, 8, 8),
            Color.FromArgb(255, 216, 0),
            Color.FromArgb(44, 177, 23),
            Color.FromArgb(44, 177, 23)
        };

        // { switch off, switch on }
        Image[] switchIcons = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading the user control
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            // Updates the slider
            updateSlider();
        }

        /// <summary>
        /// Mouse moved across the count label
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void lblCount_MouseMove(object sender, MouseEventArgs e)
        {
            // If the left mouse button is clicked, we update the slider
            if (e.Button == MouseButtons.Left)
            {
                updateLength(updateSlider());
                this.Refresh();
            }
        }

        /// <summary>
        /// In case of mouse down and mouse up, we do the same thing as mouse move
        /// to keep graphics consistent
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void MouseEvent(object sender, MouseEventArgs e)
        {
            updateLength(updateSlider());
        }

        /// <summary>
        /// When text in password text box is changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Changes the password and if parent exist, we call the text
            // changed function
            changePassword(txtPassword.Text);

            if (parent != null)
                parent.MyTextChanged(null, null);
        }

        /// <summary>
        /// Reload button clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            refreshPassword(); // We refresh the password
        }

        /// <summary>
        /// Suppress the keypresses of invalid characters
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguements</param>
        private new void KeyDown(object sender, KeyEventArgs e)
        {
            // The following keys are rejected: Enter, Space
            // Shows a tooltip with warning
            Keys[] suppress = { Keys.Space, Keys.Enter };
            if (suppress.Contains(e.KeyCode))
            {
                //tltMain.Show(lang.get("03x0011"), btnAdd);
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// When a tooltip is to be shown
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void tltMain_Popup(object sender, PopupEventArgs e)
        {
            if (e.AssociatedControl == btnReload) // Reload button title
                tltMain.ToolTipTitle = text[0];
            else if (e.AssociatedControl == txtPassword) // Password
                tltMain.ToolTipTitle = text[1];
            else if (e.AssociatedControl == lblCount) // Count label
                tltMain.ToolTipTitle = text[2];
            else if (e.AssociatedControl == lblLowercase) // Lowercase
                tltMain.ToolTipTitle = text[3];
            else if (e.AssociatedControl == chkUppercase) // Uppercase
                tltMain.ToolTipTitle = text[4];
            else if (e.AssociatedControl == chkNumbers) // Numbers
                tltMain.ToolTipTitle = text[5];
            else if (e.AssociatedControl == chkSymbols) // Symbols
                tltMain.ToolTipTitle = text[6];
            else if (e.AssociatedControl == lblStrength) // Strength label
                tltMain.ToolTipTitle = text[7];
            else
                tltMain.ToolTipTitle = e.AssociatedControl.Text; // Any other control
        }

        /// <summary>
        /// Checked changed of each check box
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Arguements</param>
        private void CheckedChanged(object sender, EventArgs e)
        {
            // We change the button images of each checkbox accordingly
            if (chkUppercase.Checked)
                chkUppercase.Image = switchIcons[1];
            else
                chkUppercase.Image = switchIcons[0];

            if (chkNumbers.Checked)
                chkNumbers.Image = switchIcons[1];
            else
                chkNumbers.Image = switchIcons[0];

            if (chkSymbols.Checked)
                chkSymbols.Image = switchIcons[1];
            else
                chkSymbols.Image = switchIcons[0];

            refreshPassword(); // Password is also refreshed
        }

        ///////////////////////////////////////////////////////////////
        /// INITIALIZE FUNCTIONS

        /// <summary>
        /// Initializes the settings
        /// </summary>
        /// <param name="_parent">Parent form</param>
        /// <param name="refreshIcon">Refresh icon</param>
        /// <param name="_switchIcons">Switch icons</param>
        public void initialize(frmAddPassword _parent, Image refreshIcon, Image[] _switchIcons)
        {
            parent = _parent;

            btnReload.Image = refreshIcon;
            switchIcons = _switchIcons;
            lblLowercase.Image = switchIcons[1];
        }

        /// <summary>
        /// Loads the text strings
        /// </summary>
        /// <param name="_text">String array</param>
        public void loadStrings(string[] _text)
        {
            /// Tooltips and watermark
            txtPassword.ApplyWatermark(_text[0]);
            text[0] = _text[1];
            tltMain.SetToolTip(btnReload, _text[2]);
            text[1] = _text[3];
            tltMain.SetToolTip(txtPassword, _text[4]);

            // Text strings
            text[2] = _text[5]; // Count label
            tltMain.SetToolTip(lblCount, _text[6]);
            text[3] = _text[7]; // Lowercase label
            tltMain.SetToolTip(lblLowercase, _text[8]);
            text[4] = _text[9]; // Uppercase label
            tltMain.SetToolTip(chkUppercase, _text[10]);
            text[5] = _text[11]; // Number label
            tltMain.SetToolTip(chkNumbers, _text[12]);
            text[6] = _text[13]; // Symbol label
            tltMain.SetToolTip(chkSymbols, _text[14]);
            text[7] = _text[15]; // Strength label
            tltMain.SetToolTip(lblStrength, _text[16]);
            text[8] = _text[17]; // Count string
            text[9] = _text[18]; // Textbox error
            text[10] = _text[19]; // No characters
            text[11] = _text[20]; // character
            text[12] = _text[21]; // characters
            text[13] = _text[22]; // Only <>
            text[14] = _text[23]; // Weak <> characters
            text[15] = _text[24]; // Good <> characters
            text[16] = _text[25]; // Over <> characters
            text[17] = _text[26]; // Very Weak
            text[18] = _text[27]; // Weak
            text[19] = _text[28]; // Normal
            text[20] = _text[29]; // Strong
            text[21] = _text[30]; // Very Strong
        }

        /// <summary>
        /// Refreshes the settings { length, uppercase, numbers, symbols}
        /// </summary>
        /// <param name="settings">Settings</param>
        public void refreshSettings(Tuple<int, bool, bool, bool> settings)
        {
            passwordLength = settings.Item1;
            chkUppercase.Checked = settings.Item2;
            chkNumbers.Checked = settings.Item2;
            chkSymbols.Checked = settings.Item3;
        }

        /// <summary>
        /// Reload a new password
        /// </summary>
        public void refreshPassword()
        {
            // Gets a new random password from the parent
            txtPassword.MainText = parent.getRandomPassword(passwordLength, chkUppercase.Checked, chkNumbers.Checked, chkSymbols.Checked);
        }

        /// <summary>
        /// Sets the password in the generator
        /// </summary>
        /// <param name="password">Password</param>
        public void setPassword(string password)
        {
            txtPassword.MainText = password;
        }

        /// <summary>
        /// Returns the password set
        /// </summary>
        /// <returns>Password as string</returns>
        public string getPassword()
        {
            return txtPassword.MainText;
        }

        /// <summary>
        /// Updates the length of the password
        /// </summary>
        private void lengthUpdated()
        {
            // In this case we just create a new random password from parent
            txtPassword.MainText = parent.getRandomPassword(passwordLength, chkUppercase.Checked, chkNumbers.Checked, chkSymbols.Checked);
        }

        /// <summary>
        /// Updates the slider according to the new value
        /// </summary>
        /// <returns>The new slider value { value, min, max }</returns>
        public Tuple<int, int, int> updateSlider()
        {
            if (lblCount.Image != null)
                lblCount.Image.Dispose();

            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(lblCount.Size.Width, lblCount.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Width and height to be displayed
            int height = BitmapImage.Size.Height - 8;
            int width = BitmapImage.Size.Width - 8;

            int sliderPosition;
            int colourSelection;

            if (passwordLength < 1) // No characters
                colourSelection = 0;
            else if (passwordLength < 5) // Very weak
                colourSelection = 1;
            else if (passwordLength < 8) // Weak
                colourSelection = 2;
            else if (passwordLength < 12) // Good
                colourSelection = 3;
            else // Strong
                colourSelection = 4;

            if (MouseButtons == MouseButtons.Left)
                sliderPosition = MousePosition.X - lblCount.Location.X - this.Location.X - parent.DesktopLocation.X;
            else
                sliderPosition = Map(passwordLength, lengthRange[0], lengthRange[1], 0, width);

            if (sliderPosition > width)
                sliderPosition = width;
            if (sliderPosition < 15)
                sliderPosition = 15;

            // Draws the background, progress and a border
            Plasmoid.Extensions.GraphicsExtension.FillRoundedRectangle(GraphicsFromImage, new SolidBrush(Color.FromArgb(191, 191, 191)), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            Plasmoid.Extensions.GraphicsExtension.FillRoundedRectangle(GraphicsFromImage, new SolidBrush(colourPalette[colourSelection]), 4, 4, sliderPosition, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            if (MouseButtons == MouseButtons.Left)
                Plasmoid.Extensions.GraphicsExtension.DrawRoundedRectangle(GraphicsFromImage, new Pen(colourPalette[colourSelection], 3), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);
            else
                Plasmoid.Extensions.GraphicsExtension.DrawRoundedRectangle(GraphicsFromImage, new Pen(Color.FromArgb(89, 89, 89), 2), 4, 4, width, height, 10, Plasmoid.Extensions.RectangleEdgeFilter.All);

            if (passwordLength < 1) // No characters
            {
                lblCount.Text = text[10];
                lblCount.ForeColor = Color.White;
            }
            else if (passwordLength < 5) // Very weak
            {
                lblCount.Text = LanguageManagement.parse(text[13], countString(passwordLength, text[11], text[12]));
                lblCount.ForeColor = Color.White;
            }
            else if (passwordLength < 8) // Weak
            {
                lblCount.Text = LanguageManagement.parse(text[14], passwordLength.ToString());
                lblCount.ForeColor = Color.Black;
            }
            else if (passwordLength < 12) // Good
            {
                lblCount.Text = LanguageManagement.parse(text[15], passwordLength.ToString());
                lblCount.ForeColor = Color.White;
            }
            else // Strong
            {
                lblCount.Text = LanguageManagement.parse(text[16], passwordLength.ToString());
                lblCount.ForeColor = Color.White;
            }

            // Applying to the picturebox
            lblCount.Image = BitmapImage;

            return new Tuple<int, int, int>(sliderPosition, 0, width);
        }

        /// <summary>
        /// Updates the length of the password
        /// </summary>
        /// <param name="sliderValue">Value on the slider</param>
        private void updateLength(Tuple<int, int, int> sliderValue)
        {
            // We map the values on the slider to the min and max of password lengths and change
            // the password length. Then we call the lengthUpdated function
            int tempLength = passwordLength;
            passwordLength = Map(sliderValue.Item1, sliderValue.Item2, sliderValue.Item3, lengthRange[0], lengthRange[1]);

            if (tempLength != passwordLength)
                lengthUpdated();
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

            // Update each character type with its relevant count
            updateComponent(lblLowercase, lowercase);
            updateComponent(chkUppercase, uppercase);
            updateComponent(chkNumbers, numbers);
            updateComponent(chkSymbols, symbols);

            passwordLength = txtPassword.MainText.Length;
            updateSlider();

            // Draw the overall score
            drawScore(score);

            return score; // Return the score
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
                lblStrength.Text = text[17]; // Very Weak
            else if (score == 1)
                lblStrength.Text = text[18]; // Weak
            else if (score == 2)
                lblStrength.Text = text[19]; // Normal
            else if (score == 3)
                lblStrength.Text = text[20]; // Strong
            else
                lblStrength.Text = text[21]; // Very Strong

            // Applying to the label
            lblStrength.Image = BitmapImage;
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
        /// Updates the number characters of each type
        /// </summary>
        /// <param name="updateLabel">The label associated</param>
        /// <param name="count">Number of characters as int</param>
        private void updateComponent(CheckBox updateLabel, int count)
        {
            // For each case, we change the display colours
            if (count > 1) // Greater than 1
            { updateLabel.BackColor = colourPalette[4]; updateLabel.ForeColor = Color.White; }
            else if (count > 0) // Only one
            { updateLabel.BackColor = colourPalette[2]; updateLabel.ForeColor = Color.Black; }
            else // None
            { updateLabel.BackColor = colourPalette[0]; updateLabel.ForeColor = Color.White; }
        }

        ///////////////////////////////////////////////////////////////
        /// MISCELLANEOUS FUNCTIONS

        /// <summary>
        /// Maps a value
        /// </summary>
        /// <param name="value">Source Value</param>
        /// <param name="fromLow">Lowest point of source</param>
        /// <param name="fromHigh">Highest point of source</param>
        /// <param name="toLow">Lowest point of destination</param>
        /// <param name="toHigh">Highest point of destination</param>
        /// <returns>Mapped value as integer</returns>
        private static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
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
                //return LanguageManagement.parse(text[24], new string[] { count.ToString(), singularForm });
                return LanguageManagement.parse(text[8], new string[] { count.ToString(), singularForm });
            else
                //return LanguageManagement.parse(text[24], new string[] { count.ToString(), pluralForm });
                return LanguageManagement.parse(text[8], new string[] { count.ToString(), pluralForm });
        }
    }
}
