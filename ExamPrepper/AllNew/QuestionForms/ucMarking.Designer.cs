namespace ExamPrepper
{
    partial class ucMarking
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
            tableLayoutPanel1 = new TableLayoutPanel();
            mbtCorrect = new MaterialSkin.Controls.MaterialButton();
            mbtWrong = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(mbtCorrect, 1, 1);
            tableLayoutPanel1.Controls.Add(mbtWrong, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(316, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // mbtCorrect
            // 
            mbtCorrect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtCorrect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtCorrect.Depth = 0;
            mbtCorrect.Dock = DockStyle.Fill;
            mbtCorrect.HighEmphasis = true;
            mbtCorrect.Icon = null;
            mbtCorrect.Location = new Point(74, 9);
            mbtCorrect.Margin = new Padding(4, 6, 4, 6);
            mbtCorrect.MouseState = MaterialSkin.MouseState.HOVER;
            mbtCorrect.Name = "mbtCorrect";
            mbtCorrect.NoAccentTextColor = Color.Empty;
            mbtCorrect.Size = new Size(42, 18);
            mbtCorrect.TabIndex = 0;
            mbtCorrect.Text = "/";
            mbtCorrect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtCorrect.UseAccentColor = false;
            mbtCorrect.UseVisualStyleBackColor = true;
            // 
            // mbtWrong
            // 
            mbtWrong.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtWrong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtWrong.Depth = 0;
            mbtWrong.Dock = DockStyle.Fill;
            mbtWrong.HighEmphasis = true;
            mbtWrong.Icon = null;
            mbtWrong.Location = new Point(199, 9);
            mbtWrong.Margin = new Padding(4, 6, 4, 6);
            mbtWrong.MouseState = MaterialSkin.MouseState.HOVER;
            mbtWrong.Name = "mbtWrong";
            mbtWrong.NoAccentTextColor = Color.Empty;
            mbtWrong.Size = new Size(42, 18);
            mbtWrong.TabIndex = 1;
            mbtWrong.Text = "X";
            mbtWrong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtWrong.UseAccentColor = false;
            mbtWrong.UseVisualStyleBackColor = true;
            // 
            // ucMarking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMarking";
            Size = new Size(316, 36);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton mbtCorrect;
        private MaterialSkin.Controls.MaterialButton mbtWrong;
    }
}
