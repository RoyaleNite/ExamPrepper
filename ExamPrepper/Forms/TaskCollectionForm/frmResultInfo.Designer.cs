namespace ExamPrepper.Forms.TaskCollectionForm
{
    partial class frmResultInfo
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
            pnlTaskCollectionInfoHolder = new Panel();
            cgbHeadingTaskCollectionInfoHolder = new CustomGroupBox();
            tlpTaskCollectionInfoHolder = new TableLayoutPanel();
            txtTotal = new TextBox();
            lblSubject = new Label();
            lblName = new Label();
            lblAnswers = new Label();
            txtReceived = new TextBox();
            txtPercentage = new TextBox();
            tlpMainHolder.SuspendLayout();
            pnlTaskCollectionInfoHolder.SuspendLayout();
            cgbHeadingTaskCollectionInfoHolder.SuspendLayout();
            tlpTaskCollectionInfoHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlTaskCollectionInfoHolder, 0, 0);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 1;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(384, 211);
            tlpMainHolder.TabIndex = 2;
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
            pnlTaskCollectionInfoHolder.Size = new Size(364, 196);
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
            cgbHeadingTaskCollectionInfoHolder.Size = new Size(350, 182);
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
            tlpTaskCollectionInfoHolder.Controls.Add(txtTotal, 2, 3);
            tlpTaskCollectionInfoHolder.Controls.Add(lblSubject, 1, 3);
            tlpTaskCollectionInfoHolder.Controls.Add(lblName, 1, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(lblAnswers, 1, 5);
            tlpTaskCollectionInfoHolder.Controls.Add(txtReceived, 2, 1);
            tlpTaskCollectionInfoHolder.Controls.Add(txtPercentage, 2, 5);
            tlpTaskCollectionInfoHolder.Dock = DockStyle.Fill;
            tlpTaskCollectionInfoHolder.Location = new Point(6, 31);
            tlpTaskCollectionInfoHolder.Margin = new Padding(2);
            tlpTaskCollectionInfoHolder.Name = "tlpTaskCollectionInfoHolder";
            tlpTaskCollectionInfoHolder.RowCount = 9;
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTaskCollectionInfoHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTaskCollectionInfoHolder.Size = new Size(338, 146);
            tlpTaskCollectionInfoHolder.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Dock = DockStyle.Fill;
            txtTotal.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(206, 58);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(119, 30);
            txtTotal.TabIndex = 10;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Dock = DockStyle.Fill;
            lblSubject.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject.Location = new Point(12, 57);
            lblSubject.Margin = new Padding(2);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(189, 31);
            lblSubject.TabIndex = 9;
            lblSubject.Text = "Total Marks :";
            lblSubject.TextAlign = ContentAlignment.MiddleRight;
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
            lblName.Text = "Marks Received :";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAnswers
            // 
            lblAnswers.AutoSize = true;
            lblAnswers.Dock = DockStyle.Fill;
            lblAnswers.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswers.Location = new Point(12, 102);
            lblAnswers.Margin = new Padding(2);
            lblAnswers.Name = "lblAnswers";
            lblAnswers.Size = new Size(189, 31);
            lblAnswers.TabIndex = 2;
            lblAnswers.Text = "Percentage :";
            lblAnswers.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtReceived
            // 
            txtReceived.Dock = DockStyle.Fill;
            txtReceived.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtReceived.Location = new Point(206, 13);
            txtReceived.Name = "txtReceived";
            txtReceived.ReadOnly = true;
            txtReceived.Size = new Size(119, 30);
            txtReceived.TabIndex = 3;
            // 
            // txtPercentage
            // 
            txtPercentage.Dock = DockStyle.Fill;
            txtPercentage.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPercentage.Location = new Point(206, 103);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.ReadOnly = true;
            txtPercentage.Size = new Size(119, 30);
            txtPercentage.TabIndex = 5;
            // 
            // frmResultInfo
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(400, 250);
            MinimumSize = new Size(400, 250);
            Name = "frmResultInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Info";
            Load += frmResultInfo_Load;
            tlpMainHolder.ResumeLayout(false);
            pnlTaskCollectionInfoHolder.ResumeLayout(false);
            cgbHeadingTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.ResumeLayout(false);
            tlpTaskCollectionInfoHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private Panel pnlTaskCollectionInfoHolder;
        private CustomGroupBox cgbHeadingTaskCollectionInfoHolder;
        private TableLayoutPanel tlpTaskCollectionInfoHolder;
        public TextBox txtMarkCount;
        private Label lblCount;
        public TextBox txtCS;
        private Label lblCaseSentitive;
        public TextBox txtSubject;
        private Label lblSubject;
        private Label lblName;
        private Label lblAnswers;
        public TextBox txtTotal;
        public TextBox txtPercentage;
        private Label lblDistractors;
        public TextBox txtReceived;
    }
}