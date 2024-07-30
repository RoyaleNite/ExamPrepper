namespace ExamPrepper.Forms.QuestionForms
{
    partial class qfrmMatchColumn
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
            tlpMHolder = new TableLayoutPanel();
            pnlExtraOptionsHolder = new Panel();
            tlpEOHolder = new TableLayoutPanel();
            lblReceived = new Label();
            lblMC = new Label();
            nudMarks = new NumericUpDown();
            pnlButtonHolder = new Panel();
            tlpButtonHolder = new TableLayoutPanel();
            btnPreviousQuestion = new Button();
            btnCreate = new Button();
            pnlHeadingHolder = new Panel();
            lblHeading = new Label();
            pnlAnswerHolder = new Panel();
            tlpAnswerHolder = new TableLayoutPanel();
            lblAHeading = new Label();
            pnlQuestionHolder = new Panel();
            tlpQuestions = new TableLayoutPanel();
            lblQuestion = new Label();
            lblQHeading = new Label();
            tlpMHolder.SuspendLayout();
            pnlExtraOptionsHolder.SuspendLayout();
            tlpEOHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMarks).BeginInit();
            pnlButtonHolder.SuspendLayout();
            tlpButtonHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            tlpQuestions.SuspendLayout();
            SuspendLayout();
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
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMHolder.Size = new Size(569, 381);
            tlpMHolder.TabIndex = 3;
            // 
            // pnlExtraOptionsHolder
            // 
            pnlExtraOptionsHolder.BackColor = Color.Silver;
            pnlExtraOptionsHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlExtraOptionsHolder.Controls.Add(tlpEOHolder);
            pnlExtraOptionsHolder.Dock = DockStyle.Fill;
            pnlExtraOptionsHolder.Location = new Point(0, 235);
            pnlExtraOptionsHolder.Margin = new Padding(0);
            pnlExtraOptionsHolder.Name = "pnlExtraOptionsHolder";
            pnlExtraOptionsHolder.Size = new Size(569, 55);
            pnlExtraOptionsHolder.TabIndex = 27;
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
            tlpEOHolder.Size = new Size(567, 53);
            tlpEOHolder.TabIndex = 0;
            // 
            // lblReceived
            // 
            lblReceived.Dock = DockStyle.Fill;
            lblReceived.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceived.Location = new Point(377, 12);
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
            pnlButtonHolder.Location = new Point(0, 290);
            pnlButtonHolder.Margin = new Padding(0);
            pnlButtonHolder.MinimumSize = new Size(534, 68);
            pnlButtonHolder.Name = "pnlButtonHolder";
            pnlButtonHolder.Padding = new Padding(4, 5, 4, 5);
            pnlButtonHolder.Size = new Size(569, 91);
            pnlButtonHolder.TabIndex = 22;
            // 
            // tlpButtonHolder
            // 
            tlpButtonHolder.ColumnCount = 9;
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.Controls.Add(btnPreviousQuestion, 1, 1);
            tlpButtonHolder.Controls.Add(btnCreate, 7, 1);
            tlpButtonHolder.Dock = DockStyle.Fill;
            tlpButtonHolder.Location = new Point(4, 5);
            tlpButtonHolder.Name = "tlpButtonHolder";
            tlpButtonHolder.RowCount = 5;
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpButtonHolder.Size = new Size(559, 79);
            tlpButtonHolder.TabIndex = 3;
            // 
            // btnPreviousQuestion
            // 
            btnPreviousQuestion.BackColor = Color.DimGray;
            btnPreviousQuestion.Dock = DockStyle.Fill;
            btnPreviousQuestion.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviousQuestion.ForeColor = Color.Transparent;
            btnPreviousQuestion.Location = new Point(10, 9);
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
            btnCreate.Location = new Point(398, 9);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            tlpButtonHolder.SetRowSpan(btnCreate, 3);
            btnCreate.Size = new Size(150, 60);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Next Question";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
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
            lblHeading.Text = "Match Column";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(tlpAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 155);
            pnlAnswerHolder.Margin = new Padding(0);
            pnlAnswerHolder.Name = "pnlAnswerHolder";
            pnlAnswerHolder.Size = new Size(569, 80);
            pnlAnswerHolder.TabIndex = 0;
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 4;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Dock = DockStyle.Top;
            tlpAnswerHolder.Location = new Point(0, 50);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 1;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAnswerHolder.Size = new Size(567, 10);
            tlpAnswerHolder.TabIndex = 0;
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
            lblAHeading.TabIndex = 0;
            lblAHeading.Text = "Column B:";
            lblAHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlQuestionHolder
            // 
            pnlQuestionHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlQuestionHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlQuestionHolder.Controls.Add(tlpQuestions);
            pnlQuestionHolder.Controls.Add(lblQHeading);
            pnlQuestionHolder.Dock = DockStyle.Fill;
            pnlQuestionHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlQuestionHolder.Location = new Point(0, 55);
            pnlQuestionHolder.Margin = new Padding(0);
            pnlQuestionHolder.Name = "pnlQuestionHolder";
            pnlQuestionHolder.Size = new Size(569, 100);
            pnlQuestionHolder.TabIndex = 20;
            // 
            // tlpQuestions
            // 
            tlpQuestions.AutoSize = true;
            tlpQuestions.ColumnCount = 3;
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestions.Controls.Add(lblQuestion, 1, 0);
            tlpQuestions.Dock = DockStyle.Top;
            tlpQuestions.Location = new Point(0, 50);
            tlpQuestions.Name = "tlpQuestions";
            tlpQuestions.RowCount = 1;
            tlpQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpQuestions.Size = new Size(567, 30);
            tlpQuestions.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(22, 2);
            lblQuestion.Margin = new Padding(2);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(523, 26);
            lblQuestion.TabIndex = 0;
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
            lblQHeading.TabIndex = 0;
            lblQHeading.Text = "Column Answer(s):";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // qfrmMatchColumn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 381);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            MinimumSize = new Size(585, 400);
            Name = "qfrmMatchColumn";
            Text = "Match Column A and B Question";
            Load += qfrmMatchColumn_Load;
            Shown += qfrmMatchColumn_Shown;
            ResizeEnd += qfrmMatchColumn_ResizeEnd;
            tlpMHolder.ResumeLayout(false);
            pnlExtraOptionsHolder.ResumeLayout(false);
            tlpEOHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMarks).EndInit();
            pnlButtonHolder.ResumeLayout(false);
            tlpButtonHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            tlpQuestions.ResumeLayout(false);
            tlpQuestions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMHolder;
        private Panel pnlHeadingHolder;
        private Panel pnlAnswerHolder;
        private TableLayoutPanel tlpAnswerHolder;
        private Label lblAHeading;
        private Panel pnlQuestionHolder;
        private TableLayoutPanel tlpQuestions;
        private Label lblQHeading;
        private Label lblQuestion;
        public Label lblHeading;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        public Button btnPreviousQuestion;
        public Button btnCreate;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        private Label lblReceived;
    }
}