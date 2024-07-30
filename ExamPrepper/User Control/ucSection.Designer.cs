namespace ExamPrepper
{
    partial class ucSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cgbTasks = new CustomGroupBox();
            tlpTasksOptionHolder = new TableLayoutPanel();
            btnDeleteSection = new Button();
            btnMore = new Button();
            dgvTasks = new DataGridView();
            lblTaskAmount = new Label();
            txtTasksSelected = new TextBox();
            lblFilterHeader = new Label();
            lblFilter = new Label();
            txtFilterName = new TextBox();
            label1 = new Label();
            txtSection = new TextBox();
            cgbTasks.SuspendLayout();
            tlpTasksOptionHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // cgbTasks
            // 
            cgbTasks.Controls.Add(tlpTasksOptionHolder);
            cgbTasks.Dock = DockStyle.Fill;
            cgbTasks.Font = new Font("Calibri Light", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cgbTasks.Location = new Point(0, 0);
            cgbTasks.Name = "cgbTasks";
            cgbTasks.Padding = new Padding(3, 3, 3, 7);
            cgbTasks.Size = new Size(531, 554);
            cgbTasks.TabIndex = 2;
            cgbTasks.TabStop = false;
            cgbTasks.Text = "Task Selection";
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
            tlpTasksOptionHolder.Controls.Add(btnDeleteSection, 6, 8);
            tlpTasksOptionHolder.Controls.Add(btnMore, 6, 5);
            tlpTasksOptionHolder.Controls.Add(dgvTasks, 1, 6);
            tlpTasksOptionHolder.Controls.Add(lblTaskAmount, 1, 7);
            tlpTasksOptionHolder.Controls.Add(txtTasksSelected, 3, 7);
            tlpTasksOptionHolder.Controls.Add(lblFilterHeader, 1, 3);
            tlpTasksOptionHolder.Controls.Add(lblFilter, 1, 5);
            tlpTasksOptionHolder.Controls.Add(txtFilterName, 2, 5);
            tlpTasksOptionHolder.Controls.Add(label1, 1, 1);
            tlpTasksOptionHolder.Controls.Add(txtSection, 2, 1);
            tlpTasksOptionHolder.Dock = DockStyle.Fill;
            tlpTasksOptionHolder.Location = new Point(3, 33);
            tlpTasksOptionHolder.Name = "tlpTasksOptionHolder";
            tlpTasksOptionHolder.RowCount = 9;
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTasksOptionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpTasksOptionHolder.Size = new Size(525, 514);
            tlpTasksOptionHolder.TabIndex = 1;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.BackColor = Color.DimGray;
            btnDeleteSection.Dock = DockStyle.Fill;
            btnDeleteSection.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteSection.Location = new Point(365, 469);
            btnDeleteSection.Margin = new Padding(0);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Size = new Size(150, 45);
            btnDeleteSection.TabIndex = 9;
            btnDeleteSection.Text = "Delete Section";
            btnDeleteSection.UseVisualStyleBackColor = false;
            btnDeleteSection.Click += btnDeleteSection_Click;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.DimGray;
            btnMore.Dock = DockStyle.Fill;
            btnMore.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.Location = new Point(365, 95);
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
            dgvTasks.Location = new Point(13, 136);
            dgvTasks.Margin = new Padding(3, 6, 3, 3);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowTemplate.Height = 25;
            dgvTasks.Size = new Size(499, 295);
            dgvTasks.TabIndex = 0;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            dgvTasks.CellValueChanged += dgvTasks_CellValueChanged;
            dgvTasks.MouseHover += dgvTasks_MouseHover;
            // 
            // lblTaskAmount
            // 
            lblTaskAmount.AutoSize = true;
            tlpTasksOptionHolder.SetColumnSpan(lblTaskAmount, 2);
            lblTaskAmount.Dock = DockStyle.Fill;
            lblTaskAmount.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaskAmount.Location = new Point(12, 436);
            lblTaskAmount.Margin = new Padding(2);
            lblTaskAmount.Name = "lblTaskAmount";
            lblTaskAmount.Size = new Size(156, 31);
            lblTaskAmount.TabIndex = 1;
            lblTaskAmount.Text = "Tasks Selected:";
            lblTaskAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTasksSelected
            // 
            txtTasksSelected.BackColor = Color.WhiteSmoke;
            txtTasksSelected.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTasksSelected.Location = new Point(173, 437);
            txtTasksSelected.Name = "txtTasksSelected";
            txtTasksSelected.ReadOnly = true;
            txtTasksSelected.Size = new Size(59, 30);
            txtTasksSelected.TabIndex = 2;
            txtTasksSelected.Text = "0";
            // 
            // lblFilterHeader
            // 
            lblFilterHeader.AutoSize = true;
            lblFilterHeader.Dock = DockStyle.Fill;
            lblFilterHeader.Font = new Font("Calibri Light", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblFilterHeader.Location = new Point(12, 57);
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
            lblFilter.Location = new Point(12, 97);
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
            txtFilterName.Location = new Point(108, 98);
            txtFilterName.Margin = new Padding(3, 3, 15, 3);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.PlaceholderText = "Filter by Name";
            txtFilterName.Size = new Size(242, 30);
            txtFilterName.TabIndex = 5;
            txtFilterName.TextChanged += txtFilterName_TextChanged;
            txtFilterName.MouseHover += txtFilterName_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 10;
            label1.Text = "Section:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSection
            // 
            tlpTasksOptionHolder.SetColumnSpan(txtSection, 4);
            txtSection.Dock = DockStyle.Fill;
            txtSection.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSection.Location = new Point(108, 13);
            txtSection.Name = "txtSection";
            txtSection.PlaceholderText = "Enter Section Heading";
            txtSection.Size = new Size(254, 30);
            txtSection.TabIndex = 11;
            txtSection.TextChanged += txtSection_TextChanged;
            txtSection.MouseHover += txtSection_MouseHover;
            // 
            // ucSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cgbTasks);
            DoubleBuffered = true;
            Name = "ucSection";
            Size = new Size(531, 554);
            Load += ucSection_Load;
            cgbTasks.ResumeLayout(false);
            tlpTasksOptionHolder.ResumeLayout(false);
            tlpTasksOptionHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomGroupBox cgbTasks;
        private TableLayoutPanel tlpTasksOptionHolder;
        public Button btnDeleteSection;
        private Button btnMore;
        private Label lblTaskAmount;
        private TextBox txtTasksSelected;
        private Label lblFilterHeader;
        private Label lblFilter;
        private Label label1;
        public DataGridView dgvTasks;
        public TextBox txtFilterName;
        public TextBox txtSection;
    }
}
