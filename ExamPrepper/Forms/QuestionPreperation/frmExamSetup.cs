using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.Classes.Notifications;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper.Forms.QuestionPreperation
{
    public partial class frmExamSetup : Form
    {
        #region Form Variables
        public List<Subject> subjects = new List<Subject>();
        public string selectFilePath;
        public string selectSubject;

        public Exam preExam;

        #region Error Messages
        private string errmsg_NoSubjectSelected = $"No subject has been selected, please select a subject for the exam before adding sections.";
        private string errmsg_NoTaskInSection(string section) => $"No tasks have been selected for section {section}, select atleast ones task per a section.";
        private string errmsg_ChangingSubject = "Caution, changing the subject of the exam will result in all sections and data being cleared.";
        private string errmsg_NoName = $"Exam name has not been entered, are you sure you do not want to give the exam a name?";
        private string errmsg_ConfirmEdit = "Are you sure you want to edit this exam?";
        private string errmsg_NoSections = "No sections were created, create atleast one section.";
        private string errmsg_NoTasks = "No tasks were selected, please select at least one task.";
        #endregion Error Messages

        #endregion Form Variables

        public frmExamSetup()
        {
            InitializeComponent();
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
            Exam exam = generateData();
            if (exam.Sections?.Count == 0)
            {
                DialogResult result = MessageBox.Show(errmsg_NoSections, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (exam.Sections.Find(sec => sec.Section_Tasks?.Count == 0) != null)
            {
                DialogResult result = MessageBox.Show(errmsg_NoTasks, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            #endregion "Erorr Checking"

            if (btnCreate.Text == "Create Exam")
            {

                string seedText = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
                string subjectFolder = $"{Default.Exam_Storage_Path}/{cbxSelectSubject.SelectedItem}";
                if (!Directory.Exists(subjectFolder)) Directory.CreateDirectory(subjectFolder);
                DataToJSON(exam, $"{subjectFolder}/{seedText}.json");
                CloseForm(this);
                ShowSuccess(mainForm, "Exam");
            }
            else
            {
                DialogResult result = MessageBox.Show(errmsg_ConfirmEdit, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    return;
                }
                EditInJSON(exam, selectFilePath);
            }
        }

        public Exam generateData()
        {
            List<ExamSection> sections = new List<ExamSection>();

            foreach (TabPage page in tbcSectionTasks.TabPages)
            {
                ucSection sec = page.Controls[0] as ucSection;

                List<ExamTask> examTasks = new List<ExamTask>();

                foreach (ExamTask task in sec.tasks)
                {
                    if (sec.selTaskIDs.Contains(task.Task_ID))
                    {
                        examTasks.Add(task);
                    }
                }

                if (examTasks.Count == 0)
                {
                    MessageBox.Show(errmsg_NoTaskInSection(page.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    page.Show();
                    break;
                }

                ExamSection section = new ExamSection(page.Text, examTasks);
                sections.Add(section);
            }

            ExamInfo examInfo = new ExamInfo(txtName.Text);
            Exam exam = new Exam(examInfo, sections);
            return exam;
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if (cbxSelectSubject.SelectedIndex == -1)
            {
                MessageBox.Show(errmsg_NoSubjectSelected, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxSelectSubject.Focus();
                return;
            }

            addSection();
        }

        public void addSection()
        {
            ucSection sec = new ucSection();
            sec.Dock = DockStyle.Fill;
            sec.Padding = new Padding(3, 3, 3, 3);

            sec.LoadDGV(sec.getTasks(subjects[cbxSelectSubject.SelectedIndex].SubjectID));

            TabPage tempPage = new TabPage();
            tempPage.Controls.Add(sec);
            tempPage.Text = $"Section {tbcSectionTasks.TabPages.Count + 1}";
            tempPage.BackColor = Color.Silver;
            tbcSectionTasks.TabPages.Add(tempPage);
        }

        private void frmExamSetup_Load(object sender, EventArgs e)
        {
            subjects = JSONToData<List<Subject>>("./Data/Subjects.json");
            foreach (Subject subject in subjects)
            {
                cbxSelectSubject.Items.Add(subject.Name);
            }
        }

        private void LoadPagesDGV()
        {
            foreach (TabPage page in tbcSectionTasks.TabPages)
            {
                ucSection tempSec = page.Controls[0] as ucSection;
                tempSec.LoadDGV(tempSec.getTasks(subjects[cbxSelectSubject.SelectedIndex].SubjectID));
            }
        }

        private void cbxSelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPagesDGV();
        }

        private void cbxSelectSubject_DropDown(object sender, EventArgs e)
        {
            if (cbxSelectSubject.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show(errmsg_ChangingSubject, "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    cbxSelectSubject.SelectedIndex = cbxSelectSubject.SelectedIndex;
                }
            }
        }

        private void frmExamSetup_Shown(object sender, EventArgs e)
        {
            if (selectSubject != null)
            {
                cbxSelectSubject.SelectedIndex = cbxSelectSubject.Items.IndexOf(selectSubject);
                LoadPagesDGV();
            }

            if (preExam != null)
            {
                int index = 0;

                foreach (ExamSection sec in preExam.Sections)
                {
                    addSection();
                    tbcSectionTasks.TabPages[index].Text = sec.Section;
                    ucSection ucSec = tbcSectionTasks.TabPages[index].Controls[0] as ucSection;
                    ucSec.txtSection.Text = sec.Section;
                    foreach (ExamTask task in sec.Section_Tasks)
                    {
                        ucSec.selTaskIDs.Add(task.Task_ID);
                    }
                    ucSec.LoadDGV(ucSec.tasks);
                    index++;
                }
            }
        }

        private void btnAddSection_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Add an Exam Section");
        }

        private void cbxSelectSubject_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as ComboBox, "Exam Subject");
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Exam Name");
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Create Exam");
        }
    }
}
