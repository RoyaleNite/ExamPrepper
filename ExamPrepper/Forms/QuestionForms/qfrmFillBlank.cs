using ExamPrepper.Classes;
using ExamPrepper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper.Forms.QuestionForms
{
    public partial class qfrmFillBlank : Form, qfrmInterface
    {
        public ExamTask _data;
        public ExamTask data
        {
            get { return _data; }
            set { _data = value; }
        }
        public List<AnswerOption> ans = new List<AnswerOption>();

        #region Form Variables
        private int minFormWidth = 585;
        public int minFormHeight = 485;

        public class AnswerOption
        {
            public TextBox answerBox;
            public Label answerNumber;
            public bool cs;

            public AnswerOption(TextBox answerBox, Label answerNumber, bool cs = false)
            {
                this.answerBox = answerBox;
                this.answerNumber = answerNumber;
                this.cs = cs;
            }

            public AnswerOption() { }
        }

        //Answer Option Textbox variables
        private int aoMinRowWidth = 40;
        #endregion Form Variables

        public qfrmFillBlank()
        {
            InitializeComponent();
        }

        private void qfrmFillBlank_Load(object sender, EventArgs e)
        {

            nudMarks.Controls[0].Visible = false;

            #region Loading Form with Data
            if (data != null)
            {
                nudMarks.Value = (decimal)data.GetQuestion().MarkCount;
                rtbQuestion.Text = data.GetQuestion().Question;
                string lines = "/" + rtbQuestion.Text + "/";
                int answers = lines.Split("---").Count() - 1;

                for (int a = 0; a < answers; a++)
                {
                    TextBox txtTmp = new TextBox();

                    if (data.Answer != null)
                    {
                        txtTmp.Text = data.Answer[a].Answer;
                    }
                    else
                    {
                        txtTmp.Text = "";
                    }

                    txtTmp.Dock = DockStyle.Fill;
                    txtTmp.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                    txtTmp.PlaceholderText = "Enter your answer for blank #" + (a + 1).ToString();
                    txtTmp.Name = $"txt{a}";

                    Label lblTmpNumber = new Label();

                    lblTmpNumber.Dock = DockStyle.Fill;
                    lblTmpNumber.Font = new Font("Calibri Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    // lblTmpNumber.Margin = new Padding(2);
                    lblTmpNumber.TextAlign = ContentAlignment.MiddleLeft;
                    lblTmpNumber.Text = $"{a + 1})";
                    lblTmpNumber.Name = $"lblAON{a}";

                    AnswerOption option = new AnswerOption(txtTmp, lblTmpNumber, data.Question[0].Memo[a].CaseSensitive);

                    ans.Add(option);

                    tlpAnswerHolder.RowCount++;
                    tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, aoMinRowWidth));

                    tlpAnswerHolder.Controls.Add(option.answerBox, 2, a + 1);
                    tlpAnswerHolder.Controls.Add(lblTmpNumber, 1, a + 1);


                    //Adding to show Answer is CaseSensitive
                    //Label lblTmpCS = new Label();

                }

                tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (95 + (answers * aoMinRowWidth)));

                minFormHeight = 480 + (answers * aoMinRowWidth);

                this.AutoScroll = true;
                this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);

            }
            #endregion Loading Form with Data
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        public List<AnswerInfo> genAnswers()
        {
            List<AnswerInfo> answers = new List<AnswerInfo>();
            foreach (AnswerOption opt in ans)
            {
                answers.Add(new AnswerInfo(opt.answerBox.Text));
                opt.answerBox.ReadOnly = true;
            }
            return answers;
        }

        public void MarkPage()
        {
            int index = 0;
            foreach (MemoInfo memo in data.Question[0].Memo)
            {
                if (memo.Test(data.Answer[index].Answer))
                {
                    MarkCorrect<TextBox>(ans[index].answerBox);
                    data.Answer[index].CorrectMarkCount = (float)Math.Round((double)(data.GetQuestion().MarkCount / (float)data.Answer.Count), 2);

                }
                else
                {
                    MarkIncorrect<TextBox>(ans[index].answerBox);
                }
                index++;
            }
        }

        public void getFeedback()
        {
            Feedback(data);
        }

        public float MarkCount()
        {
            float count = 0;
            foreach (AnswerInfo ans in data.Answer)
            {
                count += ans.CorrectMarkCount;
            }
            return count;
        }

        public bool noEmptyAnswers()
        {
            if (ans.Find(opt => opt.answerBox.Text.Length == 0) != null)
            {
                DialogResult res = MessageBox.Show("Some fields have been left empty, are you sure you want to submit empty answers?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    ans.Find(opt => opt.answerBox.Text.Length == 0).answerBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        public void Feedback(ExamTask task)
        {
            if (data.Answer == null)
            {
                data.Answer = genAnswers();
            }

            MarkPage();

            lblReceived.Text = $"Mark: {MarkCount()}";
        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }

        public void MarkCorrect<T>(T ctrl) where T : Control
        {
            ctrl.BackColor = Color.Green;
        }

        public void MarkIncorrect<T>(T ctrl) where T : Control
        {
            ctrl.BackColor = Color.Red;
        }

    }
}
