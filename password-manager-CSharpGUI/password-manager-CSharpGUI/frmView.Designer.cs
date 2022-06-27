
namespace password_manager_CSharpGUI
{
    partial class frmView
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tlpPlatform = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlatformFields = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tlpProfile = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.btnVisit = new System.Windows.Forms.Button();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.spcMore = new System.Windows.Forms.SplitContainer();
            this.tlpAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.psmMain = new password_manager_CSharpGUI.PasswordStrengthMeter();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.tlpPassword = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.spcPassword = new System.Windows.Forms.SplitContainer();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tlpTextbox = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.bgwWork = new System.ComponentModel.BackgroundWorker();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpPlatform.SuspendLayout();
            this.tlpPlatformFields.SuspendLayout();
            this.tlpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMore)).BeginInit();
            this.spcMore.Panel1.SuspendLayout();
            this.spcMore.Panel2.SuspendLayout();
            this.spcMore.SuspendLayout();
            this.tlpAdvanced.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.tlpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPassword)).BeginInit();
            this.spcPassword.Panel1.SuspendLayout();
            this.spcPassword.Panel2.SuspendLayout();
            this.spcPassword.SuspendLayout();
            this.tlpTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 3);
            this.tlpMain.Controls.Add(this.tlpPlatform, 0, 0);
            this.tlpMain.Controls.Add(this.spcMore, 0, 2);
            this.tlpMain.Controls.Add(this.tlpPassword, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(499, 459);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tlpButtons.Controls.Add(this.btnCopy, 0, 0);
            this.tlpButtons.Controls.Add(this.btnDone, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 396);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(493, 60);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(10, 10);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(10);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(10);
            this.btnCopy.Size = new System.Drawing.Size(40, 40);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.Enabled = false;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.Location = new System.Drawing.Point(268, 10);
            this.btnDone.Margin = new System.Windows.Forms.Padding(10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(215, 40);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            this.tlpPlatform.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.tlpPlatform.Name = "tlpPlatform";
            this.tlpPlatform.RowCount = 1;
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpPlatform.Size = new System.Drawing.Size(479, 96);
            this.tlpPlatform.TabIndex = 1;
            // 
            // tlpPlatformFields
            // 
            this.tlpPlatformFields.ColumnCount = 1;
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlatformFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlatformFields.Controls.Add(this.txtUsername, 0, 1);
            this.tlpPlatformFields.Controls.Add(this.tlpProfile, 0, 0);
            this.tlpPlatformFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlatformFields.Location = new System.Drawing.Point(99, 3);
            this.tlpPlatformFields.Name = "tlpPlatformFields";
            this.tlpPlatformFields.RowCount = 2;
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlatformFields.Size = new System.Drawing.Size(377, 90);
            this.tlpPlatformFields.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(10, 48);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(357, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TabStop = false;
            // 
            // tlpProfile
            // 
            this.tlpProfile.ColumnCount = 2;
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpProfile.Controls.Add(this.txtPlatform, 0, 0);
            this.tlpProfile.Controls.Add(this.btnVisit, 1, 0);
            this.tlpProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfile.Location = new System.Drawing.Point(3, 3);
            this.tlpProfile.Name = "tlpProfile";
            this.tlpProfile.RowCount = 1;
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpProfile.Size = new System.Drawing.Size(371, 39);
            this.tlpProfile.TabIndex = 1;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlatform.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.Location = new System.Drawing.Point(7, 6);
            this.txtPlatform.Margin = new System.Windows.Forms.Padding(7, 3, 0, 5);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(324, 28);
            this.txtPlatform.TabIndex = 1;
            this.txtPlatform.TabStop = false;
            // 
            // btnVisit
            // 
            this.btnVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVisit.Location = new System.Drawing.Point(331, 5);
            this.btnVisit.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(30, 29);
            this.btnVisit.TabIndex = 2;
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(10, 10);
            this.pcbIcon.Margin = new System.Windows.Forms.Padding(10);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(76, 76);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // spcMore
            // 
            this.spcMore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMore.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcMore.Location = new System.Drawing.Point(3, 162);
            this.spcMore.Name = "spcMore";
            this.spcMore.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMore.Panel1
            // 
            this.spcMore.Panel1.Controls.Add(this.tlpAdvanced);
            // 
            // spcMore.Panel2
            // 
            this.spcMore.Panel2.Controls.Add(this.btnCollapse);
            this.spcMore.Size = new System.Drawing.Size(493, 228);
            this.spcMore.SplitterDistance = 199;
            this.spcMore.TabIndex = 3;
            // 
            // tlpAdvanced
            // 
            this.tlpAdvanced.ColumnCount = 1;
            this.tlpAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdvanced.Controls.Add(this.psmMain, 0, 0);
            this.tlpAdvanced.Controls.Add(this.tlpStats, 0, 1);
            this.tlpAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdvanced.Location = new System.Drawing.Point(0, 0);
            this.tlpAdvanced.Name = "tlpAdvanced";
            this.tlpAdvanced.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tlpAdvanced.RowCount = 2;
            this.tlpAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpAdvanced.Size = new System.Drawing.Size(493, 199);
            this.tlpAdvanced.TabIndex = 0;
            // 
            // psmMain
            // 
            this.psmMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.psmMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.psmMain.Location = new System.Drawing.Point(13, 3);
            this.psmMain.Name = "psmMain";
            this.psmMain.Size = new System.Drawing.Size(467, 128);
            this.psmMain.TabIndex = 0;
            // 
            // tlpStats
            // 
            this.tlpStats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.Controls.Add(this.lblDate, 0, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Location = new System.Drawing.Point(13, 149);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStats.Size = new System.Drawing.Size(467, 37);
            this.tlpStats.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(227, 37);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date Added";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapse.Location = new System.Drawing.Point(0, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(493, 25);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.Text = "🔼";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // tlpPassword
            // 
            this.tlpPassword.ColumnCount = 3;
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.Controls.Add(this.btnEdit, 0, 0);
            this.tlpPassword.Controls.Add(this.btnDelete, 1, 0);
            this.tlpPassword.Controls.Add(this.spcPassword, 2, 0);
            this.tlpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPassword.Location = new System.Drawing.Point(3, 109);
            this.tlpPassword.Name = "tlpPassword";
            this.tlpPassword.RowCount = 1;
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPassword.Size = new System.Drawing.Size(493, 47);
            this.tlpPassword.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(5, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 37);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(52, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // spcPassword
            // 
            this.spcPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPassword.Location = new System.Drawing.Point(97, 3);
            this.spcPassword.Name = "spcPassword";
            this.spcPassword.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPassword.Panel1
            // 
            this.spcPassword.Panel1.Controls.Add(this.lblMessage);
            // 
            // spcPassword.Panel2
            // 
            this.spcPassword.Panel2.Controls.Add(this.tlpTextbox);
            this.spcPassword.Panel2Collapsed = true;
            this.spcPassword.Size = new System.Drawing.Size(393, 41);
            this.spcPassword.SplitterDistance = 25;
            this.spcPassword.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Location = new System.Drawing.Point(92, 7);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(204, 32);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Retrieving...";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTextbox
            // 
            this.tlpTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.tlpTextbox.ColumnCount = 1;
            this.tlpTextbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTextbox.Controls.Add(this.txtPassword, 0, 0);
            this.tlpTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTextbox.Location = new System.Drawing.Point(0, 0);
            this.tlpTextbox.Name = "tlpTextbox";
            this.tlpTextbox.RowCount = 1;
            this.tlpTextbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpTextbox.Size = new System.Drawing.Size(150, 46);
            this.tlpTextbox.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(0, 7);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 7, 20, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(130, 28);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // bgwWork
            // 
            this.bgwWork.WorkerReportsProgress = true;
            this.bgwWork.WorkerSupportsCancellation = true;
            this.bgwWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWork_DoWork);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Mragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 459);
            this.Controls.Add(this.tlpMain);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 300);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Password";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpPlatform.ResumeLayout(false);
            this.tlpPlatformFields.ResumeLayout(false);
            this.tlpPlatformFields.PerformLayout();
            this.tlpProfile.ResumeLayout(false);
            this.tlpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.spcMore.Panel1.ResumeLayout(false);
            this.spcMore.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMore)).EndInit();
            this.spcMore.ResumeLayout(false);
            this.tlpAdvanced.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.tlpPassword.ResumeLayout(false);
            this.spcPassword.Panel1.ResumeLayout(false);
            this.spcPassword.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPassword)).EndInit();
            this.spcPassword.ResumeLayout(false);
            this.tlpTextbox.ResumeLayout(false);
            this.tlpTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpPlatform;
        private System.Windows.Forms.TableLayoutPanel tlpPlatformFields;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.SplitContainer spcMore;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.TableLayoutPanel tlpPassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.SplitContainer spcPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TableLayoutPanel tlpTextbox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tlpAdvanced;
        private PasswordStrengthMeter psmMain;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrMain;
        private System.ComponentModel.BackgroundWorker bgwWork;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.TableLayoutPanel tlpProfile;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnDone;
    }
}