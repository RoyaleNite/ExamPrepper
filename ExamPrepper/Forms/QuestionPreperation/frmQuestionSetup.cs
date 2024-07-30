using ExamPrepper.Classes;
using ExamPrepper.Forms.QuestionSetupForm;
using ExamPrepper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Classes.ExamFormData;

namespace ExamPrepper.Forms
{
    public partial class frmQuestionSetup : Form
    {

        #region Error Messages
        string errmsg_NoSubject = "You must select a subject before you can continue.";
        #endregion Error Messages

        private List<string> subjectIDs = new List<string>();

        public frmQuestionSetup()
        {
            InitializeComponent();
        }

        private void btnBasicQuestion_Click(object sender, EventArgs e)
        {
            if (!canLoadNextForm()) return;
            FormHandler(new cfrmQuestion());
        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            if (!canLoadNextForm()) return;
            FormHandler(new cfrmTrueFalse());
        }

        private void btnMultiChoice_Click(object sender, EventArgs e)
        {
            if (!canLoadNextForm()) return;
            FormHandler(new cfrmMultiChoice());
        }

        private void btnFillBlank_Click(object sender, EventArgs e)
        {
            if (!canLoadNextForm()) return;
            FormHandler(new cfrmFillBlank());
        }

        private void btnMultiColumn_Click(object sender, EventArgs e)
        {
            if (!canLoadNextForm()) return;
            FormHandler(new cfrmMatchColumn());
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            FormHandler(new frmSubjectSetup(), showDialog: true);
        }

        private bool canLoadNextForm()
        {
            if (cbxSubjects.SelectedIndex == -1)
            {
                MessageBox.Show(errmsg_NoSubject, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxSubjects.Focus();
                return false;
            }
            else return true;
        }

        private void frmQuestionSetup_Load(object sender, EventArgs e)
        {
            GetRefresh(this).Click += (s, e) =>
            {
                List<Subject> subjects = JSONHandler.JSONToData<List<Subject>>("./Data/Subjects.json");
                if (subjects == null) return;
                if (subjects.Count > 0)
                {
                    cbxSubjects.Items.Clear();
                    foreach (Subject sub in subjects)
                    {
                        cbxSubjects.Items.Add(sub.Name);
                        subjectIDs.Add(sub.SubjectID);
                    }
                }
                cbxSubjects.SelectedIndex = cbxSubjects.Items.IndexOf(cbxSubjects.Text);
            };
        }

        private void cbxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.ActiveSubject = subjectIDs[cbxSubjects.SelectedIndex];
            Settings.Default.Save();
        }

        private void btnManage_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Manage All Subjects");
        }

        private void btnBasicQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Basic Question Setup");
        }

        private void btnTrueFalse_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "True/False Question Setup");
        }

        private void btnMultiChoice_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Multiple Choice Question Setup");
        }

        private void btnFillBlank_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Fill Blank Question Setup");
        }

        private void btnMultiColumn_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Match Column A and B Question Setup");
        }

        private void cbxSubjects_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as ComboBox, "Task Subject");
        }
    }
}
