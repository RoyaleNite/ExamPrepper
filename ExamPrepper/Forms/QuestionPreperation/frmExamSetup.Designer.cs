namespace ExamPrepper.Forms.QuestionPreperation
{
    partial class frmExamSetup
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
            pnlHeadingHolder = new Panel();
            tlpHeadingHolder = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            pnlCustomize = new Panel();
            tbcSectionTasks = new TabControl();
            pnlBottomHolder = new Panel();
            tlpBottomHolder = new TableLayoutPanel();
            btnCreate = new Button();
            pnlSectionHolder = new Panel();
            tlpSectionHolder = new TableLayoutPanel();
            btnAddSection = new Button();
            lblSelectSubject = new Label();
            cbxSelectSubject = new ComboBox();
            tlpMainHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            tlpHeadingHolder.SuspendLayout();
            pnlCustomize.SuspendLayout();
            pnlBottomHolder.SuspendLayout();
            tlpBottomHolder.SuspendLayout();
            pnlSectionHolder.SuspendLayout();
            tlpSectionHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlHeadingHolder, 0, 0);
            tlpMainHolder.Controls.Add(pnlCustomize, 0, 2);
            tlpMainHolder.Controls.Add(pnlBottomHolder, 0, 3);
            tlpMainHolder.Controls.Add(pnlSectionHolder, 0, 1);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 4;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMainHolder.Size = new Size(580, 680);
            tlpMainHolder.TabIndex = 1;
            // 
            // pnlHeadingHolder
            // 
            pnlHeadingHolder.BackColor = Color.Gray;
            pnlHeadingHolder.Controls.Add(tlpHeadingHolder);
            pnlHeadingHolder.Dock = DockStyle.Fill;
            pnlHeadingHolder.Location = new Point(0, 0);
            pnlHeadingHolder.Margin = new Padding(0);
            pnlHeadingHolder.Name = "pnlHeadingHolder";
            pnlHeadingHolder.Size = new Size(580, 55);
            pnlHeadingHolder.TabIndex = 0;
            // 
            // tlpHeadingHolder
            // 
            tlpHeadingHolder.ColumnCount = 5;
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpHeadingHolder.Controls.Add(lblName, 1, 1);
            tlpHeadingHolder.Controls.Add(txtName, 2, 1);
            tlpHeadingHolder.Dock = DockStyle.Fill;
            tlpHeadingHolder.Location = new Point(0, 0);
            tlpHeadingHolder.Margin = new Padding(0);
            tlpHeadingHolder.Name = "tlpHeadingHolder";
            tlpHeadingHolder.RowCount = 3;
            tlpHeadingHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpHeadingHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpHeadingHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpHeadingHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeadingHolder.Size = new Size(580, 55);
            tlpHeadingHolder.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(12, 12);
            lblName.Margin = new Padding(2);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Exam Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(162, 12);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Exam Name";
            txtName.Size = new Size(332, 30);
            txtName.TabIndex = 1;
            txtName.MouseHover += txtName_MouseHover;
            // 
            // pnlCustomize
            // 
            pnlCustomize.BackColor = Color.Silver;
            pnlCustomize.Controls.Add(tbcSectionTasks);
            pnlCustomize.Dock = DockStyle.Fill;
            pnlCustomize.Location = new Point(0, 160);
            pnlCustomize.Margin = new Padding(0);
            pnlCustomize.Name = "pnlCustomize";
            pnlCustomize.Padding = new Padding(10);
            pnlCustomize.Size = new Size(580, 460);
            pnlCustomize.TabIndex = 2;
            // 
            // tbcSectionTasks
            // 
            tbcSectionTasks.Dock = DockStyle.Fill;
            tbcSectionTasks.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tbcSectionTasks.Location = new Point(10, 10);
            tbcSectionTasks.Margin = new Padding(0);
            tbcSectionTasks.Name = "tbcSectionTasks";
            tbcSectionTasks.Padding = new Point(0, 0);
            tbcSectionTasks.SelectedIndex = 0;
            tbcSectionTasks.Size = new Size(560, 440);
            tbcSectionTasks.TabIndex = 9;
            // 
            // pnlBottomHolder
            // 
            pnlBottomHolder.BackColor = Color.Silver;
            pnlBottomHolder.Controls.Add(tlpBottomHolder);
            pnlBottomHolder.Dock = DockStyle.Fill;
            pnlBottomHolder.Location = new Point(0, 620);
            pnlBottomHolder.Margin = new Padding(0);
            pnlBottomHolder.Name = "pnlBottomHolder";
            pnlBottomHolder.Size = new Size(580, 60);
            pnlBottomHolder.TabIndex = 1;
            // 
            // tlpBottomHolder
            // 
            tlpBottomHolder.ColumnCount = 5;
            tlpBottomHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpBottomHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tlpBottomHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottomHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            tlpBottomHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpBottomHolder.Controls.Add(btnCreate, 3, 0);
            tlpBottomHolder.Dock = DockStyle.Fill;
            tlpBottomHolder.Location = new Point(0, 0);
            tlpBottomHolder.Margin = new Padding(0);
            tlpBottomHolder.Name = "tlpBottomHolder";
            tlpBottomHolder.RowCount = 1;
            tlpBottomHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottomHolder.Size = new Size(580, 60);
            tlpBottomHolder.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(399, 5);
            btnCreate.Margin = new Padding(5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(166, 50);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Exam";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseHover += btnCreate_MouseHover;
            // 
            // pnlSectionHolder
            // 
            pnlSectionHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlSectionHolder.Controls.Add(tlpSectionHolder);
            pnlSectionHolder.Dock = DockStyle.Fill;
            pnlSectionHolder.Location = new Point(0, 55);
            pnlSectionHolder.Margin = new Padding(0);
            pnlSectionHolder.Name = "pnlSectionHolder";
            pnlSectionHolder.Size = new Size(580, 105);
            pnlSectionHolder.TabIndex = 3;
            // 
            // tlpSectionHolder
            // 
            tlpSectionHolder.ColumnCount = 5;
            tlpSectionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpSectionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpSectionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tlpSectionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSectionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpSectionHolder.Controls.Add(btnAddSection, 1, 2);
            tlpSectionHolder.Controls.Add(lblSelectSubject, 1, 1);
            tlpSectionHolder.Controls.Add(cbxSelectSubject, 2, 1);
            tlpSectionHolder.Dock = DockStyle.Fill;
            tlpSectionHolder.Location = new Point(0, 0);
            tlpSectionHolder.Name = "tlpSectionHolder";
            tlpSectionHolder.RowCount = 4;
            tlpSectionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpSectionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpSectionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSectionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpSectionHolder.Size = new Size(580, 105);
            tlpSectionHolder.TabIndex = 0;
            // 
            // btnAddSection
            // 
            btnAddSection.BackColor = Color.DimGray;
            btnAddSection.Dock = DockStyle.Fill;
            btnAddSection.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSection.Location = new Point(10, 52);
            btnAddSection.Margin = new Padding(0);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new Size(150, 43);
            btnAddSection.TabIndex = 9;
            btnAddSection.Text = "Add Section";
            btnAddSection.UseVisualStyleBackColor = false;
            btnAddSection.Click += btnAddSection_Click;
            btnAddSection.MouseHover += btnAddSection_MouseHover;
            // 
            // lblSelectSubject
            // 
            lblSelectSubject.AutoSize = true;
            lblSelectSubject.Dock = DockStyle.Fill;
            lblSelectSubject.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectSubject.Location = new Point(12, 12);
            lblSelectSubject.Margin = new Padding(2);
            lblSelectSubject.Name = "lblSelectSubject";
            lblSelectSubject.Padding = new Padding(0, 0, 0, 6);
            lblSelectSubject.Size = new Size(146, 38);
            lblSelectSubject.TabIndex = 10;
            lblSelectSubject.Text = "Select Subject";
            lblSelectSubject.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxSelectSubject
            // 
            cbxSelectSubject.Dock = DockStyle.Fill;
            cbxSelectSubject.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSelectSubject.FormattingEnabled = true;
            cbxSelectSubject.Location = new Point(163, 13);
            cbxSelectSubject.Name = "cbxSelectSubject";
            cbxSelectSubject.Size = new Size(254, 31);
            cbxSelectSubject.TabIndex = 11;
            cbxSelectSubject.DropDown += cbxSelectSubject_DropDown;
            cbxSelectSubject.SelectedIndexChanged += cbxSelectSubject_SelectedIndexChanged;
            cbxSelectSubject.MouseHover += cbxSelectSubject_MouseHover;
            // 
            // frmExamSetup
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(580, 680);
            ClientSize = new Size(584, 561);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmExamSetup";
            Text = "Exam Setup";
            Load += frmExamSetup_Load;
            Shown += frmExamSetup_Shown;
            tlpMainHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            tlpHeadingHolder.ResumeLayout(false);
            tlpHeadingHolder.PerformLayout();
            pnlCustomize.ResumeLayout(false);
            pnlBottomHolder.ResumeLayout(false);
            tlpBottomHolder.ResumeLayout(false);
            pnlSectionHolder.ResumeLayout(false);
            tlpSectionHolder.ResumeLayout(false);
            tlpSectionHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private Panel pnlHeadingHolder;
        private TableLayoutPanel tlpHeadingHolder;
        private Label lblName;
        public TextBox txtName;
        private Panel pnlCustomize;
        private Panel pnlBottomHolder;
        private TableLayoutPanel tlpBottomHolder;
        public Button btnCreate;
        private Panel pnlSectionHolder;
        private TableLayoutPanel tlpSectionHolder;
        private Button btnAddSection;
        private Label lblSelectSubject;
        private ComboBox cbxSelectSubject;
        public TabControl tbcSectionTasks;
    }
}