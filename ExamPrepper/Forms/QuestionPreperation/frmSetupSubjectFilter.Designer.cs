namespace ExamPrepper.Forms.QuestionPreperation
{
    partial class frmSetupSubjectFilter
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tlpMainHolder = new TableLayoutPanel();
            pnlMainHolder = new Panel();
            cgpHeadingSetup = new CustomGroupBox();
            tlpTaskSetupHolder = new TableLayoutPanel();
            cbxShowRandom = new CheckBox();
            dgvTypes = new DataGridView();
            btnSelectAll = new Button();
            btnMore = new Button();
            dgvSubjects = new DataGridView();
            tlpMainHolder.SuspendLayout();
            pnlMainHolder.SuspendLayout();
            cgpHeadingSetup.SuspendLayout();
            tlpTaskSetupHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlMainHolder, 0, 0);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 1;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(613, 451);
            tlpMainHolder.TabIndex = 0;
            // 
            // pnlMainHolder
            // 
            pnlMainHolder.Controls.Add(cgpHeadingSetup);
            pnlMainHolder.Dock = DockStyle.Fill;
            pnlMainHolder.Location = new Point(0, 0);
            pnlMainHolder.Margin = new Padding(0);
            pnlMainHolder.Name = "pnlMainHolder";
            pnlMainHolder.Padding = new Padding(10);
            pnlMainHolder.Size = new Size(613, 451);
            pnlMainHolder.TabIndex = 0;
            // 
            // cgpHeadingSetup
            // 
            cgpHeadingSetup.Controls.Add(tlpTaskSetupHolder);
            cgpHeadingSetup.Dock = DockStyle.Fill;
            cgpHeadingSetup.Font = new Font("Calibri Light", 17F, FontStyle.Bold, GraphicsUnit.Point);
            cgpHeadingSetup.ForeColor = Color.Black;
            cgpHeadingSetup.Location = new Point(10, 10);
            cgpHeadingSetup.Name = "cgpHeadingSetup";
            cgpHeadingSetup.Padding = new Padding(5, 3, 3, 3);
            cgpHeadingSetup.Size = new Size(593, 431);
            cgpHeadingSetup.TabIndex = 5;
            cgpHeadingSetup.TabStop = false;
            cgpHeadingSetup.Text = "Filters";
            cgpHeadingSetup.TextColor = SystemColors.ActiveCaptionText;
            // 
            // tlpTaskSetupHolder
            // 
            tlpTaskSetupHolder.ColumnCount = 4;
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpTaskSetupHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTaskSetupHolder.Controls.Add(cbxShowRandom, 0, 4);
            tlpTaskSetupHolder.Controls.Add(dgvTypes, 1, 3);
            tlpTaskSetupHolder.Controls.Add(btnSelectAll, 2, 1);
            tlpTaskSetupHolder.Controls.Add(btnMore, 0, 1);
            tlpTaskSetupHolder.Controls.Add(dgvSubjects, 0, 3);
            tlpTaskSetupHolder.Dock = DockStyle.Fill;
            tlpTaskSetupHolder.Location = new Point(5, 31);
            tlpTaskSetupHolder.Margin = new Padding(0);
            tlpTaskSetupHolder.Name = "tlpTaskSetupHolder";
            tlpTaskSetupHolder.RowCount = 6;
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpTaskSetupHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskSetupHolder.Size = new Size(585, 397);
            tlpTaskSetupHolder.TabIndex = 3;
            // 
            // cbxShowRandom
            // 
            cbxShowRandom.AutoSize = true;
            cbxShowRandom.BackColor = SystemColors.ActiveBorder;
            tlpTaskSetupHolder.SetColumnSpan(cbxShowRandom, 3);
            cbxShowRandom.Dock = DockStyle.Fill;
            cbxShowRandom.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShowRandom.Location = new Point(3, 350);
            cbxShowRandom.Margin = new Padding(3, 8, 3, 3);
            cbxShowRandom.Name = "cbxShowRandom";
            cbxShowRandom.Padding = new Padding(10, 3, 0, 0);
            cbxShowRandom.Size = new Size(354, 34);
            cbxShowRandom.TabIndex = 12;
            cbxShowRandom.Text = "Show Random Quizzes";
            cbxShowRandom.UseVisualStyleBackColor = false;
            // 
            // dgvTypes
            // 
            dgvTypes.AllowUserToAddRows = false;
            dgvTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTypes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTypes.Dock = DockStyle.Fill;
            dgvTypes.Location = new Point(363, 83);
            dgvTypes.Name = "dgvTypes";
            dgvTypes.RowHeadersVisible = false;
            dgvTypes.RowTemplate.Height = 25;
            dgvTypes.Size = new Size(219, 256);
            dgvTypes.TabIndex = 11;
            dgvTypes.CellContentClick += dgvTypes_CellContentClick;
            dgvTypes.CellValueChanged += dgvTypes_CellValueChanged;
            dgvTypes.MouseHover += dgvTypes_MouseHover;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.DimGray;
            btnSelectAll.Dock = DockStyle.Fill;
            btnSelectAll.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectAll.Location = new Point(185, 10);
            btnSelectAll.Margin = new Padding(0);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(175, 60);
            btnSelectAll.TabIndex = 10;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            btnSelectAll.MouseHover += btnSelectAll_MouseHover;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.DimGray;
            btnMore.Dock = DockStyle.Fill;
            btnMore.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.Location = new Point(0, 10);
            btnMore.Margin = new Padding(0);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(175, 60);
            btnMore.TabIndex = 9;
            btnMore.Text = "Clear FIlters";
            btnMore.UseVisualStyleBackColor = false;
            btnMore.Click += btnMore_Click;
            btnMore.MouseHover += btnMore_MouseHover;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpTaskSetupHolder.SetColumnSpan(dgvSubjects, 3);
            dgvSubjects.Dock = DockStyle.Fill;
            dgvSubjects.Location = new Point(3, 83);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersVisible = false;
            dgvSubjects.RowTemplate.Height = 25;
            dgvSubjects.Size = new Size(354, 256);
            dgvSubjects.TabIndex = 1;
            dgvSubjects.CellContentClick += dgvSubjects_CellContentClick;
            dgvSubjects.CellValueChanged += dgvSubjects_CellValueChanged;
            dgvSubjects.MouseHover += dgvSubjects_MouseHover;
            // 
            // frmSetupSubjectFilter
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 451);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(550, 490);
            Name = "frmSetupSubjectFilter";
            Text = "Filters";
            Load += frmSetupSubjectFilter_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlMainHolder.ResumeLayout(false);
            cgpHeadingSetup.ResumeLayout(false);
            tlpTaskSetupHolder.ResumeLayout(false);
            tlpTaskSetupHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel tlpMainHolder;
        public Panel pnlMainHolder;
        public CustomGroupBox cgpHeadingSetup;
        public TableLayoutPanel tlpTaskSetupHolder;
        public DataGridView dgvSubjects;
        public Button btnSelectAll;
        public Button btnMore;
        public DataGridView dgvTypes;
        public CheckBox cbxShowRandom;
    }
}