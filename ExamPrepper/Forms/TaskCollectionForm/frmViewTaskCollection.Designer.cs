namespace ExamPrepper.Forms
{
    partial class frmViewTaskCollection
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
            pnlTaskColHolder = new Panel();
            tlpTopHolder = new TableLayoutPanel();
            dgvTaskCollection = new DataGridView();
            cpgHeadingFilter = new CustomGroupBox();
            tlpFilterHolder = new TableLayoutPanel();
            btnMore = new Button();
            lblFilter = new Label();
            txtFilterName = new TextBox();
            pnlOptionsHolder = new Panel();
            tlpOptionsHolder = new TableLayoutPanel();
            btnInfo = new Button();
            btnDo = new Button();
            btnResults = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            tlpMainHolder.SuspendLayout();
            pnlTaskColHolder.SuspendLayout();
            tlpTopHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaskCollection).BeginInit();
            cpgHeadingFilter.SuspendLayout();
            tlpFilterHolder.SuspendLayout();
            pnlOptionsHolder.SuspendLayout();
            tlpOptionsHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlTaskColHolder, 0, 0);
            tlpMainHolder.Controls.Add(pnlOptionsHolder, 0, 1);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 3;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(604, 561);
            tlpMainHolder.TabIndex = 0;
            // 
            // pnlTaskColHolder
            // 
            pnlTaskColHolder.BackColor = Color.Silver;
            pnlTaskColHolder.Controls.Add(tlpTopHolder);
            pnlTaskColHolder.Dock = DockStyle.Fill;
            pnlTaskColHolder.Location = new Point(0, 0);
            pnlTaskColHolder.Margin = new Padding(0);
            pnlTaskColHolder.Name = "pnlTaskColHolder";
            pnlTaskColHolder.Padding = new Padding(10);
            pnlTaskColHolder.Size = new Size(604, 401);
            pnlTaskColHolder.TabIndex = 2;
            // 
            // tlpTopHolder
            // 
            tlpTopHolder.ColumnCount = 1;
            tlpTopHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTopHolder.Controls.Add(dgvTaskCollection, 0, 1);
            tlpTopHolder.Controls.Add(cpgHeadingFilter, 0, 0);
            tlpTopHolder.Dock = DockStyle.Fill;
            tlpTopHolder.Location = new Point(10, 10);
            tlpTopHolder.Margin = new Padding(0);
            tlpTopHolder.Name = "tlpTopHolder";
            tlpTopHolder.RowCount = 2;
            tlpTopHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tlpTopHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTopHolder.Size = new Size(584, 381);
            tlpTopHolder.TabIndex = 1;
            // 
            // dgvTaskCollection
            // 
            dgvTaskCollection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTaskCollection.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTaskCollection.Dock = DockStyle.Fill;
            dgvTaskCollection.Location = new Point(0, 97);
            dgvTaskCollection.Margin = new Padding(0, 10, 0, 0);
            dgvTaskCollection.Name = "dgvTaskCollection";
            dgvTaskCollection.RowHeadersVisible = false;
            dgvTaskCollection.RowTemplate.Height = 25;
            dgvTaskCollection.Size = new Size(584, 284);
            dgvTaskCollection.TabIndex = 0;
            dgvTaskCollection.MouseHover += dgvTaskCollection_MouseHover;
            // 
            // cpgHeadingFilter
            // 
            cpgHeadingFilter.Controls.Add(tlpFilterHolder);
            cpgHeadingFilter.Dock = DockStyle.Fill;
            cpgHeadingFilter.Font = new Font("Calibri Light", 17F, FontStyle.Bold, GraphicsUnit.Point);
            cpgHeadingFilter.ForeColor = Color.Black;
            cpgHeadingFilter.Location = new Point(3, 3);
            cpgHeadingFilter.Name = "cpgHeadingFilter";
            cpgHeadingFilter.Padding = new Padding(6, 3, 6, 5);
            cpgHeadingFilter.Size = new Size(578, 81);
            cpgHeadingFilter.TabIndex = 5;
            cpgHeadingFilter.TabStop = false;
            cpgHeadingFilter.Text = "Filter";
            cpgHeadingFilter.TextColor = SystemColors.ActiveCaptionText;
            // 
            // tlpFilterHolder
            // 
            tlpFilterHolder.ColumnCount = 3;
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilterHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpFilterHolder.Controls.Add(btnMore, 3, 0);
            tlpFilterHolder.Controls.Add(lblFilter, 0, 0);
            tlpFilterHolder.Controls.Add(txtFilterName, 1, 0);
            tlpFilterHolder.Dock = DockStyle.Fill;
            tlpFilterHolder.Location = new Point(6, 31);
            tlpFilterHolder.Margin = new Padding(0);
            tlpFilterHolder.Name = "tlpFilterHolder";
            tlpFilterHolder.RowCount = 1;
            tlpFilterHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilterHolder.Size = new Size(566, 45);
            tlpFilterHolder.TabIndex = 1;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.DimGray;
            btnMore.Dock = DockStyle.Fill;
            btnMore.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMore.Location = new Point(386, 0);
            btnMore.Margin = new Padding(0);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(180, 45);
            btnMore.TabIndex = 11;
            btnMore.Text = "More FIlters";
            btnMore.UseVisualStyleBackColor = false;
            btnMore.Click += btnMore_Click;
            btnMore.MouseHover += btnMore_MouseHover;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Dock = DockStyle.Fill;
            lblFilter.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.Location = new Point(2, 2);
            lblFilter.Margin = new Padding(2);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(106, 41);
            lblFilter.TabIndex = 9;
            lblFilter.Text = "By Name:";
            lblFilter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFilterName
            // 
            txtFilterName.BackColor = Color.WhiteSmoke;
            txtFilterName.Dock = DockStyle.Fill;
            txtFilterName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtFilterName.Location = new Point(113, 7);
            txtFilterName.Margin = new Padding(3, 7, 3, 3);
            txtFilterName.Name = "txtFilterName";
            txtFilterName.PlaceholderText = "Filter by Name";
            txtFilterName.Size = new Size(270, 30);
            txtFilterName.TabIndex = 10;
            txtFilterName.TextChanged += txtFilterName_TextChanged;
            txtFilterName.MouseHover += txtFilterName_MouseHover;
            // 
            // pnlOptionsHolder
            // 
            pnlOptionsHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlOptionsHolder.Controls.Add(tlpOptionsHolder);
            pnlOptionsHolder.Dock = DockStyle.Fill;
            pnlOptionsHolder.Location = new Point(0, 401);
            pnlOptionsHolder.Margin = new Padding(0);
            pnlOptionsHolder.Name = "pnlOptionsHolder";
            pnlOptionsHolder.Size = new Size(604, 140);
            pnlOptionsHolder.TabIndex = 1;
            // 
            // tlpOptionsHolder
            // 
            tlpOptionsHolder.ColumnCount = 11;
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Controls.Add(btnInfo, 7, 1);
            tlpOptionsHolder.Controls.Add(btnDo, 1, 3);
            tlpOptionsHolder.Controls.Add(btnResults, 5, 3);
            tlpOptionsHolder.Controls.Add(btnDelete, 3, 1);
            tlpOptionsHolder.Controls.Add(btnEdit, 1, 1);
            tlpOptionsHolder.Dock = DockStyle.Fill;
            tlpOptionsHolder.Location = new Point(0, 0);
            tlpOptionsHolder.Name = "tlpOptionsHolder";
            tlpOptionsHolder.RowCount = 7;
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Size = new Size(604, 140);
            tlpOptionsHolder.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.DimGray;
            btnInfo.Dock = DockStyle.Fill;
            btnInfo.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.Transparent;
            btnInfo.Location = new Point(260, 10);
            btnInfo.Margin = new Padding(0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(110, 40);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            btnInfo.MouseHover += btnInfo_MouseHover;
            // 
            // btnDo
            // 
            btnDo.BackColor = Color.DimGray;
            tlpOptionsHolder.SetColumnSpan(btnDo, 3);
            btnDo.Dock = DockStyle.Fill;
            btnDo.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDo.ForeColor = Color.Transparent;
            btnDo.Location = new Point(10, 65);
            btnDo.Margin = new Padding(0);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(175, 65);
            btnDo.TabIndex = 4;
            btnDo.Text = "Do Quiz";
            btnDo.UseVisualStyleBackColor = false;
            btnDo.Click += btnDo_Click;
            btnDo.MouseHover += btnDo_MouseHover;
            // 
            // btnResults
            // 
            btnResults.BackColor = Color.DimGray;
            tlpOptionsHolder.SetColumnSpan(btnResults, 3);
            btnResults.Dock = DockStyle.Fill;
            btnResults.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnResults.ForeColor = Color.Transparent;
            btnResults.Location = new Point(195, 65);
            btnResults.Margin = new Padding(0);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(175, 65);
            btnResults.TabIndex = 3;
            btnResults.Text = "View Results";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            btnResults.MouseHover += btnResults_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            tlpOptionsHolder.SetColumnSpan(btnDelete, 3);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(135, 10);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(10, 10);
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseHover += btnEdit_MouseHover;
            // 
            // frmViewTaskCollection
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 561);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmViewTaskCollection";
            Text = "Task Collection View";
            Load += frmViewTaskCollection_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskColHolder.ResumeLayout(false);
            tlpTopHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaskCollection).EndInit();
            cpgHeadingFilter.ResumeLayout(false);
            tlpFilterHolder.ResumeLayout(false);
            tlpFilterHolder.PerformLayout();
            pnlOptionsHolder.ResumeLayout(false);
            tlpOptionsHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private DataGridView dgvTaskCollection;
        private Panel pnlOptionsHolder;
        private TableLayoutPanel tlpOptionsHolder;
        private Button btnDelete;
        private Button btnEdit;
        private Panel pnlTaskColHolder;
        private TableLayoutPanel tlpTopHolder;
        private TableLayoutPanel tlpFilterHolder;
        private CustomGroupBox cpgHeadingFilter;
        private Button btnMore;
        private Label lblFilter;
        private TextBox txtFilterName;
        private Button btnDo;
        private Button btnResults;
        private Button btnInfo;
    }
}