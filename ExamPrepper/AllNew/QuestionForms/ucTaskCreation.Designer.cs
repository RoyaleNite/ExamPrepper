namespace ExamPrepper.AllNew.QuestionForms
{
    partial class ucTaskCreation
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
            tlpMainTask = new TableLayoutPanel();
            mlblTaskName = new MaterialSkin.Controls.MaterialLabel();
            mtbTaskName = new MaterialSkin.Controls.MaterialTextBox2();
            mtbtnCreate = new MaterialSkin.Controls.MaterialButton();
            tlpMainTask.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainTask
            // 
            tlpMainTask.ColumnCount = 7;
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpMainTask.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMainTask.Controls.Add(mlblTaskName, 1, 1);
            tlpMainTask.Controls.Add(mtbTaskName, 3, 1);
            tlpMainTask.Controls.Add(mtbtnCreate, 5, 1);
            tlpMainTask.Dock = DockStyle.Fill;
            tlpMainTask.Location = new Point(0, 0);
            tlpMainTask.Margin = new Padding(0);
            tlpMainTask.Name = "tlpMainTask";
            tlpMainTask.RowCount = 3;
            tlpMainTask.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainTask.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainTask.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMainTask.Size = new Size(681, 90);
            tlpMainTask.TabIndex = 0;
            // 
            // mlblTaskName
            // 
            mlblTaskName.Depth = 0;
            mlblTaskName.Dock = DockStyle.Fill;
            mlblTaskName.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            mlblTaskName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            mlblTaskName.Location = new Point(22, 22);
            mlblTaskName.Margin = new Padding(2, 2, 0, 0);
            mlblTaskName.MouseState = MaterialSkin.MouseState.HOVER;
            mlblTaskName.Name = "mlblTaskName";
            mlblTaskName.Size = new Size(133, 48);
            mlblTaskName.TabIndex = 0;
            mlblTaskName.Text = "Task Name:";
            mlblTaskName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mtbTaskName
            // 
            mtbTaskName.AnimateReadOnly = false;
            mtbTaskName.BackgroundImageLayout = ImageLayout.None;
            mtbTaskName.CharacterCasing = CharacterCasing.Normal;
            mtbTaskName.Depth = 0;
            mtbTaskName.Dock = DockStyle.Fill;
            mtbTaskName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbTaskName.HideSelection = true;
            mtbTaskName.LeadingIcon = null;
            mtbTaskName.Location = new Point(168, 23);
            mtbTaskName.MaxLength = 32767;
            mtbTaskName.MouseState = MaterialSkin.MouseState.OUT;
            mtbTaskName.Name = "mtbTaskName";
            mtbTaskName.PasswordChar = '\0';
            mtbTaskName.PrefixSuffixText = null;
            mtbTaskName.ReadOnly = false;
            mtbTaskName.RightToLeft = RightToLeft.No;
            mtbTaskName.SelectedText = "";
            mtbTaskName.SelectionLength = 0;
            mtbTaskName.SelectionStart = 0;
            mtbTaskName.ShortcutsEnabled = true;
            mtbTaskName.Size = new Size(294, 48);
            mtbTaskName.TabIndex = 1;
            mtbTaskName.TabStop = false;
            mtbTaskName.Text = "materialTextBox21";
            mtbTaskName.TextAlign = HorizontalAlignment.Left;
            mtbTaskName.TrailingIcon = null;
            mtbTaskName.UseSystemPasswordChar = false;
            // 
            // mtbtnCreate
            // 
            mtbtnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbtnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mtbtnCreate.Depth = 0;
            mtbtnCreate.Dock = DockStyle.Fill;
            mtbtnCreate.HighEmphasis = true;
            mtbtnCreate.Icon = null;
            mtbtnCreate.Location = new Point(485, 26);
            mtbtnCreate.Margin = new Padding(4, 6, 4, 6);
            mtbtnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            mtbtnCreate.Name = "mtbtnCreate";
            mtbtnCreate.NoAccentTextColor = Color.Empty;
            mtbtnCreate.Size = new Size(172, 38);
            mtbtnCreate.TabIndex = 2;
            mtbtnCreate.Text = "Create Task";
            mtbtnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mtbtnCreate.UseAccentColor = false;
            mtbtnCreate.UseVisualStyleBackColor = true;
            // 
            // ucTaskCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMainTask);
            Name = "ucTaskCreation";
            Size = new Size(681, 90);
            tlpMainTask.ResumeLayout(false);
            tlpMainTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainTask;
        private MaterialSkin.Controls.MaterialLabel mlblTaskName;
        private MaterialSkin.Controls.MaterialTextBox2 mtbTaskName;
        private MaterialSkin.Controls.MaterialButton mtbtnCreate;
    }
}
