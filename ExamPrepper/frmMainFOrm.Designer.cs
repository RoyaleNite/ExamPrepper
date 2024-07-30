namespace ExamPrepper
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            pnlMSMainHolder = new Panel();
            pnlExtrasHolder = new Panel();
            msExtras = new MenuStrip();
            pnlMenuPlaceholder2 = new Panel();
            pnlBNHolder = new Panel();
            msBN = new MenuStrip();
            mstHome = new ToolStripMenuItem();
            mstBack = new ToolStripMenuItem();
            mstNext = new ToolStripMenuItem();
            pnlMenuPlaceholder1 = new Panel();
            pnlFHolder = new Panel();
            msF = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mstOptions = new ToolStripMenuItem();
            optUICustomization = new ToolStripMenuItem();
            optDataSettings = new ToolStripMenuItem();
            mstExit = new ToolStripMenuItem();
            tt = new ToolTip(components);
            pnlMSMainHolder.SuspendLayout();
            pnlExtrasHolder.SuspendLayout();
            pnlBNHolder.SuspendLayout();
            msBN.SuspendLayout();
            pnlFHolder.SuspendLayout();
            msF.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMSMainHolder
            // 
            pnlMSMainHolder.BackColor = Color.Gainsboro;
            pnlMSMainHolder.Controls.Add(pnlExtrasHolder);
            pnlMSMainHolder.Controls.Add(pnlMenuPlaceholder2);
            pnlMSMainHolder.Controls.Add(pnlBNHolder);
            pnlMSMainHolder.Controls.Add(pnlMenuPlaceholder1);
            pnlMSMainHolder.Controls.Add(pnlFHolder);
            pnlMSMainHolder.Dock = DockStyle.Top;
            pnlMSMainHolder.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlMSMainHolder.Location = new Point(0, 0);
            pnlMSMainHolder.Name = "pnlMSMainHolder";
            pnlMSMainHolder.Size = new Size(644, 25);
            pnlMSMainHolder.TabIndex = 3;
            // 
            // pnlExtrasHolder
            // 
            pnlExtrasHolder.BackColor = Color.Gainsboro;
            pnlExtrasHolder.Controls.Add(msExtras);
            pnlExtrasHolder.Dock = DockStyle.Fill;
            pnlExtrasHolder.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlExtrasHolder.Location = new Point(213, 0);
            pnlExtrasHolder.Name = "pnlExtrasHolder";
            pnlExtrasHolder.Size = new Size(431, 25);
            pnlExtrasHolder.TabIndex = 9;
            // 
            // msExtras
            // 
            msExtras.BackColor = Color.Gainsboro;
            msExtras.Dock = DockStyle.Fill;
            msExtras.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            msExtras.Location = new Point(0, 0);
            msExtras.Name = "msExtras";
            msExtras.Padding = new Padding(5, 2, 0, 2);
            msExtras.Size = new Size(431, 25);
            msExtras.TabIndex = 9;
            msExtras.Text = "menuStrip1";
            // 
            // pnlMenuPlaceholder2
            // 
            pnlMenuPlaceholder2.BackColor = Color.Black;
            pnlMenuPlaceholder2.Dock = DockStyle.Left;
            pnlMenuPlaceholder2.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlMenuPlaceholder2.Location = new Point(212, 0);
            pnlMenuPlaceholder2.Name = "pnlMenuPlaceholder2";
            pnlMenuPlaceholder2.Size = new Size(1, 25);
            pnlMenuPlaceholder2.TabIndex = 7;
            // 
            // pnlBNHolder
            // 
            pnlBNHolder.BackColor = Color.Gainsboro;
            pnlBNHolder.Controls.Add(msBN);
            pnlBNHolder.Dock = DockStyle.Left;
            pnlBNHolder.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBNHolder.Location = new Point(50, 0);
            pnlBNHolder.Name = "pnlBNHolder";
            pnlBNHolder.Size = new Size(162, 25);
            pnlBNHolder.TabIndex = 5;
            // 
            // msBN
            // 
            msBN.BackColor = Color.Gainsboro;
            msBN.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            msBN.Items.AddRange(new ToolStripItem[] { mstHome, mstBack, mstNext });
            msBN.Location = new Point(0, 0);
            msBN.Name = "msBN";
            msBN.Padding = new Padding(5, 2, 0, 2);
            msBN.Size = new Size(162, 26);
            msBN.TabIndex = 3;
            msBN.Text = "menuStrip2";
            // 
            // mstHome
            // 
            mstHome.Name = "mstHome";
            mstHome.Size = new Size(56, 22);
            mstHome.Text = "Home";
            mstHome.Click += mstHome_Click;
            // 
            // mstBack
            // 
            mstBack.BackColor = Color.Gainsboro;
            mstBack.Enabled = false;
            mstBack.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mstBack.Name = "mstBack";
            mstBack.Size = new Size(48, 22);
            mstBack.Text = "Back";
            mstBack.Click += mstBack_Click;
            // 
            // mstNext
            // 
            mstNext.BackColor = Color.Gainsboro;
            mstNext.Enabled = false;
            mstNext.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mstNext.Name = "mstNext";
            mstNext.Size = new Size(48, 22);
            mstNext.Text = "Next";
            mstNext.Click += mstNext_Click;
            // 
            // pnlMenuPlaceholder1
            // 
            pnlMenuPlaceholder1.BackColor = Color.Black;
            pnlMenuPlaceholder1.Dock = DockStyle.Left;
            pnlMenuPlaceholder1.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlMenuPlaceholder1.Location = new Point(49, 0);
            pnlMenuPlaceholder1.Name = "pnlMenuPlaceholder1";
            pnlMenuPlaceholder1.Size = new Size(1, 25);
            pnlMenuPlaceholder1.TabIndex = 6;
            // 
            // pnlFHolder
            // 
            pnlFHolder.BackColor = Color.Gainsboro;
            pnlFHolder.Controls.Add(msF);
            pnlFHolder.Dock = DockStyle.Left;
            pnlFHolder.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlFHolder.Location = new Point(0, 0);
            pnlFHolder.Name = "pnlFHolder";
            pnlFHolder.Size = new Size(49, 25);
            pnlFHolder.TabIndex = 4;
            // 
            // msF
            // 
            msF.BackColor = Color.Gainsboro;
            msF.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            msF.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            msF.Location = new Point(0, 0);
            msF.Name = "msF";
            msF.Padding = new Padding(5, 2, 0, 2);
            msF.Size = new Size(49, 26);
            msF.TabIndex = 3;
            msF.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Gainsboro;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mstOptions, mstExit });
            fileToolStripMenuItem.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // mstOptions
            // 
            mstOptions.BackColor = Color.Gainsboro;
            mstOptions.DropDownItems.AddRange(new ToolStripItem[] { optUICustomization, optDataSettings });
            mstOptions.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mstOptions.Name = "mstOptions";
            mstOptions.Size = new Size(124, 22);
            mstOptions.Text = "&Options";
            // 
            // optUICustomization
            // 
            optUICustomization.Name = "optUICustomization";
            optUICustomization.Size = new Size(180, 22);
            optUICustomization.Text = "UI Customization";
            optUICustomization.Click += optUICustomization_Click;
            // 
            // optDataSettings
            // 
            optDataSettings.Name = "optDataSettings";
            optDataSettings.Size = new Size(180, 22);
            optDataSettings.Text = "Data Settings";
            optDataSettings.Click += optDataSettings_Click;
            // 
            // mstExit
            // 
            mstExit.BackColor = Color.Gainsboro;
            mstExit.Font = new Font("Calibri Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mstExit.Name = "mstExit";
            mstExit.Size = new Size(124, 22);
            mstExit.Text = "&Exit";
            mstExit.Click += mstExit_Click;
            // 
            // tt
            // 
            tt.ToolTipTitle = "Hint:";
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 521);
            Controls.Add(pnlMSMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(660, 560);
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Prepper";
            Load += frmMainForm_Load;
            Shown += frmMainForm_Shown;
            pnlMSMainHolder.ResumeLayout(false);
            pnlExtrasHolder.ResumeLayout(false);
            pnlExtrasHolder.PerformLayout();
            pnlBNHolder.ResumeLayout(false);
            pnlBNHolder.PerformLayout();
            msBN.ResumeLayout(false);
            msBN.PerformLayout();
            pnlFHolder.ResumeLayout(false);
            pnlFHolder.PerformLayout();
            msF.ResumeLayout(false);
            msF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMSMainHolder;
        private Panel pnlBNHolder;
        private Panel pnlFHolder;
        private MenuStrip msF;
        private Panel pnlMenuPlaceholder2;
        private Panel pnlMenuPlaceholder1;
        private ToolStripMenuItem mstOptions;
        private ToolStripMenuItem mstExit;
        private ToolStripMenuItem optUICustomization;
        private ToolStripMenuItem optDataSettings;
        private Panel pnlExtrasHolder;
        private MenuStrip msExtras;
        public ToolStripMenuItem mstBack;
        public ToolStripMenuItem mstNext;
        public ToolStripMenuItem fileToolStripMenuItem;
        public ToolStripMenuItem mstHome;
        public MenuStrip msBN;
        public ToolTip tt;
    }
}