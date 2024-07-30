using ExamPrepper.Forms;
using ExamPrepper.Forms.QuestionPreperation;
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
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Properties.Settings;
using ExamPrepper.Forms.TaskCollectionForm;

namespace ExamPrepper
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            List<ExamTask> tasks = new List<ExamTask>();
            
            ExamSection section = new ExamSection() { Section = "asd", Results = new Results(), Section_Tasks = tasks};


            
            //section.Section_Tasks = tasks;
            //Exam exam = new Exam() { Sections = { new ExamSection() { Results = new Results(), Section_Tasks = new List<ExamTask>(), Section = "asd"} }, Exam_Info = new ExamInfo()};

            
        }

        private void btnQuestionSetup_Click(object sender, EventArgs e)
        {
            FormHandler(new frmQuestionSetup());
        }

        private void cgpHeadingSetup_ForeColorChanged(object sender, EventArgs e)
        {
            cgpHeadingSetup.TextColor = cgpHeadingSetup.ForeColor;
        }

        private void btnQuizSetup_Click(object sender, EventArgs e)
        {
            FormHandler(new frmQuizSetup());
        }

        private void btnExamSetup_Click(object sender, EventArgs e)
        {
            FormHandler(new frmExamSetup());
        }

        private void btnQuizzes_Click(object sender, EventArgs e)
        {
            List<Exam> tasks = new List<Exam>();
            List<string> quizType = new List<string>();

            List<string> dirs = Directory.GetDirectories(Default.Quiz_Storage_Path).ToList();
            List<string> files = new List<string>();

            foreach (string dir in dirs)
            {
                List<string> filePaths = Directory.GetFiles(dir).ToList();

                foreach (string filePath in filePaths)
                {
                    string tempDir = dir.Replace("\\", "/");
                    quizType.Add(tempDir.Split("/")[tempDir.Split("/").Count() - 1]);
                    tasks.Add(JSONToData<Exam>(filePath));
                    files.Add(filePath);
                }
            }

            FormHandler(new frmViewTaskCollection()
            {
                taskCollection = tasks,
                subjectTypes = quizType,
                filePaths = files
            });
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            List<Exam> tasks = new List<Exam>();
            List<string> quizType = new List<string>();

            List<string> dirs = Directory.GetDirectories(Default.Exam_Storage_Path).ToList();
            List<string> files = new List<string>();

            foreach (string dir in dirs)
            {
                List<string> filePaths = Directory.GetFiles(dir).ToList();

                foreach (string filePath in filePaths)
                {
                    string tempDir = dir.Replace("\\", "/");
                    quizType.Add(tempDir.Split("/")[tempDir.Split("/").Count() - 1]);
                    tasks.Add(JSONToData<Exam>(filePath));
                    files.Add(filePath);
                }
            }

            FormHandler(new frmViewTaskCollection()
            {
                taskCollection = tasks,
                subjectTypes = quizType,
                filePaths = files
            });
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            FormHandler(new frmViewTasks());
        }

        private void btnQuizzes_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View all Quizzes");
        }

        private void btnExams_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View all Exams");
        }

        private void btnTasks_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View all Tasks");
        }

        private void btnQuestionSetup_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Question Setup and Subjects Setup");
        }

        private void btnQuizSetup_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Quiz Setup");
        }

        private void btnExamSetup_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Exam Setup");
        }
    }
}
