using ExamPrepper.AllNew.QuestionForms;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrepper.AllNew
{
    public partial class MainForm : FormTemplate
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );

            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            qBasicQuestion frm = new qBasicQuestion(new Classes.ExamFormData.ExamTask());
            this.Text = frm.Text;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormStyle = FormStyles.StatusAndActionBar_None;
            frm.Show();
            
        }
    }
}
