namespace ExamPrepper.Forms
{
    partial class frmQuestionSetup
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
            tlpOptionsHolder = new TableLayoutPanel();
            btnMultiColumn = new Button();
            btnMultiChoice = new Button();
            btnFillBlank = new Button();
            btnTrueFalse = new Button();
            btnBasicQuestion = new Button();
            tlpSubjectHolder = new TableLayoutPanel();
            cbxSubjects = new ComboBox();
            lblSubjects = new Label();
            btnManage = new Button();
            tblMainHolder = new TableLayoutPanel();
            pnlSubjectsHolder = new Panel();
            pnlOptionsHolder = new Panel();
            tlpOptionsHolder.SuspendLayout();
            tlpSubjectHolder.SuspendLayout();
            tblMainHolder.SuspendLayout();
            pnlSubjectsHolder.SuspendLayout();
            pnlOptionsHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpOptionsHolder
            // 
            tlpOptionsHolder.ColumnCount = 5;
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Controls.Add(btnMultiColumn, 1, 3);
            tlpOptionsHolder.Controls.Add(btnMultiChoice, 1, 2);
            tlpOptionsHolder.Controls.Add(btnFillBlank, 2, 2);
            tlpOptionsHolder.Controls.Add(btnTrueFalse, 2, 1);
            tlpOptionsHolder.Controls.Add(btnBasicQuestion, 1, 1);
            tlpOptionsHolder.Dock = DockStyle.Fill;
            tlpOptionsHolder.Location = new Point(0, 0);
            tlpOptionsHolder.Margin = new Padding(0);
            tlpOptionsHolder.Name = "tlpOptionsHolder";
            tlpOptionsHolder.RowCount = 7;
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Size = new Size(686, 300);
            tlpOptionsHolder.TabIndex = 0;
            // 
            // btnMultiColumn
            // 
            btnMultiColumn.BackColor = Color.DimGray;
            btnMultiColumn.Dock = DockStyle.Top;
            btnMultiColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiColumn.Location = new Point(15, 145);
            btnMultiColumn.Margin = new Padding(5);
            btnMultiColumn.Name = "btnMultiColumn";
            btnMultiColumn.Size = new Size(240, 55);
            btnMultiColumn.TabIndex = 6;
            btnMultiColumn.Text = "Match Column A and B";
            btnMultiColumn.UseVisualStyleBackColor = false;
            btnMultiColumn.Click += btnMultiColumn_Click;
            btnMultiColumn.MouseHover += btnMultiColumn_MouseHover;
            // 
            // btnMultiChoice
            // 
            btnMultiChoice.BackColor = Color.DimGray;
            btnMultiChoice.Dock = DockStyle.Top;
            btnMultiChoice.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiChoice.Location = new Point(15, 80);
            btnMultiChoice.Margin = new Padding(5);
            btnMultiChoice.Name = "btnMultiChoice";
            btnMultiChoice.Size = new Size(240, 55);
            btnMultiChoice.TabIndex = 4;
            btnMultiChoice.Text = "Multiple Choice";
            btnMultiChoice.UseVisualStyleBackColor = false;
            btnMultiChoice.Click += btnMultiChoice_Click;
            btnMultiChoice.MouseHover += btnMultiChoice_MouseHover;
            // 
            // btnFillBlank
            // 
            btnFillBlank.BackColor = Color.DimGray;
            btnFillBlank.Dock = DockStyle.Top;
            btnFillBlank.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnFillBlank.Location = new Point(265, 80);
            btnFillBlank.Margin = new Padding(5);
            btnFillBlank.Name = "btnFillBlank";
            btnFillBlank.Size = new Size(240, 55);
            btnFillBlank.TabIndex = 5;
            btnFillBlank.Text = "Fill Blank";
            btnFillBlank.UseVisualStyleBackColor = false;
            btnFillBlank.Click += btnFillBlank_Click;
            btnFillBlank.MouseHover += btnFillBlank_MouseHover;
            // 
            // btnTrueFalse
            // 
            btnTrueFalse.BackColor = Color.DimGray;
            btnTrueFalse.Dock = DockStyle.Top;
            btnTrueFalse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrueFalse.Location = new Point(265, 15);
            btnTrueFalse.Margin = new Padding(5);
            btnTrueFalse.Name = "btnTrueFalse";
            btnTrueFalse.Size = new Size(240, 55);
            btnTrueFalse.TabIndex = 3;
            btnTrueFalse.Text = "True/False";
            btnTrueFalse.UseVisualStyleBackColor = false;
            btnTrueFalse.Click += btnTrueFalse_Click;
            btnTrueFalse.MouseHover += btnTrueFalse_MouseHover;
            // 
            // btnBasicQuestion
            // 
            btnBasicQuestion.BackColor = Color.DimGray;
            btnBasicQuestion.Dock = DockStyle.Top;
            btnBasicQuestion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBasicQuestion.Location = new Point(15, 15);
            btnBasicQuestion.Margin = new Padding(5);
            btnBasicQuestion.Name = "btnBasicQuestion";
            btnBasicQuestion.Size = new Size(240, 55);
            btnBasicQuestion.TabIndex = 2;
            btnBasicQuestion.Text = "Basic Question";
            btnBasicQuestion.UseVisualStyleBackColor = false;
            btnBasicQuestion.Click += btnBasicQuestion_Click;
            btnBasicQuestion.MouseHover += btnBasicQuestion_MouseHover;
            // 
            // tlpSubjectHolder
            // 
            tlpSubjectHolder.ColumnCount = 7;
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSubjectHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpSubjectHolder.Controls.Add(cbxSubjects, 3, 1);
            tlpSubjectHolder.Controls.Add(lblSubjects, 2, 1);
            tlpSubjectHolder.Controls.Add(btnManage, 3, 3);
            tlpSubjectHolder.Dock = DockStyle.Fill;
            tlpSubjectHolder.Location = new Point(0, 0);
            tlpSubjectHolder.Margin = new Padding(0);
            tlpSubjectHolder.Name = "tlpSubjectHolder";
            tlpSubjectHolder.RowCount = 6;
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSubjectHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSubjectHolder.Size = new Size(686, 120);
            tlpSubjectHolder.TabIndex = 10;
            // 
            // cbxSubjects
            // 
            tlpSubjectHolder.SetColumnSpan(cbxSubjects, 2);
            cbxSubjects.Dock = DockStyle.Fill;
            cbxSubjects.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSubjects.FormattingEnabled = true;
            cbxSubjects.Location = new Point(255, 13);
            cbxSubjects.Name = "cbxSubjects";
            cbxSubjects.Size = new Size(331, 31);
            cbxSubjects.TabIndex = 0;
            cbxSubjects.SelectedIndexChanged += cbxSubjects_SelectedIndexChanged;
            cbxSubjects.MouseHover += cbxSubjects_MouseHover;
            // 
            // lblSubjects
            // 
            lblSubjects.AutoSize = true;
            lblSubjects.Dock = DockStyle.Fill;
            lblSubjects.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubjects.Location = new Point(99, 12);
            lblSubjects.Margin = new Padding(2);
            lblSubjects.Name = "lblSubjects";
            lblSubjects.Size = new Size(151, 31);
            lblSubjects.TabIndex = 9;
            lblSubjects.Text = "Subjects:";
            lblSubjects.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.DimGray;
            btnManage.Dock = DockStyle.Fill;
            btnManage.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnManage.Location = new Point(255, 53);
            btnManage.Name = "btnManage";
            tlpSubjectHolder.SetRowSpan(btnManage, 2);
            btnManage.Size = new Size(204, 49);
            btnManage.TabIndex = 1;
            btnManage.Text = "Manage Subjects";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            btnManage.MouseHover += btnManage_MouseHover;
            // 
            // tblMainHolder
            // 
            tblMainHolder.ColumnCount = 1;
            tblMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainHolder.Controls.Add(pnlSubjectsHolder, 0, 0);
            tblMainHolder.Controls.Add(pnlOptionsHolder, 0, 1);
            tblMainHolder.Dock = DockStyle.Fill;
            tblMainHolder.Location = new Point(0, 0);
            tblMainHolder.Margin = new Padding(0);
            tblMainHolder.Name = "tblMainHolder";
            tblMainHolder.RowCount = 2;
            tblMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMainHolder.Size = new Size(686, 420);
            tblMainHolder.TabIndex = 11;
            // 
            // pnlSubjectsHolder
            // 
            pnlSubjectsHolder.BackColor = Color.Silver;
            pnlSubjectsHolder.Controls.Add(tlpSubjectHolder);
            pnlSubjectsHolder.Dock = DockStyle.Fill;
            pnlSubjectsHolder.Location = new Point(0, 0);
            pnlSubjectsHolder.Margin = new Padding(0);
            pnlSubjectsHolder.Name = "pnlSubjectsHolder";
            pnlSubjectsHolder.Size = new Size(686, 120);
            pnlSubjectsHolder.TabIndex = 1;
            // 
            // pnlOptionsHolder
            // 
            pnlOptionsHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlOptionsHolder.Controls.Add(tlpOptionsHolder);
            pnlOptionsHolder.Dock = DockStyle.Fill;
            pnlOptionsHolder.Location = new Point(0, 120);
            pnlOptionsHolder.Margin = new Padding(0);
            pnlOptionsHolder.Name = "pnlOptionsHolder";
            pnlOptionsHolder.Size = new Size(686, 300);
            pnlOptionsHolder.TabIndex = 12;
            // 
            // frmQuestionSetup
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 420);
            Controls.Add(tblMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmQuestionSetup";
            Text = "Question Setup";
            Load += frmQuestionSetup_Load;
            tlpOptionsHolder.ResumeLayout(false);
            tlpSubjectHolder.ResumeLayout(false);
            tlpSubjectHolder.PerformLayout();
            tblMainHolder.ResumeLayout(false);
            pnlSubjectsHolder.ResumeLayout(false);
            pnlOptionsHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpOptionsHolder;
        private Button btnMultiColumn;
        private Button btnMultiChoice;
        private Button btnFillBlank;
        private Button btnTrueFalse;
        private Button btnBasicQuestion;
        private TableLayoutPanel tlpSubjectHolder;
        private TableLayoutPanel tblMainHolder;
        private ComboBox cbxSubjects;
        private Label lblSubjects;
        private Button btnManage;
        private Panel pnlOptionsHolder;
        private Panel pnlSubjectsHolder;
    }
}