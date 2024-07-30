using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.frmMainForm;
using ExamPrepper.Properties;

namespace ExamPrepper
{
    public partial class frmUICustomization : Form
    {
        public frmUICustomization()
        {
            InitializeComponent();
        }

        private void cbxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Default.FontName = cbxFonts.SelectedItem.ToString();
            Default.Save();
            RefreshFonts();
        }

        private void frmUICustomization_Load(object sender, EventArgs e)
        {
            cbxFonts.SelectedIndex = cbxFonts.Items.IndexOf(Default.FontName);
            cdHeadingColor.Color = Color.FromArgb(Default.Heading_Color);
            pnlHeadingColor.BackColor = Color.FromArgb(Default.Heading_Color);
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdHeadingColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                pnlHeadingColor.BackColor = Color.FromArgb(cdHeadingColor.Color.ToArgb());
                Default.Heading_Color = cdHeadingColor.Color.ToArgb();
                Default.Save();
                RefreshFonts();
            }
        }

        public void RefreshFonts()
        {
            Button btnRefresh = GetRefresh(this);

            if (btnRefresh != null)
            {
                btnRefresh.PerformClick();
            }
            foreach (Form frm in frmMainForm.lsActiveForms)
            {
                if (GetRefresh(frm) != null)
                    GetRefresh(frm).PerformClick();
            }
        }

        private void cbxFonts_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as ComboBox, "Application Font");
        }

        private void btnPickColor_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Application Header Font Color");
        }
    }
}
