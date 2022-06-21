
namespace password_manager_CSharpGUI
{
    partial class PlatformListItem
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
            this.tlpPlatform = new System.Windows.Forms.TableLayoutPanel();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblUsernames = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpPlatform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMain.Controls.Add(this.tlpPlatform, 0, 0);
            this.tlpMain.Controls.Add(this.lblUsernames, 0, 1);
            this.tlpMain.Controls.Add(this.lblArrow, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(377, 57);
            this.tlpMain.TabIndex = 0;
            this.tlpMain.Click += new System.EventHandler(this.MousePressed);
            this.tlpMain.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.tlpMain.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // tlpPlatform
            // 
            this.tlpPlatform.ColumnCount = 2;
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.Controls.Add(this.pcbIcon, 0, 0);
            this.tlpPlatform.Controls.Add(this.lblPlatform, 1, 0);
            this.tlpPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatform.Location = new System.Drawing.Point(3, 3);
            this.tlpPlatform.Name = "tlpPlatform";
            this.tlpPlatform.RowCount = 1;
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.Size = new System.Drawing.Size(342, 51);
            this.tlpPlatform.TabIndex = 0;
            this.tlpPlatform.Click += new System.EventHandler(this.MousePressed);
            this.tlpPlatform.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.tlpPlatform.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(3, 3);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(45, 45);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            this.pcbIcon.Click += new System.EventHandler(this.MousePressed);
            this.pcbIcon.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pcbIcon.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblPlatform
            // 
            this.lblPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatform.Location = new System.Drawing.Point(54, 0);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(285, 51);
            this.lblPlatform.TabIndex = 1;
            this.lblPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlatform.Click += new System.EventHandler(this.MousePressed);
            this.lblPlatform.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.lblPlatform.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblUsernames
            // 
            this.lblUsernames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsernames.Location = new System.Drawing.Point(3, 57);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(342, 1);
            this.lblUsernames.TabIndex = 1;
            this.lblUsernames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsernames.Click += new System.EventHandler(this.MousePressed);
            this.lblUsernames.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.lblUsernames.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblArrow
            // 
            this.lblArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrow.Font = new System.Drawing.Font("Miriam CLM", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArrow.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblArrow.Location = new System.Drawing.Point(351, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(23, 57);
            this.lblArrow.TabIndex = 2;
            this.lblArrow.Text = ">";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArrow.Click += new System.EventHandler(this.MousePressed);
            this.lblArrow.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.lblArrow.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // PlatformListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "PlatformListItem";
            this.Size = new System.Drawing.Size(377, 57);
            this.tlpMain.ResumeLayout(false);
            this.tlpPlatform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPlatform;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblUsernames;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.ToolTip tltMain;
    }
}
