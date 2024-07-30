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
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.frmMainForm;
using System.Reflection;

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmResults : Form
    {
        public Exam exam;
        public List<Results> results;
        public List<string> files;
        public string type;

        public frmResults()
        {
            InitializeComponent();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            if (results == null) return;
            {
                LoadDGV();
            }
        }

        private void LoadDGV()
        {
            //Creating a textfield for DGV for task subject names
            var txtCorrect = new DataGridViewTextBoxColumn();
            txtCorrect.Name = $"txtCorrect";
            txtCorrect.HeaderText = "Mark Received";
            dgvResults.Columns.Add(txtCorrect);


            //Creating a textfield for DGV for exam name
            var txtTotalMarks = new DataGridViewTextBoxColumn();
            txtTotalMarks.Name = $"txtMarks";
            txtTotalMarks.HeaderText = $"Total Mark";
            dgvResults.Columns.Add(txtTotalMarks);

            //Creating a textfield for DGV for exam id
            var txtPercent = new DataGridViewTextBoxColumn();
            txtPercent.Name = $"txtPercent";
            txtPercent.HeaderText = $"Percent";
            dgvResults.Columns.Add(txtPercent);

            for (int i = 0; i < results.Count; i++)
            {
                dgvResults.Rows.Add((DataGridViewRow)dgvResults.Rows[0].Clone());
                dgvResults.Rows[i].Cells["txtCorrect"].Value = results[i].TotalCorrectMarks.ToString();
                dgvResults.Rows[i].Cells["txtMarks"].Value = results[i].TotalMarks.ToString();
                dgvResults.Rows[i].Cells["txtPercent"].Value = results[i].MarkPercentage.ToString();
            }

            dgvResults.Columns["txtCorrect"].Width = 100;
            dgvResults.Columns["txtMarks"].Width = 100;
            dgvResults.Columns["txtPercent"].Width = 100;

            dgvResults.Font = new Font(Default.FontName, 14F, FontStyle.Bold, GraphicsUnit.Point);
            dgvResults.AllowUserToAddRows = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResults.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }

            File.Delete(files[dgvResults.CurrentRow.Index]);
            dgvResults.Rows.Remove(dgvResults.CurrentRow);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvResults.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }
            Results result = results[dgvResults.CurrentRow.Index];
            FormHandler(new frmResultInfo() { res = result }, normalShow: true);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmDoOptions frmShow = new frmDoOptions();
            frmShow.taskCollection = exam;
            int index = 0;
            foreach (ExamSection sec in exam.Sections)
            {
                foreach (ExamTask task in sec.Section_Tasks)
                {
                    List<AnswerInfo> tempAns = new List<AnswerInfo>();

                    if (task.Question.Count > task.GetQuestion().Memo.Count)
                    {
                        foreach (QuestionInfo que in task.Question)
                        {
                            tempAns.Add(new AnswerInfo(results[dgvResults.CurrentRow.Index].Answers[index].Answer, results[dgvResults.CurrentRow.Index].Answers[index].CorrectMarkCount));
                            index++;
                        }
                    }
                    else
                    {
                        foreach (MemoInfo memo in task.GetQuestion().Memo)
                        {
                            tempAns.Add(new AnswerInfo(results[dgvResults.CurrentRow.Index].Answers[index].Answer, results[dgvResults.CurrentRow.Index].Answers[index].CorrectMarkCount));
                            index++;
                        }
                    }
                    task.Answer = tempAns;
                }
            }
            frmShow.LoadExams(0);

            List<AnswerInfo> answers = new List<AnswerInfo>();

            foreach (Form form in frmShow.allForms)
            {
                qfrmInterface frm = form as qfrmInterface;
                FormHandler(frm as Form, showForm: true);
                frm.MarkPage();
            }

            FormHandler(lsActiveForms.Find(frm => frm.Name.EndsWith("0")));

            CloseForm(this);
        }

        private void btnView_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Result in Detail");
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Result Information");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Delete Result");
        }
    }
}
