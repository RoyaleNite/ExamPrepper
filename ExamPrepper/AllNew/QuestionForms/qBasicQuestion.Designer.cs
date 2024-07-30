namespace ExamPrepper
{
    partial class qBasicQuestion
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
            tlpMHolder = new TableLayoutPanel();
            tlpQuestionHolder = new TableLayoutPanel();
            mtbQuestion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            lblQuestion = new MaterialSkin.Controls.MaterialLabel();
            tlpAnswerHolder = new TableLayoutPanel();
            materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            lblAnswer = new MaterialSkin.Controls.MaterialLabel();
            lblMarks = new MaterialSkin.Controls.MaterialLabel();
            tlpMHolder.SuspendLayout();
            tlpQuestionHolder.SuspendLayout();
            tlpAnswerHolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMHolder
            // 
            tlpMHolder.ColumnCount = 1;
            tlpMHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMHolder.Controls.Add(tlpQuestionHolder, 0, 1);
            tlpMHolder.Controls.Add(tlpAnswerHolder, 0, 1);
            tlpMHolder.Dock = DockStyle.Fill;
            tlpMHolder.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlpMHolder.Location = new Point(0, 0);
            tlpMHolder.Name = "tlpMHolder";
            tlpMHolder.RowCount = 3;
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMHolder.Size = new Size(660, 489);
            tlpMHolder.TabIndex = 4;
            // 
            // tlpQuestionHolder
            // 
            tlpQuestionHolder.AutoSize = true;
            tlpQuestionHolder.ColumnCount = 4;
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQuestionHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpQuestionHolder.Controls.Add(mtbQuestion, 1, 1);
            tlpQuestionHolder.Controls.Add(lblQuestion, 1, 0);
            tlpQuestionHolder.Dock = DockStyle.Fill;
            tlpQuestionHolder.Font = new Font("Calibri Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQuestionHolder.Location = new Point(0, 292);
            tlpQuestionHolder.Margin = new Padding(0);
            tlpQuestionHolder.Name = "tlpQuestionHolder";
            tlpQuestionHolder.RowCount = 3;
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuestionHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpQuestionHolder.Size = new Size(660, 197);
            tlpQuestionHolder.TabIndex = 2;
            // 
            // mtbQuestion
            // 
            mtbQuestion.AnimateReadOnly = false;
            mtbQuestion.BackgroundImageLayout = ImageLayout.None;
            mtbQuestion.CharacterCasing = CharacterCasing.Normal;
            tlpQuestionHolder.SetColumnSpan(mtbQuestion, 2);
            mtbQuestion.Depth = 0;
            mtbQuestion.Dock = DockStyle.Fill;
            mtbQuestion.Font = new Font("Calibri Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            mtbQuestion.HideSelection = true;
            mtbQuestion.Location = new Point(22, 47);
            mtbQuestion.Margin = new Padding(2);
            mtbQuestion.MaxLength = 32767;
            mtbQuestion.MouseState = MaterialSkin.MouseState.OUT;
            mtbQuestion.Name = "mtbQuestion";
            mtbQuestion.PasswordChar = '\0';
            mtbQuestion.ReadOnly = false;
            mtbQuestion.ScrollBars = ScrollBars.None;
            mtbQuestion.SelectedText = "";
            mtbQuestion.SelectionLength = 0;
            mtbQuestion.SelectionStart = 0;
            mtbQuestion.ShortcutsEnabled = true;
            mtbQuestion.Size = new Size(616, 133);
            mtbQuestion.TabIndex = 3;
            mtbQuestion.TabStop = false;
            mtbQuestion.TextAlign = HorizontalAlignment.Left;
            mtbQuestion.UseSystemPasswordChar = false;
            // 
            // lblQuestion
            // 
            lblQuestion.Depth = 0;
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Calibri Light", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblQuestion.Location = new Point(35, 8);
            lblQuestion.Margin = new Padding(15, 8, 5, 5);
            lblQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(290, 32);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question:";
            // 
            // tlpAnswerHolder
            // 
            tlpAnswerHolder.AutoSize = true;
            tlpAnswerHolder.ColumnCount = 4;
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAnswerHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpAnswerHolder.Controls.Add(lblMarks, 2, 0);
            tlpAnswerHolder.Controls.Add(materialMultiLineTextBox21, 1, 1);
            tlpAnswerHolder.Controls.Add(lblAnswer, 1, 0);
            tlpAnswerHolder.Dock = DockStyle.Fill;
            tlpAnswerHolder.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tlpAnswerHolder.Location = new Point(0, 95);
            tlpAnswerHolder.Margin = new Padding(0);
            tlpAnswerHolder.Name = "tlpAnswerHolder";
            tlpAnswerHolder.RowCount = 3;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpAnswerHolder.Size = new Size(660, 197);
            tlpAnswerHolder.TabIndex = 1;
            // 
            // materialMultiLineTextBox21
            // 
            materialMultiLineTextBox21.AnimateReadOnly = false;
            materialMultiLineTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBox21.CharacterCasing = CharacterCasing.Normal;
            tlpAnswerHolder.SetColumnSpan(materialMultiLineTextBox21, 2);
            materialMultiLineTextBox21.Depth = 0;
            materialMultiLineTextBox21.Dock = DockStyle.Fill;
            materialMultiLineTextBox21.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialMultiLineTextBox21.HideSelection = true;
            materialMultiLineTextBox21.Location = new Point(22, 47);
            materialMultiLineTextBox21.Margin = new Padding(2);
            materialMultiLineTextBox21.MaxLength = 32767;
            materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            materialMultiLineTextBox21.PasswordChar = '\0';
            materialMultiLineTextBox21.ReadOnly = false;
            materialMultiLineTextBox21.ScrollBars = ScrollBars.None;
            materialMultiLineTextBox21.SelectedText = "";
            materialMultiLineTextBox21.SelectionLength = 0;
            materialMultiLineTextBox21.SelectionStart = 0;
            materialMultiLineTextBox21.ShortcutsEnabled = true;
            materialMultiLineTextBox21.Size = new Size(616, 133);
            materialMultiLineTextBox21.TabIndex = 5;
            materialMultiLineTextBox21.TabStop = false;
            materialMultiLineTextBox21.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // lblAnswer
            // 
            lblAnswer.Depth = 0;
            lblAnswer.Dock = DockStyle.Fill;
            lblAnswer.Font = new Font("Calibri Light", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswer.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblAnswer.Location = new Point(35, 8);
            lblAnswer.Margin = new Padding(15, 8, 5, 5);
            lblAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(290, 32);
            lblAnswer.TabIndex = 0;
            lblAnswer.Text = "Answer:";
            // 
            // lblMarks
            // 
            lblMarks.Depth = 0;
            lblMarks.Dock = DockStyle.Fill;
            lblMarks.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMarks.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblMarks.Location = new Point(345, 8);
            lblMarks.Margin = new Padding(15, 8, 5, 5);
            lblMarks.MouseState = MaterialSkin.MouseState.HOVER;
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(290, 32);
            lblMarks.TabIndex = 6;
            lblMarks.Text = "Marks";
            // 
            // qBasicQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 489);
            Controls.Add(tlpMHolder);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "qBasicQuestion";
            Padding = new Padding(0);
            RightToLeft = RightToLeft.No;
            Text = "Basic Question";
            tlpMHolder.ResumeLayout(false);
            tlpMHolder.PerformLayout();
            tlpQuestionHolder.ResumeLayout(false);
            tlpAnswerHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMHolder;
        private TableLayoutPanel tlpAnswerHolder;
        private MaterialSkin.Controls.MaterialLabel lblAnswer;
        private TableLayoutPanel tlpQuestionHolder;
        private MaterialSkin.Controls.MaterialLabel lblQuestion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mtbQuestion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialLabel lblMarks;
    }
}