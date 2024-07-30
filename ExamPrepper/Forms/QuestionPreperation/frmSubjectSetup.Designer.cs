namespace ExamPrepper.Forms
{
    partial class frmSubjectSetup
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
            dgvSubjects = new DataGridView();
            pnlBottomColor = new Panel();
            tblOptionsHolder = new TableLayoutPanel();
            btnAddEdit = new Button();
            lblDescription = new Label();
            lblName = new Label();
            txtName = new TextBox();
            rtbDescription = new RichTextBox();
            pnlMainHolder = new Panel();
            tlpMainHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            pnlBottomColor.SuspendLayout();
            tblOptionsHolder.SuspendLayout();
            pnlMainHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 3;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpMainHolder.Controls.Add(dgvSubjects, 1, 1);
            tlpMainHolder.Controls.Add(pnlBottomColor, 1, 2);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 4;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpMainHolder.Size = new Size(604, 516);
            tlpMainHolder.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSubjects.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSubjects.Dock = DockStyle.Fill;
            dgvSubjects.Location = new Point(10, 10);
            dgvSubjects.Margin = new Padding(0);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.RowHeadersVisible = false;
            dgvSubjects.RowTemplate.Height = 25;
            dgvSubjects.Size = new Size(584, 250);
            dgvSubjects.TabIndex = 0;
            dgvSubjects.CellClick += dgvSubjects_CellClick;
            // 
            // pnlBottomColor
            // 
            pnlBottomColor.BackColor = Color.Silver;
            pnlBottomColor.Controls.Add(tblOptionsHolder);
            pnlBottomColor.Dock = DockStyle.Fill;
            pnlBottomColor.Location = new Point(10, 260);
            pnlBottomColor.Margin = new Padding(0);
            pnlBottomColor.Name = "pnlBottomColor";
            pnlBottomColor.Size = new Size(584, 246);
            pnlBottomColor.TabIndex = 1;
            // 
            // tblOptionsHolder
            // 
            tblOptionsHolder.ColumnCount = 4;
            tblOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tblOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tblOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblOptionsHolder.Controls.Add(btnAddEdit, 2, 5);
            tblOptionsHolder.Controls.Add(lblDescription, 0, 3);
            tblOptionsHolder.Controls.Add(lblName, 0, 1);
            tblOptionsHolder.Controls.Add(txtName, 1, 1);
            tblOptionsHolder.Controls.Add(rtbDescription, 1, 3);
            tblOptionsHolder.Dock = DockStyle.Top;
            tblOptionsHolder.Location = new Point(0, 0);
            tblOptionsHolder.Margin = new Padding(0);
            tblOptionsHolder.Name = "tblOptionsHolder";
            tblOptionsHolder.RowCount = 7;
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblOptionsHolder.Size = new Size(584, 236);
            tblOptionsHolder.TabIndex = 1;
            // 
            // btnAddEdit
            // 
            btnAddEdit.Dock = DockStyle.Fill;
            btnAddEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEdit.Location = new Point(387, 175);
            btnAddEdit.Margin = new Padding(5);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(182, 60);
            btnAddEdit.TabIndex = 2;
            btnAddEdit.Text = "Add Subject";
            btnAddEdit.UseVisualStyleBackColor = true;
            btnAddEdit.Click += btnAddEdit_Click;
            btnAddEdit.MouseHover += btnAddEdit_MouseHover;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(2, 57);
            lblDescription.Margin = new Padding(2);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(210, 31);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Subject Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(2, 12);
            lblName.Margin = new Padding(2);
            lblName.Name = "lblName";
            lblName.Size = new Size(210, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Subject Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            tblOptionsHolder.SetColumnSpan(txtName, 2);
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(217, 13);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Subject Name";
            txtName.Size = new Size(354, 32);
            txtName.TabIndex = 0;
            txtName.MouseHover += txtName_MouseHover;
            // 
            // rtbDescription
            // 
            tblOptionsHolder.SetColumnSpan(rtbDescription, 2);
            rtbDescription.Dock = DockStyle.Fill;
            rtbDescription.Location = new Point(217, 58);
            rtbDescription.Name = "rtbDescription";
            tblOptionsHolder.SetRowSpan(rtbDescription, 2);
            rtbDescription.Size = new Size(354, 109);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            rtbDescription.MouseHover += rtbDescription_MouseHover;
            // 
            // pnlMainHolder
            // 
            pnlMainHolder.BackColor = Color.FromArgb(224, 224, 224);
            pnlMainHolder.Controls.Add(tlpMainHolder);
            pnlMainHolder.Dock = DockStyle.Fill;
            pnlMainHolder.Location = new Point(0, 0);
            pnlMainHolder.Name = "pnlMainHolder";
            pnlMainHolder.Size = new Size(604, 516);
            pnlMainHolder.TabIndex = 1;
            // 
            // frmSubjectSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(604, 516);
            Controls.Add(pnlMainHolder);
            DoubleBuffered = true;
            MinimumSize = new Size(620, 555);
            Name = "frmSubjectSetup";
            Text = "Subject Setup";
            Load += frmSubjectSetup_Load;
            tlpMainHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            pnlBottomColor.ResumeLayout(false);
            tblOptionsHolder.ResumeLayout(false);
            tblOptionsHolder.PerformLayout();
            pnlMainHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private DataGridView dgvSubjects;
        private TableLayoutPanel tblOptionsHolder;
        private Label lblDescription;
        private Label lblName;
        private TextBox txtName;
        private RichTextBox rtbDescription;
        private Button btnAddEdit;
        private Panel pnlBottomColor;
        private Panel pnlMainHolder;
    }
}