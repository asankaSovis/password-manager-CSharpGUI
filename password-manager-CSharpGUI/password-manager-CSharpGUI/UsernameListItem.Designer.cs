
namespace password_manager_CSharpGUI
{
    partial class UsernameListItem
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
            this.tlpPlatform = new System.Windows.Forms.TableLayoutPanel();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.spcUsername = new System.Windows.Forms.SplitContainer();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpPlatform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcUsername)).BeginInit();
            this.spcUsername.Panel1.SuspendLayout();
            this.spcUsername.Panel2.SuspendLayout();
            this.spcUsername.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPlatform
            // 
            this.tlpPlatform.ColumnCount = 2;
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.Controls.Add(this.pcbIcon, 0, 0);
            this.tlpPlatform.Controls.Add(this.spcUsername, 1, 0);
            this.tlpPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatform.Location = new System.Drawing.Point(0, 0);
            this.tlpPlatform.Name = "tlpPlatform";
            this.tlpPlatform.RowCount = 1;
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPlatform.Size = new System.Drawing.Size(377, 51);
            this.tlpPlatform.TabIndex = 1;
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
            this.pcbIcon.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pcbIcon.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // spcUsername
            // 
            this.spcUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcUsername.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcUsername.IsSplitterFixed = true;
            this.spcUsername.Location = new System.Drawing.Point(54, 3);
            this.spcUsername.Name = "spcUsername";
            // 
            // spcUsername.Panel1
            // 
            this.spcUsername.Panel1.Controls.Add(this.lblUsername);
            // 
            // spcUsername.Panel2
            // 
            this.spcUsername.Panel2.Controls.Add(this.tlpControls);
            this.spcUsername.Panel2Collapsed = true;
            this.spcUsername.Size = new System.Drawing.Size(320, 45);
            this.spcUsername.SplitterDistance = 197;
            this.spcUsername.TabIndex = 1;
            this.spcUsername.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(320, 45);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 2;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.Controls.Add(this.btnView, 0, 0);
            this.tlpControls.Controls.Add(this.btnDelete, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControls.Size = new System.Drawing.Size(96, 100);
            this.tlpControls.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(42, 94);
            this.btnView.TabIndex = 0;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(51, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 94);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // UsernameListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPlatform);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "UsernameListItem";
            this.Size = new System.Drawing.Size(377, 51);
            this.tlpPlatform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.spcUsername.Panel1.ResumeLayout(false);
            this.spcUsername.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcUsername)).EndInit();
            this.spcUsername.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlatform;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.SplitContainer spcUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip tltMain;
    }
}
