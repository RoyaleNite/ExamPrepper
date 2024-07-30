namespace ExamPrepper.Forms
{
    partial class hfrmHelp
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
            rtbHelp = new RichTextBox();
            tlpOptionsHolder = new TableLayoutPanel();
            pnlTopHolder = new Panel();
            tlpMainHolder = new TableLayoutPanel();
            tlpOptionsHolder.SuspendLayout();
            pnlTopHolder.SuspendLayout();
            tlpMainHolder.SuspendLayout();
            SuspendLayout();
            // 
            // rtbHelp
            // 
            rtbHelp.Dock = DockStyle.Fill;
            rtbHelp.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbHelp.Location = new Point(13, 13);
            rtbHelp.Name = "rtbHelp";
            rtbHelp.Size = new Size(458, 335);
            rtbHelp.TabIndex = 0;
            rtbHelp.Text = "";
            // 
            // tlpOptionsHolder
            // 
            tlpOptionsHolder.ColumnCount = 3;
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.Controls.Add(rtbHelp, 1, 1);
            tlpOptionsHolder.Dock = DockStyle.Fill;
            tlpOptionsHolder.Location = new Point(0, 0);
            tlpOptionsHolder.Margin = new Padding(0);
            tlpOptionsHolder.Name = "tlpOptionsHolder";
            tlpOptionsHolder.RowCount = 3;
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpOptionsHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpOptionsHolder.Size = new Size(484, 361);
            tlpOptionsHolder.TabIndex = 1;
            // 
            // pnlTopHolder
            // 
            pnlTopHolder.Controls.Add(tlpOptionsHolder);
            pnlTopHolder.Dock = DockStyle.Fill;
            pnlTopHolder.Location = new Point(0, 0);
            pnlTopHolder.Margin = new Padding(0);
            pnlTopHolder.Name = "pnlTopHolder";
            pnlTopHolder.Size = new Size(484, 361);
            pnlTopHolder.TabIndex = 2;
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 1;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.Controls.Add(pnlTopHolder, 0, 0);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 1;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Size = new Size(484, 361);
            tlpMainHolder.TabIndex = 0;
            // 
            // hfrmHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(tlpMainHolder);
            DoubleBuffered = true;
            MaximumSize = new Size(500, 400);
            Name = "hfrmHelp";
            Text = "Help";
            Load += hfrmHelp_Load;
            tlpOptionsHolder.ResumeLayout(false);
            pnlTopHolder.ResumeLayout(false);
            tlpMainHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpOptionsHolder;
        private Panel pnlTopHolder;
        private TableLayoutPanel tlpMainHolder;
        public RichTextBox rtbHelp;
    }
}