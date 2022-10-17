
namespace password_manager_CSharpGUI
{
    partial class frmAddPassword
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
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.spcButton = new System.Windows.Forms.SplitContainer();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblApply = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tlpPlatform = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlatformFields = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new password_manager_CSharpGUI.WatermarkTextBox();
            this.txtPlatform = new password_manager_CSharpGUI.WatermarkTextBox();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.passwordGenerator = new password_manager_CSharpGUI.PasswordGenerator();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.bgwAdd = new System.ComponentModel.BackgroundWorker();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).BeginInit();
            this.spcButton.Panel1.SuspendLayout();
            this.spcButton.Panel2.SuspendLayout();
            this.spcButton.SuspendLayout();
            this.tlpPlatform.SuspendLayout();
            this.tlpPlatformFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tlpButtons.Controls.Add(this.spcButton, 2, 0);
            this.tlpButtons.Controls.Add(this.btnCopy, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(2, 214);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(430, 50);
            this.tlpButtons.TabIndex = 1;
            // 
            // spcButton
            // 
            this.spcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcButton.Location = new System.Drawing.Point(202, 8);
            this.spcButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.spcButton.Name = "spcButton";
            // 
            // spcButton.Panel1
            // 
            this.spcButton.Panel1.Controls.Add(this.btnApply);
            // 
            // spcButton.Panel2
            // 
            this.spcButton.Panel2.Controls.Add(this.lblApply);
            this.spcButton.Size = new System.Drawing.Size(220, 34);
            this.spcButton.SplitterDistance = 108;
            this.spcButton.SplitterWidth = 3;
            this.spcButton.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(0, 0);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(108, 34);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Add Password";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblApply
            // 
            this.lblApply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApply.Location = new System.Drawing.Point(0, 0);
            this.lblApply.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApply.Name = "lblApply";
            this.lblApply.Size = new System.Drawing.Size(109, 34);
            this.lblApply.TabIndex = 0;
            this.lblApply.Text = "Add Password";
            this.lblApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Location = new System.Drawing.Point(8, 8);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(29, 34);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tlpPlatform
            // 
            this.tlpPlatform.ColumnCount = 2;
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPlatform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.Controls.Add(this.tlpPlatformFields, 1, 0);
            this.tlpPlatform.Controls.Add(this.pcbIcon, 0, 0);
            this.tlpPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatform.Location = new System.Drawing.Point(8, 8);
            this.tlpPlatform.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.tlpPlatform.Name = "tlpPlatform";
            this.tlpPlatform.RowCount = 1;
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpPlatform.Size = new System.Drawing.Size(418, 74);
            this.tlpPlatform.TabIndex = 0;
            // 
            // tlpPlatformFields
            // 
            this.tlpPlatformFields.ColumnCount = 1;
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpPlatformFields.Controls.Add(this.txtUsername, 0, 1);
            this.tlpPlatformFields.Controls.Add(this.txtPlatform, 0, 0);
            this.tlpPlatformFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatformFields.Location = new System.Drawing.Point(74, 2);
            this.tlpPlatformFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpPlatformFields.Name = "tlpPlatformFields";
            this.tlpPlatformFields.RowCount = 2;
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.Size = new System.Drawing.Size(342, 70);
            this.tlpPlatformFields.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(8, 39);
            this.txtUsername.MainText = "";
            this.txtUsername.Margin = new System.Windows.Forms.Padding(8, 4, 8, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(326, 24);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.WatermarkActive = false;
            this.txtUsername.WatermarkText = "";
            this.txtUsername.TextChanged += new System.EventHandler(this.MyTextChanged);
            // 
            // txtPlatform
            // 
            this.txtPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlatform.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.ForeColor = System.Drawing.Color.Black;
            this.txtPlatform.Location = new System.Drawing.Point(8, 7);
            this.txtPlatform.MainText = "";
            this.txtPlatform.Margin = new System.Windows.Forms.Padding(8, 2, 8, 4);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(326, 24);
            this.txtPlatform.TabIndex = 1;
            this.txtPlatform.WatermarkActive = false;
            this.txtPlatform.WatermarkText = "";
            this.txtPlatform.TextChanged += new System.EventHandler(this.MyTextChanged);
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(8, 8);
            this.pcbIcon.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(56, 58);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpPlatform, 0, 0);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 2);
            this.tlpMain.Controls.Add(this.passwordGenerator, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpMain.Size = new System.Drawing.Size(434, 266);
            this.tlpMain.TabIndex = 0;
            // 
            // passwordGenerator
            // 
            this.passwordGenerator.BackColor = System.Drawing.Color.SeaShell;
            this.passwordGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGenerator.Location = new System.Drawing.Point(8, 90);
            this.passwordGenerator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.passwordGenerator.Name = "passwordGenerator";
            this.passwordGenerator.Size = new System.Drawing.Size(418, 114);
            this.passwordGenerator.TabIndex = 3;
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // bgwAdd
            // 
            this.bgwAdd.WorkerReportsProgress = true;
            this.bgwAdd.WorkerSupportsCancellation = true;
            this.bgwAdd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwAdd_DoWork);
            // 
            // frmAddPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 266);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 305);
            this.Name = "frmAddPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Password";
            this.tltMain.SetToolTip(this, "Add Password");
            this.Load += new System.EventHandler(this.frmAddPassword_Load);
            this.tlpButtons.ResumeLayout(false);
            this.spcButton.Panel1.ResumeLayout(false);
            this.spcButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).EndInit();
            this.spcButton.ResumeLayout(false);
            this.tlpPlatform.ResumeLayout(false);
            this.tlpPlatformFields.ResumeLayout(false);
            this.tlpPlatformFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.SplitContainer spcButton;
        private System.Windows.Forms.TableLayoutPanel tlpPlatform;
        private System.Windows.Forms.TableLayoutPanel tlpPlatformFields;
        private WatermarkTextBox txtUsername;
        private WatermarkTextBox txtPlatform;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblApply;
        private System.Windows.Forms.Button btnCopy;
        private PasswordGenerator passwordGenerator;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.ComponentModel.BackgroundWorker bgwAdd;
    }
}