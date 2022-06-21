
namespace password_manager_CSharpGUI
{
    partial class PasswordStrengthMeter
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
            this.lblCount = new System.Windows.Forms.Label();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblLowercase = new System.Windows.Forms.Label();
            this.lblUppercase = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblCount, 0, 1);
            this.tlpMain.Controls.Add(this.tlpStats, 0, 1);
            this.tlpMain.Controls.Add(this.lblStrength, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(652, 178);
            this.tlpMain.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(6, 89);
            this.lblCount.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(640, 40);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Only 8 characters";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnCount = 4;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStats.Controls.Add(this.lblLowercase, 0, 0);
            this.tlpStats.Controls.Add(this.lblUppercase, 1, 0);
            this.tlpStats.Controls.Add(this.lblNumbers, 2, 0);
            this.tlpStats.Controls.Add(this.lblSymbols, 3, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Location = new System.Drawing.Point(3, 135);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Size = new System.Drawing.Size(646, 40);
            this.tlpStats.TabIndex = 0;
            // 
            // lblLowercase
            // 
            this.lblLowercase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowercase.ForeColor = System.Drawing.Color.Black;
            this.lblLowercase.Location = new System.Drawing.Point(3, 3);
            this.lblLowercase.Margin = new System.Windows.Forms.Padding(3);
            this.lblLowercase.Name = "lblLowercase";
            this.lblLowercase.Size = new System.Drawing.Size(155, 34);
            this.lblLowercase.TabIndex = 1;
            this.lblLowercase.Text = "abcd";
            this.lblLowercase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUppercase
            // 
            this.lblUppercase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUppercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUppercase.ForeColor = System.Drawing.Color.Black;
            this.lblUppercase.Location = new System.Drawing.Point(164, 3);
            this.lblUppercase.Margin = new System.Windows.Forms.Padding(3);
            this.lblUppercase.Name = "lblUppercase";
            this.lblUppercase.Size = new System.Drawing.Size(155, 34);
            this.lblUppercase.TabIndex = 2;
            this.lblUppercase.Text = "ABCD";
            this.lblUppercase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblNumbers.Location = new System.Drawing.Point(325, 3);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(3);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(155, 34);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "1234";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSymbols
            // 
            this.lblSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSymbols.ForeColor = System.Drawing.Color.Black;
            this.lblSymbols.Location = new System.Drawing.Point(486, 3);
            this.lblSymbols.Margin = new System.Windows.Forms.Padding(3);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(157, 34);
            this.lblSymbols.TabIndex = 4;
            this.lblSymbols.Text = "@#%?";
            this.lblSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStrength
            // 
            this.lblStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.DimGray;
            this.lblStrength.Location = new System.Drawing.Point(3, 0);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(646, 86);
            this.lblStrength.TabIndex = 1;
            this.lblStrength.Text = "Strong";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // PasswordStrengthMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "PasswordStrengthMeter";
            this.Size = new System.Drawing.Size(652, 178);
            this.tlpMain.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Label lblLowercase;
        private System.Windows.Forms.Label lblUppercase;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolTip tltMain;
    }
}
