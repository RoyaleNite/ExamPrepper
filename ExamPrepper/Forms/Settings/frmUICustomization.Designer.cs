namespace ExamPrepper
{
    partial class frmUICustomization
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
            tblMain = new TableLayoutPanel();
            cgpFontSettings = new CustomGroupBox();
            tlpFontSettingsHolder = new TableLayoutPanel();
            btnPickColor = new Button();
            lblFontName = new Label();
            cbxFonts = new ComboBox();
            pnlHeadiangColorHolder = new Panel();
            tblHeadiangColorHolder = new TableLayoutPanel();
            pnlHeadingColor = new Panel();
            lblHeadiangColor = new Label();
            cdHeadingColor = new ColorDialog();
            tblMain.SuspendLayout();
            cgpFontSettings.SuspendLayout();
            tlpFontSettingsHolder.SuspendLayout();
            pnlHeadiangColorHolder.SuspendLayout();
            tblHeadiangColorHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblMain.Controls.Add(cgpFontSettings, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 154F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblMain.Size = new Size(558, 450);
            tblMain.TabIndex = 3;
            // 
            // cgpFontSettings
            // 
            cgpFontSettings.Controls.Add(tlpFontSettingsHolder);
            cgpFontSettings.Dock = DockStyle.Fill;
            cgpFontSettings.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cgpFontSettings.Location = new Point(13, 13);
            cgpFontSettings.Name = "cgpFontSettings";
            cgpFontSettings.Size = new Size(532, 148);
            cgpFontSettings.TabIndex = 4;
            cgpFontSettings.TabStop = false;
            cgpFontSettings.Text = "Font Settings";
            // 
            // tlpFontSettingsHolder
            // 
            tlpFontSettingsHolder.ColumnCount = 5;
            tlpFontSettingsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpFontSettingsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tlpFontSettingsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tlpFontSettingsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFontSettingsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpFontSettingsHolder.Controls.Add(btnPickColor, 2, 3);
            tlpFontSettingsHolder.Controls.Add(lblFontName, 1, 1);
            tlpFontSettingsHolder.Controls.Add(cbxFonts, 2, 1);
            tlpFontSettingsHolder.Controls.Add(pnlHeadiangColorHolder, 1, 3);
            tlpFontSettingsHolder.Dock = DockStyle.Fill;
            tlpFontSettingsHolder.Location = new Point(3, 30);
            tlpFontSettingsHolder.Name = "tlpFontSettingsHolder";
            tlpFontSettingsHolder.RowCount = 7;
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFontSettingsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFontSettingsHolder.Size = new Size(526, 115);
            tlpFontSettingsHolder.TabIndex = 0;
            // 
            // btnPickColor
            // 
            btnPickColor.BackColor = Color.DimGray;
            btnPickColor.Dock = DockStyle.Fill;
            btnPickColor.Location = new Point(187, 55);
            btnPickColor.Margin = new Padding(0);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(174, 40);
            btnPickColor.TabIndex = 4;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = false;
            btnPickColor.Click += btnPickColor_Click;
            btnPickColor.MouseHover += btnPickColor_MouseHover;
            // 
            // lblFontName
            // 
            lblFontName.Dock = DockStyle.Fill;
            lblFontName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFontName.Location = new Point(12, 12);
            lblFontName.Margin = new Padding(2);
            lblFontName.Name = "lblFontName";
            lblFontName.Size = new Size(173, 36);
            lblFontName.TabIndex = 0;
            lblFontName.Text = "Font :";
            lblFontName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxFonts
            // 
            tlpFontSettingsHolder.SetColumnSpan(cbxFonts, 2);
            cbxFonts.Dock = DockStyle.Fill;
            cbxFonts.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFonts.FormattingEnabled = true;
            cbxFonts.Items.AddRange(new object[] { "Calibri", "Calibri Light", "Corbel", "Corbel Light", "Elephant", "Kristen ITC", "Rockwell", "Stencil" });
            cbxFonts.Location = new Point(190, 13);
            cbxFonts.Name = "cbxFonts";
            cbxFonts.Size = new Size(323, 33);
            cbxFonts.Sorted = true;
            cbxFonts.TabIndex = 1;
            cbxFonts.SelectedIndexChanged += cbxFonts_SelectedIndexChanged;
            cbxFonts.MouseHover += cbxFonts_MouseHover;
            // 
            // pnlHeadiangColorHolder
            // 
            pnlHeadiangColorHolder.Controls.Add(tblHeadiangColorHolder);
            pnlHeadiangColorHolder.Location = new Point(10, 55);
            pnlHeadiangColorHolder.Margin = new Padding(0);
            pnlHeadiangColorHolder.Name = "pnlHeadiangColorHolder";
            pnlHeadiangColorHolder.Size = new Size(177, 40);
            pnlHeadiangColorHolder.TabIndex = 3;
            // 
            // tblHeadiangColorHolder
            // 
            tblHeadiangColorHolder.ColumnCount = 2;
            tblHeadiangColorHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tblHeadiangColorHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeadiangColorHolder.Controls.Add(pnlHeadingColor, 0, 0);
            tblHeadiangColorHolder.Controls.Add(lblHeadiangColor, 1, 0);
            tblHeadiangColorHolder.Dock = DockStyle.Fill;
            tblHeadiangColorHolder.Location = new Point(0, 0);
            tblHeadiangColorHolder.Name = "tblHeadiangColorHolder";
            tblHeadiangColorHolder.RowCount = 1;
            tblHeadiangColorHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeadiangColorHolder.Size = new Size(177, 40);
            tblHeadiangColorHolder.TabIndex = 3;
            // 
            // pnlHeadingColor
            // 
            pnlHeadingColor.BackColor = Color.Red;
            pnlHeadingColor.ForeColor = Color.Red;
            pnlHeadingColor.Location = new Point(5, 10);
            pnlHeadingColor.Margin = new Padding(5, 10, 5, 10);
            pnlHeadingColor.Name = "pnlHeadingColor";
            pnlHeadingColor.Size = new Size(20, 20);
            pnlHeadingColor.TabIndex = 2;
            // 
            // lblHeadiangColor
            // 
            lblHeadiangColor.Dock = DockStyle.Fill;
            lblHeadiangColor.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeadiangColor.Location = new Point(32, 2);
            lblHeadiangColor.Margin = new Padding(2);
            lblHeadiangColor.Name = "lblHeadiangColor";
            lblHeadiangColor.Size = new Size(143, 36);
            lblHeadiangColor.TabIndex = 1;
            lblHeadiangColor.Text = "Heading Color :";
            lblHeadiangColor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmUICustomization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(tblMain);
            DoubleBuffered = true;
            Name = "frmUICustomization";
            Text = "UI Customization";
            Load += frmUICustomization_Load;
            tblMain.ResumeLayout(false);
            cgpFontSettings.ResumeLayout(false);
            tlpFontSettingsHolder.ResumeLayout(false);
            pnlHeadiangColorHolder.ResumeLayout(false);
            tblHeadiangColorHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tlpFontSettingsHolder;
        private Label lblFontName;
        private ComboBox cbxFonts;
        private Panel pnlHeadiangColorHolder;
        private TableLayoutPanel tblHeadiangColorHolder;
        private Label lblHeadiangColor;
        private Panel pnlHeadingColor;
        private Button btnPickColor;
        private ColorDialog cdHeadingColor;
        private CustomGroupBox cgpFontSettings;
    }
}