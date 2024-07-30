namespace ExamPrepper.Forms.TaskCollectionForm
{
    partial class frmInfoTasks
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
            tlpMainHolder = new TableLayoutPanel();
            pnlTaskCollectionInfoHolder = new Panel();
            cgbHeadingTaskCollectionInfoHolder = new CustomGroupBox();
            tlpTaskCollectionInfoHolder = new TableLayoutPanel();
            txtMarkCount = new TextBox();
            lblCount = new Label();
            txtCS = new TextBox();
            lblCaseSentitive = new Label();
            txtSubject = new TextBox();
            lblSubject = new Label();
            lblName = new Label();
            lblQuestion = new Label();
            lblAnswers = new Label();
            txtName = new TextBox();
            txtTasks = new TextBox();
            lblDistractors = new Label();
            txtDistractors = new TextBox();
            rtbQuestion = new RichTextBox();
            tlpMainHolder.SuspendLayout();
            pnlTaskCollectionInfoHolder.SuspendLayout();
            cgbHeadingTaskCollectionInfoHolder.SuspendLayout();
            tlpTaskCollectionInfoHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlTaskCollectionInfoHolder, 0, 0);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 1;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(609, 475);
            tlpMainHolder.TabIndex = 1;
            // 
            // pnlTaskCollectionInfoHolder
            // 
            pnlTaskCollectionInfoHolder.BackColor = Color.Silver;
            pnlTaskCollectionInfoHolder.Controls.Add(cgbHeadingTaskCollectionInfoHolder);
            pnlTaskCollectionInfoHolder.Dock = DockStyle.Fill;
            pnlTaskCollectionInfoHolder.Location = new Point(10, 10);
            pnlTaskCollectionInfoHolder.Margin = new Padding(10, 10, 10, 5);
            pnlTaskCollectionInfoHolder.Name = "pnlTaskCollectionInfoHolder";
            pnlTaskCollectionInfoHolder.Padding = new Padding(7);
            pnlTaskCollectionInfoHolder.Size = new Size(589, 460);
            pnlTaskCollectionInfoHolder.TabIndex = 1;
            // 
            // cgbHeadingTaskCollectionInfoHolder
            // 
            cgbHeadingTaskCollectionInfoHolder.Controls.Add(tlpTaskCollectionInfoHolder);
            cgbHeadingTaskCollectionInfoHolder.Dock = DockStyle.Fill;
            cgbHeadingTaskCollectionInfoHolder.Font = new Font("Calibri Light", 17F, FontStyle.Bold, GraphicsUnit.Point);
            cgbHeadingTaskCollectionInfoHolder.ForeColor = Color.Black;
            cgbHeadingTaskCollectionInfoHolder.Location = new Point(7, 7);
            cgbHeadingTaskCollectionInfoHolder.Margin = new Padding(10);
            cgbHeadingTaskCollectionInfoHolder.Name = "cgbHeadingTaskCollectionInfoHolder";
            cgbHeadingTaskCollectionInfoHolder.Padding = new Padding(6, 3, 6, 5);
            cgbHeadingTaskCollectionInfoHolder.Size = new Size(575, 446);
            cgbHeadingTaskCollectionInfoHolder.TabIndex = 6;
            cgbHeadingTaskCollectionInfoHolder.TabStop = false;
            cgbHeadingTaskCollectionInfoHolder.Text = "Information";
            cgbHeadingTaskCollectionInfoHolder.TextColor = SystemColors.ActiveCaptionText;
            // 
            // tlpTaskCollectionInfoHolder
            // 
            tlpTaskCollectionInfoHolder.ColumnCount = 4;
            tlpTaskCollectionInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tlpTaskCollectionInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTaskCollectionInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.Controls.Add(txtMarkCount, 2, 13);
            tlpTaskCollectionInfoHolder.Controls.Add(lblCount, 1, 13);
            tlpTaskCollectionInfoHolder.Controls.Add(txtCS, 2, 11);
            tlpTaskCollectionInfoHolder.Controls.Add(lblCaseSentitive, 1, 11);
            tlpTaskCollectionInfoHolder.Controls.Add(txtSubject, 2, 5);
            tlpTaskCollectionInfoHolder.Controls.Add(lblSubject, 1, 5);
            tlpTaskCollectionInfoHolder.Controls.Add(lblName, 1, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(lblQuestion, 1, 3);
            tlpTaskCollectionInfoHolder.Controls.Add(lblAnswers, 1, 7);
            tlpTaskCollectionInfoHolder.Controls.Add(txtName, 2, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(txtTasks, 2, 7);
            tlpTaskCollectionInfoHolder.Controls.Add(lblDistractors, 1, 9);
            tlpTaskCollectionInfoHolder.Controls.Add(txtDistractors, 2, 9);
            tlpTaskCollectionInfoHolder.Controls.Add(rtbQuestion, 2, 3);
            tlpTaskCollectionInfoHolder.Dock = DockStyle.Fill;
            tlpTaskCollectionInfoHolder.Location = new Point(6, 31);
            tlpTaskCollectionInfoHolder.Margin = new Padding(2);
            tlpTaskCollectionInfoHolder.Name = "tlpTaskCollectionInfoHolder";
            tlpTaskCollectionInfoHolder.RowCount = 16;
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.Size = new Size(563, 410);
            tlpTaskCollectionInfoHolder.TabIndex = 0;
            // 
            // txtMarkCount
            // 
            txtMarkCount.Dock = DockStyle.Fill;
            txtMarkCount.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMarkCount.Location = new Point(206, 368);
            txtMarkCount.Name = "txtMarkCount";
            txtMarkCount.ReadOnly = true;
            txtMarkCount.Size = new Size(344, 30);
            txtMarkCount.TabIndex = 14;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Dock = DockStyle.Fill;
            lblCount.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.Location = new Point(12, 367);
            lblCount.Margin = new Padding(2);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(189, 31);
            lblCount.TabIndex = 13;
            lblCount.Text = "Mark Count:";
            lblCount.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCS
            // 
            txtCS.Dock = DockStyle.Fill;
            txtCS.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtCS.Location = new Point(206, 308);
            txtCS.Name = "txtCS";
            txtCS.ReadOnly = true;
            txtCS.Size = new Size(344, 30);
            txtCS.TabIndex = 12;
            // 
            // lblCaseSentitive
            // 
            lblCaseSentitive.AutoSize = true;
            lblCaseSentitive.Dock = DockStyle.Fill;
            lblCaseSentitive.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaseSentitive.Location = new Point(12, 307);
            lblCaseSentitive.Margin = new Padding(2);
            lblCaseSentitive.Name = "lblCaseSentitive";
            lblCaseSentitive.Size = new Size(189, 46);
            lblCaseSentitive.TabIndex = 11;
            lblCaseSentitive.Text = "Case Senstivie Answers :";
            lblCaseSentitive.TextAlign = ContentAlignment.TopRight;
            // 
            // txtSubject
            // 
            txtSubject.Dock = DockStyle.Fill;
            txtSubject.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubject.Location = new Point(206, 173);
            txtSubject.Name = "txtSubject";
            txtSubject.ReadOnly = true;
            txtSubject.Size = new Size(344, 30);
            txtSubject.TabIndex = 10;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Dock = DockStyle.Fill;
            lblSubject.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject.Location = new Point(12, 172);
            lblSubject.Margin = new Padding(2);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(189, 31);
            lblSubject.TabIndex = 9;
            lblSubject.Text = "Subject :";
            lblSubject.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 12);
            lblName.Margin = new Padding(2);
            lblName.Name = "lblName";
            lblName.Size = new Size(189, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(12, 57);
            lblQuestion.Margin = new Padding(2);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(189, 101);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAnswers
            // 
            lblAnswers.AutoSize = true;
            lblAnswers.Dock = DockStyle.Fill;
            lblAnswers.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswers.Location = new Point(12, 217);
            lblAnswers.Margin = new Padding(2);
            lblAnswers.Name = "lblAnswers";
            lblAnswers.Size = new Size(189, 31);
            lblAnswers.TabIndex = 2;
            lblAnswers.Text = "Answers :";
            lblAnswers.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(206, 13);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(344, 30);
            txtName.TabIndex = 3;
            // 
            // txtTasks
            // 
            txtTasks.Dock = DockStyle.Fill;
            txtTasks.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTasks.Location = new Point(206, 218);
            txtTasks.Name = "txtTasks";
            txtTasks.ReadOnly = true;
            txtTasks.Size = new Size(344, 30);
            txtTasks.TabIndex = 5;
            // 
            // lblDistractors
            // 
            lblDistractors.AutoSize = true;
            lblDistractors.Dock = DockStyle.Fill;
            lblDistractors.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDistractors.Location = new Point(12, 262);
            lblDistractors.Margin = new Padding(2);
            lblDistractors.Name = "lblDistractors";
            lblDistractors.Size = new Size(189, 31);
            lblDistractors.TabIndex = 6;
            lblDistractors.Text = "Distractors :";
            lblDistractors.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDistractors
            // 
            txtDistractors.Dock = DockStyle.Fill;
            txtDistractors.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtDistractors.Location = new Point(206, 263);
            txtDistractors.Name = "txtDistractors";
            txtDistractors.ReadOnly = true;
            txtDistractors.Size = new Size(344, 30);
            txtDistractors.TabIndex = 7;
            // 
            // rtbQuestion
            // 
            rtbQuestion.Dock = DockStyle.Fill;
            rtbQuestion.Location = new Point(206, 58);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.ReadOnly = true;
            rtbQuestion.Size = new Size(344, 99);
            rtbQuestion.TabIndex = 8;
            rtbQuestion.Text = "";
            // 
            // frmInfoTasks
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 475);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmInfoTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks Information";
            Load += frmInfoTasks_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskCollectionInfoHolder.ResumeLayout(false);
            cgbHeadingTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private Panel pnlTaskCollectionInfoHolder;
        private CustomGroupBox cgbHeadingTaskCollectionInfoHolder;
        private TableLayoutPanel tlpTaskCollectionInfoHolder;
        private Label lblName;
        private Label lblQuestion;
        private Label lblAnswers;
        private Label lblDistractors;
        private Label lblSubject;
        private Label lblCaseSentitive;
        private Label lblCount;
        public TextBox txtName;
        public TextBox txtTasks;
        public TextBox txtDistractors;
        public RichTextBox rtbQuestion;
        public TextBox txtSubject;
        public TextBox txtCS;
        public TextBox txtMarkCount;
    }
}