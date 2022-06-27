
namespace password_manager_CSharpGUI
{
    partial class LanguageItem
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
            this.tlpLanguage = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegion = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.tlpLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLanguage
            // 
            this.tlpLanguage.ColumnCount = 3;
            this.tlpLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpLanguage.Controls.Add(this.lblRegion, 1, 0);
            this.tlpLanguage.Controls.Add(this.pcbIcon, 2, 0);
            this.tlpLanguage.Controls.Add(this.lblLanguage, 0, 0);
            this.tlpLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLanguage.Location = new System.Drawing.Point(0, 0);
            this.tlpLanguage.Name = "tlpLanguage";
            this.tlpLanguage.RowCount = 1;
            this.tlpLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLanguage.Size = new System.Drawing.Size(326, 40);
            this.tlpLanguage.TabIndex = 0;
            // 
            // lblRegion
            // 
            this.lblRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(146, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(137, 40);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegion.Click += new System.EventHandler(this.MousePressed);
            this.lblRegion.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.lblRegion.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pcbIcon
            // 
            this.pcbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(289, 3);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(34, 34);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            this.pcbIcon.Click += new System.EventHandler(this.MousePressed);
            this.pcbIcon.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pcbIcon.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(3, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(137, 40);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLanguage.Click += new System.EventHandler(this.MousePressed);
            this.lblLanguage.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.lblLanguage.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // LanguageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpLanguage);
            this.Name = "LanguageItem";
            this.Size = new System.Drawing.Size(326, 40);
            this.tlpLanguage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLanguage;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblRegion;
    }
}
