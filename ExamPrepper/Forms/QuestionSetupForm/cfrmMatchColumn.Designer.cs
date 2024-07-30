namespace ExamPrepper
{
    partial class cfrmMatchColumn
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
            ttQuestion = new ToolTip(components);
            tlpMHolder = new TableLayoutPanel();
            pnlHeadingHolder = new Panel();
            lblHeading = new Label();
            pnlAnswerHolder = new Panel();
            tlpAnswers = new TableLayoutPanel();
            tlpAddAnswerHolder = new TableLayoutPanel();
            btnAddAnswer = new Button();
            lblAHeading = new Label();
            pnlQuestionHolder = new Panel();
            tlpQuestions = new TableLayoutPanel();
            tlpAddQuestionHolder = new TableLayoutPanel();
            btnAddQuestion = new Button();
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
            tlpChoiceHolder = new TableLayoutPanel();
            tlpAnswerHolder = new TableLayoutPanel();
            btnAddChoice = new Button();
            btnChoiceAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            tlpMHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            pnlAnswerHolder.SuspendLayout();
            tlpAddAnswerHolder.SuspendLayout();
            pnlQuestionHolder.SuspendLayout();
            tlpAddQuestionHolder.SuspendLayout();
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
            // ttQuestion
            // 
            ttQuestion.ToolTipTitle = "How to enter your input:";
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
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMHolder.Size = new Size(569, 461);
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
            lblHeading.Text = "Create a Match Column Question";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerHolder
            // 
            pnlAnswerHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlAnswerHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswerHolder.Controls.Add(tlpAnswers);
            pnlAnswerHolder.Controls.Add(tlpAddAnswerHolder);
            pnlAnswerHolder.Controls.Add(lblAHeading);
            pnlAnswerHolder.Dock = DockStyle.Fill;
            pnlAnswerHolder.Location = new Point(0, 195);
            pnlAnswerHolder.Margin = new Padding(0);
            pnlAnswerHolder.Name = "pnlAnswerHolder";
            pnlAnswerHolder.Size = new Size(569, 140);
            pnlAnswerHolder.TabIndex = 0;
            // 
            // tlpAnswers
            // 
            tlpAnswers.AutoSize = true;
            tlpAnswers.ColumnCount = 6;
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswers.Dock = DockStyle.Top;
            tlpAnswers.Location = new Point(0, 110);
            tlpAnswers.Name = "tlpAnswers";
            tlpAnswers.RowCount = 1;
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAnswers.Size = new Size(567, 10);
            tlpAnswers.TabIndex = 0;
            // 
            // tlpAddAnswerHolder
            // 
            tlpAddAnswerHolder.AutoSize = true;
            tlpAddAnswerHolder.ColumnCount = 4;
            tlpAddAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAddAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tlpAddAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAddAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAddAnswerHolder.Controls.Add(btnAddAnswer, 1, 0);
            tlpAddAnswerHolder.Dock = DockStyle.Top;
            tlpAddAnswerHolder.Location = new Point(0, 50);
            tlpAddAnswerHolder.Name = "tlpAddAnswerHolder";
            tlpAddAnswerHolder.RowCount = 1;
            tlpAddAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpAddAnswerHolder.Size = new Size(567, 60);
            tlpAddAnswerHolder.TabIndex = 1;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.BackColor = Color.DimGray;
            btnAddAnswer.Dock = DockStyle.Fill;
            btnAddAnswer.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAnswer.ForeColor = Color.Transparent;
            btnAddAnswer.Location = new Point(24, 14);
            btnAddAnswer.Margin = new Padding(4, 14, 4, 4);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(202, 42);
            btnAddAnswer.TabIndex = 0;
            btnAddAnswer.Text = "Add Answer";
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
            btnAddAnswer.MouseHover += btnAddAnswer_MouseHover;
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
            lblAHeading.Text = "Enter Answer(s):";
            lblAHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlQuestionHolder
            // 
            pnlQuestionHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlQuestionHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlQuestionHolder.Controls.Add(tlpQuestions);
            pnlQuestionHolder.Controls.Add(tlpAddQuestionHolder);
            pnlQuestionHolder.Controls.Add(lblQHeading);
            pnlQuestionHolder.Dock = DockStyle.Fill;
            pnlQuestionHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlQuestionHolder.Location = new Point(0, 55);
            pnlQuestionHolder.Margin = new Padding(0);
            pnlQuestionHolder.Name = "pnlQuestionHolder";
            pnlQuestionHolder.Size = new Size(569, 140);
            pnlQuestionHolder.TabIndex = 20;
            // 
            // tlpQuestions
            // 
            tlpQuestions.AutoSize = true;
            tlpQuestions.ColumnCount = 5;
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestions.Dock = DockStyle.Top;
            tlpQuestions.Location = new Point(0, 110);
            tlpQuestions.Name = "tlpQuestions";
            tlpQuestions.RowCount = 1;
            tlpQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpQuestions.Size = new Size(567, 10);
            tlpQuestions.TabIndex = 0;
            // 
            // tlpAddQuestionHolder
            // 
            tlpAddQuestionHolder.AutoSize = true;
            tlpAddQuestionHolder.ColumnCount = 4;
            tlpAddQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAddQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tlpAddQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAddQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAddQuestionHolder.Controls.Add(btnAddQuestion, 1, 0);
            tlpAddQuestionHolder.Dock = DockStyle.Top;
            tlpAddQuestionHolder.Location = new Point(0, 50);
            tlpAddQuestionHolder.Name = "tlpAddQuestionHolder";
            tlpAddQuestionHolder.RowCount = 1;
            tlpAddQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpAddQuestionHolder.Size = new Size(567, 60);
            tlpAddQuestionHolder.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.DimGray;
            btnAddQuestion.Dock = DockStyle.Fill;
            btnAddQuestion.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddQuestion.ForeColor = Color.Transparent;
            btnAddQuestion.Location = new Point(24, 14);
            btnAddQuestion.Margin = new Padding(4, 14, 4, 4);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(202, 42);
            btnAddQuestion.TabIndex = 0;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            btnAddQuestion.MouseHover += btnAddQuestion_MouseHover;
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
            lblQHeading.Text = "Enter Question(s):";
            lblQHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButtonHolder
            // 
            pnlButtonHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlButtonHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlButtonHolder.Controls.Add(tlpButtonHolder);
            pnlButtonHolder.Dock = DockStyle.Fill;
            pnlButtonHolder.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlButtonHolder.Location = new Point(0, 388);
            pnlButtonHolder.Margin = new Padding(0);
            pnlButtonHolder.MinimumSize = new Size(534, 68);
            pnlButtonHolder.Name = "pnlButtonHolder";
            pnlButtonHolder.Padding = new Padding(4, 5, 4, 5);
            pnlButtonHolder.Size = new Size(569, 73);
            pnlButtonHolder.TabIndex = 0;
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
            tlpButtonHolder.Size = new Size(559, 61);
            tlpButtonHolder.TabIndex = 0;
            // 
            // pnlTaskName
            // 
            pnlTaskName.Controls.Add(tlpTaskName);
            pnlTaskName.Dock = DockStyle.Fill;
            pnlTaskName.Location = new Point(10, 1);
            pnlTaskName.Margin = new Padding(0);
            pnlTaskName.Name = "pnlTaskName";
            pnlTaskName.Size = new Size(340, 60);
            pnlTaskName.TabIndex = 2;
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
            pnlBHolder.Location = new Point(353, 4);
            pnlBHolder.Name = "pnlBHolder";
            pnlBHolder.Size = new Size(193, 54);
            pnlBHolder.TabIndex = 0;
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
            pnlExtraOptionsHolder.Location = new Point(0, 335);
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
            lblMC.TabIndex = 1;
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
            // tlpChoiceHolder
            // 
            tlpChoiceHolder.AutoSize = true;
            tlpChoiceHolder.ColumnCount = 5;
            tlpChoiceHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpChoiceHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpChoiceHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpChoiceHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tlpChoiceHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpChoiceHolder.Dock = DockStyle.Top;
            tlpChoiceHolder.Location = new Point(3, 161);
            tlpChoiceHolder.Name = "tlpChoiceHolder";
            tlpChoiceHolder.RowCount = 1;
            tlpChoiceHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpChoiceHolder.Size = new Size(14, 4);
            tlpChoiceHolder.TabIndex = 5;
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 4;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Dock = DockStyle.Top;
            tlpAnswerHolder.Location = new Point(0, 0);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 1;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Size = new Size(200, 100);
            tlpAnswerHolder.TabIndex = 0;
            // 
            // btnAddChoice
            // 
            btnAddChoice.BackColor = Color.DimGray;
            btnAddChoice.Dock = DockStyle.Fill;
            btnAddChoice.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddChoice.ForeColor = Color.Transparent;
            btnAddChoice.Location = new Point(24, 4);
            btnAddChoice.Margin = new Padding(4);
            btnAddChoice.Name = "btnAddChoice";
            btnAddChoice.Size = new Size(125, 92);
            btnAddChoice.TabIndex = 0;
            btnAddChoice.Text = "Add Choice";
            btnAddChoice.UseVisualStyleBackColor = false;
            // 
            // btnChoiceAdd
            // 
            btnChoiceAdd.BackColor = Color.DimGray;
            btnChoiceAdd.Dock = DockStyle.Fill;
            btnChoiceAdd.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoiceAdd.ForeColor = Color.Transparent;
            btnChoiceAdd.Location = new Point(24, 4);
            btnChoiceAdd.Margin = new Padding(4);
            btnChoiceAdd.Name = "btnChoiceAdd";
            btnChoiceAdd.Size = new Size(125, 42);
            btnChoiceAdd.TabIndex = 0;
            btnChoiceAdd.Text = "Add Choice";
            btnChoiceAdd.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(24, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(125, 92);
            button1.TabIndex = 0;
            button1.Text = "Add Choice";
            button1.UseVisualStyleBackColor = false;
            // 
            // cfrmMatchColumn
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 461);
            Controls.Add(tlpMHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "cfrmMatchColumn";
            Text = "Create Match Column A and B Question";
            Load += cfrmMatchColumn_Load;
            Shown += cfrmMatchColumn_Shown;
            tlpMHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            pnlAnswerHolder.ResumeLayout(false);
            pnlAnswerHolder.PerformLayout();
            tlpAddAnswerHolder.ResumeLayout(false);
            pnlQuestionHolder.ResumeLayout(false);
            pnlQuestionHolder.PerformLayout();
            tlpAddQuestionHolder.ResumeLayout(false);
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

        private ToolTip ttQuestion;
        private TableLayoutPanel tlpMHolder;
        private Panel pnlHeadingHolder;
        private Label lblHeading;
        private Panel pnlAnswerHolder;
        private Panel pnlQuestionHolder;
        private Panel pnlButtonHolder;
        private TableLayoutPanel tlpButtonHolder;
        private Panel pnlBHolder;
        private Panel pnlExtraOptionsHolder;
        private TableLayoutPanel tlpEOHolder;
        private Label lblMC;
        public NumericUpDown nudMarks;
        private Label lblAHeading;
        private TableLayoutPanel tlpQuestionHolder;
        private Label lblQHeading;
        private Button btnChoiceAdd;
        private TableLayoutPanel tlpChoiceHolder;
        private TableLayoutPanel tlpAnswerHolder;
        private Button btnAddChoice;
        private TableLayoutPanel tlpAddQuestionHolder;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TableLayoutPanel tlpAddAnswerHolder;
        private Panel pnlTaskName;
        private TableLayoutPanel tlpTaskName;
        private Label lblTaskName;
        public Button btnCreate;
        public TableLayoutPanel tlpQuestions;
        public Button btnAddQuestion;
        public TableLayoutPanel tlpAnswers;
        public Button btnAddAnswer;
        public TextBox txtTaskName;
    }
}