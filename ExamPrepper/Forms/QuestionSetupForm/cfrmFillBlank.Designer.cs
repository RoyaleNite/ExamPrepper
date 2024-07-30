namespace ExamPrepper
{
    partial class cfrmFillBlank
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
            components = new System.ComponentModel.Container();
            cmsQuestion = new ContextMenuStrip(components);
            cmsoQAddBlank = new ToolStripMenuItem();
            cmsItemModify = new ContextMenuStrip(components);
            cmsoCS = new ToolStripMenuItem();
            ttQuestion = new ToolTip(components);
            cmsOCaseSensative = new ToolStripMenuItem();
            pnlExtraOptionsHolder = new Panel();
            tlpEOHolder = new TableLayoutPanel();
            lblMC = new Label();
            nudMarks = new NumericUpDown();
            pnlButtonHolder = new Panel();
            tlpButtonHolder = new TableLayoutPanel();
            pnlTaskName = new Panel();
            tlpTaskName = new TableLayoutPanel();
            lblTaskName = new Label();
            txtTaskName = new TextBox();
            pnlBHolder = new Panel();
            btnCreate = new Button();
            pnlQuestionHolder = new Panel();
            tlpQuestionHolder = new TableLayoutPanel();
            rtbQuestion = new RichTextBox();
            lblQHeading = new Label();
            pnlAnswerHolder = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tlpAnswerHolder = new TableLayoutPanel();
            lblAHeading = new Label();
            pnlHeadingHolder = new Panel();
            lblHeading = new Label();
            tlpMHolder = new TableLayoutPanel();
            cmsQuestion.SuspendLayout();
            cmsItemModify.SuspendLayout();
            pnlExtraOptionsHolder.SuspendLayout();
            tlpEOHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMarks).BeginInit();
            pnlButtonHolder.SuspendLayout();
            tlpButtonHolder.SuspendLayout();
            pnlTaskName.SuspendLayout();
            tlpTaskName.SuspendLayout();
            pnlBHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            tlpQuestionHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            tlpMHolder.SuspendLayout();
            SuspendLayout();
            // 
            // cmsQuestion
            // 
            cmsQuestion.Items.AddRange(new ToolStripItem[] { cmsoQAddBlank });
            cmsQuestion.Name = "cmsQuestion";
            cmsQuestion.Size = new Size(129, 26);
            // 
            // cmsoQAddBlank
            // 
            cmsoQAddBlank.Name = "cmsoQAddBlank";
            cmsoQAddBlank.Size = new Size(128, 22);
            cmsoQAddBlank.Text = "Add Blank";
            cmsoQAddBlank.Click += cmsoQAddBlank_Click;
            // 
            // cmsItemModify
            // 
            cmsItemModify.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmsItemModify.Items.AddRange(new ToolStripItem[] { cmsoCS });
            cmsItemModify.Name = "cmsItemModify";
            cmsItemModify.Size = new Size(173, 28);
            cmsItemModify.Opened += cmsItemModify_Opened;
            // 
            // cmsoCS
            // 
            cmsoCS.CheckOnClick = true;
            cmsoCS.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmsoCS.Name = "cmsoCS";
            cmsoCS.Size = new Size(172, 24);
            cmsoCS.Text = "Case Sensative";
            cmsoCS.CheckedChanged += cmsoCS_CheckedChanged;
            // 
            // ttQuestion
            // 
            ttQuestion.ToolTipTitle = "How to enter your input:";
            // 
            // cmsOCaseSensative
            // 
            cmsOCaseSensative.CheckOnClick = true;
            cmsOCaseSensative.Name = "cmsOCaseSensative";
            cmsOCaseSensative.Size = new Size(143, 22);
            cmsOCaseSensative.Text = "Case Sensitive";
            // 
            // pnlExtraOptionsHolder
            // 
            pnlExtraOptionsHolder.BackColor = Color.Silver;
            pnlExtraOptionsHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlExtraOptionsHolder.Controls.Add(tlpEOHolder);
            pnlExtraOptionsHolder.Dock = DockStyle.Fill;
            pnlExtraOptionsHolder.Location = new Point(0, 318);
            pnlExtraOptionsHolder.Margin = new Padding(0);
            pnlExtraOptionsHolder.Name = "pnlExtraOptionsHolder";
            pnlExtraOptionsHolder.Size = new Size(569, 53);
            pnlExtraOptionsHolder.TabIndex = 23;
            // 
            // tlpEOHolder
            // 
            tlpEOHolder.ColumnCount = 4;
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHolder.Controls.Add(lblMC, 1, 1);
            tlpEOHolder.Controls.Add(nudMarks, 2, 1);
            tlpEOHolder.Dock = DockStyle.Fill;
            tlpEOHolder.Location = new Point(0, 0);
            tlpEOHolder.Name = "tlpEOHolder";
            tlpEOHolder.RowCount = 3;
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEOHolder.Size = new Size(567, 51);
            tlpEOHolder.TabIndex = 0;
            // 
            // lblMC
            // 
            lblMC.Dock = DockStyle.Fill;
            lblMC.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMC.Location = new Point(22, 12);
            lblMC.Margin = new Padding(2);
            lblMC.Name = "lblMC";
            lblMC.Size = new Size(102, 26);
            lblMC.TabIndex = 2;
            lblMC.Text = "Mark count:";
            lblMC.TextAlign = ContentAlignment.MiddleLeft;
            lblMC.MouseHover += lblMC_MouseHover;
            // 
            // nudMarks
            // 
            nudMarks.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudMarks.Location = new Point(129, 13);
            nudMarks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMarks.Name = "nudMarks";
            nudMarks.Size = new Size(72, 27);
            nudMarks.TabIndex = 0;
            nudMarks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlButtonHolder
            // 
            pnlButtonHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlButtonHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlButtonHolder.Controls.Add(tlpButtonHolder);
            pnlButtonHolder.Dock = DockStyle.Fill;
            pnlButtonHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlButtonHolder.Location = new Point(0, 371);
            pnlButtonHolder.Margin = new Padding(0);
            pnlButtonHolder.MinimumSize = new Size(534, 68);
            pnlButtonHolder.Name = "pnlButtonHolder";
            pnlButtonHolder.Padding = new Padding(4, 5, 4, 5);
            pnlButtonHolder.Size = new Size(569, 75);
            pnlButtonHolder.TabIndex = 21;
            // 
            // tlpButtonHolder
            // 
            tlpButtonHolder.ColumnCount = 4;
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.Controls.Add(pnlTaskName, 1, 1);
            tlpButtonHolder.Controls.Add(pnlBHolder, 2, 1);
            tlpButtonHolder.Dock = DockStyle.Fill;
            tlpButtonHolder.Location = new Point(4, 5);
            tlpButtonHolder.Name = "tlpButtonHolder";
            tlpButtonHolder.RowCount = 2;
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpButtonHolder.Size = new Size(559, 63);
            tlpButtonHolder.TabIndex = 3;
            // 
            // pnlTaskName
            // 
            pnlTaskName.Controls.Add(tlpTaskName);
            pnlTaskName.Dock = DockStyle.Fill;
            pnlTaskName.Location = new Point(10, 3);
            pnlTaskName.Margin = new Padding(0);
            pnlTaskName.Name = "pnlTaskName";
            pnlTaskName.Size = new Size(340, 60);
            pnlTaskName.TabIndex = 1;
            // 
            // tlpTaskName
            // 
            tlpTaskName.ColumnCount = 1;
            tlpTaskName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTaskName.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTaskName.Controls.Add(lblTaskName, 0, 0);
            tlpTaskName.Controls.Add(txtTaskName, 0, 1);
            tlpTaskName.Dock = DockStyle.Fill;
            tlpTaskName.Location = new Point(0, 0);
            tlpTaskName.Margin = new Padding(0);
            tlpTaskName.Name = "tlpTaskName";
            tlpTaskName.RowCount = 2;
            tlpTaskName.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tlpTaskName.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3333321F));
            tlpTaskName.Size = new Size(340, 60);
            tlpTaskName.TabIndex = 7;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Dock = DockStyle.Left;
            lblTaskName.Font = new Font("Calibri Light", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTaskName.Location = new Point(2, 2);
            lblTaskName.Margin = new Padding(2);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(197, 21);
            lblTaskName.TabIndex = 5;
            lblTaskName.Text = "Task Name: (Optional)";
            // 
            // txtTaskName
            // 
            txtTaskName.Dock = DockStyle.Fill;
            txtTaskName.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaskName.Location = new Point(3, 28);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(334, 30);
            txtTaskName.TabIndex = 6;
            txtTaskName.MouseHover += txtTaskName_MouseHover;
            // 
            // pnlBHolder
            // 
            pnlBHolder.Controls.Add(btnCreate);
            pnlBHolder.Dock = DockStyle.Fill;
            pnlBHolder.Location = new Point(350, 3);
            pnlBHolder.Margin = new Padding(0);
            pnlBHolder.Name = "pnlBHolder";
            pnlBHolder.Size = new Size(199, 60);
            pnlBHolder.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Dock = DockStyle.Right;
            btnCreate.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Transparent;
            btnCreate.Location = new Point(21, 0);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(178, 60);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Question";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // pnlQuestionHolder
            // 
            pnlQuestionHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlQuestionHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlQuestionHolder.Controls.Add(tlpQuestionHolder);
            pnlQuestionHolder.Controls.Add(lblQHeading);
            pnlQuestionHolder.Dock = DockStyle.Fill;
            pnlQuestionHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlQuestionHolder.Location = new Point(0, 55);
            pnlQuestionHolder.Margin = new Padding(0);
            pnlQuestionHolder.Name = "pnlQuestionHolder";
            pnlQuestionHolder.Size = new Size(569, 168);
            pnlQuestionHolder.TabIndex = 20;
            // 
            // tlpQuestionHolder
            // 
            tlpQuestionHolder.AutoSize = true;
            tlpQuestionHolder.ColumnCount = 3;
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.Controls.Add(rtbQuestion, 1, 0);
            tlpQuestionHolder.Dock = DockStyle.Fill;
            tlpQuestionHolder.Location = new Point(0, 50);
            tlpQuestionHolder.Margin = new Padding(0);
            tlpQuestionHolder.Name = "tlpQuestionHolder";
            tlpQuestionHolder.RowCount = 2;
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.Size = new Size(567, 116);
            tlpQuestionHolder.TabIndex = 2;
            // 
            // rtbQuestion
            // 
            rtbQuestion.ContextMenuStrip = cmsQuestion;
            rtbQuestion.Dock = DockStyle.Fill;
            rtbQuestion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbQuestion.Location = new Point(23, 3);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.Size = new Size(521, 100);
            rtbQuestion.TabIndex = 0;
            rtbQuestion.Text = "";
            rtbQuestion.TextChanged += rtbQuestion_TextChanged;
            rtbQuestion.MouseHover += rtbQuestion_MouseHover;
            // 
            // lblQHeading
            // 
            lblQHeading.BackColor = Color.Silver;
            lblQHeading.Dock = DockStyle.Top;
            lblQHeading.Font = new Font("Calibri Light", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblQHeading.Location = new Point(0, 0);
            lblQHeading.Margin = new Padding(2, 8, 2, 2);
            lblQHeading.Name = "lblQHeading";
            lblQHeading.Padding = new Padding(20, 0, 0, 0);
            lblQHeading.Size = new Size(567, 50);
            lblQHeading.TabIndex = 1;
            lblQHeading.Text = "Enter a Question:";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(materialLabel1);
            pnlAnswerHolder.Controls.Add(tlpAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 223);
            pnlAnswerHolder.Margin = new Padding(0);
            pnlAnswerHolder.Name = "pnlAnswerHolder";
            pnlAnswerHolder.Size = new Size(569, 95);
            pnlAnswerHolder.TabIndex = 22;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(250, 20);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "materialLabel1";
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 5;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Dock = DockStyle.Top;
            tlpAnswerHolder.Location = new Point(0, 50);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 1;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAnswerHolder.Size = new Size(567, 10);
            tlpAnswerHolder.TabIndex = 1;
            // 
            // lblAHeading
            // 
            lblAHeading.BackColor = Color.Silver;
            lblAHeading.Dock = DockStyle.Top;
            lblAHeading.Font = new Font("Calibri Light", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAHeading.Location = new Point(0, 0);
            lblAHeading.Margin = new Padding(2, 8, 2, 2);
            lblAHeading.Name = "lblAHeading";
            lblAHeading.Padding = new Padding(20, 0, 0, 0);
            lblAHeading.Size = new Size(567, 50);
            lblAHeading.TabIndex = 2;
            lblAHeading.Text = "Enter Answer(s):";
            lblAHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlHeadingHolder
            // 
            pnlHeadingHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlHeadingHolder.Controls.Add(lblHeading);
            pnlHeadingHolder.Dock = DockStyle.Fill;
            pnlHeadingHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlHeadingHolder.Location = new Point(0, 0);
            pnlHeadingHolder.Margin = new Padding(0);
            pnlHeadingHolder.Name = "pnlHeadingHolder";
            pnlHeadingHolder.Size = new Size(569, 55);
            pnlHeadingHolder.TabIndex = 19;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.DimGray;
            lblHeading.BorderStyle = BorderStyle.FixedSingle;
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(567, 53);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Create a Fill Blank Question";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpMHolder
            // 
            tlpMHolder.ColumnCount = 1;
            tlpMHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMHolder.Controls.Add(pnlHeadingHolder, 0, 0);
            tlpMHolder.Controls.Add(pnlAnswerHolder, 0, 2);
            tlpMHolder.Controls.Add(pnlQuestionHolder, 0, 1);
            tlpMHolder.Controls.Add(pnlButtonHolder, 0, 4);
            tlpMHolder.Controls.Add(pnlExtraOptionsHolder, 0, 3);
            tlpMHolder.Dock = DockStyle.Fill;
            tlpMHolder.Location = new Point(0, 0);
            tlpMHolder.Name = "tlpMHolder";
            tlpMHolder.RowCount = 5;
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpMHolder.Size = new Size(569, 446);
            tlpMHolder.TabIndex = 1;
            // 
            // cfrmFillBlank
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(569, 446);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "cfrmFillBlank";
            Text = "Create Fill Blank Question";
            FormClosed += cfrmFillBlank_FormClosed;
            Load += cfrmFillBlank_Load;
            Shown += cfrmFillBlank_Shown;
            cmsQuestion.ResumeLayout(false);
            cmsItemModify.ResumeLayout(false);
            pnlExtraOptionsHolder.ResumeLayout(false);
            tlpEOHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMarks).EndInit();
            pnlButtonHolder.ResumeLayout(false);
            tlpButtonHolder.ResumeLayout(false);
            pnlTaskName.ResumeLayout(false);
            tlpTaskName.ResumeLayout(false);
            tlpTaskName.PerformLayout();
            pnlBHolder.ResumeLayout(false);
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            tlpQuestionHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            pnlHeadingHolder.ResumeLayout(false);
            tlpMHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip ttQuestion;
        private ContextMenuStrip cmsItemModify;
        private ToolStripMenuItem cmsoCS;
        private ToolStripMenuItem cmsOCaseSensative;
        private ContextMenuStrip cmsQuestion;
        private ToolStripMenuItem cmsoQAddBlank;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        private Panel pnlBHolder;
        private Panel pnlQuestionHolder;
        private TableLayoutPanel tlpQuestionHolder;
        public RichTextBox rtbQuestion;
        private Label lblQHeading;
        private Panel pnlAnswerHolder;
        private Label lblAHeading;
        private Panel pnlHeadingHolder;
        private Label lblHeading;
        private TableLayoutPanel tlpMHolder;
        private Panel pnlTaskName;
        private TableLayoutPanel tlpTaskName;
        private Label lblTaskName;
        public TableLayoutPanel tlpAnswerHolder;
        public Button btnCreate;
        public TextBox txtTaskName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}