
namespace password_manager_CSharpGUI
{
    partial class frmSetup
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
            this.txtRetype = new password_manager_CSharpGUI.WatermarkTextBox();
            this.psmMain = new password_manager_CSharpGUI.PasswordStrengthMeter();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.spcButton = new System.Windows.Forms.SplitContainer();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.txtType = new password_manager_CSharpGUI.WatermarkTextBox();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).BeginInit();
            this.spcButton.Panel1.SuspendLayout();
            this.spcButton.Panel2.SuspendLayout();
            this.spcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.txtRetype, 0, 2);
            this.tlpMain.Controls.Add(this.psmMain, 0, 3);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 4);
            this.tlpMain.Controls.Add(this.txtType, 0, 1);
            this.tlpMain.Controls.Add(this.pcbMain, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpMain.Size = new System.Drawing.Size(385, 472);
            this.tlpMain.TabIndex = 0;
            // 
            // txtRetype
            // 
            this.txtRetype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetype.ForeColor = System.Drawing.Color.Black;
            this.txtRetype.Location = new System.Drawing.Point(18, 246);
            this.txtRetype.MainText = "";
            this.txtRetype.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(349, 26);
            this.txtRetype.TabIndex = 2;
            this.txtRetype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetype.WatermarkActive = false;
            this.txtRetype.WatermarkText = "";
            this.txtRetype.TextChanged += new System.EventHandler(this.txtRetype_TextChanged);
            this.txtRetype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // psmMain
            // 
            this.psmMain.BackColor = System.Drawing.Color.Transparent;
            this.psmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psmMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.psmMain.Location = new System.Drawing.Point(13, 275);
            this.psmMain.Name = "psmMain";
            this.psmMain.Size = new System.Drawing.Size(359, 137);
            this.psmMain.TabIndex = 0;
            this.psmMain.TabStop = false;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tlpButtons.Controls.Add(this.chkShow, 0, 0);
            this.tlpButtons.Controls.Add(this.spcButton, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(13, 418);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpButtons.Size = new System.Drawing.Size(359, 41);
            this.tlpButtons.TabIndex = 1;
            // 
            // chkShow
            // 
            this.chkShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShow.AutoSize = true;
            this.chkShow.Checked = true;
            this.chkShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkShow.Location = new System.Drawing.Point(3, 3);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(35, 35);
            this.chkShow.TabIndex = 3;
            this.chkShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // spcButton
            // 
            this.spcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcButton.Location = new System.Drawing.Point(161, 3);
            this.spcButton.Name = "spcButton";
            // 
            // spcButton.Panel1
            // 
            this.spcButton.Panel1.Controls.Add(this.btnDone);
            // 
            // spcButton.Panel2
            // 
            this.spcButton.Panel2.Controls.Add(this.lblDone);
            this.spcButton.Size = new System.Drawing.Size(195, 35);
            this.spcButton.SplitterDistance = 93;
            this.spcButton.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.Location = new System.Drawing.Point(0, 0);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 35);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblDone
            // 
            this.lblDone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDone.Location = new System.Drawing.Point(0, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(98, 35);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "Done";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(18, 214);
            this.txtType.MainText = "";
            this.txtType.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(349, 26);
            this.txtType.TabIndex = 1;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtType.WatermarkActive = false;
            this.txtType.WatermarkText = "";
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // pcbMain
            // 
            this.pcbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbMain.Location = new System.Drawing.Point(13, 13);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(359, 195);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMain.TabIndex = 3;
            this.pcbMain.TabStop = false;
            // 
            // tltMain
            // 
            this.tltMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltMain.ToolTipTitle = "Muragala Password Manager";
            this.tltMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltMain_Popup);
            // 
            // bgwMain
            // 
            this.bgwMain.WorkerReportsProgress = true;
            this.bgwMain.WorkerSupportsCancellation = true;
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 472);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(403, 517);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(403, 517);
            this.Name = "frmSetup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetup";
            this.TopMost = true;
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.spcButton.Panel1.ResumeLayout(false);
            this.spcButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).EndInit();
            this.spcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private PasswordStrengthMeter psmMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.CheckBox chkShow;
        private WatermarkTextBox txtType;
        private WatermarkTextBox txtRetype;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.SplitContainer spcButton;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblDone;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.PictureBox pcbMain;
    }
}