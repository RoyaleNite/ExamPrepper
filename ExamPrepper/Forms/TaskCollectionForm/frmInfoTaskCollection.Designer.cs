namespace ExamPrepper.Forms.TaskCollectionForm
{
    partial class frmInfoTaskCollection
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
            pnlTaskCollectionInfoHolder = new Panel();
            cgbHeadingTaskCollectionInfoHolder = new CustomGroupBox();
            tlpTaskCollectionInfoHolder = new TableLayoutPanel();
            txtSubjects = new TextBox();
            lblSubjects = new Label();
            lblName = new Label();
            lblSection = new Label();
            lblTasks = new Label();
            txtName = new TextBox();
            txtSections = new TextBox();
            txtTasks = new TextBox();
            lblTypes = new Label();
            txtTypes = new TextBox();
            pnlTasksHolder = new Panel();
            cgbHeadingTasksInformationHolder = new CustomGroupBox();
            tlpTasksInformationHolder = new TableLayoutPanel();
            dgvTasks = new DataGridView();
            cpgHeadingFilter = new CustomGroupBox();
            tlpFilterHolder = new TableLayoutPanel();
            btnMore = new Button();
            lblFilter = new Label();
            tlpMainHolder.SuspendLayout();
            pnlTaskCollectionInfoHolder.SuspendLayout();
            cgbHeadingTaskCollectionInfoHolder.SuspendLayout();
            tlpTaskCollectionInfoHolder.SuspendLayout();
            pnlTasksHolder.SuspendLayout();
            cgbHeadingTasksInformationHolder.SuspendLayout();
            tlpTasksInformationHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tlpFilterHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Controls.Add(pnlTaskCollectionInfoHolder, 0, 0);
            tlpMainHolder.Controls.Add(pnlTasksHolder, 0, 1);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 2;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 62.30032F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 37.69968F));
            tlpMainHolder.Size = new Size(609, 626);
            tlpMainHolder.TabIndex = 0;
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
            pnlTaskCollectionInfoHolder.Size = new Size(589, 375);
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
            cgbHeadingTaskCollectionInfoHolder.Size = new Size(575, 361);
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
            tlpTaskCollectionInfoHolder.Controls.Add(txtSubjects, 2, 8);
            tlpTaskCollectionInfoHolder.Controls.Add(lblSubjects, 1, 8);
            tlpTaskCollectionInfoHolder.Controls.Add(lblName, 1, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(lblSection, 1, 3);
            tlpTaskCollectionInfoHolder.Controls.Add(lblTasks, 1, 5);
            tlpTaskCollectionInfoHolder.Controls.Add(txtName, 2, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(txtSections, 2, 3);
            tlpTaskCollectionInfoHolder.Controls.Add(txtTasks, 2, 5);
            tlpTaskCollectionInfoHolder.Controls.Add(lblTypes, 1, 7);
            tlpTaskCollectionInfoHolder.Controls.Add(txtTypes, 2, 7);
            tlpTaskCollectionInfoHolder.Dock = DockStyle.Fill;
            tlpTaskCollectionInfoHolder.Location = new Point(6, 31);
            tlpTaskCollectionInfoHolder.Margin = new Padding(2);
            tlpTaskCollectionInfoHolder.Name = "tlpTaskCollectionInfoHolder";
            tlpTaskCollectionInfoHolder.RowCount = 10;
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.Size = new Size(563, 325);
            tlpTaskCollectionInfoHolder.TabIndex = 0;
            // 
            // txtSubjects
            // 
            txtSubjects.Dock = DockStyle.Fill;
            txtSubjects.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjects.Location = new Point(206, 209);
            txtSubjects.Multiline = true;
            txtSubjects.Name = "txtSubjects";
            txtSubjects.ReadOnly = true;
            txtSubjects.Size = new Size(344, 103);
            txtSubjects.TabIndex = 9;
            // 
            // lblSubjects
            // 
            lblSubjects.AutoSize = true;
            lblSubjects.Dock = DockStyle.Fill;
            lblSubjects.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubjects.Location = new Point(12, 208);
            lblSubjects.Margin = new Padding(2);
            lblSubjects.Name = "lblSubjects";
            lblSubjects.Size = new Size(189, 105);
            lblSubjects.TabIndex = 8;
            lblSubjects.Text = "Subjects";
            lblSubjects.TextAlign = ContentAlignment.TopRight;
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
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Dock = DockStyle.Fill;
            lblSection.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSection.Location = new Point(12, 57);
            lblSection.Margin = new Padding(2);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(189, 31);
            lblSection.TabIndex = 1;
            lblSection.Text = "Sections :";
            lblSection.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Dock = DockStyle.Fill;
            lblTasks.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTasks.Location = new Point(12, 102);
            lblTasks.Margin = new Padding(2);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(189, 31);
            lblTasks.TabIndex = 2;
            lblTasks.Text = "Tasks :";
            lblTasks.TextAlign = ContentAlignment.MiddleRight;
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
            // txtSections
            // 
            txtSections.Dock = DockStyle.Fill;
            txtSections.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSections.Location = new Point(206, 58);
            txtSections.Name = "txtSections";
            txtSections.ReadOnly = true;
            txtSections.Size = new Size(344, 30);
            txtSections.TabIndex = 4;
            // 
            // txtTasks
            // 
            txtTasks.Dock = DockStyle.Fill;
            txtTasks.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTasks.Location = new Point(206, 103);
            txtTasks.Name = "txtTasks";
            txtTasks.ReadOnly = true;
            txtTasks.Size = new Size(344, 30);
            txtTasks.TabIndex = 5;
            // 
            // lblTypes
            // 
            lblTypes.AutoSize = true;
            lblTypes.Dock = DockStyle.Fill;
            lblTypes.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypes.Location = new Point(12, 147);
            lblTypes.Margin = new Padding(2);
            lblTypes.Name = "lblTypes";
            lblTypes.Size = new Size(189, 57);
            lblTypes.TabIndex = 6;
            lblTypes.Text = "Type of questions:";
            lblTypes.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTypes
            // 
            txtTypes.Dock = DockStyle.Fill;
            txtTypes.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTypes.Location = new Point(206, 148);
            txtTypes.Multiline = true;
            txtTypes.Name = "txtTypes";
            txtTypes.ReadOnly = true;
            txtTypes.Size = new Size(344, 55);
            txtTypes.TabIndex = 7;
            // 
            // pnlTasksHolder
            // 
            pnlTasksHolder.BackColor = Color.Silver;
            pnlTasksHolder.Controls.Add(cgbHeadingTasksInformationHolder);
            pnlTasksHolder.Dock = DockStyle.Fill;
            pnlTasksHolder.Location = new Point(10, 395);
            pnlTasksHolder.Margin = new Padding(10, 5, 10, 10);
            pnlTasksHolder.Name = "pnlTasksHolder";
            pnlTasksHolder.Padding = new Padding(7);
            pnlTasksHolder.Size = new Size(589, 221);
            pnlTasksHolder.TabIndex = 2;
            // 
            // cgbHeadingTasksInformationHolder
            // 
            cgbHeadingTasksInformationHolder.Controls.Add(tlpTasksInformationHolder);
            cgbHeadingTasksInformationHolder.Dock = DockStyle.Fill;
            cgbHeadingTasksInformationHolder.Font = new Font("Calibri Light", 17F, FontStyle.Bold, GraphicsUnit.Point);
            cgbHeadingTasksInformationHolder.ForeColor = Color.Black;
            cgbHeadingTasksInformationHolder.Location = new Point(7, 7);
            cgbHeadingTasksInformationHolder.Margin = new Padding(10);
            cgbHeadingTasksInformationHolder.Name = "cgbHeadingTasksInformationHolder";
            cgbHeadingTasksInformationHolder.Padding = new Padding(6, 3, 6, 5);
            cgbHeadingTasksInformationHolder.Size = new Size(575, 207);
            cgbHeadingTasksInformationHolder.TabIndex = 7;
            cgbHeadingTasksInformationHolder.TabStop = false;
            cgbHeadingTasksInformationHolder.Text = "Tasks";
            cgbHeadingTasksInformationHolder.TextColor = SystemColors.ActiveCaptionText;
            // 
            // tlpTasksInformationHolder
            // 
            tlpTasksInformationHolder.ColumnCount = 3;
            tlpTasksInformationHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksInformationHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTasksInformationHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksInformationHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTasksInformationHolder.Controls.Add(dgvTasks, 1, 1);
            tlpTasksInformationHolder.Dock = DockStyle.Fill;
            tlpTasksInformationHolder.Location = new Point(6, 31);
            tlpTasksInformationHolder.Margin = new Padding(2);
            tlpTasksInformationHolder.Name = "tlpTasksInformationHolder";
            tlpTasksInformationHolder.RowCount = 3;
            tlpTasksInformationHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksInformationHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTasksInformationHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksInformationHolder.Size = new Size(563, 171);
            tlpTasksInformationHolder.TabIndex = 0;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(10, 10);
            dgvTasks.Margin = new Padding(0);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowTemplate.Height = 25;
            dgvTasks.Size = new Size(543, 151);
            dgvTasks.TabIndex = 0;
            // 
            // cpgHeadingFilter
            // 
            cpgHeadingFilter.Location = new Point(0, 0);
            cpgHeadingFilter.Name = "cpgHeadingFilter";
            cpgHeadingFilter.Size = new Size(200, 100);
            cpgHeadingFilter.TabIndex = 0;
            cpgHeadingFilter.TabStop = false;
            // 
            // tlpFilterHolder
            // 
            tlpFilterHolder.ColumnCount = 3;
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpFilterHolder.Controls.Add(btnMore, 3, 0);
            tlpFilterHolder.Location = new Point(0, 0);
            tlpFilterHolder.Name = "tlpFilterHolder";
            tlpFilterHolder.RowCount = 1;
            tlpFilterHolder.Size = new Size(200, 100);
            tlpFilterHolder.TabIndex = 0;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.DimGray;
            btnMore.Dock = DockStyle.Fill;
            btnMore.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.Location = new Point(20, 0);
            btnMore.Margin = new Padding(0);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(180, 100);
            btnMore.TabIndex = 11;
            btnMore.Text = "More FIlters";
            btnMore.UseVisualStyleBackColor = false;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Dock = DockStyle.Fill;
            lblFilter.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.Location = new Point(2, 2);
            lblFilter.Margin = new Padding(2);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(106, 96);
            lblFilter.TabIndex = 9;
            lblFilter.Text = "By Name:";
            lblFilter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmInfoTaskCollection
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(590, 625);
            BackColor = Color.Gray;
            ClientSize = new Size(609, 626);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmInfoTaskCollection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            Load += frmInfo_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskCollectionInfoHolder.ResumeLayout(false);
            cgbHeadingTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.PerformLayout();
            pnlTasksHolder.ResumeLayout(false);
            cgbHeadingTasksInformationHolder.ResumeLayout(false);
            tlpTasksInformationHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tlpFilterHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private TableLayoutPanel tlpTaskCollectionInfoHolder;
        private CustomGroupBox cgbHeadingTaskCollectionInfoHolder;
        private CustomGroupBox cpgHeadingFilter;
        private TableLayoutPanel tlpFilterHolder;
        private Button btnMore;
        private Label lblFilter;
        private Panel pnlTaskCollectionInfoHolder;
        private Label lblName;
        private Label lblSection;
        private Label lblTasks;
        private TextBox txtName;
        private TextBox txtSections;
        private TextBox txtTasks;
        private Label lblTypes;
        private TextBox txtTypes;
        private Label lblSubjects;
        private TextBox txtSubjects;
        private Panel pnlTasksHolder;
        private CustomGroupBox cgbHeadingTasksInformationHolder;
        private TableLayoutPanel tlpTasksInformationHolder;
        private DataGridView dgvTasks;
    }
}