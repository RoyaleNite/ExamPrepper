namespace ExamPrepper
{
    partial class frmHomePage
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
            pnlTaskSetupHolder = new Panel();
            cgpHeadingSetup = new CustomGroupBox();
            tlpTaskSetupHolder = new TableLayoutPanel();
            btnExamSetup = new Button();
            btnQuizSetup = new Button();
            btnQuestionSetup = new Button();
            pnlResultsHolder = new Panel();
            tblResultsHolder = new TableLayoutPanel();
            pnlTasksHolder = new Panel();
            tlpTasksHolder = new TableLayoutPanel();
            btnTasks = new Button();
            btnExams = new Button();
            btnQuizzes = new Button();
            tlpMainHolder.SuspendLayout();
            pnlTaskSetupHolder.SuspendLayout();
            cgpHeadingSetup.SuspendLayout();
            tlpTaskSetupHolder.SuspendLayout();
            pnlResultsHolder.SuspendLayout();
            pnlTasksHolder.SuspendLayout();
            tlpTasksHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlTaskSetupHolder, 0, 1);
            tlpMainHolder.Controls.Add(pnlResultsHolder, 0, 2);
            tlpMainHolder.Controls.Add(pnlTasksHolder, 0, 0);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 3;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(640, 402);
            tlpMainHolder.TabIndex = 1;
            // 
            // pnlTaskSetupHolder
            // 
            pnlTaskSetupHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlTaskSetupHolder.Controls.Add(cgpHeadingSetup);
            pnlTaskSetupHolder.Dock = DockStyle.Fill;
            pnlTaskSetupHolder.Location = new Point(0, 90);
            pnlTaskSetupHolder.Margin = new Padding(0);
            pnlTaskSetupHolder.Name = "pnlTaskSetupHolder";
            pnlTaskSetupHolder.Padding = new Padding(10, 5, 10, 10);
            pnlTaskSetupHolder.Size = new Size(640, 220);
            pnlTaskSetupHolder.TabIndex = 4;
            // 
            // cgpHeadingSetup
            // 
            cgpHeadingSetup.Controls.Add(tlpTaskSetupHolder);
            cgpHeadingSetup.Dock = DockStyle.Fill;
            cgpHeadingSetup.Font = new Font("Calibri Light", 17F, FontStyle.Bold, GraphicsUnit.Point);
            cgpHeadingSetup.ForeColor = Color.Black;
            cgpHeadingSetup.Location = new Point(10, 5);
            cgpHeadingSetup.Name = "cgpHeadingSetup";
            cgpHeadingSetup.Padding = new Padding(5, 3, 3, 3);
            cgpHeadingSetup.Size = new Size(620, 205);
            cgpHeadingSetup.TabIndex = 4;
            cgpHeadingSetup.TabStop = false;
            cgpHeadingSetup.Text = "Setup";
            cgpHeadingSetup.TextColor = SystemColors.ActiveCaptionText;
            cgpHeadingSetup.ForeColorChanged += cgpHeadingSetup_ForeColorChanged;
            // 
            // tlpTaskSetupHolder
            // 
            tlpTaskSetupHolder.ColumnCount = 5;
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTaskSetupHolder.Controls.Add(btnExamSetup, 2, 3);
            tlpTaskSetupHolder.Controls.Add(btnQuizSetup, 0, 3);
            tlpTaskSetupHolder.Controls.Add(btnQuestionSetup, 0, 1);
            tlpTaskSetupHolder.Dock = DockStyle.Fill;
            tlpTaskSetupHolder.Location = new Point(5, 31);
            tlpTaskSetupHolder.Margin = new Padding(0);
            tlpTaskSetupHolder.Name = "tlpTaskSetupHolder";
            tlpTaskSetupHolder.RowCount = 5;
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.Size = new Size(612, 171);
            tlpTaskSetupHolder.TabIndex = 3;
            // 
            // btnExamSetup
            // 
            btnExamSetup.BackColor = Color.DimGray;
            btnExamSetup.Dock = DockStyle.Fill;
            btnExamSetup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnExamSetup.ForeColor = Color.Black;
            btnExamSetup.Location = new Point(213, 93);
            btnExamSetup.Name = "btnExamSetup";
            btnExamSetup.Size = new Size(194, 64);
            btnExamSetup.TabIndex = 5;
            btnExamSetup.Text = "Exam Setup";
            btnExamSetup.UseVisualStyleBackColor = false;
            btnExamSetup.Click += btnExamSetup_Click;
            btnExamSetup.MouseHover += btnExamSetup_MouseHover;
            // 
            // btnQuizSetup
            // 
            btnQuizSetup.BackColor = Color.DimGray;
            btnQuizSetup.Dock = DockStyle.Fill;
            btnQuizSetup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuizSetup.ForeColor = Color.Black;
            btnQuizSetup.Location = new Point(3, 93);
            btnQuizSetup.Name = "btnQuizSetup";
            btnQuizSetup.Size = new Size(194, 64);
            btnQuizSetup.TabIndex = 4;
            btnQuizSetup.Text = "Quiz Setup";
            btnQuizSetup.UseVisualStyleBackColor = false;
            btnQuizSetup.Click += btnQuizSetup_Click;
            btnQuizSetup.MouseHover += btnQuizSetup_MouseHover;
            // 
            // btnQuestionSetup
            // 
            btnQuestionSetup.BackColor = Color.DimGray;
            btnQuestionSetup.Dock = DockStyle.Fill;
            btnQuestionSetup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionSetup.ForeColor = Color.Black;
            btnQuestionSetup.Location = new Point(3, 13);
            btnQuestionSetup.Name = "btnQuestionSetup";
            btnQuestionSetup.Size = new Size(194, 64);
            btnQuestionSetup.TabIndex = 3;
            btnQuestionSetup.Text = "Question Setup";
            btnQuestionSetup.UseVisualStyleBackColor = false;
            btnQuestionSetup.Click += btnQuestionSetup_Click;
            btnQuestionSetup.MouseHover += btnQuestionSetup_MouseHover;
            // 
            // pnlResultsHolder
            // 
            pnlResultsHolder.BackColor = Color.Silver;
            pnlResultsHolder.Controls.Add(tblResultsHolder);
            pnlResultsHolder.Dock = DockStyle.Fill;
            pnlResultsHolder.Location = new Point(0, 310);
            pnlResultsHolder.Margin = new Padding(0);
            pnlResultsHolder.Name = "pnlResultsHolder";
            pnlResultsHolder.Size = new Size(640, 92);
            pnlResultsHolder.TabIndex = 5;
            // 
            // tblResultsHolder
            // 
            tblResultsHolder.ColumnCount = 4;
            tblResultsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblResultsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tblResultsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblResultsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblResultsHolder.Dock = DockStyle.Fill;
            tblResultsHolder.Location = new Point(0, 0);
            tblResultsHolder.Name = "tblResultsHolder";
            tblResultsHolder.RowCount = 4;
            tblResultsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblResultsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblResultsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblResultsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblResultsHolder.Size = new Size(640, 92);
            tblResultsHolder.TabIndex = 0;
            // 
            // pnlTasksHolder
            // 
            pnlTasksHolder.BackColor = Color.Silver;
            pnlTasksHolder.Controls.Add(tlpTasksHolder);
            pnlTasksHolder.Dock = DockStyle.Fill;
            pnlTasksHolder.Location = new Point(0, 0);
            pnlTasksHolder.Margin = new Padding(0);
            pnlTasksHolder.Name = "pnlTasksHolder";
            pnlTasksHolder.Size = new Size(640, 90);
            pnlTasksHolder.TabIndex = 4;
            // 
            // tlpTasksHolder
            // 
            tlpTasksHolder.ColumnCount = 7;
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpTasksHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.Controls.Add(btnTasks, 5, 1);
            tlpTasksHolder.Controls.Add(btnExams, 3, 1);
            tlpTasksHolder.Controls.Add(btnQuizzes, 1, 1);
            tlpTasksHolder.Dock = DockStyle.Fill;
            tlpTasksHolder.Location = new Point(0, 0);
            tlpTasksHolder.Margin = new Padding(0);
            tlpTasksHolder.Name = "tlpTasksHolder";
            tlpTasksHolder.RowCount = 3;
            tlpTasksHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpTasksHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksHolder.Size = new Size(640, 90);
            tlpTasksHolder.TabIndex = 0;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.DimGray;
            btnTasks.Dock = DockStyle.Fill;
            btnTasks.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTasks.Location = new Point(433, 13);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(194, 64);
            btnTasks.TabIndex = 2;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            btnTasks.MouseHover += btnTasks_MouseHover;
            // 
            // btnExams
            // 
            btnExams.BackColor = Color.DimGray;
            btnExams.Dock = DockStyle.Fill;
            btnExams.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnExams.Location = new Point(223, 13);
            btnExams.Name = "btnExams";
            btnExams.Size = new Size(194, 64);
            btnExams.TabIndex = 1;
            btnExams.Text = "Exams";
            btnExams.UseVisualStyleBackColor = false;
            btnExams.Click += btnExams_Click;
            btnExams.MouseHover += btnExams_MouseHover;
            // 
            // btnQuizzes
            // 
            btnQuizzes.BackColor = Color.DimGray;
            btnQuizzes.Dock = DockStyle.Fill;
            btnQuizzes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuizzes.Location = new Point(13, 13);
            btnQuizzes.Name = "btnQuizzes";
            btnQuizzes.Size = new Size(194, 64);
            btnQuizzes.TabIndex = 0;
            btnQuizzes.Text = "Quizzes";
            btnQuizzes.UseVisualStyleBackColor = false;
            btnQuizzes.Click += btnQuizzes_Click;
            btnQuizzes.MouseHover += btnQuizzes_MouseHover;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(640, 402);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmHomePage";
            Text = "Home Page";
            Load += frmHomePage_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskSetupHolder.ResumeLayout(false);
            cgpHeadingSetup.ResumeLayout(false);
            tlpTaskSetupHolder.ResumeLayout(false);
            pnlResultsHolder.ResumeLayout(false);
            pnlTasksHolder.ResumeLayout(false);
            tlpTasksHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private TableLayoutPanel tlpTasksHolder;
        private Button btnExams;
        private Button btnQuizzes;
        private TableLayoutPanel tlpTaskSetupHolder;
        private Button btnQuestionSetup;
        private Panel pnlTasksHolder;
        private Panel pnlTaskSetupHolder;
        private Button btnExamSetup;
        private Button btnQuizSetup;
        private Panel pnlResultsHolder;
        private TableLayoutPanel tblResultsHolder;
        private CustomGroupBox cgpHeadingSetup;
        private Button btnTasks;
    }
}