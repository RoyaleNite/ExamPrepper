namespace ExamPrepper.Forms.QuestionPreperation
{
    partial class frmQuizSetup
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
            pnlHeadingHolder = new Panel();
            tlpHeadingHolder = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            pnlQuickGeneration = new Panel();
            pnlCustomize = new Panel();
            pnlBottomHolder = new Panel();
            tlpBottomHolder = new TableLayoutPanel();
            btnCreate = new Button();
            tlpQuickOptionsHolder = new TableLayoutPanel();
            btnGenerateRandom = new Button();
            lblAmount = new Label();
            nudAmount = new NumericUpDown();
            tlpTasksOptionHolder = new TableLayoutPanel();
            btnMore = new Button();
            dgvTasks = new DataGridView();
            lblTaskAmount = new Label();
            txtTasksSelected = new TextBox();
            lblFilterHeader = new Label();
            lblFilter = new Label();
            txtFilterName = new TextBox();
            tlpMainHolder.SuspendLayout();
            pnlHeadingHolder.SuspendLayout();
            tlpHeadingHolder.SuspendLayout();
            pnlBottomHolder.SuspendLayout();
            tlpBottomHolder.SuspendLayout();
            tlpQuickOptionsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            tlpTasksOptionHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlHeadingHolder, 0, 0);
            tlpMainHolder.Controls.Add(pnlQuickGeneration, 0, 2);
            tlpMainHolder.Controls.Add(pnlCustomize, 0, 1);
            tlpMainHolder.Controls.Add(pnlBottomHolder, 0, 3);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 4;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMainHolder.Size = new Size(584, 649);
            tlpMainHolder.TabIndex = 0;
            // 
            // pnlHeadingHolder
            // 
            pnlHeadingHolder.BackColor = Color.Gray;
            pnlHeadingHolder.Controls.Add(tlpHeadingHolder);
            pnlHeadingHolder.Dock = DockStyle.Fill;
            pnlHeadingHolder.Location = new Point(0, 0);
            pnlHeadingHolder.Margin = new Padding(0);
            pnlHeadingHolder.Name = "pnlHeadingHolder";
            pnlHeadingHolder.Size = new Size(584, 55);
            pnlHeadingHolder.TabIndex = 0;
            // 
            // tlpHeadingHolder
            // 
            tlpHeadingHolder.ColumnCount = 5;
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tlpHeadingHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
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
            tlpHeadingHolder.Size = new Size(584, 55);
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
            lblName.Size = new Size(132, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Quiz Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(148, 12);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Quiz Name";
            txtName.Size = new Size(346, 30);
            txtName.TabIndex = 1;
            txtName.MouseHover += txtName_MouseHover;
            // 
            // pnlQuickGeneration
            // 
            pnlQuickGeneration.BackColor = Color.FromArgb(224, 224, 224);
            pnlQuickGeneration.Dock = DockStyle.Fill;
            pnlQuickGeneration.Location = new Point(0, 464);
            pnlQuickGeneration.Margin = new Padding(0);
            pnlQuickGeneration.Name = "pnlQuickGeneration";
            pnlQuickGeneration.Padding = new Padding(10);
            pnlQuickGeneration.Size = new Size(584, 125);
            pnlQuickGeneration.TabIndex = 0;
            // 
            // pnlCustomize
            // 
            pnlCustomize.BackColor = Color.Silver;
            pnlCustomize.Dock = DockStyle.Fill;
            pnlCustomize.Location = new Point(0, 55);
            pnlCustomize.Margin = new Padding(0);
            pnlCustomize.Name = "pnlCustomize";
            pnlCustomize.Padding = new Padding(10);
            pnlCustomize.Size = new Size(584, 409);
            pnlCustomize.TabIndex = 2;
            // 
            // pnlBottomHolder
            // 
            pnlBottomHolder.BackColor = Color.Silver;
            pnlBottomHolder.Controls.Add(tlpBottomHolder);
            pnlBottomHolder.Dock = DockStyle.Fill;
            pnlBottomHolder.Location = new Point(0, 589);
            pnlBottomHolder.Margin = new Padding(0);
            pnlBottomHolder.Name = "pnlBottomHolder";
            pnlBottomHolder.Size = new Size(584, 60);
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
            tlpBottomHolder.Size = new Size(584, 60);
            tlpBottomHolder.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(403, 5);
            btnCreate.Margin = new Padding(5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(166, 50);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Quiz";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseHover += btnCreate_MouseHover;
            // 
            // tlpQuickOptionsHolder
            // 
            tlpQuickOptionsHolder.ColumnCount = 5;
            tlpQuickOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpQuickOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tlpQuickOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tlpQuickOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuickOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpQuickOptionsHolder.Controls.Add(btnGenerateRandom, 3, 1);
            tlpQuickOptionsHolder.Controls.Add(lblAmount, 1, 1);
            tlpQuickOptionsHolder.Controls.Add(nudAmount, 2, 1);
            tlpQuickOptionsHolder.Dock = DockStyle.Fill;
            tlpQuickOptionsHolder.Location = new Point(3, 26);
            tlpQuickOptionsHolder.Name = "tlpQuickOptionsHolder";
            tlpQuickOptionsHolder.RowCount = 3;
            tlpQuickOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpQuickOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpQuickOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tlpQuickOptionsHolder.Size = new Size(558, 76);
            tlpQuickOptionsHolder.TabIndex = 1;
            // 
            // btnGenerateRandom
            // 
            btnGenerateRandom.BackColor = Color.DimGray;
            btnGenerateRandom.Dock = DockStyle.Fill;
            btnGenerateRandom.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateRandom.Location = new Point(283, 15);
            btnGenerateRandom.Margin = new Padding(5);
            btnGenerateRandom.Name = "btnGenerateRandom";
            btnGenerateRandom.Size = new Size(260, 48);
            btnGenerateRandom.TabIndex = 10;
            btnGenerateRandom.Text = "Generate Random Quiz";
            btnGenerateRandom.UseVisualStyleBackColor = false;
            btnGenerateRandom.Click += btnGenerateRandom_Click;
            btnGenerateRandom.MouseHover += btnGenerateRandom_MouseHover;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.Location = new Point(12, 12);
            lblAmount.Margin = new Padding(2);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(205, 54);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount of questions:";
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(222, 25);
            nudAmount.Margin = new Padding(3, 15, 3, 3);
            nudAmount.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(53, 23);
            nudAmount.TabIndex = 7;
            nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tlpTasksOptionHolder
            // 
            tlpTasksOptionHolder.ColumnCount = 8;
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpTasksOptionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpTasksOptionHolder.Controls.Add(btnMore, 6, 3);
            tlpTasksOptionHolder.Controls.Add(dgvTasks, 1, 4);
            tlpTasksOptionHolder.Controls.Add(lblTaskAmount, 1, 5);
            tlpTasksOptionHolder.Controls.Add(txtTasksSelected, 3, 5);
            tlpTasksOptionHolder.Controls.Add(lblFilterHeader, 1, 1);
            tlpTasksOptionHolder.Controls.Add(lblFilter, 1, 3);
            tlpTasksOptionHolder.Controls.Add(txtFilterName, 2, 3);
            tlpTasksOptionHolder.Dock = DockStyle.Fill;
            tlpTasksOptionHolder.Location = new Point(3, 33);
            tlpTasksOptionHolder.Name = "tlpTasksOptionHolder";
            tlpTasksOptionHolder.RowCount = 6;
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpTasksOptionHolder.Size = new Size(558, 353);
            tlpTasksOptionHolder.TabIndex = 1;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.DimGray;
            btnMore.Dock = DockStyle.Fill;
            btnMore.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.Location = new Point(398, 50);
            btnMore.Margin = new Padding(0);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(150, 35);
            btnMore.TabIndex = 8;
            btnMore.Text = "More FIlters";
            btnMore.UseVisualStyleBackColor = false;
            btnMore.Click += btnMore_Click;
            btnMore.MouseHover += btnMore_MouseHover;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpTasksOptionHolder.SetColumnSpan(dgvTasks, 6);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(13, 91);
            dgvTasks.Margin = new Padding(3, 6, 3, 3);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowTemplate.Height = 25;
            dgvTasks.Size = new Size(532, 219);
            dgvTasks.TabIndex = 0;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            dgvTasks.CellValueChanged += dgvTasks_CellValueChanged;
            // 
            // lblTaskAmount
            // 
            lblTaskAmount.AutoSize = true;
            tlpTasksOptionHolder.SetColumnSpan(lblTaskAmount, 2);
            lblTaskAmount.Dock = DockStyle.Fill;
            lblTaskAmount.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaskAmount.Location = new Point(12, 315);
            lblTaskAmount.Margin = new Padding(2);
            lblTaskAmount.Name = "lblTaskAmount";
            lblTaskAmount.Size = new Size(156, 36);
            lblTaskAmount.TabIndex = 1;
            lblTaskAmount.Text = "Tasks Selected:";
            lblTaskAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTasksSelected
            // 
            txtTasksSelected.BackColor = Color.WhiteSmoke;
            txtTasksSelected.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTasksSelected.Location = new Point(173, 316);
            txtTasksSelected.Name = "txtTasksSelected";
            txtTasksSelected.ReadOnly = true;
            txtTasksSelected.Size = new Size(59, 30);
            txtTasksSelected.TabIndex = 2;
            txtTasksSelected.MouseHover += txtTasksSelected_MouseHover;
            // 
            // lblFilterHeader
            // 
            lblFilterHeader.AutoSize = true;
            lblFilterHeader.Dock = DockStyle.Fill;
            lblFilterHeader.Font = new Font("Calibri Light", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblFilterHeader.Location = new Point(12, 12);
            lblFilterHeader.Margin = new Padding(2);
            lblFilterHeader.Name = "lblFilterHeader";
            lblFilterHeader.Size = new Size(91, 31);
            lblFilterHeader.TabIndex = 3;
            lblFilterHeader.Text = "Filters:";
            lblFilterHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Dock = DockStyle.Fill;
            lblFilter.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.Location = new Point(12, 52);
            lblFilter.Margin = new Padding(2);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(91, 31);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "By Name:";
            lblFilter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFilterName
            // 
            txtFilterName.BackColor = Color.WhiteSmoke;
            tlpTasksOptionHolder.SetColumnSpan(txtFilterName, 4);
            txtFilterName.Dock = DockStyle.Fill;
            txtFilterName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtFilterName.Location = new Point(108, 53);
            txtFilterName.Margin = new Padding(3, 3, 15, 3);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.Size = new Size(275, 30);
            txtFilterName.TabIndex = 5;
            txtFilterName.TextChanged += txtFilterName_TextChanged;
            txtFilterName.MouseHover += txtFilterName_MouseHover;
            // 
            // frmQuizSetup
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(580, 620);
            ClientSize = new Size(584, 649);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmQuizSetup";
            Text = "Quiz Setup";
            Load += frmQuizSetup_Load;
            Shown += frmQuizSetup_Shown;
            tlpMainHolder.ResumeLayout(false);
            pnlHeadingHolder.ResumeLayout(false);
            tlpHeadingHolder.ResumeLayout(false);
            tlpHeadingHolder.PerformLayout();
            pnlBottomHolder.ResumeLayout(false);
            tlpBottomHolder.ResumeLayout(false);
            tlpQuickOptionsHolder.ResumeLayout(false);
            tlpQuickOptionsHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            tlpTasksOptionHolder.ResumeLayout(false);
            tlpTasksOptionHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private Panel pnlHeadingHolder;
        private TableLayoutPanel tlpHeadingHolder;
        private Label lblName;
        private Panel pnlQuickGeneration;
        private CustomGroupBox cgbQuickOptions;
        private TableLayoutPanel tlpQuickOptionsHolder;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private Panel pnlBottomHolder;
        private TableLayoutPanel tlpBottomHolder;
        private Panel pnlCustomize;
        private TableLayoutPanel tlpTasksOptionHolder;
        private CustomGroupBox cgbTasks;
        private Label lblTaskAmount;
        private TextBox txtTasksSelected;
        private Button btnMore;
        private Label lblFilterHeader;
        private Label lblFilter;
        private TextBox txtFilterName;
        private Button btnGenerateRandom;
        public Button btnCreate;
        public TextBox txtName;
        private DataGridView dgvTasks;
    }
}