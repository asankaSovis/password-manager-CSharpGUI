
namespace password_manager_CSharpGUI
{
    partial class frmMain
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
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tstCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pcbBanner = new System.Windows.Forms.PictureBox();
            this.grpPasswords = new System.Windows.Forms.GroupBox();
            this.tlpPasswords = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProfile = new System.Windows.Forms.TableLayoutPanel();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.flpPlatforms = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUsernames = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new System.Windows.Forms.Button();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new password_manager_CSharpGUI.WatermarkTextBox();
            this.stsMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanner)).BeginInit();
            this.grpPasswords.SuspendLayout();
            this.tlpPasswords.SuspendLayout();
            this.tlpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.AutoSize = false;
            this.stsMain.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstStatus,
            this.tstProgress,
            this.tstCount});
            this.stsMain.Location = new System.Drawing.Point(0, 615);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(570, 28);
            this.stsMain.TabIndex = 0;
            this.stsMain.Text = "stsMain";
            // 
            // tstStatus
            // 
            this.tstStatus.AutoSize = false;
            this.tstStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tstStatus.Name = "tstStatus";
            this.tstStatus.Size = new System.Drawing.Size(400, 22);
            this.tstStatus.Text = "No Platforms...";
            this.tstStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstProgress
            // 
            this.tstProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstProgress.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tstProgress.Name = "tstProgress";
            this.tstProgress.Size = new System.Drawing.Size(79, 18);
            this.tstProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tstProgress.Visible = false;
            // 
            // tstCount
            // 
            this.tstCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tstCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstCount.Name = "tstCount";
            this.tstCount.Size = new System.Drawing.Size(37, 22);
            this.tstCount.Spring = true;
            this.tstCount.Text = "0 Passwords";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pcbBanner, 0, 0);
            this.tlpMain.Controls.Add(this.grpPasswords, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(570, 615);
            this.tlpMain.TabIndex = 1;
            // 
            // pcbBanner
            // 
            this.pcbBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbBanner.Location = new System.Drawing.Point(3, 3);
            this.pcbBanner.Name = "pcbBanner";
            this.pcbBanner.Size = new System.Drawing.Size(564, 84);
            this.pcbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBanner.TabIndex = 1;
            this.pcbBanner.TabStop = false;
            // 
            // grpPasswords
            // 
            this.grpPasswords.Controls.Add(this.tlpPasswords);
            this.grpPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPasswords.Location = new System.Drawing.Point(3, 93);
            this.grpPasswords.Name = "grpPasswords";
            this.grpPasswords.Size = new System.Drawing.Size(564, 519);
            this.grpPasswords.TabIndex = 3;
            this.grpPasswords.TabStop = false;
            this.grpPasswords.Text = "Profiles";
            // 
            // tlpPasswords
            // 
            this.tlpPasswords.ColumnCount = 1;
            this.tlpPasswords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPasswords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPasswords.Controls.Add(this.tlpProfile, 0, 0);
            this.tlpPasswords.Controls.Add(this.tlpBottom, 0, 1);
            this.tlpPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPasswords.Location = new System.Drawing.Point(3, 18);
            this.tlpPasswords.Name = "tlpPasswords";
            this.tlpPasswords.RowCount = 2;
            this.tlpPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPasswords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpPasswords.Size = new System.Drawing.Size(558, 498);
            this.tlpPasswords.TabIndex = 0;
            // 
            // tlpProfile
            // 
            this.tlpProfile.ColumnCount = 1;
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProfile.Controls.Add(this.spcMain, 0, 1);
            this.tlpProfile.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfile.Location = new System.Drawing.Point(3, 3);
            this.tlpProfile.Name = "tlpProfile";
            this.tlpProfile.RowCount = 2;
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProfile.Size = new System.Drawing.Size(552, 434);
            this.tlpProfile.TabIndex = 2;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(3, 50);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.flpPlatforms);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.flpUsernames);
            this.spcMain.Panel2Collapsed = true;
            this.spcMain.Size = new System.Drawing.Size(546, 381);
            this.spcMain.SplitterDistance = 232;
            this.spcMain.TabIndex = 2;
            // 
            // flpPlatforms
            // 
            this.flpPlatforms.AutoScroll = true;
            this.flpPlatforms.AutoSize = true;
            this.flpPlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlatforms.Location = new System.Drawing.Point(0, 0);
            this.flpPlatforms.Name = "flpPlatforms";
            this.flpPlatforms.Size = new System.Drawing.Size(546, 381);
            this.flpPlatforms.TabIndex = 0;
            this.flpPlatforms.WrapContents = false;
            this.flpPlatforms.Click += new System.EventHandler(this.flpPlatforms_Click);
            // 
            // flpUsernames
            // 
            this.flpUsernames.AutoScroll = true;
            this.flpUsernames.AutoSize = true;
            this.flpUsernames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpUsernames.Location = new System.Drawing.Point(0, 0);
            this.flpUsernames.Name = "flpUsernames";
            this.flpUsernames.Size = new System.Drawing.Size(96, 100);
            this.flpUsernames.TabIndex = 1;
            this.flpUsernames.WrapContents = false;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Controls.Add(this.btnReload, 0, 0);
            this.tlpSearch.Controls.Add(this.txtSearch, 1, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 3);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(546, 41);
            this.tlpSearch.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 2;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 6;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpBottom.Controls.Add(this.btnAdd, 5, 0);
            this.tlpBottom.Controls.Add(this.btnSettings, 2, 0);
            this.tlpBottom.Controls.Add(this.btnAbout, 3, 0);
            this.tlpBottom.Controls.Add(this.btnLock, 0, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(3, 443);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(552, 52);
            this.tlpBottom.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(335, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(143, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 46);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.Location = new System.Drawing.Point(195, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(46, 46);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLock
            // 
            this.btnLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLock.Location = new System.Drawing.Point(3, 3);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(46, 46);
            this.btnLock.TabIndex = 6;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.WorkerReportsProgress = true;
            this.bgwLoad.WorkerSupportsCancellation = true;
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(44, 9);
            this.txtSearch.MainText = "";
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(499, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.WatermarkActive = true;
            this.txtSearch.WatermarkText = "Type here";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 643);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.stsMain);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Muragala Password Manager";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanner)).EndInit();
            this.grpPasswords.ResumeLayout(false);
            this.tlpPasswords.ResumeLayout(false);
            this.tlpProfile.ResumeLayout(false);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.tlpBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pcbBanner;
        private System.Windows.Forms.GroupBox grpPasswords;
        private System.Windows.Forms.TableLayoutPanel tlpPasswords;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.ToolStripStatusLabel tstStatus;
        private System.Windows.Forms.ToolStripProgressBar tstProgress;
        private System.Windows.Forms.ToolStripStatusLabel tstCount;
        private System.ComponentModel.BackgroundWorker bgwLoad;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.TableLayoutPanel tlpProfile;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.FlowLayoutPanel flpPlatforms;
        private System.Windows.Forms.FlowLayoutPanel flpUsernames;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.Button btnLock;
        private WatermarkTextBox txtSearch;
    }
}

