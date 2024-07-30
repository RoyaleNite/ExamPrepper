namespace ExamPrepper.Forms.QuestionForms
{
    partial class qfrmQuestion
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
            rtbQuestion = new RichTextBox();
            lblQHeading = new Label();
            tlpQuestionHolder = new TableLayoutPanel();
            rtbAnswer = new RichTextBox();
            lblAHeading = new Label();
            tlpAnswerHolder = new TableLayoutPanel();
            pnlAnswerHolder = new Panel();
            lblHeading = new Label();
            pnlHeadingHolder = new Panel();
            tlpMHolder = new TableLayoutPanel();
            pnlExtraOptionsHolder = new Panel();
            tlpEOHolder = new TableLayoutPanel();
            lblReceived = new Label();
            lblMC = new Label();
            nudMarks = new NumericUpDown();
            pnlButtonHolder = new Panel();
            tlpButtonHolder = new TableLayoutPanel();
            btnViewAnswer = new Button();
            btnWrong = new Button();
            btnCorrect = new Button();
            btnPreviousQuestion = new Button();
            btnCreate = new Button();
            pnlQuestionHolder = new Panel();
            tlpQuestionHolder.SuspendLayout();
            tlpAnswerHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            tlpMHolder.SuspendLayout();
            pnlExtraOptionsHolder.SuspendLayout();
            tlpEOHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMarks).BeginInit();
            pnlButtonHolder.SuspendLayout();
            tlpButtonHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            SuspendLayout();
            // 
            // rtbQuestion
            // 
            rtbQuestion.Dock = DockStyle.Fill;
            rtbQuestion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbQuestion.Location = new Point(23, 3);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.ReadOnly = true;
            rtbQuestion.Size = new Size(693, 146);
            rtbQuestion.TabIndex = 0;
            rtbQuestion.Text = "";
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
            lblQHeading.Size = new Size(739, 50);
            lblQHeading.TabIndex = 1;
            lblQHeading.Text = "Question:";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
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
            tlpQuestionHolder.Name = "tlpQuestionHolder";
            tlpQuestionHolder.RowCount = 2;
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.Size = new Size(739, 162);
            tlpQuestionHolder.TabIndex = 2;
            // 
            // rtbAnswer
            // 
            rtbAnswer.Dock = DockStyle.Fill;
            rtbAnswer.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbAnswer.Location = new Point(23, 3);
            rtbAnswer.Name = "rtbAnswer";
            rtbAnswer.Size = new Size(693, 146);
            rtbAnswer.TabIndex = 4;
            rtbAnswer.Text = "";
            rtbAnswer.MouseHover += rtbAnswer_MouseHover;
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
            lblAHeading.Size = new Size(739, 50);
            lblAHeading.TabIndex = 3;
            lblAHeading.Text = "Answer:";
            lblAHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 3;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Controls.Add(rtbAnswer, 1, 0);
            tlpAnswerHolder.Dock = DockStyle.Fill;
            tlpAnswerHolder.Location = new Point(0, 50);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 2;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Size = new Size(739, 162);
            tlpAnswerHolder.TabIndex = 1;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(tlpAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 269);
            pnlAnswerHolder.Margin = new Padding(0);
            pnlAnswerHolder.Name = "pnlAnswerHolder";
            pnlAnswerHolder.Size = new Size(741, 214);
            pnlAnswerHolder.TabIndex = 22;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.DimGray;
            lblHeading.BorderStyle = BorderStyle.FixedSingle;
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(739, 53);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Basic Question";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
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
            pnlHeadingHolder.Size = new Size(741, 55);
            pnlHeadingHolder.TabIndex = 19;
            pnlHeadingHolder.Paint += pnlHeadingHolder_Paint;
            // 
            // tlpMHolder
            // 
            tlpMHolder.ColumnCount = 1;
            tlpMHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMHolder.Controls.Add(pnlExtraOptionsHolder, 0, 3);
            tlpMHolder.Controls.Add(pnlButtonHolder, 0, 4);
            tlpMHolder.Controls.Add(pnlHeadingHolder, 0, 0);
            tlpMHolder.Controls.Add(pnlAnswerHolder, 0, 2);
            tlpMHolder.Controls.Add(pnlQuestionHolder, 0, 1);
            tlpMHolder.Dock = DockStyle.Fill;
            tlpMHolder.Location = new Point(0, 0);
            tlpMHolder.Name = "tlpMHolder";
            tlpMHolder.RowCount = 5;
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpMHolder.Size = new Size(741, 628);
            tlpMHolder.TabIndex = 3;
            tlpMHolder.Paint += tlpMHolder_Paint;
            // 
            // pnlExtraOptionsHolder
            // 
            pnlExtraOptionsHolder.BackColor = Color.Silver;
            pnlExtraOptionsHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlExtraOptionsHolder.Controls.Add(tlpEOHolder);
            pnlExtraOptionsHolder.Dock = DockStyle.Fill;
            pnlExtraOptionsHolder.Location = new Point(0, 483);
            pnlExtraOptionsHolder.Margin = new Padding(0);
            pnlExtraOptionsHolder.Name = "pnlExtraOptionsHolder";
            pnlExtraOptionsHolder.Size = new Size(741, 55);
            pnlExtraOptionsHolder.TabIndex = 25;
            // 
            // tlpEOHolder
            // 
            tlpEOHolder.ColumnCount = 5;
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHolder.Controls.Add(lblReceived, 3, 1);
            tlpEOHolder.Controls.Add(lblMC, 1, 1);
            tlpEOHolder.Controls.Add(nudMarks, 2, 1);
            tlpEOHolder.Dock = DockStyle.Fill;
            tlpEOHolder.Location = new Point(0, 0);
            tlpEOHolder.Name = "tlpEOHolder";
            tlpEOHolder.RowCount = 3;
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHolder.Size = new Size(739, 53);
            tlpEOHolder.TabIndex = 0;
            // 
            // lblReceived
            // 
            lblReceived.Dock = DockStyle.Fill;
            lblReceived.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceived.Location = new Point(549, 12);
            lblReceived.Margin = new Padding(2);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(168, 26);
            lblReceived.TabIndex = 5;
            lblReceived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMC
            // 
            lblMC.Dock = DockStyle.Fill;
            lblMC.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMC.Location = new Point(22, 12);
            lblMC.Margin = new Padding(2);
            lblMC.Name = "lblMC";
            lblMC.Size = new Size(111, 26);
            lblMC.TabIndex = 2;
            lblMC.Text = "Mark count:";
            lblMC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMarks
            // 
            nudMarks.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudMarks.Location = new Point(138, 13);
            nudMarks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMarks.Name = "nudMarks";
            nudMarks.ReadOnly = true;
            nudMarks.Size = new Size(72, 27);
            nudMarks.TabIndex = 3;
            nudMarks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlButtonHolder
            // 
            pnlButtonHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlButtonHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlButtonHolder.Controls.Add(tlpButtonHolder);
            pnlButtonHolder.Dock = DockStyle.Fill;
            pnlButtonHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlButtonHolder.Location = new Point(0, 538);
            pnlButtonHolder.Margin = new Padding(0);
            pnlButtonHolder.MinimumSize = new Size(534, 68);
            pnlButtonHolder.Name = "pnlButtonHolder";
            pnlButtonHolder.Padding = new Padding(4, 5, 4, 5);
            pnlButtonHolder.Size = new Size(741, 90);
            pnlButtonHolder.TabIndex = 24;
            // 
            // tlpButtonHolder
            // 
            tlpButtonHolder.ColumnCount = 11;
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.Controls.Add(btnViewAnswer, 3, 0);
            tlpButtonHolder.Controls.Add(btnWrong, 6, 2);
            tlpButtonHolder.Controls.Add(btnCorrect, 4, 2);
            tlpButtonHolder.Controls.Add(btnPreviousQuestion, 1, 1);
            tlpButtonHolder.Controls.Add(btnCreate, 9, 1);
            tlpButtonHolder.Dock = DockStyle.Fill;
            tlpButtonHolder.Location = new Point(4, 5);
            tlpButtonHolder.Name = "tlpButtonHolder";
            tlpButtonHolder.RowCount = 5;
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.Size = new Size(731, 78);
            tlpButtonHolder.TabIndex = 3;
            // 
            // btnViewAnswer
            // 
            btnViewAnswer.BackColor = Color.DimGray;
            tlpButtonHolder.SetColumnSpan(btnViewAnswer, 5);
            btnViewAnswer.Dock = DockStyle.Fill;
            btnViewAnswer.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAnswer.ForeColor = Color.Transparent;
            btnViewAnswer.Location = new Point(295, 5);
            btnViewAnswer.Margin = new Padding(0, 5, 0, 5);
            btnViewAnswer.Name = "btnViewAnswer";
            btnViewAnswer.Size = new Size(140, 1);
            btnViewAnswer.TabIndex = 5;
            btnViewAnswer.Text = "View Answer";
            btnViewAnswer.UseVisualStyleBackColor = false;
            btnViewAnswer.Visible = false;
            btnViewAnswer.Click += btnViewAnswer_Click;
            // 
            // btnWrong
            // 
            btnWrong.BackColor = Color.DimGray;
            btnWrong.Dock = DockStyle.Fill;
            btnWrong.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrong.ForeColor = Color.Transparent;
            btnWrong.Location = new Point(370, 18);
            btnWrong.Margin = new Padding(0);
            btnWrong.Name = "btnWrong";
            btnWrong.Size = new Size(40, 40);
            btnWrong.TabIndex = 4;
            btnWrong.Text = "X";
            btnWrong.UseVisualStyleBackColor = false;
            btnWrong.Visible = false;
            btnWrong.Click += btnWrong_Click;
            // 
            // btnCorrect
            // 
            btnCorrect.BackColor = Color.DimGray;
            btnCorrect.Dock = DockStyle.Fill;
            btnCorrect.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCorrect.ForeColor = Color.Transparent;
            btnCorrect.Location = new Point(320, 18);
            btnCorrect.Margin = new Padding(0);
            btnCorrect.Name = "btnCorrect";
            btnCorrect.Size = new Size(40, 40);
            btnCorrect.TabIndex = 3;
            btnCorrect.Text = "C";
            btnCorrect.UseVisualStyleBackColor = false;
            btnCorrect.Visible = false;
            btnCorrect.VisibleChanged += btnCorrect_VisibleChanged;
            btnCorrect.Click += btnCorrect_Click;
            // 
            // btnPreviousQuestion
            // 
            btnPreviousQuestion.BackColor = Color.DimGray;
            btnPreviousQuestion.Dock = DockStyle.Fill;
            btnPreviousQuestion.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviousQuestion.ForeColor = Color.Transparent;
            btnPreviousQuestion.Location = new Point(10, 8);
            btnPreviousQuestion.Margin = new Padding(0);
            btnPreviousQuestion.Name = "btnPreviousQuestion";
            tlpButtonHolder.SetRowSpan(btnPreviousQuestion, 3);
            btnPreviousQuestion.Size = new Size(150, 60);
            btnPreviousQuestion.TabIndex = 2;
            btnPreviousQuestion.Text = "Previous Question";
            btnPreviousQuestion.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Transparent;
            btnCreate.Location = new Point(570, 8);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            tlpButtonHolder.SetRowSpan(btnCreate, 3);
            btnCreate.Size = new Size(150, 60);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Next Question";
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
            pnlQuestionHolder.Size = new Size(741, 214);
            pnlQuestionHolder.TabIndex = 20;
            // 
            // qfrmQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 628);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(585, 485);
            Name = "qfrmQuestion";
            Text = "Basic Question";
            FormClosing += qfrmQuestion_FormClosing;
            Load += qfrmQuestion_Load;
            Leave += qfrmQuestion_Leave;
            tlpQuestionHolder.ResumeLayout(false);
            tlpAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            pnlHeadingHolder.ResumeLayout(false);
            tlpMHolder.ResumeLayout(false);
            pnlExtraOptionsHolder.ResumeLayout(false);
            tlpEOHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMarks).EndInit();
            pnlButtonHolder.ResumeLayout(false);
            tlpButtonHolder.ResumeLayout(false);
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public RichTextBox rtbQuestion;
        private Label lblQHeading;
        private TableLayoutPanel tlpQuestionHolder;
        public RichTextBox rtbAnswer;
        private Label lblAHeading;
        private TableLayoutPanel tlpAnswerHolder;
        private Panel pnlAnswerHolder;
        private Panel pnlHeadingHolder;
        private TableLayoutPanel tlpMHolder;
        private Panel pnlQuestionHolder;
        public Label lblHeading;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        public Button btnWrong;
        public Button btnCorrect;
        public Button btnPreviousQuestion;
        public Button btnCreate;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        public Button btnViewAnswer;
        private Label lblReceived;
    }
}