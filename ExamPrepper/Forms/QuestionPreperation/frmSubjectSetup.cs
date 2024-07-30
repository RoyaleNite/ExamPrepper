using ExamPrepper.Classes;
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
using static ExamPrepper.Classes.Notifications;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper.Forms
{
    public partial class frmSubjectSetup : Form
    {
        private string selSubID;
        private string selSubName;

        #region "Error Messages"
        private string errmsg_NoName = "Subject name cannot be empty.";
        private string errmsg_NoDescription = "Subject description cannot be empty.";
        private string errmsg_ConfirmEdit(string selSub) => $"Are you sure you want to edit {selSub}";
        #endregion "Error Messages"

        public frmSubjectSetup()
        {
            InitializeComponent();
        }

        private void frmSubjectSetup_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            #region "Erorr Checking"
            if (txtName.Text == "")
            {
                MessageBox.Show(errmsg_NoName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (rtbDescription.Text == "")
            {
                MessageBox.Show(errmsg_NoDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbDescription.Focus();
                return;
            }
            #endregion "Erorr Checking"

            //Testing to add or edit item in database
            if (btnAddEdit.Text == "Add Subject")
            {
                string id = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
                Subject addSub = new Subject(id, txtName.Text, rtbDescription.Text);

                AddToJSON(addSub, "./Data/Subjects.json");
            }
            else if (btnAddEdit.Text == "Confirm Edit")
            {
                //Getting dialog result if user wants to edit item
                DialogResult result = MessageBox.Show(errmsg_ConfirmEdit(selSubName), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    //Editing item in database and refreshing the form
                    Subject editSub = new Subject(selSubID, txtName.Text, rtbDescription.Text);
                    List<Subject> subs = JSONToData<List<Subject>>("./Data/Subjects.json");
                    subs[subs.FindIndex(sub => sub.SubjectID == editSub.SubjectID)] = editSub;
                    EditInJSON(subs, "./Data/Subjects.json");

                    this.Refresh();
                    LoadDataGrid();
                }

                //Resettings text boxes if user did or did not edit item
                btnAddEdit.Text = "Add Subject";
            }
            LoadDataGrid();
            ShowSuccess(this, "Subject");
            txtName.Text = string.Empty;
            rtbDescription.Clear();
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Returning if no cells were selected
            if (e.RowIndex == dgvSubjects.NewRowIndex || e.RowIndex < 0)
                return;

            //Getting Selected item ID and Name for use
            selSubID = (string)dgvSubjects.Rows[e.RowIndex].Cells["SubjectID"].Value;
            selSubName = (string)dgvSubjects.Rows[e.RowIndex].Cells["Name"].Value;

            //Testing if the delete button has been pressed
            if (e.ColumnIndex == dgvSubjects?.Columns["dgvDeletebtn"].Index)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {dgvSubjects.Rows[e.RowIndex].Cells["Name"].Value.ToString()}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Subject delSub = new Subject(selSubID, txtName.Text, rtbDescription.Text);
                    RemoveFromJSON(delSub, "./Data/Subjects.json");

                    this.Refresh();
                    LoadDataGrid();
                }
            }

            //Testing if the edit button has been pressed
            if (e.ColumnIndex == dgvSubjects?.Columns["dgvEditbtn"].Index)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to edit {dgvSubjects.Rows[e.RowIndex].Cells["Name"].Value.ToString()}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    txtName.Text = selSubName;
                    rtbDescription.Text = (string)dgvSubjects.Rows[e.RowIndex].Cells["Description"].Value;
                    btnAddEdit.Text = "Confirm Edit";
                    txtName.Focus();
                }
            }
        }

        private void LoadDataGrid()
        {
            List<Subject> subjects = JSONToData<List<Subject>>("./Data/Subjects.json");

            List<string> btnCaps = new List<string>()
            {
                "Edit",
                "Delete"
            };

            if (subjects?.Count == 0) return;

            LoadData<Subject>(ref dgvSubjects, subjects, btnCaps);

            //Hiding SubjectID and Editing columns/Font
            dgvSubjects.Columns["SubjectID"].Visible = false;
            dgvSubjects.Columns["Name"].Width = 175;
            dgvSubjects.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubjects.Font = new Font(dgvSubjects.Font.Name, 12, FontStyle.Bold);
            dgvSubjects.Refresh();
            this.Refresh();
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Subject Name");
        }

        private void rtbDescription_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Subject Description");
        }

        private void btnAddEdit_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Add Subject");
        }
    }
}
