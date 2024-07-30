namespace ExamPrepper.Forms.QuestionSetupForm
{
    partial class cfrmTrueFalse
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
            pnlHeadingHolder = new Panel();
            lblHeading = new Label();
            pnlAnswerHolder = new Panel();
            tlpAnswerHolder = new TableLayoutPanel();
            rbFalse = new RadioButton();
            lblFalse = new Label();
            rbTrue = new RadioButton();
            lblTrue = new Label();
            lblAHeading = new Label();
            pnlQuestionHolder = new Panel();
            tlpQuestionHolder = new TableLayoutPanel();
            rtbQuestion = new RichTextBox();
            lblQHeading = new Label();
            pnlButtonHolder = new Panel();
            tlpButtonHolder = new TableLayoutPanel();
            pnlTaskName = new Panel();
            tlpTaskName = new TableLayoutPanel();
            lblTaskName = new Label();
            txtTaskName = new TextBox();
            pnlBHolder = new Panel();
            btnCreate = new Button();
            pnlExtraOptionsHolder = new Panel();
            tlpEOHolder = new TableLayoutPanel();
            lblMC = new Label();
            nudMarks = new NumericUpDown();
            tlpMHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            tlpAnswerHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            tlpQuestionHolder.SuspendLayout();
            pnlButtonHolder.SuspendLayout();
            tlpButtonHolder.SuspendLayout();
            pnlTaskName.SuspendLayout();
            tlpTaskName.SuspendLayout();
            pnlBHolder.SuspendLayout();
            pnlExtraOptionsHolder.SuspendLayout();
            tlpEOHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMarks).BeginInit();
            SuspendLayout();
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
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpMHolder.Size = new Size(569, 481);
            tlpMHolder.TabIndex = 2;
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
            lblHeading.Text = "Create a True False Question";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(tlpAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 223);
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
            tlpAnswerHolder.Controls.Add(rbFalse, 1, 1);
            tlpAnswerHolder.Controls.Add(lblFalse, 2, 1);
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
            tlpAnswerHolder.TabIndex = 1;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Dock = DockStyle.Fill;
            rbFalse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rbFalse.Location = new Point(23, 33);
            rbFalse.Name = "rbFalse";
            rbFalse.Padding = new Padding(5, 0, 5, 0);
            rbFalse.RightToLeft = RightToLeft.Yes;
            rbFalse.Size = new Size(34, 24);
            rbFalse.TabIndex = 1;
            rbFalse.TextAlign = ContentAlignment.MiddleRight;
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // lblFalse
            // 
            lblFalse.AutoSize = true;
            lblFalse.Dock = DockStyle.Fill;
            lblFalse.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFalse.Location = new Point(62, 32);
            lblFalse.Margin = new Padding(2);
            lblFalse.Name = "lblFalse";
            lblFalse.Padding = new Padding(2);
            lblFalse.Size = new Size(483, 26);
            lblFalse.TabIndex = 3;
            lblFalse.Text = "False";
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
            rbTrue.TabIndex = 0;
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
            rtbQuestion.Dock = DockStyle.Fill;
            rtbQuestion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbQuestion.Location = new Point(23, 3);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.Size = new Size(521, 100);
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
            lblQHeading.Size = new Size(567, 50);
            lblQHeading.TabIndex = 1;
            lblQHeading.Text = "Enter a Question:";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButtonHolder
            // 
            pnlButtonHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlButtonHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlButtonHolder.Controls.Add(tlpButtonHolder);
            pnlButtonHolder.Dock = DockStyle.Fill;
            pnlButtonHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlButtonHolder.Location = new Point(0, 406);
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
            pnlTaskName.TabIndex = 5;
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
            pnlBHolder.Location = new Point(353, 6);
            pnlBHolder.Name = "pnlBHolder";
            pnlBHolder.Size = new Size(193, 54);
            pnlBHolder.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Dock = DockStyle.Right;
            btnCreate.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Transparent;
            btnCreate.Location = new Point(15, 0);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(178, 54);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Question";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseHover += btnCreate_MouseHover;
            // 
            // pnlExtraOptionsHolder
            // 
            pnlExtraOptionsHolder.BackColor = Color.Silver;
            pnlExtraOptionsHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlExtraOptionsHolder.Controls.Add(tlpEOHolder);
            pnlExtraOptionsHolder.Dock = DockStyle.Fill;
            pnlExtraOptionsHolder.Location = new Point(0, 353);
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
            // cfrmTrueFalse
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 481);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "cfrmTrueFalse";
            Text = "Create True False Question";
            Load += cfrmTrueFalse_Load;
            Shown += cfrmTrueFalse_Shown;
            tlpMHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            tlpAnswerHolder.ResumeLayout(false);
            tlpAnswerHolder.PerformLayout();
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            tlpQuestionHolder.ResumeLayout(false);
            pnlButtonHolder.ResumeLayout(false);
            tlpButtonHolder.ResumeLayout(false);
            pnlTaskName.ResumeLayout(false);
            tlpTaskName.ResumeLayout(false);
            tlpTaskName.PerformLayout();
            pnlBHolder.ResumeLayout(false);
            pnlExtraOptionsHolder.ResumeLayout(false);
            tlpEOHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMarks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMHolder;
        private Panel pnlHeadingHolder;
        private Label lblHeading;
        private Panel pnlAnswerHolder;
        private TableLayoutPanel tlpAnswerHolder;
        private Label lblAHeading;
        private Panel pnlQuestionHolder;
        private TableLayoutPanel tlpQuestionHolder;
        public RichTextBox rtbQuestion;
        private Label lblQHeading;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        private Panel pnlBHolder;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        private Label lblTrue;
        private Label lblFalse;
        private Panel pnlTaskName;
        private TableLayoutPanel tlpTaskName;
        private Label lblTaskName;
        public Button btnCreate;
        public RadioButton rbTrue;
        public RadioButton rbFalse;
        public TextBox txtTaskName;
    }
}