
namespace password_manager_CSharpGUI
{
    partial class frmLogin
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
            this.chkKeep = new System.Windows.Forms.CheckBox();
            this.spcButton = new System.Windows.Forms.SplitContainer();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tlpUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.tlpPassword = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new password_manager_CSharpGUI.WatermarkTextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.bgwPassword = new System.ComponentModel.BackgroundWorker();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).BeginInit();
            this.spcButton.Panel1.SuspendLayout();
            this.spcButton.Panel2.SuspendLayout();
            this.spcButton.SuspendLayout();
            this.tlpUser.SuspendLayout();
            this.tlpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Controls.Add(this.tlpUser, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpMain.Size = new System.Drawing.Size(318, 400);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tlpButtons.Controls.Add(this.chkKeep, 0, 0);
            this.tlpButtons.Controls.Add(this.spcButton, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 342);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpButtons.Size = new System.Drawing.Size(312, 55);
            this.tlpButtons.TabIndex = 0;
            // 
            // chkKeep
            // 
            this.chkKeep.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKeep.AutoSize = true;
            this.chkKeep.Checked = true;
            this.chkKeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkKeep.Location = new System.Drawing.Point(10, 10);
            this.chkKeep.Margin = new System.Windows.Forms.Padding(10);
            this.chkKeep.Name = "chkKeep";
            this.chkKeep.Size = new System.Drawing.Size(35, 35);
            this.chkKeep.TabIndex = 0;
            this.chkKeep.UseVisualStyleBackColor = true;
            this.chkKeep.CheckedChanged += new System.EventHandler(this.chkKeep_CheckedChanged);
            // 
            // spcButton
            // 
            this.spcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcButton.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcButton.IsSplitterFixed = true;
            this.spcButton.Location = new System.Drawing.Point(143, 10);
            this.spcButton.Margin = new System.Windows.Forms.Padding(10);
            this.spcButton.Name = "spcButton";
            // 
            // spcButton.Panel1
            // 
            this.spcButton.Panel1.Controls.Add(this.btnLogin);
            // 
            // spcButton.Panel2
            // 
            this.spcButton.Panel2.Controls.Add(this.lblLogin);
            this.spcButton.Size = new System.Drawing.Size(159, 35);
            this.spcButton.SplitterDistance = 83;
            this.spcButton.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(72, 35);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpUser
            // 
            this.tlpUser.ColumnCount = 1;
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUser.Controls.Add(this.lblUser, 0, 0);
            this.tlpUser.Controls.Add(this.tlpPassword, 0, 1);
            this.tlpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUser.Location = new System.Drawing.Point(20, 20);
            this.tlpUser.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.tlpUser.Name = "tlpUser";
            this.tlpUser.RowCount = 2;
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUser.Size = new System.Drawing.Size(278, 309);
            this.tlpUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.SystemColors.Info;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUser.Location = new System.Drawing.Point(10, 10);
            this.lblUser.Margin = new System.Windows.Forms.Padding(10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(258, 244);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Patrick Jane";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpPassword
            // 
            this.tlpPassword.ColumnCount = 2;
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.Controls.Add(this.txtPassword, 1, 0);
            this.tlpPassword.Controls.Add(this.chkShow, 0, 0);
            this.tlpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPassword.Location = new System.Drawing.Point(3, 267);
            this.tlpPassword.Name = "tlpPassword";
            this.tlpPassword.RowCount = 1;
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpPassword.Size = new System.Drawing.Size(272, 39);
            this.tlpPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(45, 6);
            this.txtPassword.MainText = "";
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.WatermarkActive = false;
            this.txtPassword.WatermarkText = "";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // chkShow
            // 
            this.chkShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShow.Checked = true;
            this.chkShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkShow.Location = new System.Drawing.Point(3, 3);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(36, 33);
            this.chkShow.TabIndex = 2;
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // bgwPassword
            // 
            this.bgwPassword.WorkerReportsProgress = true;
            this.bgwPassword.WorkerSupportsCancellation = true;
            this.bgwPassword.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPassword_DoWork);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 400);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Authentication";
            this.TopMost = true;
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.spcButton.Panel1.ResumeLayout(false);
            this.spcButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).EndInit();
            this.spcButton.ResumeLayout(false);
            this.tlpUser.ResumeLayout(false);
            this.tlpPassword.ResumeLayout(false);
            this.tlpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.CheckBox chkKeep;
        private System.Windows.Forms.TableLayoutPanel tlpUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel tlpPassword;
        private WatermarkTextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Timer tmrMain;
        private System.ComponentModel.BackgroundWorker bgwPassword;
        private System.Windows.Forms.SplitContainer spcButton;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ToolTip tltMain;
    }
}