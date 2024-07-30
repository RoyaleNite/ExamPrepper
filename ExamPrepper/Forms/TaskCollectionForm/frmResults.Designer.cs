namespace ExamPrepper.Forms.TaskCollectionForm
{
    partial class frmResults
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
            dgvResults = new DataGridView();
            pnlOptionsHolder = new Panel();
            tlpOptionsHolder = new TableLayoutPanel();
            btnInfo = new Button();
            btnDelete = new Button();
            btnView = new Button();
            tlpMainHolder.SuspendLayout();
            pnlTaskColHolder.SuspendLayout();
            tlpTopHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
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
            tlpMainHolder.RowCount = 2;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMainHolder.Size = new Size(686, 420);
            tlpMainHolder.TabIndex = 2;
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
            pnlTaskColHolder.Size = new Size(686, 360);
            pnlTaskColHolder.TabIndex = 2;
            // 
            // tlpTopHolder
            // 
            tlpTopHolder.ColumnCount = 1;
            tlpTopHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTopHolder.Controls.Add(dgvResults, 0, 0);
            tlpTopHolder.Dock = DockStyle.Fill;
            tlpTopHolder.Location = new Point(10, 10);
            tlpTopHolder.Margin = new Padding(0);
            tlpTopHolder.Name = "tlpTopHolder";
            tlpTopHolder.RowCount = 1;
            tlpTopHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTopHolder.Size = new Size(666, 340);
            tlpTopHolder.TabIndex = 1;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(0, 0);
            dgvResults.Margin = new Padding(0);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new Size(666, 340);
            dgvResults.TabIndex = 0;
            // 
            // pnlOptionsHolder
            // 
            pnlOptionsHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlOptionsHolder.Controls.Add(tlpOptionsHolder);
            pnlOptionsHolder.Dock = DockStyle.Fill;
            pnlOptionsHolder.Location = new Point(0, 360);
            pnlOptionsHolder.Margin = new Padding(0);
            pnlOptionsHolder.Name = "pnlOptionsHolder";
            pnlOptionsHolder.Size = new Size(686, 60);
            pnlOptionsHolder.TabIndex = 1;
            // 
            // tlpOptionsHolder
            // 
            tlpOptionsHolder.ColumnCount = 9;
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Controls.Add(btnInfo, 3, 1);
            tlpOptionsHolder.Controls.Add(btnDelete, 5, 1);
            tlpOptionsHolder.Controls.Add(btnView, 1, 1);
            tlpOptionsHolder.Dock = DockStyle.Fill;
            tlpOptionsHolder.Location = new Point(0, 0);
            tlpOptionsHolder.Name = "tlpOptionsHolder";
            tlpOptionsHolder.RowCount = 4;
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.Size = new Size(686, 60);
            tlpOptionsHolder.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.DimGray;
            btnInfo.Dock = DockStyle.Fill;
            btnInfo.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.Transparent;
            btnInfo.Location = new Point(195, 10);
            btnInfo.Margin = new Padding(0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(115, 40);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            btnInfo.MouseHover += btnInfo_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(320, 10);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnView
            // 
            btnView.BackColor = Color.DimGray;
            btnView.Dock = DockStyle.Fill;
            btnView.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.Transparent;
            btnView.Location = new Point(10, 10);
            btnView.Margin = new Padding(0);
            btnView.Name = "btnView";
            btnView.Size = new Size(175, 40);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            btnView.MouseHover += btnView_MouseHover;
            // 
            // frmResults
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 420);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmResults";
            Text = "Results";
            Load += frmResults_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskColHolder.ResumeLayout(false);
            tlpTopHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            pnlOptionsHolder.ResumeLayout(false);
            tlpOptionsHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private Panel pnlTaskColHolder;
        private TableLayoutPanel tlpTopHolder;
        private DataGridView dgvResults;
        private Panel pnlOptionsHolder;
        private TableLayoutPanel tlpOptionsHolder;
        private Button btnInfo;
        private Button btnDelete;
        public Button btnView;
    }
}