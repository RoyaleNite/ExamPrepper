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
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.frmMainForm;
using ExamPrepper.Forms.QuestionPreperation;
using ExamPrepper.Forms.TaskCollectionForm;
using System.IO.Compression;

namespace ExamPrepper.Forms
{
    public partial class frmViewTaskCollection : Form
    {
        private string type = "";
        public List<Exam> taskCollection = new List<Exam>();
        public List<string> filePaths = new List<string>();
        public List<string> subjectTypes = new List<string>();

        private List<string> filterQueTypes = new List<string>();
        public List<string> filterSubjects = new List<string> { "" };
        private string errmsg_NoResults(string type) => $"The selected {type} does not have any results.";

        public frmViewTaskCollection()
        {
            InitializeComponent();
        }

        private void frmViewTaskCollection_Load(object sender, EventArgs e)
        {

            if (taskCollection.Count == 0) return;

            type = taskCollection[0].isExam() ? "Exam" : "Quiz";

            btnDo.Text = $"Do {type}";

            List<Subject> subjects = JSONToData<List<Subject>>("./Data/Subjects.json");
            subjects.ForEach(sub => filterSubjects.Add(sub.SubjectID));

            var types = Enum.GetValues(typeof(QuestionTypeList));

            foreach (var type in types)
            {
                filterQueTypes.Add(type.ToString());
            }

            //List<Exam> tempExams = new List<Exam>();
            //List<string> tempFiles = new List<string>();
            //List<string> tempSubjects = new List<string>();

            //FilterExams(out tempExams, out tempFiles, out tempSubjects);

            if (taskCollection != null)
            {
                LoadDGV(taskCollection, filePaths, subjectTypes);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }

            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            Exam selExam = taskCollection[index];

            if (!selExam.isExam())
            {
                frmQuizSetup frmShow = new frmQuizSetup();
                frmShow.selectTasks = selExam.Sections[0].Section_Tasks;
                frmShow.btnCreate.Text = "Edit Quiz";
                frmShow.selectFilePath = filePaths[index];
                frmShow.txtName.Text = selExam.Exam_Info.Exam_Name;
                FormHandler(frmShow);
            }
            else
            {
                frmExamSetup frmShow = new frmExamSetup();
                frmShow.btnCreate.Text = "Edit Exam";
                frmShow.selectFilePath = filePaths[index];
                frmShow.txtName.Text = selExam.Exam_Info.Exam_Name;
                frmShow.selectSubject = selExam.Sections[0].Section_Tasks[0].Task_Subject.Name;
                frmShow.preExam = selExam;

                FormHandler(frmShow);
            }
            if (taskCollection != null)
            {
                List<Exam> tempExams = new List<Exam>();
                List<string> tempFiles = new List<string>();
                List<string> tempSubjects = new List<string>();

                FilterExams(out tempExams, out tempFiles, out tempSubjects);
                LoadDGV(tempExams, tempFiles, tempSubjects);
            }
        }

        private Exam getSelectedExam()
        {
            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            return taskCollection[index];
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

            List<Exam> tempExams = new List<Exam>();
            List<string> tempFiles = new List<string>();
            List<string> tempSubjects = new List<string>();

            FilterExams(out tempExams, out tempFiles, out tempSubjects);

            if (tempExams != null)
            {
                LoadDGV(tempExams, tempFiles, tempSubjects);
            }
        }

        public void FilterExams(out List<Exam> exams, out List<string> files, out List<string> subjects)
        {
            int counter = 0;
            List<Exam> tempExams = new List<Exam>();
            List<string> tempFiles = new List<string>();
            List<string> tempSubjects = new List<string>();

            foreach (Exam task in taskCollection)
            {
                if (task.Sections.Find(section => section.Section_Tasks.Find(task => filterSubjects.Contains(task.Task_Subject.SubjectID) && filterQueTypes.Contains(task.GetQuestion().QuestionType)) != null) != null)
                {
                    tempExams.Add(task);
                    tempFiles.Add(filePaths[counter]);
                    tempSubjects.Add(subjectTypes[counter]);
                }
                counter++;
            }
            exams = tempExams;
            files = tempFiles;
            subjects = tempSubjects;
        }

        private void LoadDGV(List<Exam> exams, List<string> files, List<string> subjects)
        {
            dgvTaskCollection.Rows.Clear();
            dgvTaskCollection.Columns.Clear();

            dgvTaskCollection.AllowUserToAddRows = true;
            //Creating a textfield for DGV for exam id
            var txtExamID = new DataGridViewTextBoxColumn();
            txtExamID.Name = $"txtExamID";
            txtExamID.HeaderText = $"";
            dgvTaskCollection.Columns.Add(txtExamID);

            //Creating a textfield for DGV for exam name
            var txtExamName = new DataGridViewTextBoxColumn();
            txtExamName.Name = $"txtExamName";
            txtExamName.HeaderText = $"{type} Name";
            dgvTaskCollection.Columns.Add(txtExamName);

            //Creating a textfield for DGV for task subject names
            var txtExamSubject = new DataGridViewTextBoxColumn();
            txtExamSubject.Name = $"txtExamSubject";
            txtExamSubject.HeaderText = "Exam Subject";
            dgvTaskCollection.Columns.Add(txtExamSubject);

            //Creating a textfield for DGV for task subject names
            var txtSections = new DataGridViewTextBoxColumn();
            txtSections.Name = $"txtSections";
            txtSections.HeaderText = "Sections";
            dgvTaskCollection.Columns.Add(txtSections);

            //Creating a textfield for DGV for task count
            var txtTaskCount = new DataGridViewTextBoxColumn();
            txtTaskCount.Name = $"txtTaskCount";
            txtTaskCount.HeaderText = "Questions";
            dgvTaskCollection.Columns.Add(txtTaskCount);

            //Creating a textfield for DGV for task count
            var txtFilePath = new DataGridViewTextBoxColumn();
            txtFilePath.Name = $"txtFilePath";
            txtFilePath.HeaderText = "";
            dgvTaskCollection.Columns.Add(txtFilePath);

            for (int i = 0; i < exams.Count; i++)
            {
                dgvTaskCollection.Rows.Add((DataGridViewRow)dgvTaskCollection.Rows[0].Clone());
                dgvTaskCollection.Rows[i].Cells["txtExamID"].Value = exams[i].Exam_Info.Exam_ID;
                dgvTaskCollection.Rows[i].Cells["txtExamName"].Value = exams[i].Exam_Info.Exam_Name;

                int smallCount = 0;
                Exam tempExam = exams[i];

                foreach (ExamSection section in tempExam.Sections)
                {
                    smallCount += section.Section_Tasks.Count;
                }

                dgvTaskCollection.Rows[i].Cells["txtTaskCount"].Value = smallCount;
                dgvTaskCollection.Rows[i].Cells["txtExamSubject"].Value = subjects[i];
                dgvTaskCollection.Rows[i].Cells["txtFilePath"].Value = files[i];
                dgvTaskCollection.Rows[i].Cells["txtSections"].Value = exams[i].Sections.Count();
            }

            dgvTaskCollection.Columns["txtExamName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTaskCollection.Columns["txtTaskCount"].Width = 120;
            dgvTaskCollection.Columns["txtExamSubject"].Width = 170;
            dgvTaskCollection.Columns["txtExamID"].Visible = false;
            if (type != "Exam") dgvTaskCollection.Columns["txtSections"].Visible = false;
            else dgvTaskCollection.Columns["txtSections"].Width = 120;
            dgvTaskCollection.Columns["txtFilePath"].Visible = false;

            dgvTaskCollection.Font = new Font(Default.FontName, 14F, FontStyle.Bold, GraphicsUnit.Point);
            dgvTaskCollection.AllowUserToAddRows = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }
            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            Exam selExam = taskCollection[index];

            File.Delete(filePaths[index]);
            dgvTaskCollection.Rows.Remove(dgvTaskCollection.CurrentRow);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }
            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            Exam selExam = taskCollection[index];

            frmInfoTaskCollection showFrm = new frmInfoTaskCollection();
            showFrm.LoadInfo(selExam);
            FormHandler(showFrm, showDialog: true);
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            List<Exam> tempExams = new List<Exam>();
            List<string> tempFiles = new List<string>();
            List<string> tempSubjects = new List<string>();

            FilterExams(out tempExams, out tempFiles, out tempSubjects);

            List<Exam> filtExam = new List<Exam>();
            List<string> filtFiles = new List<string>();
            List<string> filtSubjects = new List<string>();

            int index = 0;
            foreach (Exam exam in tempExams)
            {
                if (exam.Exam_Info.Exam_Name.ToUpper().Contains(txtFilterName.Text.ToUpper()))
                {
                    filtExam.Add(exam);
                    filtFiles.Add(tempFiles[index]);
                    filtSubjects.Add(tempSubjects[index]);
                }
                index++;
            }

            LoadDGV(filtExam, filtFiles, filtSubjects);

        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }
            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            Exam selExam = taskCollection[index];

            frmDoOptions frmShow = new frmDoOptions();
            frmShow.taskCollection = selExam;
            FormHandler(frmShow, showDialog: true);

            if (frmShow.allForms?.Count == 0) return;

            Default.ActiveSubject = subjectTypes[index];
            Default.Save();

            foreach (Form form in frmShow.allForms)
            {
                FormHandler(form, showForm: true);
            }

            FormHandler(lsActiveForms.Find(frm => frm.Name.EndsWith("0")));

            CloseForm(this);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (dgvTaskCollection.CurrentRow == null)
            {
                NoneSelcted(type);
                return;
            }
            string selExamID = dgvTaskCollection.CurrentRow.Cells["txtExamID"].Value.ToString();
            int index = taskCollection.FindIndex(exam => exam.Exam_Info.Exam_ID == selExamID);
            Exam selExam = taskCollection[index];

            string path = $"{Default.Results_Storage_Path}/{subjectTypes[taskCollection.IndexOf(selExam)]}/{selExam.Exam_Info.Exam_ID}";
            if (!Directory.Exists(path))
            {
                DialogResult result = MessageBox.Show(errmsg_NoResults(type), "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            List<Results> results = new List<Results>();
            List<string> files = Directory.GetFiles(path).ToList();

            foreach (string file in files)
            {
                results.Add(JSONToData<Results>(file));
            }

            frmResults res = new frmResults() { results = results, type = type, files = files, exam = selExam };
            res.btnView.Text += $" {type}";

            FormHandler(res);
        }

        private void txtFilterName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Filter Tasks by Name");
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Open Task Collection Filter Options");
        }

        private void dgvTaskCollection_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as DataGridView, "Task Collection View");
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Edit Task Collection");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Delete Task Collection");
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Task Collection Information");
        }

        private void btnDo_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Do Task Collection");
        }

        private void btnResults_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "View Task Collection Results");
        }
    }
}
