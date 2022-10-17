
namespace password_manager_CSharpGUI
{
    partial class PasswordGenerator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCharacters = new System.Windows.Forms.TableLayoutPanel();
            this.lblLowercase = new System.Windows.Forms.Label();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.tlpGenerate = new System.Windows.Forms.TableLayoutPanel();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tlpPassword = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtPassword = new password_manager_CSharpGUI.WatermarkTextBox();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpCharacters.SuspendLayout();
            this.tlpGenerate.SuspendLayout();
            this.tlpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpCharacters, 0, 2);
            this.tlpMain.Controls.Add(this.tlpGenerate, 0, 1);
            this.tlpMain.Controls.Add(this.tlpPassword, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.53125F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.46875F));
            this.tlpMain.Size = new System.Drawing.Size(489, 145);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpCharacters
            // 
            this.tlpCharacters.ColumnCount = 4;
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCharacters.Controls.Add(this.lblLowercase, 0, 0);
            this.tlpCharacters.Controls.Add(this.chkUppercase, 1, 0);
            this.tlpCharacters.Controls.Add(this.chkNumbers, 2, 0);
            this.tlpCharacters.Controls.Add(this.chkSymbols, 3, 0);
            this.tlpCharacters.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharacters.Location = new System.Drawing.Point(2, 89);
            this.tlpCharacters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpCharacters.Name = "tlpCharacters";
            this.tlpCharacters.RowCount = 1;
            this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpCharacters.Size = new System.Drawing.Size(485, 54);
            this.tlpCharacters.TabIndex = 0;
            // 
            // lblLowercase
            // 
            this.lblLowercase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLowercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLowercase.Location = new System.Drawing.Point(4, 5);
            this.lblLowercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLowercase.Name = "lblLowercase";
            this.lblLowercase.Size = new System.Drawing.Size(113, 44);
            this.lblLowercase.TabIndex = 0;
            this.lblLowercase.Text = "abcd     ";
            this.lblLowercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUppercase
            // 
            this.chkUppercase.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUppercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUppercase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkUppercase.Location = new System.Drawing.Point(123, 2);
            this.chkUppercase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(117, 50);
            this.chkUppercase.TabIndex = 1;
            this.chkUppercase.Text = "ABCD     ";
            this.chkUppercase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUppercase.UseVisualStyleBackColor = true;
            this.chkUppercase.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkNumbers
            // 
            this.chkNumbers.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNumbers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkNumbers.Location = new System.Drawing.Point(244, 2);
            this.chkNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(117, 50);
            this.chkNumbers.TabIndex = 2;
            this.chkNumbers.Text = "1234     ";
            this.chkNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkSymbols
            // 
            this.chkSymbols.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSymbols.Location = new System.Drawing.Point(365, 2);
            this.chkSymbols.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(118, 50);
            this.chkSymbols.TabIndex = 3;
            this.chkSymbols.Text = "@#%?     ";
            this.chkSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tlpGenerate
            // 
            this.tlpGenerate.ColumnCount = 2;
            this.tlpGenerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGenerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpGenerate.Controls.Add(this.lblStrength, 1, 0);
            this.tlpGenerate.Controls.Add(this.lblCount, 0, 0);
            this.tlpGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGenerate.Location = new System.Drawing.Point(2, 43);
            this.tlpGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpGenerate.Name = "tlpGenerate";
            this.tlpGenerate.RowCount = 1;
            this.tlpGenerate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGenerate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpGenerate.Size = new System.Drawing.Size(485, 42);
            this.tlpGenerate.TabIndex = 1;
            // 
            // lblStrength
            // 
            this.lblStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.DimGray;
            this.lblStrength.Location = new System.Drawing.Point(377, 2);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(106, 38);
            this.lblStrength.TabIndex = 1;
            this.lblStrength.Text = "Strong";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblCount.Location = new System.Drawing.Point(2, 0);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(371, 42);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "No Characters!";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseEvent);
            this.lblCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCount_MouseMove);
            this.lblCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseEvent);
            // 
            // tlpPassword
            // 
            this.tlpPassword.ColumnCount = 2;
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.Controls.Add(this.btnReload, 0, 0);
            this.tlpPassword.Controls.Add(this.txtPassword, 1, 0);
            this.tlpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPassword.Location = new System.Drawing.Point(2, 2);
            this.tlpPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpPassword.Name = "tlpPassword";
            this.tlpPassword.RowCount = 1;
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpPassword.Size = new System.Drawing.Size(485, 37);
            this.tlpPassword.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.Location = new System.Drawing.Point(2, 2);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(30, 33);
            this.btnReload.TabIndex = 0;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(42, 6);
            this.txtPassword.MainText = "";
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(435, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.WatermarkActive = false;
            this.txtPassword.WatermarkText = "";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "PasswordGenerator";
            this.Size = new System.Drawing.Size(489, 145);
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpCharacters.ResumeLayout(false);
            this.tlpGenerate.ResumeLayout(false);
            this.tlpPassword.ResumeLayout(false);
            this.tlpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpCharacters;
        private System.Windows.Forms.Label lblLowercase;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.TableLayoutPanel tlpGenerate;
        private System.Windows.Forms.TableLayoutPanel tlpPassword;
        private System.Windows.Forms.Button btnReload;
        private WatermarkTextBox txtPassword;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolTip tltMain;
    }
}
