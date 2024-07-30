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
using static ExamPrepper.Classes.JSONHandler;
using ExamPrepper.Forms.QuestionPreperation;
using static ExamPrepper.frmMainForm;
using ExamPrepper.Forms.QuestionSetupForm;
using ExamPrepper.Properties;

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmViewTasks : Form
    {

        public List<ExamTask> tasks = new List<ExamTask>();
        public List<string> files = new List<string>();

        private List<string> filterQueTypes = new List<string>();
        public List<string> filterSubjects = new List<string> { "" };

        public frmViewTasks()
        {
            InitializeComponent();
        }

        private void frmViewTasks_Shown(object sender, EventArgs e)
        {
            string loadDataPath = Default.Task_Storage_Path;
            string[] dirs = Directory.GetDirectories(loadDataPath);

            foreach (string dir in dirs)
            {
                string[] subDirs = Directory.GetDirectories(dir);
                foreach (string subDir in subDirs)
                {
                    string[] filesPaths = Directory.GetFiles(subDir);
                    foreach (string file in filesPaths)
                    {
                        files.Add(file);
                        tasks.Add(JSONToData<ExamTask>(file));
                    }
                }
            }

            List<Subject> subjects = JSONToData<List<Subject>>("./Data/Subjects.json");
            subjects?.ForEach(sub => filterSubjects.Add(sub.SubjectID));

            var types = Enum.GetValues(typeof(QuestionTypeList));

            foreach (var type in types)
            {
                filterQueTypes.Add(type.ToString());
            }

            //List<ExamTask> tempTasks = new List<ExamTask>();
            //List<string> tempFiles = new List<string>();

            //FilterTasks(out tempTasks, out tempFiles);

            loadDGV(tasks);
        }

        public void refreshDGV()
        {
            string loadDataPath = Default.Task_Storage_Path;
            string[] dirs = Directory.GetDirectories(loadDataPath);

            tasks = new List<ExamTask>();
            files = new List<string>();

            foreach (string dir in dirs)
            {
                string[] subDirs = Directory.GetDirectories(dir);
                foreach (string subDir in subDirs)
                {
                    string[] filesPaths = Directory.GetFiles(subDir);
                    foreach (string file in filesPaths)
                    {
                        files.Add(file);
                        tasks.Add(JSONToData<ExamTask>(file));
                    }
                }
            }

            List<ExamTask> tempTasks = new List<ExamTask>();
            List<string> tempFiles = new List<string>();

            FilterTasks(out tempTasks, out tempFiles);

            loadDGV(tempTasks);
        }

        public void loadDGV(List<ExamTask> data)//, List<string> filePaths)
        {
            dgvTaskCollection.Rows.Clear();
            dgvTaskCollection.Columns.Clear();

            dgvTaskCollection.AllowUserToAddRows = true;

            //Creating a textfield for DGV for task subject names
            var txtTaskName = new DataGridViewTextBoxColumn();
            txtTaskName.Name = $"txtTaskName";
            txtTaskName.HeaderText = "Task Name";
            dgvTaskCollection.Columns.Add(txtTaskName);

            //Creating a textfield for DGV for task subject names
            var txtTaskID = new DataGridViewTextBoxColumn();
            txtTaskID.Name = $"txtTaskID";
            txtTaskID.HeaderText = "";
            dgvTaskCollection.Columns.Add(txtTaskID);

            //Creating a textfield for DGV for task subject names
            var txtSubjectName = new DataGridViewTextBoxColumn();
            txtSubjectName.Name = $"txtSubjectName";
            txtSubjectName.HeaderText = "Subject";
            dgvTaskCollection.Columns.Add(txtSubjectName);

            //Creating a textfield for DGV for task question types
            var txtQueType = new DataGridViewTextBoxColumn();
            txtQueType.Name = $"txtQueType";
            txtQueType.HeaderText = "Question";
            dgvTaskCollection.Columns.Add(txtQueType);

            //Settings created DGV field values
            for (int i = 0; i < data.Count; i++)
            {
                dgvTaskCollection.Rows.Add((DataGridViewRow)dgvTaskCollection.Rows[0].Clone());
                dgvTaskCollection.Rows[i].Cells["txtTaskName"].Value = data[i].Task_Name;
                dgvTaskCollection.Rows[i].Cells["txtTaskID"].Value = data[i].Task_ID;
                dgvTaskCollection.Rows[i].Cells["txtSubjectName"].Value = data[i].Task_Subject.Name;
                dgvTaskCollection.Rows[i].Cells["txtQueType"].Value = data[i].GetQuestion().QuestionType;
            }

            //Configuring DGV Columns
            dgvTaskCollection.Columns["txtTaskID"].Visible = false;
            dgvTaskCollection.Columns["txtTaskName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTaskCollection.Columns["txtSubjectName"].Width = 150;
            dgvTaskCollection.Columns["txtQueType"].Width = 150;
            dgvTaskCollection.Font = new Font(Default.FontName, 14F, FontStyle.Bold, GraphicsUnit.Point);

            dgvTaskCollection.AllowUserToAddRows = false;
        }

        private void frmViewTasks_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted("Task");
                return;
            }

            string selTaskID = dgvTaskCollection.CurrentRow.Cells["txtTaskID"].Value.ToString();
            int index = tasks.FindIndex(task => task.Task_ID == selTaskID);
            ExamTask selTask = tasks[index];

            Default.ActiveSubject = selTask.Task_Subject.SubjectID;
            Default.Save();

            #region FillBlank
            if (selTask.GetQuestion().QuestionType == QuestionTypeList.FillBlank.ToString())
            {
                cfrmFillBlank frmShow = new cfrmFillBlank();

                frmShow.Shown += (s, e) =>
                {
                    foreach (string str in selTask.GetQuestion().Question.Split(" "))
                    {
                        frmShow.rtbQuestion.Text += $"{str} ";
                    }

                    int index = 0;
                    foreach (var opt in frmShow.AnswerOptions)
                    {
                        MemoInfo curAns = selTask.GetQuestion().Memo[index];
                        bool cs = curAns.CaseSensitive;

                        opt.answerCS.Text = cs ? "[Case Sensitive]" : "[Not Case Sensitive]";
                        opt.answerNumber.Text = $"{index + 1})";
                        opt.answerBox.Text = curAns.Answer;
                        opt.cs = cs;

                        index++;
                    }
                };

                frmShow.btnCreate.Text = "Edit Question";
                frmShow.txtTaskName.Text = selTask.Task_Name;
                frmShow.nudMarks.Value = (decimal)selTask.GetQuestion().MarkCount;
                frmShow.FilePath = files[tasks.IndexOf(selTask)];

                FormHandler(frmShow);
            }
            #endregion FillBlank

            #region BasicQuestion
            else if (selTask.GetQuestion().QuestionType == QuestionTypeList.BasicQuestion.ToString())
            {
                cfrmQuestion frmShow = new cfrmQuestion();

                frmShow.rtbAnswer.Text = selTask.GetQuestion().GetMemo().Answer;
                frmShow.rtbQuestion.Text = selTask.GetQuestion().Question;
                frmShow.nudMarks.Value = (decimal)selTask.GetQuestion().MarkCount;
                frmShow.txtTaskName.Text = selTask.Task_Name;

                frmShow.btnCreate.Text = "Edit Question";
                frmShow.FilePath = files[tasks.IndexOf(selTask)];

                FormHandler(frmShow);
            }
            #endregion BasicQuestion

            #region MultipleChoice
            else if (selTask.GetQuestion().QuestionType == QuestionTypeList.MultipleChoice.ToString())
            {
                cfrmMultiChoice frmShow = new cfrmMultiChoice();

                frmShow.Shown += (s, e) =>
                {
                    int index = 0;
                    foreach (var memo in selTask.GetQuestion().Memo)
                    {
                        frmShow.btnAddChoice.PerformClick();
                        var opt = frmShow.answerOptions[index];
                        opt.answerBox.Text = memo.Answer;
                        opt.correctAnswer.Checked = true;
                        index++;
                    }
                    foreach (var dis in selTask.GetQuestion().Distractors)
                    {
                        frmShow.btnAddChoice.PerformClick();
                        var opt = frmShow.answerOptions[index];
                        opt.answerBox.Text = dis;
                        index++;
                    }
                };

                frmShow.rtbQuestion.Text = selTask.GetQuestion().Question;
                frmShow.nudMarks.Value = (decimal)selTask.GetQuestion().MarkCount;
                frmShow.txtTaskName.Text = selTask.Task_Name;

                frmShow.btnCreate.Text = "Edit Question";
                frmShow.FilePath = files[tasks.IndexOf(selTask)];

                FormHandler(frmShow);
            }
            #endregion MultipleChoice

            #region MatchColumn
            else if (selTask.GetQuestion().QuestionType == QuestionTypeList.MatchColumn.ToString())
            {
                cfrmMatchColumn frmShow = new cfrmMatchColumn();

                frmShow.Shown += (s, e) =>
                {
                    int index = 0;
                    foreach (var que in selTask.Question)
                    {
                        frmShow.btnAddQuestion.PerformClick();
                        frmShow.btnAddAnswer.PerformClick();

                        frmShow.queS[index].answerBox.Text = que.Question;
                        frmShow.queS[index].questionAnswer.SelectedItem = frmShow.queS[index].questionAnswer.Items.IndexOf((char)(65 + index));

                        frmShow.ansS[index].answerBox.Text = que.GetMemo().Answer;

                        index++;
                    }

                    foreach (var dis in selTask.GetQuestion().Distractors)
                    {
                        frmShow.btnAddAnswer.PerformClick();
                        frmShow.ansS[index].answerBox.Text = dis;
                        index++;
                    }
                };

                frmShow.nudMarks.Value = (decimal)selTask.GetQuestion().MarkCount;
                frmShow.txtTaskName.Text = selTask.Task_Name;

                frmShow.btnCreate.Text = "Edit Question";
                frmShow.FilePath = files[tasks.IndexOf(selTask)];

                FormHandler(frmShow);
            }
            #endregion MatchColumn

            #region TrueFalse
            else if (selTask.GetQuestion().QuestionType == QuestionTypeList.TrueFalse.ToString())
            {
                cfrmTrueFalse frmShow = new cfrmTrueFalse();

                frmShow.rtbQuestion.Text = selTask.GetQuestion().Question;
                frmShow.nudMarks.Value = (decimal)selTask.GetQuestion().MarkCount;
                frmShow.txtTaskName.Text = selTask.Task_Name;

                frmShow.btnCreate.Text = "Edit Question";
                frmShow.FilePath = files[tasks.IndexOf(selTask)];

                bool ca = bool.Parse(selTask.GetQuestion().GetMemo().Answer.ToLower());

                if (ca) frmShow.rbTrue.Checked = true;
                else frmShow.rbFalse.Checked = true;

                FormHandler(frmShow);
            }
            #endregion TrueFalse
        }

        public void FilterTasks(out List<ExamTask> filttasks, out List<string> filtfiles)
        {
            int counter = 0;
            List<ExamTask> tempTasks = new List<ExamTask>();
            List<string> tempFiles = new List<string>();

            foreach (ExamTask task in tasks)
            {
                if (filterSubjects.Contains(task.Task_Subject.SubjectID) && filterQueTypes.Contains(task.GetQuestion().QuestionType))
                {
                    tempTasks.Add(task);
                    tempFiles.Add(files[counter]);
                }
                counter++;
            }
            filttasks = tempTasks;
            filtfiles = tempFiles;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted("Task");
                return;
            }
            string selTaskID = dgvTaskCollection.CurrentRow.Cells["txtTaskID"].Value.ToString();
            int index = tasks.FindIndex(exam => exam.Task_ID == selTaskID);

            File.Delete(files[index]);
            dgvTaskCollection.Rows.Remove(dgvTaskCollection.CurrentRow);
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            List<ExamTask> tempTasks = new List<ExamTask>();
            List<string> tempFiles = new List<string>();

            FilterTasks(out tempTasks, out tempFiles);

            List<ExamTask> filtTasks = new List<ExamTask>();

            foreach (ExamTask task in tempTasks)
            {
                if (task.Task_Name.ToUpper().Contains(txtFilterName.Text.ToUpper()))
                {
                    filtTasks.Add(task);
                }
            }

            loadDGV(filtTasks);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            //Opening form with filters
            frmSetupSubjectFilter showFrm = new frmSetupSubjectFilter();
            showFrm.selSub = filterSubjects;
            showFrm.selTypes = filterQueTypes;
            FormHandler(showFrm, showDialog: true);
            filterSubjects = showFrm.selSub;
            filterQueTypes = showFrm.selTypes;

            List<ExamTask> tempTasks = new List<ExamTask>();
            List<string> tempFiles = new List<string>();

            FilterTasks(out tempTasks, out tempFiles);

            if (tempTasks != null)
            {
                loadDGV(tempTasks);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted("Task");
                return;
            }
            string selTaskID = dgvTaskCollection.CurrentRow.Cells["txtTaskID"].Value.ToString();
            int index = tasks.FindIndex(exam => exam.Task_ID == selTaskID);
            ExamTask selTask = tasks[index];

            frmInfoTasks frmShow = new frmInfoTasks();
            frmShow.LoadInfo(selTask);
            FormHandler(frmShow, showDialog: true);
        }

        private void txtFilterName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Filter Tasks by Name");
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Open Task Filter Options");
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Edit Task");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Delete Task");
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Task Information");
        }
    }
}
