using ExamPrepper.Properties;
using MaterialSkin.Controls;
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
    public partial class FormTemplate : MaterialForm
    {
        public FormTemplate()
        {
            InitializeComponent();
        }

        public void RefreshFont()
        {
            List<Control> controls = new List<Control>();

            foreach (Control ctrl in this.Controls)
                controls.Add(ctrl);

            while (controls.Count > 0)
            {
                if (controls[0].Controls.Count > 0)
                    foreach (Control ctrl in controls[0].Controls)
                        controls.Add(ctrl);
                float fontSize = controls[0].Font.Size;
                FontStyle fontStyle = controls[0].Font.Style;
                controls[0].Font = new Font(Properties.Settings.Default.FontName, fontSize, fontStyle);
                if (controls[0].Name.Contains("Heading")) controls[0].ForeColor = Color.FromArgb(Settings.Default.Heading_Color);
                controls.RemoveAt(0);
            }
        }

        private void FormTemplate_Load(object sender, EventArgs e)
        {

        }

        private void FormTemplate_Shown(object sender, EventArgs e)
        {
            RefreshFont();
        }
    }
}
