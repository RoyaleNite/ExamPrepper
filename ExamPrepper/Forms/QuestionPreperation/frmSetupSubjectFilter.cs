using ExamPrepper.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper.Forms.QuestionPreperation
{
    public partial class frmSetupSubjectFilter : Form
    {
        public List<string> selSub;
        public List<string> selTypes;

        private bool loaded = false;

        public string type = "";

        public frmSetupSubjectFilter()
        {
            InitializeComponent();
        }

        private void frmSetupSubjectFilter_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = JSONToData<List<Subject>>("./Data/Subjects.json");
            LoadData(ref dgvSubjects, subjects, new List<string>(), false);

            var cbxAdded = new DataGridViewCheckBoxColumn();
            cbxAdded.Name = $"dgvAddedCbx";
            cbxAdded.HeaderText = "";
            cbxAdded.IndeterminateValue = true;
            dgvSubjects.Columns.Insert(0, cbxAdded);

            if (subjects?.Count > 0)
            {
                for (int i = 0; i < dgvSubjects.Rows.Count; i++)
                {
                    if (selSub.Contains(dgvSubjects.Rows[i].Cells["SubjectID"].Value.ToString()))
                        dgvSubjects.Rows[i].Cells["dgvAddedCbx"].Value = "true";
                }

                dgvSubjects.Columns["SubjectID"].Visible = false;
                dgvSubjects.Columns["Description"].Visible = false;
                dgvSubjects.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSubjects.Columns["dgvAddedCbx"].Width = 30;
            }

            var types = Enum.GetValues(typeof(QuestionTypeList));

            var cbxAddedType = new DataGridViewCheckBoxColumn();
            cbxAddedType.Name = $"dgvAddedCbx";
            cbxAddedType.HeaderText = "";
            cbxAddedType.IndeterminateValue = true;
            dgvTypes.Columns.Add(cbxAddedType);

            DataGridViewTextBoxColumn txtTypes = new DataGridViewTextBoxColumn();
            txtTypes.Name = "txtTypes";
            txtTypes.HeaderText = "Question Type"; ;
            dgvTypes.Columns.Add(txtTypes);

            int a = 0;
            dgvTypes.AllowUserToAddRows = true;
            foreach (var type in types)
            {
                dgvTypes.Rows.Add((DataGridViewRow)dgvTypes.Rows[0].Clone());
                dgvTypes.Rows[a].Cells["txtTypes"].Value = type.ToString();
                if (selTypes.Contains(dgvTypes.Rows[a].Cells["txtTypes"].Value.ToString()))
                    dgvTypes.Rows[a].Cells["dgvAddedCbx"].Value = "true";
                a++;
            }
            dgvTypes.AllowUserToAddRows = false;
            dgvTypes.Columns["txtTypes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTypes.Columns["dgvAddedCbx"].Width = 30;
            loaded = true;

            if (type != "Quiz")
            {
                cbxShowRandom.Visible = false;
                tlpTaskSetupHolder.RowStyles[tlpTaskSetupHolder.RowCount - 2] = new RowStyle(SizeType.Absolute, 0);
            }
        }

        public static void FilterTasks(List<ExamTask> tasks, out List<ExamTask> filteredTasks, List<string> filterSubjects, List<string> QueType)
        {
            List<ExamTask> tempTasks = new List<ExamTask>();
            int counter = 0;

            //Iterating through tasks and comparing them with the filter requirements
            tasks.ForEach(task =>
            {
                if (filterSubjects.Contains(task.Task_Subject.SubjectID) && QueType.Contains(task.GetQuestion().QuestionType))
                {
                    //Adding tasks if the meet the filter requirements
                    tempTasks.Add(task);
                }
                counter++;
            });
            filteredTasks = tempTasks;
        }

        private void dgvSubjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //Returning if no cells were selected
            if (e.RowIndex == dgvSubjects.NewRowIndex || e.RowIndex < 0)
                return;

            //Testing Checkbox value
            if (e.ColumnIndex == dgvSubjects.Columns["dgvAddedCbx"].Index)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvSubjects.Rows[e.RowIndex].Cells["dgvAddedCbx"];
                try
                {
                    if ((bool)chk.Value == true)
                    {
                        dgvSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        if (loaded) selSub.Add(dgvSubjects.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString());
                    }
                    else
                    {
                        dgvSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        int index = selSub.FindIndex(sub => sub == dgvSubjects.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString());
                        if (loaded) if (index != -1) selSub.RemoveAt(index);
                    }
                }
                catch
                {
                    if (chk.Value == "true")
                    {
                        dgvSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        if (loaded) selSub.Add(dgvSubjects.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString());
                    }
                    else
                    {
                        dgvSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        int index = selSub.FindIndex(sub => sub == dgvSubjects.Rows[e.RowIndex].Cells["SubjectID"].Value.ToString());
                        if (loaded) if (index != -1) selSub.RemoveAt(index);
                    }
                }

            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSubjects.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSubjects.Rows.Count; i++)
            {
                dgvSubjects.Rows[i].Cells["dgvAddedCbx"].Value = "true";
            }
            for (int i = 0; i < dgvTypes.Rows.Count; i++)
            {
                dgvTypes.Rows[i].Cells["dgvAddedCbx"].Value = "true";
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSubjects.Rows.Count; i++)
            {
                dgvSubjects.Rows[i].Cells["dgvAddedCbx"].Value = "false";
            }
            for (int i = 0; i < dgvTypes.Rows.Count; i++)
            {
                dgvTypes.Rows[i].Cells["dgvAddedCbx"].Value = "false";
            }

        }

        private void dgvTypes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Returning if no cells were selected
            if (e.RowIndex == dgvTypes.NewRowIndex || e.RowIndex < 0)
                return;

            //Testing Checkbox value
            if (e.ColumnIndex == dgvTypes.Columns["dgvAddedCbx"].Index)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvTypes.Rows[e.RowIndex].Cells["dgvAddedCbx"];
                try
                {
                    if ((bool)chk.Value == true)
                    {
                        dgvTypes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        if (loaded) selTypes.Add(dgvTypes.Rows[e.RowIndex].Cells["txtTypes"].Value.ToString());
                    }
                    else
                    {
                        dgvTypes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        int index = selTypes.FindIndex(sub => sub == dgvTypes.Rows[e.RowIndex].Cells["txtTypes"].Value.ToString());
                        if (loaded) if (index != -1) selTypes.RemoveAt(index);
                    }
                }
                catch
                {
                    if (chk.Value == "true")
                    {
                        dgvTypes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        if (loaded) selTypes.Add(dgvTypes.Rows[e.RowIndex].Cells["txtTypes"].Value.ToString());
                    }
                    else
                    {
                        dgvTypes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        int index = selTypes.FindIndex(sub => sub == dgvTypes.Rows[e.RowIndex].Cells["txtTypes"].Value.ToString());
                        if (loaded) if (index != -1) selTypes.RemoveAt(index);
                    }
                }
            }
        }

        private void dgvTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTypes.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Deselect All Filters");
        }

        private void btnSelectAll_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Select All Filters");
        }

        private void dgvSubjects_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as DataGridView, "All Subjects");
        }

        private void dgvTypes_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as DataGridView, "All Question Types");
        }
    }
}
