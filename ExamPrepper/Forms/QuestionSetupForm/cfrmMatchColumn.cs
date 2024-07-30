using ExamPrepper.Classes;
using ExamPrepper.Forms.QuestionForms;
using ExamPrepper.Forms.TaskCollectionForm;
using ExamPrepper.Properties;
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
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.Classes.JSONHandler;
using static ExamPrepper.Classes.Notifications;

namespace ExamPrepper
{
    public partial class cfrmMatchColumn : Form
    {

        #region Form Variables
        public string FilePath;

        private int minFormWidth = 585;
        private int minFormHeight = 485;

        private int minRowHeight = 40;

        //private int questions = 0, answers = 0;

        public struct AnswerOption
        {
            public TextBox answerBox;
            public Label answerChar;
            public Button removeChoice;
            public ComboBox questionAnswer;

            public AnswerOption(TextBox answerBox, Button removeChoice, Label answerChar, ComboBox questionAnswer)
            {
                this.answerBox = answerBox;
                this.removeChoice = removeChoice;
                this.answerChar = answerChar;
                this.questionAnswer = questionAnswer;
            }

            public AnswerOption()
            {
                #region TextBoxes
                this.answerBox = new TextBox();
                this.answerBox.Text = "";
                this.answerBox.Name = "txtAnswer";
                this.answerBox.Dock = DockStyle.Fill;
                this.answerBox.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion TextBoxes

                #region Label
                this.answerChar = new Label();
                this.answerChar.Text = "";
                this.answerChar.Name = "lblAnswer";
                this.answerChar.Dock = DockStyle.Fill;
                this.answerChar.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                this.answerChar.TextAlign = ContentAlignment.MiddleRight;
                #endregion Label

                #region Buttons
                this.removeChoice = new Button();
                this.removeChoice.BackColor = Color.DimGray;
                this.removeChoice.Dock = DockStyle.Fill;
                this.removeChoice.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
                this.removeChoice.ForeColor = Color.Transparent;
                this.removeChoice.Margin = new Padding(5, 5, 5, 5);
                this.removeChoice.Name = "btnRC";
                this.removeChoice.Text = "X";
                this.removeChoice.UseVisualStyleBackColor = false;
                #endregion Buttons

                #region ComboBox
                this.questionAnswer = new ComboBox();
                this.questionAnswer.Text = "";
                this.questionAnswer.Name = "cbxAnswer";
                this.questionAnswer.Dock = DockStyle.Fill;
                this.questionAnswer.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion ComboBox
            }
        }

        public List<AnswerOption> ansS = new List<AnswerOption>();
        public List<AnswerOption> queS = new List<AnswerOption>();

        #region Error Messages
        private string errmsg_QuestionWithoutAnswer(int queNumber) => $"Question {queNumber} does not have an answer.";
        private string errmsg_TooManyAnswer = $"There cannot be more than 24 answers.";
        #endregion Error Messages

        #endregion Form Variables

        public cfrmMatchColumn()
        {
            InitializeComponent();
        }

        private void cfrmMatchColumn_Load(object sender, EventArgs e)
        {
            #region Adding Preview Button
            MenuStrip ms = (MenuStrip)this.ParentForm.Controls.Find("msExtras", true)[0];
            ToolStripMenuItem tsmiPreview = new ToolStripMenuItem()
            {
                Name = "btnPreviewForm",
                Text = "Preview"
            };
            tsmiPreview.Click += (s, e) =>
            {
                qfrmMatchColumn frmShow = new qfrmMatchColumn();
                frmShow.btnCreate.Enabled = false;
                frmShow.data = generateData();
                FormHandler(frmShow, showDialog: true);
            };
            ms.Items.Add(tsmiPreview);
            #endregion Adding Preview Button

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);
        }

        private void cfrmMatchColumn_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            addOption(queS, tlpQuestions, 1);
            updateAnswerChars(sender, e);
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (ansS.Count() < 24)
            {
                addOption(ansS, tlpAnswers, 2);
                updateAnswerChars(sender, e);
            }
            else
            {
                MessageBox.Show(errmsg_TooManyAnswer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddAnswer.Focus();
                return;
            }
        }

        #region Adding Options Method
        private void addOption(List<AnswerOption> listOfComps, TableLayoutPanel adjustment, int rowAdjustment)
        {
            AnswerOption answerOption = new AnswerOption();
            answerOption.removeChoice.Click += (s, e) =>
            {
                adjustment.Controls.Remove(answerOption.removeChoice);
                adjustment.Controls.Remove(answerOption.answerBox);
                adjustment.Controls.Remove(answerOption.answerChar);
                adjustment.Controls.Remove(answerOption.questionAnswer);
                listOfComps.Remove(answerOption);
                adjustment.RowCount--;
                adjustment.RowStyles.RemoveAt(adjustment.RowStyles.Count - 1);
                nudMarks.TabIndex++;
                btnCreate.TabIndex++;
                if (ansS.Contains(answerOption)) ansS.Remove(answerOption);
                if (queS.Contains(answerOption)) queS.Remove(answerOption);
                updateAnswers(listOfComps, adjustment, rowAdjustment);
                updateAnswerChars(s, e);
            };
            listOfComps.Add(answerOption);

            adjustment.RowCount++;
            adjustment.RowStyles.Add(new RowStyle(SizeType.Absolute, minRowHeight));

            updateAnswers(listOfComps, adjustment, rowAdjustment);

            nudMarks.TabIndex++;
            btnCreate.TabIndex++;

            tlpMHolder.RowStyles[rowAdjustment] = new RowStyle(SizeType.Absolute, 140 + (listOfComps.Count() * minRowHeight));
        }
        #endregion Adding Options Method

        #region Update Answers Method
        private void updateAnswers(List<AnswerOption> listOfComps, TableLayoutPanel adjustment, int rowAdjustment)
        {
            listOfComps.Add(new AnswerOption());

            adjustment.RowCount++;
            adjustment.RowStyles.Add(new RowStyle(SizeType.Absolute, minRowHeight));

            for (int a = 1; a < adjustment.RowCount; a++)
            {
                adjustment.RowStyles[a] = new RowStyle(SizeType.Absolute, minRowHeight);
            }

            for (int a = 0; a < listOfComps.Count() - 1; a++)
            {
                listOfComps[a].answerBox.TabIndex = a + 2;
                listOfComps[a].removeChoice.TabIndex = btnCreate.TabIndex + 5;

                if (adjustment.Name == "tlpAnswers")
                {
                    listOfComps[a].answerChar.Text = $"{((char)(65 + a))})";
                    listOfComps[a].answerBox.PlaceholderText = $"Enter answer for {((char)(65 + a))}";
                    listOfComps[a].answerBox.Leave += (s, e) =>
                    {
                        updateAnswerChars(s, e);
                    };
                    adjustment.Controls.Add(listOfComps[a].answerChar, 1, a + 1);
                    adjustment.Controls.Add(listOfComps[a].answerBox, 2, a + 1);
                    adjustment.Controls.Add(listOfComps[a].removeChoice, 3, a + 1);
                }
                else
                {
                    listOfComps[a].answerBox.PlaceholderText = $"Enter question for question field #{a + 1}";
                    adjustment.Controls.Add(listOfComps[a].answerBox, 1, a + 1);
                    adjustment.Controls.Add(listOfComps[a].removeChoice, 3, a + 1);
                    adjustment.Controls.Add(listOfComps[a].questionAnswer, 2, a + 1);
                }

            }
            listOfComps.RemoveAt(listOfComps.Count() - 1);
            adjustment.RowStyles.RemoveAt(adjustment.RowStyles.Count - 1);
            adjustment.RowCount--;
            tlpMHolder.RowStyles[rowAdjustment] = new RowStyle(SizeType.Absolute, 140 + (listOfComps.Count() * minRowHeight));

            int minFrmHeight = minFormHeight + ((ansS.Count + queS.Count) * minRowHeight);

            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFrmHeight);
        }
        #endregion Update Answers Method

        #region Updating Answers in ComboBoxes
        private void updateAnswerChars(object sender, EventArgs e)
        {
            int selIndex;
            for (int a = 0; a < queS.Count; a++)
            {
                selIndex = queS[a].questionAnswer.SelectedIndex;
                queS[a].questionAnswer.Items.Clear();
                queS[a].questionAnswer.Text = "";
                for (int b = 0; b < ansS.Count(); b++)
                {
                    queS[a].questionAnswer.Items.Add((char)(65 + b));
                }
                if (a < ansS.Count && selIndex == -1) queS[a].questionAnswer.SelectedIndex = a;
                else if (selIndex != -1 && !(selIndex >= ansS.Count)) queS[a].questionAnswer.SelectedIndex = selIndex;
            }
        }
        #endregion Updating Answers in ComboBoxes   

        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region "Error Checking"
            if (queS.Count == 0)
            {
                MessageBox.Show(mainForm.errmsg_NoQuestion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddQuestion.Focus();
                return;
            }

            foreach (AnswerOption opt in queS)
            {
                if (opt.questionAnswer.SelectedIndex == -1)
                {
                    MessageBox.Show(errmsg_QuestionWithoutAnswer(queS.IndexOf(opt) + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opt.questionAnswer.Focus();
                    return;
                }
            }

            if (queS.Count == 0)
            {
                MessageBox.Show(mainForm.errmsg_NoAnswer(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddAnswer.Focus();
                return;
            }

            if (txtTaskName.Text == "")
            {
                DialogResult result = MessageBox.Show(mainForm.errmsg_NoName, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.No)
                {
                    txtTaskName.Focus();
                    return;
                }
            }
            #endregion "Error Checking"

            if (btnCreate.Text == "Create Question")
            {
                string subjectFolder = $"{Default.Task_Storage_Path}/{Default.ActiveSubject}/MatchColumn";
                generateData().createFile(subjectFolder);
            }
            else
            {
                DialogResult result = MessageBox.Show(mainForm.errmsg_ConfirmEdit, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    return;
                }
                ExamTask task = generateData();
                EditInJSON(task, FilePath);
                frmViewTasks frm = (frmViewTasks)lsActiveForms.Find(frm => frm.Name == "frmViewTasks");
                frm.refreshDGV();
            }

            CloseForm(this);
            ShowSuccess(mainForm, "Task");
        }

        private ExamTask generateData()
        {
            List<string> distractors = new List<string>();
            List<QuestionInfo> Questions = new List<QuestionInfo>();

            for (int a = 0; a < ansS.Count; a++)
            {
                distractors.Add($"{ansS[a].answerBox.Text}");
            }

            foreach (AnswerOption opt in queS)
            {
                if (opt.questionAnswer.SelectedIndex == -1) continue;

                char ansChar = opt.questionAnswer.SelectedItem.ToString()[0];
                string fullAns = ansS[((int)ansChar - 65)].answerBox.Text;
                distractors.Remove(fullAns);

                List<MemoInfo> Memo = new List<MemoInfo>()
                {
                    new MemoInfo(ansS.Find(ans => ans.answerChar.Text.StartsWith(opt.questionAnswer.SelectedItem.ToString())).answerBox.Text)
                };
                Questions.Add(new QuestionInfo(opt.answerBox.Text, Memo, (int)nudMarks.Value, QuestionTypeList.MatchColumn));
            }

            if (Questions.Count > 0) Questions[0].Distractors = distractors;

            ExamTask examTask = new ExamTask(Questions, txtTaskName.Text, Subject.getSubjectByID(Default.ActiveSubject));
            return examTask;
        }

        private void btnAddQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Add Question to Task");
        }

        private void btnAddAnswer_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Add Answer to Task");
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Create Question");
        }

        private void txtTaskName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Task Name");
        }
    }
}
