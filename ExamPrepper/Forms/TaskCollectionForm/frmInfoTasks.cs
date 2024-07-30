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

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmInfoTasks : Form
    {
        public frmInfoTasks()
        {
            InitializeComponent();
        }

        private void frmInfoTasks_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(ExamTask Task)
        {
            txtName.Text = Task.Task_Name;
            txtMarkCount.Text = Task.GetQuestion().MarkCount.ToString();

            int cs = 0;
            int ans = 0;
            int distractors = Task.GetQuestion().Distractors != null ? Task.GetQuestion().Distractors.Count() : 0;
            string que = "";

            foreach (var question in Task.Question)
            {
                que += $"{question.Question} ";
                foreach (var memo in question.Memo)
                {
                    if (memo.CaseSensitive) cs++;
                    ans++;
                }
            }

            txtDistractors.Text = distractors.ToString();
            txtSubject.Text = Task.Task_Subject.Name;
            txtCS.Text = cs.ToString();
            txtTasks.Text = ans.ToString();
            rtbQuestion.Text = que;
        }
    }
}
