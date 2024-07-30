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

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmInfoTaskCollection : Form
    {
        public frmInfoTaskCollection()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadInfo(Exam taskCollection)
        {

            //Creating a textfield for DGV for Task Name
            var txtTaskName = new DataGridViewTextBoxColumn();
            txtTaskName.Name = $"txtTaskName";
            txtTaskName.HeaderText = $"Task Name";
            dgvTasks.Columns.Add(txtTaskName);

            //Creating a textfield for DGV for task subject
            var txtTaskSubject = new DataGridViewTextBoxColumn();
            txtTaskSubject.Name = $"txtTaskSubject";
            txtTaskSubject.HeaderText = $"Subject";
            dgvTasks.Columns.Add(txtTaskSubject);

            //Creating a textfield for DGV for task question type
            var txtTaskQuestionType = new DataGridViewTextBoxColumn();
            txtTaskQuestionType.Name = $"txtTaskQuestionType";
            txtTaskQuestionType.HeaderText = $"Question";
            dgvTasks.Columns.Add(txtTaskQuestionType);

            dgvTasks.Columns["txtTaskName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTasks.Columns["txtTaskSubject"].Width = 150;
            dgvTasks.Columns["txtTaskQuestionType"].Width = 150;

            int index = 0;
            int taskCount = 0;

            string allSubject = "";
            string allQueTypes = "";

            foreach (ExamSection section in taskCollection.Sections)
            {
                if (taskCollection.isExam())
                {
                    dgvTasks.Rows[index].Cells["txtTaskName"].Value = section.Section;
                    index++;
                }

                foreach (ExamTask task in section.Section_Tasks)
                {
                    taskCount++;

                    if (!allSubject.Contains(task.Task_Subject.Name)) allSubject += $"{task.Task_Subject.Name}, ";
                    if (!allQueTypes.Contains(task.GetQuestion().QuestionType.ToString())) allQueTypes += $"{task.GetQuestion().QuestionType}, ";

                    dgvTasks.Rows.Add((DataGridViewRow)dgvTasks.Rows[0].Clone());
                    dgvTasks.Rows[index].Cells["txtTaskName"].Value = task.Task_Name;
                    dgvTasks.Rows[index].Cells["txtTaskSubject"].Value = task.Task_Subject.Name;
                    dgvTasks.Rows[index].Cells["txtTaskQuestionType"].Value = task.GetQuestion().QuestionType;
                    index++;
                }
            }

            allSubject = allSubject.Substring(0, allSubject.Length - 2);
            allQueTypes = allQueTypes.Substring(0, allQueTypes.Length - 2);
            txtTasks.Text = taskCount.ToString();

            txtSubjects.Text = allSubject;
            txtTypes.Text = allQueTypes;

            dgvTasks.Font = new Font(Default.FontName, 14F, FontStyle.Bold, GraphicsUnit.Point);

            //tlpMainHolder.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
            //cgbHeadingTasksInformationHolder.Visible = false;

            txtName.Text = taskCollection.Exam_Info.Exam_Name;

            if (!taskCollection.isExam())
            {
                cgbHeadingTaskCollectionInfoHolder.Text = $"Quiz Information";
                tlpTaskCollectionInfoHolder.RowStyles[3] = new RowStyle(SizeType.Absolute, 0);
                tlpTaskCollectionInfoHolder.RowStyles[4] = new RowStyle(SizeType.Absolute, 0);
                lblSection.Visible = false;
                txtSections.Visible = false;
            }
            else
            {
                cgbHeadingTaskCollectionInfoHolder.Text = $"Exam Information";
                txtSections.Text = taskCollection.Sections.Count.ToString();
            }

            dgvTasks.AllowUserToAddRows = false;
        }
    }
}
