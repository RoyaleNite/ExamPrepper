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
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Forms.QuestionPreperation.frmSetupSubjectFilter;
using static ExamPrepper.Classes.Notifications;

namespace ExamPrepper.Forms.QuestionPreperation
{
    public partial class frmQuizSetup : Form
    {

        #region Form Variables
        private int taskSelected = 0;
        private List<ExamTask> tasks = new List<ExamTask>();

        private List<string> filterQueTypes = new List<string>();
        public List<string> filterSubjects = new List<string> { "" };

        public List<ExamTask> selectTasks;
        public string selectFilePath;

        public List<string> selTaskIDs = new List<string>();

        private bool loaded = false;

        #region Error Messages
        private string errmsg_NotEnoughTasks(int taskCount, int requestedCount) => $"There are not enough tasks to create the random quiz. There are only {taskCount} tasks, {requestedCount} was the number you entered.\n\n Do you want the number of tasks to be corrected?";
        private string errmsg_NoName = $"Quiz name has not been entered, are you sure you do not want to give the quiz a name?";
        private string errmsg_ConfirmEdit = "Are you sure you want to edit this quiz?";
        private string errmsg_NoTasks = "No tasks were selected, please select at least one task.";
        #endregion Error Messages

        #endregion Form Variables

        public frmQuizSetup()
        {
            InitializeComponent();
        }

        private void frmQuizSetup_Shown(object sender, EventArgs e)
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
                        //files.Add(file);
                        tasks.Add(JSONToData<ExamTask>(file));
                    }
                }
            }

            List<Subject> subjects = JSONToData<List<Subject>>("./Data/Subjects.json");
            subjects.ForEach(sub => filterSubjects.Add(sub.SubjectID));

            var types = Enum.GetValues(typeof(QuestionTypeList));

            foreach (var type in types)
            {
                filterQueTypes.Add(type.ToString());
            }

            loadDGV(tasks);//, files);

            if (selectTasks != null)
            {
                List<string> ids = new List<string>();
                foreach (var task in selectTasks)
                {
                    ids.Add(task.Task_ID);
                }

                foreach (DataGridViewRow row in dgvTasks.Rows)
                {
                    if (ids.Contains(row.Cells["Task_ID"].Value.ToString()))
                    {
                        row.Cells["dgvAddedCbx"].Value = "true";
                    }
                }
            }

            loaded = true;
        }

        #region Data Operations
        private void loadDGV(List<ExamTask> data)//, List<string> filePaths)
        {
            loaded = false;
            //Setting DGV Button captions and loading DGV with DATA
            List<string> buttonCaps = new List<string>() { };
            LoadData(ref dgvTasks, data, buttonCaps);
            taskSelected = 0;
            //If there is no data return
            if (data.Count == 0)
            {
                txtTasksSelected.Text = taskSelected.ToString();
                loaded = true;
                return;
            }

            //Creating a CheckBox for DGV to check added tasks
            var cbxAdded = new DataGridViewCheckBoxColumn();
            cbxAdded.Name = $"dgvAddedCbx";
            cbxAdded.HeaderText = "";
            cbxAdded.IndeterminateValue = true;
            dgvTasks.Columns.Insert(0, cbxAdded);

            //Creating a textfield for DGV for task subject names
            var txtSubjectName = new DataGridViewTextBoxColumn();
            txtSubjectName.Name = $"txtSubjectName";
            txtSubjectName.HeaderText = "Subject";
            dgvTasks.Columns.Add(txtSubjectName);

            //Creating a textfield for DGV for task question types
            var txtQueType = new DataGridViewTextBoxColumn();
            txtQueType.Name = $"txtQueType";
            txtQueType.HeaderText = "Question";
            dgvTasks.Columns.Add(txtQueType);
            //Settings created DGV field values
            for (int i = 0; i < data.Count; i++)
            {
                dgvTasks.Rows[i].Cells["txtSubjectName"].Value = tasks[i].Task_Subject.Name;
                dgvTasks.Rows[i].Cells["txtQueType"].Value = tasks[i].GetQuestion().QuestionType;
                if (selTaskIDs.Contains(tasks[i].Task_ID))
                {
                    taskSelected++;
                    dgvTasks.Rows[i].Cells["dgvAddedCbx"].Value = "true";
                }
                else
                {
                    dgvTasks.Rows[i].Cells["dgvAddedCbx"].Value = "false";
                }
            }

            //Configuring DGV Columns
            dgvTasks.Columns["dgvAddedCbx"].Width = 30;
            dgvTasks.Columns["Task_ID"].Visible = false;
            dgvTasks.Columns["Task_Subject"].Visible = false;
            dgvTasks.Columns["Task_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTasks.Columns["txtSubjectName"].Width = 150;
            dgvTasks.Columns["txtQueType"].Width = 150;
            dgvTasks.Font = txtFilterName.Font;

            txtTasksSelected.Text = taskSelected.ToString();
            loaded = true;
        }
        #endregion Tasks Operations

        #region DataGridView Options
        private void dgvTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!loaded) return;
            //Returning if no cells were selected
            if (e.RowIndex == dgvTasks.NewRowIndex || e.RowIndex < 0)
                return;

            //Testing Checkbox value
            if (e.ColumnIndex == dgvTasks.Columns["dgvAddedCbx"].Index)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvTasks.Rows[e.RowIndex].Cells["dgvAddedCbx"];
                try
                {
                    if ((bool)chk.Value == true)
                    {
                        taskSelected++;
                        selTaskIDs.Add(dgvTasks.Rows[e.RowIndex].Cells["Task_ID"].Value.ToString());
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                    }
                    else if ((bool)chk.Value == false)
                    {
                        taskSelected--;
                        selTaskIDs.Remove(dgvTasks.Rows[e.RowIndex].Cells["Task_ID"].Value.ToString());
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
                catch
                {
                    if (chk.Value == "true")
                    {
                        taskSelected++;
                        selTaskIDs.Add(dgvTasks.Rows[e.RowIndex].Cells["Task_ID"].Value.ToString());
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                    }
                    else if (chk.Value == "false")
                    {
                        taskSelected--;
                        selTaskIDs.Remove(dgvTasks.Rows[e.RowIndex].Cells["Task_ID"].Value.ToString());
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                txtTasksSelected.Text = taskSelected.ToString();
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Commiting when CheckBox is clicked
            dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        #endregion DataGridView Options

        #region Quiz Generation
        private Exam generateData()
        {
            List<ExamTask> quizTasks = new List<ExamTask>();

            foreach (ExamTask task in tasks)
            {
                if (selTaskIDs.Contains(task.Task_ID))
                {
                    quizTasks.Add(task);
                }
            }

            ExamInfo examInfo = new ExamInfo()
            {
                Exam_Name = txtName.Text,
            };

            List<ExamSection> examSections = new List<ExamSection>() { new ExamSection("Quiz", quizTasks) };

            Exam exam = new Exam(examInfo, examSections);
            return exam;
        }

        private void CreateQuiz(Exam exam)
        {
            string seedText = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            string subject = filterSubjects.Count > 1 ? "Combination" : filterSubjects[0];
            string subjectFolder = $"{Default.Quiz_Storage_Path}/{subject}";
            if (!Directory.Exists(subjectFolder)) Directory.CreateDirectory(subjectFolder);
            DataToJSON(exam, $"{subjectFolder}/{seedText}.json");
        }
        #endregion Quiz Generation

        #region ButtonClick Events
        private void btnMore_Click(object sender, EventArgs e)
        {
            //Opening form with filters
            frmSetupSubjectFilter showFrm = new frmSetupSubjectFilter();
            showFrm.selSub = filterSubjects;
            showFrm.selTypes = filterQueTypes;
            FormHandler(showFrm, showDialog: true);
            filterSubjects = showFrm.selSub;
            filterQueTypes = showFrm.selTypes;

            List<ExamTask> filtTask = new List<ExamTask>();
            List<string> filtFiles = new List<string>();

            //Filtering tasks according to filters selected

            FilterTasks(tasks, out filtTask, filterSubjects, filterQueTypes);

            loadDGV(filtTask);
        }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            #region Error Checking
            if ((int)nudAmount.Value > dgvTasks.Rows.Count)
            {
                DialogResult result = MessageBox.Show(errmsg_NotEnoughTasks(dgvTasks.Rows.Count, (int)nudAmount.Value), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    nudAmount.Value = dgvTasks.Rows.Count;
                }
                return;
            }
            #endregion Error Checking

            //Selecting all tasks
            for (int i = 0; i < dgvTasks.Rows.Count; i++)
            {
                dgvTasks.Rows[i].Cells["dgvAddedCbx"].Value = "true";
            }

            Exam exam = generateData();
            CreateQuiz(exam);

            //Randomizing all tasks
            Random _rand = new Random();
            exam.Sections[0].Section_Tasks = exam.Sections[0].Section_Tasks.OrderBy(_ => _rand.Next()).ToList();

            List<ExamTask> randtasks = new List<ExamTask>();

            //Selecting only the correct amount of tasks
            for (int a = 0; a < (int)nudAmount.Value; a++)
            {
                randtasks.Add(exam.Sections[0].Section_Tasks[a]);
            }

            List<ExamSection> examSections = new List<ExamSection>() { new ExamSection("Quiz", randtasks) };

            Exam finalExam = new Exam(exam.Exam_Info, examSections);
            CreateQuiz(finalExam);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region "Erorr Checking"
            if (txtName.Text == "")
            {
                DialogResult result = MessageBox.Show(errmsg_NoName, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    txtName.Focus();
                    return;
                }
            }
            if (taskSelected == 0)
            {
                DialogResult result = MessageBox.Show(errmsg_NoTasks, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            #endregion "Erorr Checking"
            if (btnCreate.Text == "Edit Quiz")
            {
                DialogResult result = MessageBox.Show(errmsg_ConfirmEdit, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    EditInJSON(generateData(), selectFilePath);
                }
            }
            else
            {
                Exam exam = generateData();
                CreateQuiz(exam);
                CloseForm(this);
                ShowSuccess(mainForm, "Quiz");
            }
        }
        #endregion ButtonClick Events

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            List<ExamTask> filtTasks = new List<ExamTask>();
            List<string> filtFiles = new List<string>();

            FilterTasks(tasks, out filtTasks, filterSubjects, filterQueTypes);

            List<ExamTask> filterTasks = new List<ExamTask>();
            List<string> filterFiles = new List<string>();

            for (int a = 0; a < filtTasks.Count(); a++)
            {
                if (filtTasks[a].Task_Name.ToUpper().Contains(txtFilterName.Text.ToUpper()))
                {
                    filterTasks.Add(filtTasks[a]);
                    filterFiles.Add(filtFiles[a]);
                };
            }

            loadDGV(filterTasks);
        }

        private void frmQuizSetup_Load(object sender, EventArgs e)
        {

        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Quiz Name");
        }

        private void txtFilterName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Quiz Name Filter");
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Open Task Filter Options");
        }

        private void txtTasksSelected_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Amount of Tasks Selected");
        }

        private void btnGenerateRandom_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Generate a random quiz based on the number of tasks the user specified");
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Create Quiz");
        }
    }
}
