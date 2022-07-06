
namespace password_manager_CSharpGUI
{
    partial class frmAbout
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
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.tlpLinks = new System.Windows.Forms.TableLayoutPanel();
            this.lnkCopyright = new System.Windows.Forms.LinkLabel();
            this.lnkBlog = new System.Windows.Forms.LinkLabel();
            this.lnkLicense = new System.Windows.Forms.LinkLabel();
            this.lnkNotes = new System.Windows.Forms.LinkLabel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.spcAbout = new System.Windows.Forms.SplitContainer();
            this.tlpAbout = new System.Windows.Forms.TableLayoutPanel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.tlpInvolve = new System.Windows.Forms.TableLayoutPanel();
            this.lnkTranslate = new System.Windows.Forms.LinkLabel();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.lblInvolve = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.bgwUpdate = new System.ComponentModel.BackgroundWorker();
            this.tlpMain.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.tlpLinks.SuspendLayout();
            this.tlpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcAbout)).BeginInit();
            this.spcAbout.Panel1.SuspendLayout();
            this.spcAbout.Panel2.SuspendLayout();
            this.spcAbout.SuspendLayout();
            this.tlpAbout.SuspendLayout();
            this.tlpInvolve.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpBottom, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpMain.Size = new System.Drawing.Size(739, 369);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpBottom
            // 
            this.tlpBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpBottom.ColumnCount = 1;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Controls.Add(this.lblTrademark, 0, 1);
            this.tlpBottom.Controls.Add(this.tlpLinks, 0, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(0, 280);
            this.tlpBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 2;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBottom.Size = new System.Drawing.Size(739, 89);
            this.tlpBottom.TabIndex = 0;
            // 
            // lblTrademark
            // 
            this.lblTrademark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrademark.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrademark.Location = new System.Drawing.Point(3, 62);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(733, 27);
            this.lblTrademark.TabIndex = 0;
            this.lblTrademark.Text = "Trademark";
            this.lblTrademark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlpLinks
            // 
            this.tlpLinks.ColumnCount = 4;
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLinks.Controls.Add(this.lnkCopyright, 0, 0);
            this.tlpLinks.Controls.Add(this.lnkBlog, 0, 0);
            this.tlpLinks.Controls.Add(this.lnkLicense, 0, 0);
            this.tlpLinks.Controls.Add(this.lnkNotes, 1, 0);
            this.tlpLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLinks.Location = new System.Drawing.Point(3, 3);
            this.tlpLinks.Name = "tlpLinks";
            this.tlpLinks.RowCount = 1;
            this.tlpLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLinks.Size = new System.Drawing.Size(733, 56);
            this.tlpLinks.TabIndex = 1;
            // 
            // lnkCopyright
            // 
            this.lnkCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkCopyright.LinkColor = System.Drawing.Color.Black;
            this.lnkCopyright.Location = new System.Drawing.Point(369, 0);
            this.lnkCopyright.Name = "lnkCopyright";
            this.lnkCopyright.Size = new System.Drawing.Size(177, 56);
            this.lnkCopyright.TabIndex = 3;
            this.lnkCopyright.TabStop = true;
            this.lnkCopyright.Text = "Copyright";
            this.lnkCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // lnkBlog
            // 
            this.lnkBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkBlog.LinkColor = System.Drawing.Color.Black;
            this.lnkBlog.Location = new System.Drawing.Point(186, 0);
            this.lnkBlog.Name = "lnkBlog";
            this.lnkBlog.Size = new System.Drawing.Size(177, 56);
            this.lnkBlog.TabIndex = 2;
            this.lnkBlog.TabStop = true;
            this.lnkBlog.Text = "Blog";
            this.lnkBlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // lnkLicense
            // 
            this.lnkLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkLicense.LinkColor = System.Drawing.Color.Black;
            this.lnkLicense.Location = new System.Drawing.Point(3, 0);
            this.lnkLicense.Name = "lnkLicense";
            this.lnkLicense.Size = new System.Drawing.Size(177, 56);
            this.lnkLicense.TabIndex = 0;
            this.lnkLicense.TabStop = true;
            this.lnkLicense.Text = "License";
            this.lnkLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // lnkNotes
            // 
            this.lnkNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkNotes.LinkColor = System.Drawing.Color.Black;
            this.lnkNotes.Location = new System.Drawing.Point(552, 0);
            this.lnkNotes.Name = "lnkNotes";
            this.lnkNotes.Size = new System.Drawing.Size(178, 56);
            this.lnkNotes.TabIndex = 1;
            this.lnkNotes.TabStop = true;
            this.lnkNotes.Text = "Release Notes";
            this.lnkNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Controls.Add(this.pcbLogo, 0, 0);
            this.tlpTop.Controls.Add(this.spcAbout, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(733, 274);
            this.tlpTop.TabIndex = 1;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLogo.Location = new System.Drawing.Point(3, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(268, 268);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // spcAbout
            // 
            this.spcAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAbout.IsSplitterFixed = true;
            this.spcAbout.Location = new System.Drawing.Point(284, 10);
            this.spcAbout.Margin = new System.Windows.Forms.Padding(10);
            this.spcAbout.Name = "spcAbout";
            this.spcAbout.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcAbout.Panel1
            // 
            this.spcAbout.Panel1.Controls.Add(this.tlpAbout);
            // 
            // spcAbout.Panel2
            // 
            this.spcAbout.Panel2.Controls.Add(this.txtLicense);
            this.spcAbout.Panel2Collapsed = true;
            this.spcAbout.Size = new System.Drawing.Size(439, 254);
            this.spcAbout.SplitterDistance = 126;
            this.spcAbout.TabIndex = 1;
            // 
            // tlpAbout
            // 
            this.tlpAbout.ColumnCount = 1;
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAbout.Controls.Add(this.lblAbout, 0, 4);
            this.tlpAbout.Controls.Add(this.lblVersion, 0, 2);
            this.tlpAbout.Controls.Add(this.lblName, 0, 0);
            this.tlpAbout.Controls.Add(this.lblProduct, 0, 1);
            this.tlpAbout.Controls.Add(this.lblUpdate, 0, 3);
            this.tlpAbout.Controls.Add(this.tlpInvolve, 0, 5);
            this.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAbout.Location = new System.Drawing.Point(0, 0);
            this.tlpAbout.Name = "tlpAbout";
            this.tlpAbout.RowCount = 6;
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAbout.Size = new System.Drawing.Size(439, 254);
            this.tlpAbout.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAbout.Location = new System.Drawing.Point(10, 159);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(426, 66);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = "About";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(10, 92);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(426, 32);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "11.1 - Alpha (64-bit)";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 30.05217F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(436, 65);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Muragala";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(10, 65);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(426, 27);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Password Manager";
            // 
            // lblUpdate
            // 
            this.lblUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpdate.Location = new System.Drawing.Point(10, 124);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(426, 35);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "Update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpInvolve
            // 
            this.tlpInvolve.ColumnCount = 4;
            this.tlpInvolve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpInvolve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpInvolve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpInvolve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInvolve.Controls.Add(this.lnkTranslate, 0, 0);
            this.tlpInvolve.Controls.Add(this.lnkGithub, 0, 0);
            this.tlpInvolve.Controls.Add(this.lblInvolve, 0, 0);
            this.tlpInvolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInvolve.Location = new System.Drawing.Point(3, 228);
            this.tlpInvolve.Name = "tlpInvolve";
            this.tlpInvolve.RowCount = 1;
            this.tlpInvolve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInvolve.Size = new System.Drawing.Size(433, 23);
            this.tlpInvolve.TabIndex = 5;
            // 
            // lnkTranslate
            // 
            this.lnkTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTranslate.LinkColor = System.Drawing.Color.Black;
            this.lnkTranslate.Location = new System.Drawing.Point(222, 0);
            this.lnkTranslate.Name = "lnkTranslate";
            this.lnkTranslate.Size = new System.Drawing.Size(62, 23);
            this.lnkTranslate.TabIndex = 7;
            this.lnkTranslate.TabStop = true;
            this.lnkTranslate.Text = "Translate";
            this.lnkTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkTranslate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // lnkGithub
            // 
            this.lnkGithub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGithub.LinkColor = System.Drawing.Color.Black;
            this.lnkGithub.Location = new System.Drawing.Point(173, 0);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(43, 23);
            this.lnkGithub.TabIndex = 6;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "Github";
            this.lnkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClicked);
            // 
            // lblInvolve
            // 
            this.lblInvolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvolve.Location = new System.Drawing.Point(7, 0);
            this.lblInvolve.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.lblInvolve.Name = "lblInvolve";
            this.lblInvolve.Size = new System.Drawing.Size(160, 23);
            this.lblInvolve.TabIndex = 5;
            this.lblInvolve.Text = "Involve";
            this.lblInvolve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLicense
            // 
            this.txtLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicense.HideSelection = false;
            this.txtLicense.Location = new System.Drawing.Point(0, 0);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLicense.Size = new System.Drawing.Size(150, 46);
            this.txtLicense.TabIndex = 0;
            this.txtLicense.TabStop = false;
            this.txtLicense.WordWrap = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // bgwUpdate
            // 
            this.bgwUpdate.WorkerSupportsCancellation = true;
            this.bgwUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUpdate_DoWork);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 369);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(757, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(757, 414);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tlpMain.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.tlpLinks.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.spcAbout.Panel1.ResumeLayout(false);
            this.spcAbout.Panel2.ResumeLayout(false);
            this.spcAbout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcAbout)).EndInit();
            this.spcAbout.ResumeLayout(false);
            this.tlpAbout.ResumeLayout(false);
            this.tlpInvolve.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Label lblTrademark;
        private System.Windows.Forms.TableLayoutPanel tlpLinks;
        private System.Windows.Forms.LinkLabel lnkLicense;
        private System.Windows.Forms.LinkLabel lnkNotes;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.SplitContainer spcAbout;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TableLayoutPanel tlpAbout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.LinkLabel lnkBlog;
        private System.Windows.Forms.TableLayoutPanel tlpInvolve;
        private System.Windows.Forms.Label lblInvolve;
        private System.Windows.Forms.LinkLabel lnkTranslate;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.LinkLabel lnkCopyright;
        private System.ComponentModel.BackgroundWorker bgwUpdate;
    }
}