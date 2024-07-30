using ExamPrepper.Classes;
using ExamPrepper.Forms.QuestionForms;
using ExamPrepper.Forms.TaskCollectionForm;
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
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Classes.Notifications;

namespace ExamPrepper.Forms.QuestionSetupForm
{
    public partial class cfrmTrueFalse : Form
    {
        #region Form Variables
        public string FilePath;

        private int minFormWidth = 585;
        private int minFormHeight = 420;
        #endregion Form Variables

        public cfrmTrueFalse()
        {
            InitializeComponent();
        }

        private void cfrmTrueFalse_Load(object sender, EventArgs e)
        {
            #region Adding Preview Button
            MenuStrip ms = (MenuStrip)this.ParentForm.Controls.Find("msExtras", true)[0];
            ToolStripMenuItem tsmiPreview = new ToolStripMenuItem()
            {
                Name = "btnPreviewForm",
                Text = "Preview"
            };
            tsmiPreview.Click += (s, e) =>
            {
                qfrmTrueFalse frmShow = new qfrmTrueFalse();
                frmShow.btnCreate.Enabled = false;
                frmShow.data = generateData();
                FormHandler(frmShow, showDialog: true);
            };
            ms.Items.Add(tsmiPreview);
            #endregion Adding Preview Button

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);
        }

        //Generating Form To Data
        private ExamTask generateData()
        {
            string ans = rbFalse.Checked ? "False" : "True";
            List<MemoInfo> memoInfo = new List<MemoInfo> { new MemoInfo(ans) };
            List<QuestionInfo> queInfo = new List<QuestionInfo>() { new QuestionInfo(rtbQuestion.Text, memoInfo, (int)nudMarks.Value, QuestionTypeList.TrueFalse) };

            ExamTask examTask = new ExamTask(queInfo, txtTaskName.Text, Subject.getSubjectByID(Default.ActiveSubject));
            return examTask;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region "Erorr Checking"
            if (rtbQuestion.Text == "")
            {
                MessageBox.Show(mainForm.errmsg_NoQuestion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbQuestion.Focus();
                return;
            }

            if (txtTaskName.Text == "")
            {
                DialogResult result = MessageBox.Show(mainForm.errmsg_NoName, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.No)
                {
                    txtTaskName.Focus();
                    return;
                }
            }
            #endregion "Erorr Checking"

            if (btnCreate.Text == "Create Question")
            {
                string subjectFolder = $"{Default.Task_Storage_Path}/{Default.ActiveSubject}/TrueFalse";
                generateData().createFile(subjectFolder);
            }
            else
            {
                DialogResult result = MessageBox.Show(mainForm.errmsg_ConfirmEdit, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    return;
                }
                ExamTask task = generateData();
                EditInJSON(task, FilePath);
                frmViewTasks frm = (frmViewTasks)lsActiveForms.Find(frm => frm.Name == "frmViewTasks");
                frm.refreshDGV();
            }

            CloseForm(this);
            ShowSuccess(mainForm, "Task");
        }

        private void cfrmTrueFalse_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }

        private void txtTaskName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Task Name");
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Create Question");
        }
    }
}
