using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrepper
{
    public partial class debugForm : Form
    {
        public debugForm()
        {
            InitializeComponent();
        }

        private void rtbDebug_TextChanged(object sender, EventArgs e)
        {
            string prevText = "";
            foreach (string line in rtbDebug.Lines) if (line != "Active Forms in order:" && line.Count() > 1) prevText += $"{line}\n";
            rtbDebug.Clear();
            rtbDebug.Text = $"Active Forms in order:\n{prevText}";
        }
    }
}
