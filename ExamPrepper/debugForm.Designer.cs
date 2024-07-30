namespace ExamPrepper
{
    partial class debugForm
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
            rtbDebug = new RichTextBox();
            SuspendLayout();
            // 
            // rtbDebug
            // 
            rtbDebug.Dock = DockStyle.Top;
            rtbDebug.Location = new Point(0, 0);
            rtbDebug.Name = "rtbDebug";
            rtbDebug.Size = new Size(477, 261);
            rtbDebug.TabIndex = 0;
            rtbDebug.Text = "";
            rtbDebug.TextChanged += rtbDebug_TextChanged;
            // 
            // debugForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(rtbDebug);
            DoubleBuffered = true;
            Name = "debugForm";
            Text = "debugForm";
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox rtbDebug;
    }
}