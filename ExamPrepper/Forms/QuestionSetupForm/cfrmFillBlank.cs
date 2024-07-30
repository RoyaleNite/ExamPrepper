using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExamPrepper.Classes;
using ExamPrepper.Forms.QuestionForms;
using ExamPrepper.Properties;
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;
using static ExamPrepper.Properties.Settings;
using static ExamPrepper.Classes.JSONHandler;
using ExamPrepper.Forms.TaskCollectionForm;
using static ExamPrepper.Classes.Notifications;

namespace ExamPrepper
{
    public partial class cfrmFillBlank : Form
    {

        #region Form Variables
        public string FilePath;

        private int minFormWidth = 585;
        private int minFormHeight = 400;

        public List<AnswerOption> AnswerOptions = new List<AnswerOption>();
        public List<string> prevLines = new List<string>() { "" };
        private TextBox selectedAnswer;

        //Answer Option Textbox variables
        private int aoMinRowWidth = 40;

        //Form Options

        //ToolTip Messages
        private string _QuestionTT = "To insert a blank space to require an answer, either right click on the question input window and click 'Add blank' or enter three dashes (E.g. '\"---\"').";
        private string _CSTT = "Right click on the answer input box to change the case sensitive option.";
        private string _MCTT = "Change the mark count according to what you want the question to count. Default mark for all questions is 1.";

        public class AnswerOption
        {
            public TextBox answerBox;
            public Label answerNumber;
            public Label answerCS;
            public bool cs;

            public AnswerOption(TextBox answerBox, Label answerNumber, Label answerCS, bool cs = false)
            {
                #region TextBoxes
                this.answerBox = answerBox;
                this.answerBox.Text = "";
                this.answerBox.Dock = DockStyle.Fill;
                this.answerBox.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion TextBoxes

                #region Labels
                this.answerNumber = answerNumber;
                this.answerNumber.Dock = DockStyle.Fill;
                this.answerNumber.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
                //this.answerNumber.Margin = new Padding(2);
                this.answerNumber.Text = "";
                this.answerNumber.TextAlign = ContentAlignment.MiddleLeft;
                #endregion Labels

                this.cs = cs;

                #region CS Labels
                this.answerCS = answerCS;
                if (this.cs) this.answerCS.Text = "[Case Sensitive]";
                else this.answerCS.Text = "[Not Case Sensitive]";
                this.answerCS.Dock = DockStyle.Fill;
                this.answerCS.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
                this.answerCS.Margin = new Padding(2);
                this.answerCS.TextAlign = ContentAlignment.MiddleLeft;
                #endregion CS Labels
            }

            public AnswerOption() { }
        }

        #endregion Form Variables

        public cfrmFillBlank()
        {
            InitializeComponent();
        }

        private void cfrmFillBlank_Load(object sender, EventArgs e)
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
                qfrmFillBlank frmShow = new qfrmFillBlank();
                frmShow.btnCreate.Enabled = false;
                frmShow.data = generateData();
                FormHandler(frmShow, showDialog: true);
            };
            ms.Items.Add(tsmiPreview);
            #endregion Adding Preview Button

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);
        }

        #region ToolTip Settings
        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            ttQuestion.SetToolTip(rtbQuestion, _QuestionTT);
        }

        private void lblMC_MouseHover(object sender, EventArgs e)
        {
            ttQuestion.SetToolTip(rtbQuestion, _MCTT);
        }

        private void setTxtTT(object sender, EventArgs e)
        {
            ttQuestion.SetToolTip((TextBox)sender, _MCTT);
        }

        private void setLblTT(object sender, EventArgs e)
        {
            ttQuestion.SetToolTip((Label)sender, _MCTT);
        }
        #endregion ToolTip Settings

        #region Selected Answer Options
        private void txtAO1_MouseEnter(object sender, EventArgs e)
        {
            selectedAnswer = (TextBox)sender;
        }

        private void cmsItemModify_Opened(object sender, EventArgs e)
        {
            cmsoCS.Checked = AnswerOptions.Find(a => a.answerBox == selectedAnswer).cs;
        }

        private void changeSelectedAnswer(object sender, EventArgs e)
        {
            selectedAnswer = (TextBox)sender;
        }

        private void cmsoCS_CheckedChanged(object sender, EventArgs e)
        {
            //Changing the CaseSensitive Bool according to the menu option
            int index = AnswerOptions.FindIndex(a => a.answerBox == selectedAnswer);
            AnswerOption ans = AnswerOptions[index];
            ans.cs = cmsoCS.Checked;
            if (cmsoCS.Checked) ans.answerCS.Text = "[Case Sensitive]";
            else ans.answerCS.Text = "[Not Case Sensitive]";
            AnswerOptions[index] = ans;
        }
        #endregion Selected Answer Options

        #region Changing Answer Options
        private void rtbQuestion_TextChanged(object sender, EventArgs e)
        {
            string lines = "/" + rtbQuestion.Text + "/";
            int answers = lines.Split("---").Count() - 1;

            if (answers == (prevLines.Count() - 1)) return;

            if (answers == 0)
            {
                for (int a = 0; a < AnswerOptions.Count(); a++)
                {
                    tlpAnswerHolder.Controls.Remove(AnswerOptions[a].answerBox);
                    tlpAnswerHolder.Controls.Remove(AnswerOptions[a].answerCS);
                    tlpAnswerHolder.Controls.Remove(AnswerOptions[a].answerNumber);
                }
                AnswerOptions.Clear();
                prevLines = new List<string>() { "" };
                tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (95 + (AnswerOptions.Count() * aoMinRowWidth)));
                this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, 480 + ((AnswerOptions.Count() + 1 * aoMinRowWidth)) + 80);
                return;
            }

            if (answers > prevLines.Count() - 1)
            {
                tempStateAnswers();
                string[] splitLines = lines.Split("---");
                int addedIndex = -1;
                int testOffset = 0;
                foreach (string line in prevLines)
                {
                    addedIndex++;
                    if (line != splitLines[addedIndex + testOffset])
                    {
                        testOffset++;
                        AnswerOption ansOption = new AnswerOption(new TextBox(), new Label(), new Label(), false);

                        ansOption.answerBox.ContextMenuStrip = cmsItemModify;
                        ansOption.answerBox.MouseEnter += changeSelectedAnswer;
                        ansOption.answerBox.MouseHover += setTxtTT;

                        ansOption.answerCS.MouseHover += setLblTT;

                        AnswerOptions.Insert(addedIndex, ansOption);

                        tlpAnswerHolder.RowCount++;
                        tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, aoMinRowWidth));
                    }
                }
                updateAnswers();
            }
            else if (answers < prevLines.Count() - 1)
            {
                tempStateAnswers();
                prevLines.RemoveAt(prevLines.Count() - 1);
                string[] splitLines = lines.Split("---");
                int removeIndex = -1;
                foreach (string line in prevLines)
                {
                    removeIndex++;
                    if (line != splitLines[removeIndex])
                    {
                        //Removing the deleted controls from the TableLayoutPanel
                        tlpAnswerHolder.Controls.Remove(AnswerOptions[removeIndex].answerBox);
                        tlpAnswerHolder.Controls.Remove(AnswerOptions[removeIndex].answerCS);
                        tlpAnswerHolder.Controls.Remove(AnswerOptions[removeIndex].answerNumber);
                        AnswerOptions.RemoveAt(removeIndex);

                        tlpAnswerHolder.RowStyles.RemoveAt(removeIndex);
                        tlpAnswerHolder.RowCount--;
                        break;
                    }
                }
                updateAnswers();
            }
            prevLines = lines.Split("---").ToList();
        }

        private void tempStateAnswers()
        {
            foreach (AnswerOption ansInfo in AnswerOptions)
            {
                ansInfo.answerBox.Name = $"tmp_{ansInfo.answerBox.Name}";
                ansInfo.answerCS.Name = $"tmp_{ansInfo.answerCS.Name}";
                ansInfo.answerNumber.Name = $"tmp_{ansInfo.answerNumber.Name}";
            }
        }

        private void updateAnswers()
        {
            AnswerOptions.Add(new AnswerOption());

            tlpAnswerHolder.RowCount++;
            tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, aoMinRowWidth));

            for (int a = 1; a < tlpAnswerHolder.RowCount; a++)
            {
                tlpAnswerHolder.RowStyles[a] = new RowStyle(SizeType.Absolute, aoMinRowWidth);
            }

            for (int a = 0; a < AnswerOptions.Count() - 1; a++)
            {
                //Change Text boxes
                AnswerOptions[a].answerBox.Name = "txtAO" + a.ToString();
                AnswerOptions[a].answerBox.PlaceholderText = "Enter your answer for blank #" + (a + 1).ToString();
                AnswerOptions[a].answerBox.TabIndex = a;

                tlpAnswerHolder.Controls.Add(AnswerOptions[a].answerBox, 2, a + 1);

                //Change Number Labels
                AnswerOptions[a].answerNumber.Text = $"{a + 1})";
                AnswerOptions[a].answerNumber.Name = $"lblAON{a}";

                tlpAnswerHolder.Controls.Add(AnswerOptions[a].answerNumber, 1, a + 1);

                //Change CS Labels
                AnswerOptions[a].answerCS.Name = $"lblCSAO{a}";
                AnswerOptions[a].answerCS.TabIndex = a;
                if (AnswerOptions[a].cs) AnswerOptions[a].answerCS.Text = "[Case Sensitive]";
                else AnswerOptions[a].answerCS.Text = "[Not Case Sensitive]";

                tlpAnswerHolder.Controls.Add(AnswerOptions[a].answerCS, 3, a + 1);
            }
            AnswerOptions.RemoveAt(AnswerOptions.Count() - 1);
            tlpAnswerHolder.RowStyles.RemoveAt(tlpAnswerHolder.RowStyles.Count - 1);
            tlpAnswerHolder.RowCount--;
            tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (95 + (AnswerOptions.Count() * aoMinRowWidth)));

            int minHeight = 480 + (AnswerOptions.Count() * aoMinRowWidth);

            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minHeight);
        }
        #endregion Changing Answer Options

        //Adding an answer option through ContextMenu
        private void cmsoQAddBlank_Click(object sender, EventArgs e)
        {
            // Setting mouse after the inserted text
            int i = rtbQuestion.SelectionStart;
            int l = rtbQuestion.SelectionLength;
            rtbQuestion.Text = rtbQuestion.Text.Insert(i, " --- ");
            rtbQuestion.SelectionStart = i + l + 5;
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

            foreach (AnswerOption opt in AnswerOptions)
            {
                if (opt.answerBox.Text == "")
                {
                    MessageBox.Show(mainForm.errmsg_NoAnswer($"'Fill Blank #{opt.answerNumber.Text.Substring(0, opt.answerNumber.Text.Length - 1)}'"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opt.answerBox.Focus();
                    return;
                }
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
            #endregion "Erorr Checking"

            if (btnCreate.Text == "Create Question")
            {
                string subjectFolder = $"{Default.Task_Storage_Path}/{Default.ActiveSubject}/FillBlank";
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
            foreach (AnswerOption opt in AnswerOptions)
            {
                memoInfos.Add(new MemoInfo(opt.answerBox.Text, opt.cs));
            }
            List<QuestionInfo> queInfo = new List<QuestionInfo>() { new QuestionInfo(rtbQuestion.Text, memoInfos, (int)nudMarks.Value, QuestionTypeList.FillBlank) };

            ExamTask examTask = new ExamTask(queInfo, txtTaskName.Text, Subject.getSubjectByID(Default.ActiveSubject));
            return examTask;
        }

        private void cfrmFillBlank_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void cfrmFillBlank_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void txtTaskName_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as TextBox, "Task Name");
        }
    }
}
