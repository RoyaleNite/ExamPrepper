namespace ExamPrepper.Forms.TaskCollectionForm
{
    partial class frmDoOptions
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnInstantResult = new Button();
            btnEndResult = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(btnInstantResult, 1, 3);
            tableLayoutPanel1.Controls.Add(btnEndResult, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(384, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInstantResult
            // 
            btnInstantResult.BackColor = Color.DimGray;
            btnInstantResult.Dock = DockStyle.Fill;
            btnInstantResult.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInstantResult.ForeColor = Color.Transparent;
            btnInstantResult.Location = new Point(10, 80);
            btnInstantResult.Margin = new Padding(0);
            btnInstantResult.Name = "btnInstantResult";
            btnInstantResult.Size = new Size(364, 60);
            btnInstantResult.TabIndex = 6;
            btnInstantResult.Text = "Get instant feedback";
            btnInstantResult.UseVisualStyleBackColor = false;
            btnInstantResult.Click += btnInstantResult_Click;
            // 
            // btnEndResult
            // 
            btnEndResult.BackColor = Color.DimGray;
            btnEndResult.Dock = DockStyle.Fill;
            btnEndResult.Font = new Font("Calibri Light", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEndResult.ForeColor = Color.Transparent;
            btnEndResult.Location = new Point(10, 10);
            btnEndResult.Margin = new Padding(0);
            btnEndResult.Name = "btnEndResult";
            btnEndResult.Size = new Size(364, 60);
            btnEndResult.TabIndex = 5;
            btnEndResult.Text = "Get results at the end";
            btnEndResult.UseVisualStyleBackColor = false;
            btnEndResult.Click += btnEndResult_Click;
            // 
            // frmDoOptions
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 151);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(400, 190);
            Name = "frmDoOptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += frmDoOptions_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInstantResult;
        private Button btnEndResult;
    }
}