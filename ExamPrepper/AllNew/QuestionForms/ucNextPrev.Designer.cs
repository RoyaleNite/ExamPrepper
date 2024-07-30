namespace ExamPrepper.AllNew.QuestionForms
{
    partial class ucNextPrev
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
            tlpMainHolder = new TableLayoutPanel();
            btnPrevious = new MaterialSkin.Controls.MaterialButton();
            btnNext = new MaterialSkin.Controls.MaterialButton();
            tlpMainHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHolder
            // 
            tlpMainHolder.ColumnCount = 5;
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpMainHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMainHolder.Controls.Add(btnNext, 3, 1);
            tlpMainHolder.Controls.Add(btnPrevious, 1, 1);
            tlpMainHolder.Dock = DockStyle.Fill;
            tlpMainHolder.Location = new Point(0, 0);
            tlpMainHolder.Margin = new Padding(0);
            tlpMainHolder.Name = "tlpMainHolder";
            tlpMainHolder.RowCount = 3;
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMainHolder.Size = new Size(645, 90);
            tlpMainHolder.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.AutoSize = false;
            btnPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrevious.Depth = 0;
            btnPrevious.Dock = DockStyle.Fill;
            btnPrevious.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.HighEmphasis = true;
            btnPrevious.Icon = null;
            btnPrevious.Location = new Point(24, 21);
            btnPrevious.Margin = new Padding(4, 6, 4, 6);
            btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrevious.Name = "btnPrevious";
            btnPrevious.NoAccentTextColor = Color.Empty;
            btnPrevious.Size = new Size(167, 48);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrevious.UseAccentColor = false;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.AutoSize = false;
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.Dock = DockStyle.Fill;
            btnNext.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.Location = new Point(454, 21);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(167, 48);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // ucNextPrev
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMainHolder);
            Name = "ucNextPrev";
            Size = new Size(645, 90);
            tlpMainHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHolder;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
    }
}
