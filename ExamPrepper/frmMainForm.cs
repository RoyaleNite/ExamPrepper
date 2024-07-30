using ExamPrepper.Classes;
using ExamPrepper.Forms;
using ExamPrepper.Forms.QuestionForms;
using ExamPrepper.Forms.QuestionPreperation;
using ExamPrepper.Forms.QuestionSetupForm;
using ExamPrepper.Forms.TaskCollectionForm;
using ExamPrepper.Properties;
using MaterialSkin.Controls;
using System.Collections;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using static ExamPrepper.Classes.ExamFormData;

/*
 * 
 * Documentation
 * 
 * Right click item to modify item
 * Hover over input for explanation
 * 
 */

//Category Type Test Definitions, Study Units, Chapters
//

namespace ExamPrepper
{
    public partial class frmMainForm : Form
    {

        #region Error Messages
        public string errmsg_NoQuestion = "Question field cannot be empty.";
        public string errmsg_NoAnswer(string txtBox = null) => $"Answer fields cannot be empty. {txtBox} requires an answer.";
        public string errmsg_NoName = $"A name has not been entered, are you sure you do not want to give the task a name?";
        public string errmsg_ConfirmEdit = $"Are you sure you want to edit this question?";
        #endregion Error Messages

        public static List<Form> lsActiveForms = new List<Form>();
        private static int activeFormIndex = 0;

        private static List<string> otf = new List<string>()
        {
            "cfrmFillBlank",
            "cfrmMatchColumn",
            "cfrmMultiChoice",
            "cfrmQuestion",
            "cfrmTrueFalse",
            "frmUICustomization",
            "frmDataSettings",
            "frmSubjectSetup",
            "frmQuizSetup",
            "frmExamSetup",
            "frmDoOptions",
            "frmExamSetup",
            "frmViewTaskCollection",
            "frmQuestionSetup",
            "frmResultInfo",
            "frmResults",
            "frmViewTasks"
        };

        public static frmMainForm mainForm;
        //public static debugForm frmDebug;

        private static void RefreshForms()
        {
            LoggingHandler.Log("REFRESHING forms...");
            if (!ActiveForm().Name.StartsWith("c") && !ActiveForm().Name.StartsWith("q"))
            {
                if (mainForm.msExtras.Items.Find("btnPreviewForm", true).Count() > 0) mainForm.msExtras.Items.Remove(mainForm.msExtras.Items.Find("btnPreviewForm", true)[0]);
            }

            if (activeFormIndex > 0) mainForm.mstBack.Enabled = true;
            else mainForm.mstBack.Enabled = false;

            if (activeFormIndex < lsActiveForms.Count() - 1) mainForm.mstNext.Enabled = true;
            else mainForm.mstNext.Enabled = false;

            //foreach (Form frm in lsActiveForms)
            //{
            //frmDebug.rtbDebug.Text += ($"{frm.Name}\n");
            //}

            if (GetRefresh(ActiveForm()) != null) GetRefresh(ActiveForm()).PerformClick();
        }

        public static void FormHandler(Form frmShow, bool forceClose = false, bool insertForm = false, bool showDialog = false, bool showForm = true, bool closeForm = false, bool normalShow = false)
        {
            if (frmShow == null) return;
            LoggingHandler.Log("FORMHANDLER called...");

            foreach (Form frm in lsActiveForms)
            {
                if (forceClose)
                {
                    LoggingHandler.Log("Force closing all current active forms.");
                    frm.Close();
                }
            }

            if (forceClose) lsActiveForms.Clear();

            bool formExists = false;
            lsActiveForms.ForEach(frm =>
            {
                if (frm.Name == frmShow.Name) formExists = true;
            });

            if (closeForm && formExists)
            {
                lsActiveForms.Remove(frmShow);
                frmShow.Close();
                LoggingHandler.Log("Force closing form, returning to start.");
                FormHandler(lsActiveForms[0]);
                return;
            }
            else
            if (!formExists)
            {
                LoggingHandler.Log("Form does not exist in current list of active forms");

                if (normalShow)
                {
                    frmShow.Show();
                }
                else
                if (showDialog)
                {
                    lsActiveForms.Add(frmShow);
                    frmShow.ShowDialog();
                    lsActiveForms.Remove(frmShow);
                }
                else
                {
                    if (insertForm)
                    {
                        FormTemplate tempFrm = new FormTemplate();
                        lsActiveForms.Add(tempFrm);
                        lsActiveForms.Insert(activeFormIndex + 1, frmShow);
                        lsActiveForms.Remove(tempFrm);
                    }
                    else
                    {
                        lsActiveForms.Add(frmShow);
                    }
                    frmShow.MdiParent = mainForm;
                    frmShow.Dock = DockStyle.Fill;
                    frmShow.FormBorderStyle = FormBorderStyle.None;

                    if (showForm) frmShow.Show();
                }
            }
            else if (!closeForm && formExists)
            {
                LoggingHandler.Log("Form exists in current list of active form (Selecting form to show from list).");
                lsActiveForms.Find(frm => frm.Name == frmShow.Name).BringToFront();
                if (showForm) frmShow.Show();
            }

            int tempCount = -1;

            LoggingHandler.Log("Getting current active form's ID in the active forms list");
            lsActiveForms.ForEach(frm =>
            {
                tempCount++;
                if (frm.Name == frmShow.Name) activeFormIndex = tempCount;
            });

            RefreshForms();
        }

        private static Form ActiveForm()
        {
            return lsActiveForms[activeFormIndex];
        }

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("DANKIE VIR DIE TOETS BOIZ");
            Settings.Default.ActiveSubject = "None";
            //frmDebug = new debugForm();
            //frmDebug.Show();

            LoggingHandler.Log("Checking for all required folders to exist...", true);
            if (!Directory.Exists("./Data")) Directory.CreateDirectory("./Data");
            if (!Directory.Exists("./Data/Quizzes")) Directory.CreateDirectory("./Data/Quizzes");
            if (!Directory.Exists("./Data/Exams")) Directory.CreateDirectory("./Data/Exams");
            if (!Directory.Exists("./Data/Tasks")) Directory.CreateDirectory("./Data/Tasks");
            if (!File.Exists("./Data/Subjects.json"))
            {
                JSONHandler.DataToJSON(new List<Subject>(), "./Data/Subjects.json");
            }
        }

        public void CloseTaskCollection()
        {
            List<Form> taskForms = lsActiveForms.FindAll(frm => frm.Name.StartsWith("q"));
            foreach (Form frm in taskForms)
            {
                FormHandler(frm, closeForm: true);
            }
            Form tempFrm = lsActiveForms.Find(frm => frm.Name == "frmViewTaskCollection");
            if (tempFrm != null)
            {
                tempFrm.Close();
                lsActiveForms.Remove(tempFrm);
            }
        }

        public static void NoneSelcted(string item)
        {
            MessageBox.Show($"A {item} has not been selected, select a {item} first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmMainForm_Shown(object sender, EventArgs e)
        {
            mainForm = this;
            FormHandler(new frmHomePage());
            LoggingHandler.Log("App loaded with no errors!");
        }

        private void mstExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstBack_Click(object sender, EventArgs e)
        {
            if (ActiveForm().Name.EndsWith("0"))
            {
                DialogResult result = MessageBox.Show(frmDoOptions.errmsg_ConfirmBack, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    mainForm.CloseTaskCollection();
                }
                else
                {
                    return;
                }
            }
            else
            if (activeFormIndex > 0)
            {
                if (otf.Contains(ActiveForm().Name))
                {
                    ActiveForm().Close();
                    lsActiveForms.Remove(ActiveForm());
                }
                activeFormIndex--;
                ActiveForm().Focus();
            }
            RefreshForms();
        }

        public static void CloseForm(Form form)
        {
            if (activeFormIndex > 0)
            {
                if (otf.Contains(form.Name))
                {
                    form.Close();
                    lsActiveForms.Remove(form);
                }
                activeFormIndex--;
                ActiveForm().Focus();
            }
            RefreshForms();
        }

        private void mstHome_Click(object sender, EventArgs e)
        {
            if (ActiveForm().Name == "frmHomePage") return;
            FormHandler(new frmHomePage(), forceClose: true);
        }

        private void mstNext_Click(object sender, EventArgs e)
        {
            if (activeFormIndex < (lsActiveForms.Count() + 1))
            {
                lsActiveForms[activeFormIndex + 1].BringToFront();
                activeFormIndex++;
                ActiveForm().Focus();
            }
            RefreshForms();
        }

        private void optUICustomization_Click(object sender, EventArgs e)
        {
            //FormHandler(new frmUICustomization(), insertForm: true);
        }

        private void optDataSettings_Click(object sender, EventArgs e)
        {
            //FormHandler(new frmDataSettings(), insertForm: true);
        }

        public static Func<Form, Button> GetRefresh = (Form frm) =>
        {
            if (frm.Controls.Find("Refresh", true).Count() > 0)
            {
                return frm.Controls.Find("Refresh", true)[0] as Button;
            }
            else
            {
                return null;
            }
        };
    }
}