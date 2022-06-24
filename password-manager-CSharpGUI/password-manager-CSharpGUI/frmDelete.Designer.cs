
namespace password_manager_CSharpGUI
{
    partial class frmDelete
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.spcButton = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.tlpPlatform = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlatformFields = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).BeginInit();
            this.spcButton.Panel1.SuspendLayout();
            this.spcButton.Panel2.SuspendLayout();
            this.spcButton.SuspendLayout();
            this.tlpPlatform.SuspendLayout();
            this.tlpPlatformFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Controls.Add(this.tlpPlatform, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpMain.Size = new System.Drawing.Size(499, 177);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.spcButton, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 114);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(493, 60);
            this.tlpButtons.TabIndex = 2;
            // 
            // spcButton
            // 
            this.spcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcButton.Location = new System.Drawing.Point(268, 10);
            this.spcButton.Margin = new System.Windows.Forms.Padding(10);
            this.spcButton.Name = "spcButton";
            // 
            // spcButton.Panel1
            // 
            this.spcButton.Panel1.Controls.Add(this.btnDelete);
            // 
            // spcButton.Panel2
            // 
            this.spcButton.Panel2.Controls.Add(this.lblDelete);
            this.spcButton.Size = new System.Drawing.Size(215, 40);
            this.spcButton.SplitterDistance = 106;
            this.spcButton.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Password";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDelete.Location = new System.Drawing.Point(0, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(105, 40);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "Delete Password";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPlatform
            // 
            this.tlpPlatform.ColumnCount = 2;
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.Controls.Add(this.tlpPlatformFields, 1, 0);
            this.tlpPlatform.Controls.Add(this.pcbIcon, 0, 0);
            this.tlpPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatform.Location = new System.Drawing.Point(10, 10);
            this.tlpPlatform.Margin = new System.Windows.Forms.Padding(10);
            this.tlpPlatform.Name = "tlpPlatform";
            this.tlpPlatform.RowCount = 1;
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpPlatform.Size = new System.Drawing.Size(479, 91);
            this.tlpPlatform.TabIndex = 1;
            // 
            // tlpPlatformFields
            // 
            this.tlpPlatformFields.ColumnCount = 1;
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlatformFields.Controls.Add(this.txtPlatform, 0, 0);
            this.tlpPlatformFields.Controls.Add(this.txtUsername, 0, 1);
            this.tlpPlatformFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatformFields.Location = new System.Drawing.Point(99, 3);
            this.tlpPlatformFields.Name = "tlpPlatformFields";
            this.tlpPlatformFields.RowCount = 2;
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.Size = new System.Drawing.Size(377, 85);
            this.tlpPlatformFields.TabIndex = 0;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlatform.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.Location = new System.Drawing.Point(10, 9);
            this.txtPlatform.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(357, 28);
            this.txtPlatform.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(10, 45);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(357, 28);
            this.txtUsername.TabIndex = 1;
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(10, 10);
            this.pcbIcon.Margin = new System.Windows.Forms.Padding(10);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(76, 71);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            // 
            // bgwMain
            // 
            this.bgwMain.WorkerReportsProgress = true;
            this.bgwMain.WorkerSupportsCancellation = true;
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwAdd_DoWork);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 177);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 222);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 222);
            this.Name = "frmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Password";
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.spcButton.Panel1.ResumeLayout(false);
            this.spcButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).EndInit();
            this.spcButton.ResumeLayout(false);
            this.tlpPlatform.ResumeLayout(false);
            this.tlpPlatformFields.ResumeLayout(false);
            this.tlpPlatformFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPlatform;
        private System.Windows.Forms.TableLayoutPanel tlpPlatformFields;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.SplitContainer spcButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolTip tltMain;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtUsername;
    }
}