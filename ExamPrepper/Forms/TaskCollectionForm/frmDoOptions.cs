using ExamPrepper.Classes;
using ExamPrepper.Forms.QuestionForms;
using ExamPrepper.Forms.QuestionSetupForm;
using ExamPrepper.Properties;
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
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Properties.Settings;

namespace ExamPrepper.Forms.TaskCollectionForm
{
    public partial class frmDoOptions : Form
    {
        public Exam taskCollection;

        public List<Form> allForms = new List<Form>();

        public static string errmsg_ConfirmBack = "Are you sure you want to go back? You will lose all of your progress and will have to start over.";

        public frmDoOptions()
        {
            InitializeComponent();
        }

        private void btnEndResult_Click(object sender, EventArgs e)
        {
            LoadExams(1);
            this.Close();
        }

        private void btnInstantResult_Click(object sender, EventArgs e)
        {
            LoadExams(2);
            this.Close();
        }

        private void btnSelfMark_Click(object sender, EventArgs e)
        {
            LoadExams(3);
            this.Close();
        }

        public void LoadExams(int choice)
        {
            int index = 0;

            if (taskCollection.isExam())
            {
                foreach (ExamSection section in taskCollection.Sections)
                {
                    foreach (ExamTask task in section.Section_Tasks)
                    {
                        bool last = false;
                        bool first = false;
                        if (section == taskCollection.Sections[taskCollection.Sections.Count - 1]
                            && task == section.Section_Tasks[section.Section_Tasks.Count - 1])
                            last = true;

                        if (section == taskCollection.Sections[0]
                            && task == section.Section_Tasks[0])
                            first = true;

                        Form addForm = CreateForm(task, section.Section, choice, last, first);
                        addForm.Name += $"{index}";
                        allForms.Add(addForm);
                        index++;
                    }
                }
            }
            else
            {
                foreach (ExamTask task in taskCollection.Sections[0].Section_Tasks)
                {
                    bool last = false;
                    bool first = false;
                    ExamSection section = taskCollection.Sections[0];

                    if (task == section.Section_Tasks[section.Section_Tasks.Count() - 1])
                        last = true;

                    if (task == section.Section_Tasks[0])
                        first = true;

                    Form addForm = CreateForm(task, choice: choice, last: last, first: first);
                    addForm.Name += $"{index}";
                    allForms.Add(addForm);
                    index++;
                }
            }
        }

        private T handleChoice<T>(T frm, int choice, bool first, bool last) where T : Form, qfrmInterface
        {
            T hFrm = frm;

            Button btnCreate = frm.Controls.Find("pnlButtonHolder", true)[0].Controls.Find("tlpButtonHolder", true)[0].Controls.Find("btnCreate", true)[0] as Button;
            Button btnPreviousQuestion = frm.Controls.Find("pnlButtonHolder", true)[0].Controls.Find("tlpButtonHolder", true)[0].Controls.Find("btnPreviousQuestion", true)[0] as Button;

            if (choice == 0)
                if (last) btnCreate.Text = "Exit";
                else
                if (last) btnCreate.Text = "Submit";
            if (first) btnPreviousQuestion.Text = "Exit";

            if (choice != 0)
                btnPreviousQuestion.Click += (s, e) =>
                {
                    if (!first)
                        mainForm.mstBack.PerformClick();
                    else
                    {
                        DialogResult result = MessageBox.Show(errmsg_ConfirmBack, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            mainForm.CloseTaskCollection();
                        }
                        else
                        {
                            return;
                        }
                    }
                };
            else
                btnPreviousQuestion.Click += (s, e) =>
                {
                    mainForm.CloseTaskCollection();
                };

            if (choice == 0)
                btnCreate.Click += async (s, e) =>
                {
                    if (btnCreate.Text == "Exit")
                    {
                        mainForm.CloseTaskCollection();
                    }
                };
            else
                btnCreate.Click += async (s, e) =>
                {
                    if (btnCreate.Text == "Submit")
                    {
                        bool stop = false;
                        float correctMarks = 0, totalMarks = 0;
                        double percCor = 0.0;

                        List<AnswerInfo> answers = new List<AnswerInfo>();

                        List<Form> taskForms = lsActiveForms.FindAll(frm => frm.Name.StartsWith("q"));

                        foreach (Form frms in taskForms)
                        {
                            qfrmInterface oFrm = (qfrmInterface)frms;
                            if (oFrm.data.Answer == null)
                            {
                                if (!oFrm.noEmptyAnswers())
                                {
                                    stop = true;
                                    FormHandler(frms);
                                    break;
                                }
                                if (frms.Name.Contains("Question"))
                                {
                                    qfrmQuestion temp = new qfrmQuestion();
                                    temp.data = oFrm.data;
                                    temp.getFeedback();
                                    temp.btnPreviousQuestion.Visible = false;
                                    temp.btnCreate.Text = "Submit Answer";
                                    temp.btnCreate.Click += (s, e) =>
                                    {
                                        temp.Close();
                                    };
                                    temp.Size = temp.MinimumSize;
                                    FormHandler(temp, showDialog: true);
                                    oFrm.data = temp.data;
                                }
                                else
                                {
                                    oFrm.getFeedback();
                                }
                            }
                            totalMarks += oFrm.data.GetQuestion().MarkCount;
                            correctMarks += oFrm.MarkCount();
                            oFrm.data.Answer.ForEach(ans => answers.Add(ans));
                            correctMarks = (float)(Math.Round(correctMarks / 0.5) * 0.5);
                            if (correctMarks.ToString().Contains(".99")) correctMarks = (float)Math.Ceiling(correctMarks);
                        }
                        if (stop) return;
                        percCor = Math.Round((correctMarks / totalMarks) * 100, 2);
                        if (correctMarks == 0) percCor = 0;

                        Results result = new Results(percCor, totalMarks, taskCollection.Exam_Info.Exam_ID, correctMarks, answers);

                        string path = $"{Default.Results_Storage_Path}/{Default.ActiveSubject}/{taskCollection.Exam_Info.Exam_ID}/";
                        result.createFile(path);
                        mainForm.CloseTaskCollection();
                        FormHandler(new frmResultInfo() { res = result }, showDialog: true);
                    }

                };

            switch (choice)
            {
                case 0:
                    {
                        btnCreate.Click += (s, e) =>
                        {
                            if (!last) mainForm.mstNext.PerformClick();
                        };
                        break;
                    }
                case 1:
                    {
                        if (last) btnCreate.Text = "Submit";
                        else btnCreate.Text = "Next Question";

                        btnCreate.Click += (s, e) =>
                        {
                            if (!last) mainForm.mstNext.PerformClick();
                        };
                        break;
                    }
                case 2:
                    {
                        btnCreate.Text = "Get Feedback";

                        btnCreate.Click += (s, e) =>
                        {
                            if (btnCreate.Text == "Get Feedback")
                            {
                                if (last) btnCreate.Text = "Submit";
                                else btnCreate.Text = "Next Question";
                                if (hFrm.noEmptyAnswers())
                                    hFrm.getFeedback();
                            }
                            else
                            {
                                if (!last) mainForm.mstNext.PerformClick();
                            }
                        };
                        break;
                    }
            }

            return hFrm;
        }

        private Form CreateForm(ExamTask task, string section = "", int choice = 0, bool last = false, bool first = false)
        {
            #region FillBlank
            if (task.GetQuestion().QuestionType == QuestionTypeList.FillBlank.ToString())
            {
                qfrmFillBlank frmShow = new qfrmFillBlank();
                if (section != "") frmShow.lblHeading.Text += $" (Section {section})";

                frmShow.data = task;

                frmShow = handleChoice(frmShow, choice, first, last);

                return frmShow;
            }
            #endregion FillBlank

            #region BasicQuestion
            else if (task.GetQuestion().QuestionType == QuestionTypeList.BasicQuestion.ToString())
            {
                qfrmQuestion frmShow = new qfrmQuestion();
                if (section != "") frmShow.lblHeading.Text += $" (Section {section})";

                frmShow.data = task;

                frmShow = handleChoice(frmShow, choice, first, last);

                return frmShow;
            }
            #endregion BasicQuestion

            #region MultipleChoice
            else if (task.GetQuestion().QuestionType == QuestionTypeList.MultipleChoice.ToString())
            {
                qfrmMultiChoice frmShow = new qfrmMultiChoice();
                if (section != "") frmShow.lblHeading.Text += $" (Section {section})";

                frmShow.data = task;

                frmShow = handleChoice(frmShow, choice, first, last);

                return frmShow;
            }
            #endregion MultipleChoice

            #region MatchColumn
            else if (task.GetQuestion().QuestionType == QuestionTypeList.MatchColumn.ToString())
            {
                qfrmMatchColumn frmShow = new qfrmMatchColumn();
                if (section != "") frmShow.lblHeading.Text += $" (Section {section})";

                frmShow.data = task;

                frmShow = handleChoice(frmShow, choice, first, last);

                return frmShow;
            }
            #endregion MatchColumn

            #region TrueFalse
            else if (task.GetQuestion().QuestionType == QuestionTypeList.TrueFalse.ToString())
            {
                qfrmTrueFalse frmShow = new qfrmTrueFalse();
                if (section != "") frmShow.lblHeading.Text += $" (Section {section})";

                frmShow.data = task;

                frmShow = handleChoice(frmShow, choice, first, last);

                return frmShow;
            }
            else return new Form();
            #endregion TrueFalse
        }

        private void frmDoOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
