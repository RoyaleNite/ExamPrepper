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
    public partial class cfrmMultiChoice : Form
    {

        #region Form Variables
        public string FilePath;

        //Form Variables
        private int minFormWidth = 585;
        private int minFrmHeight = 420;

        private static int choice = 0;

        private int minRowHeight = 35;
        private int minExtraTLPHeight = 160;

        public List<AnswerOption> answerOptions = new List<AnswerOption>();

        public struct AnswerOption
        {
            public TextBox answerBox;
            public CheckBox correctAnswer;
            public Button removeChoice;

            public AnswerOption(TextBox answerBox, CheckBox correctAnswer, Button removeChoice)
            {
                this.answerBox = answerBox;
                this.correctAnswer = correctAnswer;
                this.removeChoice = removeChoice;
            }

            public AnswerOption()
            {
                #region TextBoxes
                this.answerBox = new TextBox();
                this.answerBox.Text = "";
                this.answerBox.Name = "txtAnswer" + choice.ToString();
                this.answerBox.Dock = DockStyle.Fill;
                this.answerBox.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion TextBoxes

                #region CheckBoxes
                this.correctAnswer = new CheckBox();
                this.correctAnswer.Text = "";
                this.correctAnswer.Name = "chbCC" + choice.ToString();
                this.correctAnswer.Checked = false;
                this.correctAnswer.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion CheckBoxes

                #region Buttons
                this.removeChoice = new Button();
                this.removeChoice.BackColor = Color.DimGray;
                this.removeChoice.Dock = DockStyle.Fill;
                this.removeChoice.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
                this.removeChoice.ForeColor = Color.Transparent;
                this.removeChoice.Margin = new Padding(5, 5, 5, 5);
                this.removeChoice.Name = "btnRC" + choice.ToString();
                this.removeChoice.Text = "X";
                this.removeChoice.UseVisualStyleBackColor = false;
                #endregion Buttons
            }
        }

        #region Error Messages
        private string errmsg_NoCorrectAnswer = $"No answer has been marked as the correct answer";
        private string errmsg_NoDistractos = $"There are no distractors (Wrong answers), are you sure you do not want to add any distractors?";
        #endregion Error Messages

        #endregion Form Variables

        public cfrmMultiChoice()
        {
            InitializeComponent();
        }

        private void cfrmMultiChoice_Load(object sender, EventArgs e)
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
                qfrmMultiChoice frmShow = new qfrmMultiChoice();
                frmShow.btnCreate.Enabled = false;
                frmShow.data = generateData();
                FormHandler(frmShow, showDialog: true);
            };
            ms.Items.Add(tsmiPreview);
            #endregion Adding Preview Button

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFrmHeight);
        }

        private void btnAddChoice_Click(object sender, EventArgs e)
        {
            AnswerOption answerOption = new AnswerOption();
            choice++;
            answerOption.removeChoice.Click += (s, e) =>
            {
                tlpChoiceHolder.Controls.Remove(answerOption.removeChoice);
                tlpChoiceHolder.Controls.Remove(answerOption.answerBox);
                tlpChoiceHolder.Controls.Remove(answerOption.correctAnswer);
                answerOptions.Remove(answerOption);
                tlpChoiceHolder.RowCount--;
                tlpChoiceHolder.RowStyles.RemoveAt(tlpChoiceHolder.RowStyles.Count - 1);
                nudMarks.TabIndex++;
                btnCreate.TabIndex++;
                updateAnswers();
            };
            answerOptions.Add(answerOption);

            tlpChoiceHolder.RowCount++;
            tlpChoiceHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, minRowHeight));

            updateAnswers();

            nudMarks.TabIndex++;
            btnCreate.TabIndex++;

            tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (minExtraTLPHeight + (answerOptions.Count() * minRowHeight)));
        }

        private void updateAnswers()
        {
            answerOptions.Add(new AnswerOption());

            tlpChoiceHolder.RowCount++;
            tlpChoiceHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, minRowHeight));

            for (int a = 1; a < tlpAnswerHolder.RowCount; a++)
            {
                tlpAnswerHolder.RowStyles[a] = new RowStyle(SizeType.Absolute, minRowHeight);
            }

            for (int a = 0; a < answerOptions.Count() - 1; a++)
            {
                answerOptions[a].answerBox.TabIndex = a + 2;
                answerOptions[a].correctAnswer.TabIndex = btnCreate.TabIndex + 5;
                answerOptions[a].removeChoice.TabIndex = btnCreate.TabIndex + 5;

                tlpChoiceHolder.Controls.Add(answerOptions[a].correctAnswer, 1, a + 1);
                tlpChoiceHolder.Controls.Add(answerOptions[a].answerBox, 2, a + 1);
                tlpChoiceHolder.Controls.Add(answerOptions[a].removeChoice, 3, a + 1);
            }
            answerOptions.RemoveAt(answerOptions.Count() - 1);
            tlpChoiceHolder.RowStyles.RemoveAt(tlpChoiceHolder.RowStyles.Count - 1);
            tlpChoiceHolder.RowCount--;
            tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (minExtraTLPHeight + (answerOptions.Count() * minRowHeight)));

            int minFrmHeight = 520 + (answerOptions.Count() * minRowHeight);

            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFrmHeight);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            #region "Erorr Checking"
            if (rtbQuestion.Text == "")
            {
                MessageBox.Show(mainForm.errmsg_NoQuestion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbQuestion.Focus();
                return;
            }

            foreach (AnswerOption opt in answerOptions)
            {
                if (opt.answerBox.Text == "")
                {
                    MessageBox.Show(mainForm.errmsg_NoAnswer($"'Choice #{answerOptions.IndexOf(opt) + 1}'"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opt.answerBox.Focus();
                    return;
                }
            }

            if (!answerOptions.Exists(opt => opt.correctAnswer.Checked == true) || answerOptions.Count == 0)
            {
                MessageBox.Show(errmsg_NoCorrectAnswer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            if (!answerOptions.Exists(opt => opt.correctAnswer.Checked == false))
            {
                DialogResult result = MessageBox.Show(errmsg_NoDistractos, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            };

            if (txtTaskName.Text == "")
            {
                DialogResult result = MessageBox.Show(mainForm.errmsg_NoName, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.No)
                {
                    txtTaskName.Focus();
                    return;
                }
            }
            #endregion "Erorr Checking"

            if (btnCreate.Text == "Create Question")
            {
                string subjectFolder = $"{Default.Task_Storage_Path}/{Default.ActiveSubject}/MultiChoice";
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

        //Generating Form To Data
        private ExamTask generateData()
        {
            List<MemoInfo> memoInfos = new List<MemoInfo>();
            List<string> distractors = new List<string>();

            foreach (AnswerOption opt in answerOptions)
            {
                if (opt.correctAnswer.Checked) memoInfos.Add(new MemoInfo(opt.answerBox.Text));
                else distractors.Add(opt.answerBox.Text);
            }
            List<QuestionInfo> queInfo = new List<QuestionInfo>() { new QuestionInfo(rtbQuestion.Text, memoInfos, distractors, (int)nudMarks.Value, QuestionTypeList.MultipleChoice) };

            ExamTask examTask = new ExamTask(queInfo, txtTaskName.Text, Subject.getSubjectByID(Default.ActiveSubject));
            return examTask;
        }

        private void cfrmMultiChoice_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }

        private void btnAddChoice_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Add Choice to Task");
        }

        private void txtTaskName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Task Name");
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as Button, "Create Question");
        }
    }
}
