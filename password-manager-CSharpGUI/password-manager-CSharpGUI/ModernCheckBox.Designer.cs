
namespace password_manager_CSharpGUI
{
    partial class ModernCheckBox
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.chkMain = new System.Windows.Forms.CheckBox();
            this.lblString = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.chkMain, 0, 0);
            this.tlpMain.Controls.Add(this.lblString, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(310, 43);
            this.tlpMain.TabIndex = 0;
            // 
            // chkMain
            // 
            this.chkMain.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMain.Checked = true;
            this.chkMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMain.Location = new System.Drawing.Point(3, 3);
            this.chkMain.Name = "chkMain";
            this.chkMain.Size = new System.Drawing.Size(37, 37);
            this.chkMain.TabIndex = 0;
            this.chkMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkMain.UseVisualStyleBackColor = true;
            this.chkMain.CheckedChanged += new System.EventHandler(this.chkMain_CheckedChanged);
            // 
            // lblString
            // 
            this.lblString.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblString.Location = new System.Drawing.Point(46, 0);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(261, 43);
            this.lblString.TabIndex = 1;
            this.lblString.Text = "String";
            this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModernCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ModernCheckBox";
            this.Size = new System.Drawing.Size(310, 43);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.CheckBox chkMain;
        private System.Windows.Forms.Label lblString;
    }
}
