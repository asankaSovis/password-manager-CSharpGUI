
namespace password_manager_CSharpGUI
{
    partial class frmExport
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.tlpProgress = new System.Windows.Forms.TableLayoutPanel();
            this.prgUsernames = new System.Windows.Forms.ProgressBar();
            this.prgPlatforms = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.spcMain, 0, 1);
            this.tlpMain.Controls.Add(this.lblMessage, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpMain.Size = new System.Drawing.Size(529, 194);
            this.tlpMain.TabIndex = 0;
            // 
            // spcMain
            // 
            this.spcMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(3, 131);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlpButton);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.tlpProgress);
            this.spcMain.Size = new System.Drawing.Size(523, 60);
            this.spcMain.SplitterDistance = 266;
            this.spcMain.TabIndex = 0;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 1;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButton.Controls.Add(this.btnProceed, 0, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(0, 0);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpButton.Size = new System.Drawing.Size(266, 60);
            this.tlpButton.TabIndex = 0;
            // 
            // btnProceed
            // 
            this.btnProceed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProceed.Location = new System.Drawing.Point(10, 10);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(10);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(246, 40);
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "Proceed?";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // tlpProgress
            // 
            this.tlpProgress.ColumnCount = 1;
            this.tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgress.Controls.Add(this.prgUsernames, 0, 1);
            this.tlpProgress.Controls.Add(this.prgPlatforms, 0, 0);
            this.tlpProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProgress.Location = new System.Drawing.Point(0, 0);
            this.tlpProgress.Name = "tlpProgress";
            this.tlpProgress.RowCount = 2;
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProgress.Size = new System.Drawing.Size(253, 60);
            this.tlpProgress.TabIndex = 1;
            // 
            // prgUsernames
            // 
            this.prgUsernames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgUsernames.Location = new System.Drawing.Point(10, 32);
            this.prgUsernames.Margin = new System.Windows.Forms.Padding(10, 2, 10, 5);
            this.prgUsernames.Name = "prgUsernames";
            this.prgUsernames.Size = new System.Drawing.Size(233, 23);
            this.prgUsernames.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgUsernames.TabIndex = 2;
            // 
            // prgPlatforms
            // 
            this.prgPlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgPlatforms.Location = new System.Drawing.Point(10, 5);
            this.prgPlatforms.Margin = new System.Windows.Forms.Padding(10, 5, 10, 2);
            this.prgPlatforms.MaximumSize = new System.Drawing.Size(233, 23);
            this.prgPlatforms.MinimumSize = new System.Drawing.Size(233, 23);
            this.prgPlatforms.Name = "prgPlatforms";
            this.prgPlatforms.Size = new System.Drawing.Size(233, 23);
            this.prgPlatforms.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgPlatforms.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(20, 20);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(489, 108);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Exporting 0 of 0 platforms\r\n  Platform: -\r\n  Username: -\r\n\r\nClick on Proceed to c" +
    "ontinue...";
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 194);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Database";
            this.tlpMain.ResumeLayout(false);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.tlpProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TableLayoutPanel tlpProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar prgUsernames;
        private System.Windows.Forms.ProgressBar prgPlatforms;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.Windows.Forms.Timer tmrMain;
    }
}