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
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper
{
    public partial class ucSection : UserControl
    {
        public List<string> queTypes = new List<string>();
        public List<ExamTask> tasks = new List<ExamTask>();

        public List<string> selTaskIDs = new List<string>();

        private int taskSelected = 0;
        public bool loaded = false;

        public ucSection()
        {
            InitializeComponent();
        }

        private TabPage getParent()
        {
            return this.Parent as TabPage;
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            TabPage page = getParent();
            page.Dispose();
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {
            TabPage page = getParent();
            page.Text = txtSection.Text;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            frmSetupSubjectFilter frmFilter = new frmSetupSubjectFilter();
            frmFilter.cbxShowRandom.Visible = false;

            TableLayoutPanelCellPosition typesPos = frmFilter.tlpTaskSetupHolder.GetCellPosition(frmFilter.dgvTypes);
            TableLayoutPanelCellPosition subsPos = frmFilter.tlpTaskSetupHolder.GetCellPosition(frmFilter.dgvSubjects);

            frmFilter.tlpTaskSetupHolder.SetCellPosition(frmFilter.dgvSubjects, typesPos);
            frmFilter.tlpTaskSetupHolder.SetCellPosition(frmFilter.dgvTypes, subsPos);

            frmFilter.dgvSubjects.Visible = false;

            frmFilter.selSub = new List<string>();
            frmFilter.selTypes = queTypes;

            frmFilter.tlpTaskSetupHolder.SetColumnSpan(frmFilter.dgvTypes, 3);

            FormHandler(frmFilter, showDialog: true);

            queTypes = frmFilter.selTypes;
            List<ExamTask> filtTasks = filterTasks(tasks);

            LoadDGV(filtTasks);
        }

        private List<ExamTask> filterTasks(List<ExamTask> tasks)
        {
            List<ExamTask> filtTasks = new List<ExamTask>();
            foreach (ExamTask task in tasks)
            {
                if (queTypes.Contains(task.GetQuestion().QuestionType))
                {
                    filtTasks.Add(task);
                }
            }
            return filtTasks;
        }

        private void ucSection_Load(object sender, EventArgs e)
        {
            var types = Enum.GetValues(typeof(QuestionTypeList));

            foreach (var type in types)
            {
                queTypes.Add(type.ToString());
            }

            loaded = true;
        }

        public List<ExamTask> getTasks(string subjectID)
        {
            string storagePath = $"{Default.Task_Storage_Path}/{subjectID}";

            string[] questionTypes = Directory.GetDirectories(storagePath);
            List<ExamTask> taskFiles = new List<ExamTask>();

            foreach (string type in questionTypes)
            {
                foreach (string file in Directory.GetFiles(type))
                {
                    taskFiles.Add(JSONToData<ExamTask>(file));
                }
            }
            tasks = taskFiles;
            return taskFiles;
        }

        public void LoadDGV(List<ExamTask> tasks)
        {
            loaded = false;
            taskSelected = 0;
            dgvTasks.Rows.Clear();
            dgvTasks.Columns.Clear();
            dgvTasks.AllowUserToAddRows = true;

            //Creating a CheckBox for DGV to check added tasks
            var cbxAdded = new DataGridViewCheckBoxColumn();
            cbxAdded.Name = $"dgvAddedCbx";
            cbxAdded.HeaderText = "";
            cbxAdded.IndeterminateValue = true;
            dgvTasks.Columns.Insert(0, cbxAdded);

            //Creating a textfield for DGV for task question types
            var txtTaskName = new DataGridViewTextBoxColumn();
            txtTaskName.Name = $"txtTaskName";
            txtTaskName.HeaderText = "Task Name";
            dgvTasks.Columns.Add(txtTaskName);

            //Creating a textfield for DGV for task question types
            var txtTaskID = new DataGridViewTextBoxColumn();
            txtTaskID.Name = $"txtTaskID";
            txtTaskID.HeaderText = "";
            dgvTasks.Columns.Add(txtTaskID);

            //Creating a textfield for DGV for task question types
            var txtQueType = new DataGridViewTextBoxColumn();
            txtQueType.Name = $"txtQueType";
            txtQueType.HeaderText = "Question";
            dgvTasks.Columns.Add(txtQueType);

            //Settings created DGV field values
            for (int i = 0; i < tasks.Count; i++)
            {
                dgvTasks.Rows.Add((DataGridViewRow)dgvTasks.Rows[0].Clone());
                dgvTasks.Rows[i].Cells["txtTaskName"].Value = tasks[i].Task_Name;
                dgvTasks.Rows[i].Cells["txtQueType"].Value = tasks[i].GetQuestion().QuestionType;
                dgvTasks.Rows[i].Cells["txtTaskID"].Value = tasks[i].Task_ID;
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
            dgvTasks.Columns["txtTaskName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTasks.Columns["txtQueType"].Width = 150;
            dgvTasks.Columns["txtTaskID"].Visible = false;

            dgvTasks.AllowUserToAddRows = false;

            txtTasksSelected.Text = taskSelected.ToString();
            loaded = true;
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Commiting when CheckBox is clicked
            dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

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
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        selTaskIDs.Add(dgvTasks.Rows[e.RowIndex].Cells["txtTaskID"].Value.ToString());
                    }
                    else if ((bool)chk.Value == false)
                    {
                        taskSelected--;
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        selTaskIDs.Remove(dgvTasks.Rows[e.RowIndex].Cells["txtTaskID"].Value.ToString());
                    }
                }
                catch
                {
                    if (chk.Value == "true")
                    {
                        taskSelected++;
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                        selTaskIDs.Add(dgvTasks.Rows[e.RowIndex].Cells["txtTaskID"].Value.ToString());
                    }
                    else if (chk.Value == "false")
                    {
                        taskSelected--;
                        dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        selTaskIDs.Remove(dgvTasks.Rows[e.RowIndex].Cells["txtTaskID"].Value.ToString());
                    }
                }

                txtTasksSelected.Text = taskSelected.ToString();
            }
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            List<ExamTask> filtTasks = filterTasks(tasks);
            List<ExamTask> nameFilter = new List<ExamTask>();
            foreach (ExamTask task in filtTasks)
            {
                if (task.Task_Name.ToUpper().Contains(txtFilterName.Text.ToUpper()))
                {
                    nameFilter.Add(task);
                }
            }
            LoadDGV(nameFilter);
        }

        private void txtSection_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Section Name");
        }

        private void txtFilterName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Filter Tasks by Name");
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Open Task Filtering Options");
        }

        private void dgvTasks_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as DataGridView, "Tasks View");
        }
    }
}
