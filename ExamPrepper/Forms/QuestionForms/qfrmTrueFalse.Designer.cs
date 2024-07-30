namespace ExamPrepper.Forms.QuestionForms
{
    partial class qfrmTrueFalse
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
            tlpEOHoldertlpEOHolder = new TableLayoutPanel();
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
            rbFalsse = new RadioButton();
            lblFalsse = new Label();
            rbTrue = new RadioButton();
            lblTrue = new Label();
            lblAHeading = new Label();
            pnlQuestionHolder = new Panel();
            tlpQuestionHolder = new TableLayoutPanel();
            rtbQuestion = new RichTextBox();
            lblQHeading = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            rbFalse = new RadioButton();
            lblFalse = new Label();
            tlpMHolder.SuspendLayout();
            pnlExtraOptionsHolder.SuspendLayout();
            tlpEOHoldertlpEOHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMarks).BeginInit();
            pnlButtonHolder.SuspendLayout();
            tlpButtonHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            tlpAnswerHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            tlpQuestionHolder.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMHolder.Size = new Size(569, 499);
            tlpMHolder.TabIndex = 2;
            // 
            // pnlExtraOptionsHolder
            // 
            pnlExtraOptionsHolder.BackColor = Color.Silver;
            pnlExtraOptionsHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlExtraOptionsHolder.Controls.Add(tlpEOHoldertlpEOHolder);
            pnlExtraOptionsHolder.Dock = DockStyle.Fill;
            pnlExtraOptionsHolder.Location = new Point(0, 355);
            pnlExtraOptionsHolder.Margin = new Padding(0);
            pnlExtraOptionsHolder.Name = "pnlExtraOptionsHolder";
            pnlExtraOptionsHolder.Size = new Size(569, 53);
            pnlExtraOptionsHolder.TabIndex = 27;
            // 
            // tlpEOHoldertlpEOHolder
            // 
            tlpEOHoldertlpEOHolder.ColumnCount = 5;
            tlpEOHoldertlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHoldertlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpEOHoldertlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEOHoldertlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tlpEOHoldertlpEOHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEOHoldertlpEOHolder.Controls.Add(lblReceived, 3, 1);
            tlpEOHoldertlpEOHolder.Controls.Add(lblMC, 1, 1);
            tlpEOHoldertlpEOHolder.Controls.Add(nudMarks, 2, 1);
            tlpEOHoldertlpEOHolder.Dock = DockStyle.Fill;
            tlpEOHoldertlpEOHolder.Location = new Point(0, 0);
            tlpEOHoldertlpEOHolder.Name = "tlpEOHoldertlpEOHolder";
            tlpEOHoldertlpEOHolder.RowCount = 3;
            tlpEOHoldertlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHoldertlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpEOHoldertlpEOHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpEOHoldertlpEOHolder.Size = new Size(567, 51);
            tlpEOHoldertlpEOHolder.TabIndex = 0;
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
            pnlButtonHolder.Location = new Point(0, 408);
            pnlButtonHolder.Margin = new Padding(0);
            pnlButtonHolder.MinimumSize = new Size(534, 68);
            pnlButtonHolder.Name = "pnlButtonHolder";
            pnlButtonHolder.Padding = new Padding(4, 5, 4, 5);
            pnlButtonHolder.Size = new Size(569, 91);
            pnlButtonHolder.TabIndex = 24;
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
            lblHeading.Text = "True False";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(tlpAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 225);
            pnlAnswerHolder.Margin = new Padding(0);
            pnlAnswerHolder.Name = "pnlAnswerHolder";
            pnlAnswerHolder.Size = new Size(569, 130);
            pnlAnswerHolder.TabIndex = 22;
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 4;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Controls.Add(rbFalsse, 1, 1);
            tlpAnswerHolder.Controls.Add(lblFalsse, 2, 1);
            tlpAnswerHolder.Controls.Add(rbTrue, 1, 0);
            tlpAnswerHolder.Controls.Add(lblTrue, 2, 0);
            tlpAnswerHolder.Dock = DockStyle.Top;
            tlpAnswerHolder.Location = new Point(0, 50);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 2;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Size = new Size(567, 60);
            tlpAnswerHolder.TabIndex = 3;
            // 
            // rbFalsse
            // 
            rbFalsse.AutoSize = true;
            rbFalsse.Dock = DockStyle.Fill;
            rbFalsse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbFalsse.Location = new Point(23, 33);
            rbFalsse.Name = "rbFalsse";
            rbFalsse.Padding = new Padding(5, 0, 5, 0);
            rbFalsse.RightToLeft = RightToLeft.Yes;
            rbFalsse.Size = new Size(34, 24);
            rbFalsse.TabIndex = 4;
            rbFalsse.TextAlign = ContentAlignment.MiddleRight;
            rbFalsse.UseVisualStyleBackColor = true;
            // 
            // lblFalsse
            // 
            lblFalsse.AutoSize = true;
            lblFalsse.Dock = DockStyle.Fill;
            lblFalsse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFalsse.ForeColor = Color.Black;
            lblFalsse.Location = new Point(62, 32);
            lblFalsse.Margin = new Padding(2);
            lblFalsse.Name = "lblFalsse";
            lblFalsse.Padding = new Padding(2);
            lblFalsse.Size = new Size(483, 26);
            lblFalsse.TabIndex = 3;
            lblFalsse.Text = "False";
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Checked = true;
            rbTrue.Dock = DockStyle.Fill;
            rbTrue.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbTrue.Location = new Point(23, 3);
            rbTrue.Name = "rbTrue";
            rbTrue.Padding = new Padding(5, 0, 5, 0);
            rbTrue.RightToLeft = RightToLeft.Yes;
            rbTrue.Size = new Size(34, 24);
            rbTrue.TabIndex = 1;
            rbTrue.TabStop = true;
            rbTrue.TextAlign = ContentAlignment.MiddleRight;
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // lblTrue
            // 
            lblTrue.AutoSize = true;
            lblTrue.Dock = DockStyle.Fill;
            lblTrue.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrue.Location = new Point(62, 2);
            lblTrue.Margin = new Padding(2);
            lblTrue.Name = "lblTrue";
            lblTrue.Padding = new Padding(2);
            lblTrue.Size = new Size(483, 26);
            lblTrue.TabIndex = 2;
            lblTrue.Text = "True";
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
            lblAHeading.Text = "Select an Answer:";
            lblAHeading.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlQuestionHolder.Size = new Size(569, 170);
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
            tlpQuestionHolder.Name = "tlpQuestionHolder";
            tlpQuestionHolder.RowCount = 2;
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.Size = new Size(567, 118);
            tlpQuestionHolder.TabIndex = 2;
            // 
            // rtbQuestion
            // 
            rtbQuestion.Dock = DockStyle.Fill;
            rtbQuestion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbQuestion.Location = new Point(23, 3);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.ReadOnly = true;
            rtbQuestion.Size = new Size(521, 102);
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
            lblQHeading.Size = new Size(567, 50);
            lblQHeading.TabIndex = 1;
            lblQHeading.Text = "Question:";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(rbFalse, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Dock = DockStyle.Fill;
            rbFalse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbFalse.Location = new Point(23, 3);
            rbFalse.Name = "rbFalse";
            rbFalse.Padding = new Padding(5, 0, 5, 0);
            rbFalse.RightToLeft = RightToLeft.Yes;
            rbFalse.Size = new Size(34, 94);
            rbFalse.TabIndex = 4;
            rbFalse.TextAlign = ContentAlignment.MiddleRight;
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // lblFalse
            // 
            lblFalse.AutoSize = true;
            lblFalse.Dock = DockStyle.Fill;
            lblFalse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFalse.Location = new Point(62, 2);
            lblFalse.Margin = new Padding(2);
            lblFalse.Name = "lblFalse";
            lblFalse.Padding = new Padding(2);
            lblFalse.Size = new Size(116, 96);
            lblFalse.TabIndex = 3;
            lblFalse.Text = "False";
            // 
            // qfrmTrueFalse
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 499);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "qfrmTrueFalse";
            Text = "True False Question";
            Load += qfrmTrueFalse_Load;
            tlpMHolder.ResumeLayout(false);
            pnlExtraOptionsHolder.ResumeLayout(false);
            tlpEOHoldertlpEOHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMarks).EndInit();
            pnlButtonHolder.ResumeLayout(false);
            tlpButtonHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            tlpAnswerHolder.ResumeLayout(false);
            tlpAnswerHolder.PerformLayout();
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            tlpQuestionHolder.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMHolder;
        private Panel pnlHeadingHolder;
        private Panel pnlAnswerHolder;
        private Label lblAHeading;
        private Panel pnlQuestionHolder;
        private TableLayoutPanel tlpQuestionHolder;
        public RichTextBox rtbQuestion;
        private Label lblQHeading;
        private TableLayoutPanel tlpAnswerHolder;
        private RadioButton rbFalsse;
        private Label lblFalsse;
        private RadioButton rbTrue;
        private Label lblTrue;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton rbFalse;
        private Label lblFalse;
        public Label lblHeading;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        public Button btnPreviousQuestion;
        public Button btnCreate;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHoldertlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        private Label lblReceived;
    }
}