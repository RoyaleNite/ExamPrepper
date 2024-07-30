using ExamPrepper.Classes;
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

namespace ExamPrepper.Forms.QuestionForms
{
    public partial class qfrmMatchColumn : Form, qfrmInterface
    {
        public ExamTask _data;
        public ExamTask data
        {
            get { return _data; }
            set { _data = value; }
        }
        public List<AnswerOption> ansS = new List<AnswerOption>();
        public List<AnswerOption> queS = new List<AnswerOption>();

        #region Form Variables
        private int minFormWidth = 585;
        public int minFormHeight = 385;

        private int minRowHeight = 35;

        private int txtFontSize = 28;
        private int wrapTxtHeight = 20;
        private int minExtraTLPHeight = 80;

        public struct AnswerOption
        {
            public Label answerChar;
            public ComboBox questionAnswer;

            public AnswerOption(Label answerChar, ComboBox questionAnswer)
            {
                this.answerChar = answerChar;
                this.questionAnswer = questionAnswer;
            }

            public AnswerOption()
            {
                #region Label
                this.answerChar = new Label();
                this.answerChar.Text = "";
                this.answerChar.Name = "lblAnswer";
                this.answerChar.Dock = DockStyle.Fill;
                this.answerChar.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                this.answerChar.TextAlign = ContentAlignment.MiddleRight;
                #endregion Label

                #region ComboBox
                this.questionAnswer = new ComboBox();
                this.questionAnswer.Text = "";
                this.questionAnswer.Name = "cbxAnswer";
                this.questionAnswer.Dock = DockStyle.Fill;
                this.questionAnswer.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion ComboBox
            }
        }
        #endregion Form Variables

        public qfrmMatchColumn()
        {
            InitializeComponent();
        }

        private void qfrmMatchColumn_Load(object sender, EventArgs e)
        {
            nudMarks.Controls[0].Visible = false;

            #region Loading Form with Data
            if (data != null)
            {
                nudMarks.Value = (decimal)data.GetQuestion().MarkCount;

                List<string> Answers = new List<string>();

                foreach (QuestionInfo que in data.Question)
                {
                    foreach (MemoInfo memo in que.Memo)
                    {
                        Answers.Add($"{memo.Answer}");
                    }
                    if (que.Distractors == null) continue;
                    if (que.Distractors.Count > 0)
                    {
                        foreach (string distractor in que.Distractors)
                        {
                            Answers.Add(distractor);
                        }
                    }
                }

                Random _rand = new Random();
                Answers = Answers.OrderBy(_ => _rand.Next()).ToList();

                List<string> ansChars = new List<string>();

                for (int a = 0; a < Answers.Count; a++)
                {
                    Answers[a] = $"({(char)(65 + a)}) {Answers[a]}";
                    lblQuestion.Text += $" {Answers[a]} //";
                    ansChars.Add($"{(char)(65 + a)}");
                    AnswerOption que = new AnswerOption();
                    que.answerChar.Text = $"{(char)(65 + a)}";
                    que.questionAnswer.Text = $"{Answers[a]}";
                    queS.Add(que);
                }

                lblQuestion.Text = lblQuestion.Text.Remove(lblQuestion.Text.Length - 3);

                tlpMHolder.RowStyles[1] = new RowStyle(SizeType.Absolute, 60 + calcTLPHeight(lblQuestion));

                for (int a = 0; a < data.Question.Count; a++)
                {
                    Label lblQue = new Label();
                    lblQue.Text = data.Question[a].Question;
                    lblQue.Name = "lblAns" + a;
                    lblQue.Dock = DockStyle.Top;
                    lblQue.AutoSize = true;
                    lblQue.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);

                    int height = calcTLPHeight(lblQue);

                    ComboBox cbxSelect = new ComboBox();
                    cbxSelect.Text = "";
                    cbxSelect.Name = "cbxCC" + a;
                    cbxSelect.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);

                    tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, height));

                    if (data.Answer != null)
                    {
                        cbxSelect.Items.Add(queS.Find(que => que.questionAnswer.Text.Contains(data.Answer[a].Answer)).answerChar.Text);
                    }
                    else
                    {
                        cbxSelect.Items.AddRange(ansChars.ToArray());
                    }
                    cbxSelect.SelectedIndex = 0;

                    AnswerOption opt = new AnswerOption(lblQue, cbxSelect);
                    ansS.Add(opt);
                    tlpAnswerHolder.Controls.Add(opt.answerChar, 1, a + 1);
                    tlpAnswerHolder.Controls.Add(opt.questionAnswer, 2, a + 1);
                }
            }
            #endregion Loading Form with Data

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);
        }

        private int calcTLPHeight(Control ctrl)
        {
            int intExtraSize = 0;
            int intTotalSPacing = 0;

            int txtWidth = TextRenderer.MeasureText(ctrl.Text, ctrl.Font, ctrl.Size).Width + txtFontSize;

            intExtraSize += txtWidth / ctrl.Width;
            int intSpacing = 0;
            if (intExtraSize > 0)
            {
                intSpacing = 6;
                intTotalSPacing += intSpacing;
            }

            return (((txtWidth / ctrl.Width)) * wrapTxtHeight + intSpacing + minRowHeight);
        }

        private void updateLabels()
        {
            decimal extraSize = 0;
            int totCtrl = 0;
            int totalSPacing = 0;

            foreach (Control ctrl in tlpAnswerHolder.Controls)
            {
                if (ctrl is Label)
                {
                    totCtrl++;
                    int txtWidth = TextRenderer.MeasureText(ctrl.Text, ctrl.Font, ctrl.Size).Width + txtFontSize;

                    TableLayoutPanelCellPosition cellPos = tlpAnswerHolder.GetCellPosition(ctrl);

                    extraSize += txtWidth / ctrl.Width;
                    if (ctrl.Width * (extraSize + 1) < txtWidth) extraSize++;
                    int spacing = 0;
                    if (extraSize > 0)
                    {
                        spacing = 6;
                        totalSPacing += spacing;
                    }

                    tlpAnswerHolder.RowStyles[cellPos.Row] = new RowStyle(SizeType.Absolute, ((float)extraSize * wrapTxtHeight) + spacing + minRowHeight);
                }
            }

            tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (minExtraTLPHeight + ((float)extraSize * wrapTxtHeight) + totalSPacing + (totCtrl * minRowHeight)));
            int minFrmHeight = minFormHeight + (int)((float)extraSize * wrapTxtHeight) + (totCtrl * minRowHeight);

            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFrmHeight);
        }

        private void qfrmMatchColumn_ResizeEnd(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void qfrmMatchColumn_Shown(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void btnCorrect_VisibleChanged(object sender, EventArgs e)
        {

        }

        public bool noEmptyAnswers()
        {
            return true;
        }

        public List<AnswerInfo> genAnswers()
        {
            List<AnswerInfo> answers = new List<AnswerInfo>();
            foreach (AnswerOption opt in ansS)
            {
                string ans = queS.Find(que => que.answerChar.Text.ToUpper() == opt.questionAnswer.SelectedItem.ToString().ToUpper()).questionAnswer.Text.Substring(3);
                answers.Add(new AnswerInfo(ans));
                string answer = opt.questionAnswer.SelectedItem.ToString();
                opt.questionAnswer.Items.Clear();
                opt.questionAnswer.Items.Add(answer);
                opt.questionAnswer.SelectedIndex = 0;
            }

            data.Answer = answers;
            return answers;
        }

        public void MarkPage()
        {
            int index = 0;
            foreach (QuestionInfo que in data.Question)
            {
                if (que.GetMemo().Test(data.Answer[index].Answer))
                {
                    MarkCorrect<ComboBox>(ansS[index].questionAnswer);
                    data.Answer[index].CorrectMarkCount = (float)Math.Round((double)(data.GetQuestion().MarkCount / (float)data.Answer.Count), 2);
                }
                else
                {
                    MarkIncorrect<ComboBox>(ansS[index].questionAnswer);
                }
                index++;
            }
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

        public void getFeedback()
        {
            Feedback(data);
        }

        public void Feedback(ExamTask task)
        {
            if (data.Answer == null)
                data.Answer = genAnswers();

            MarkPage();

            lblReceived.Text = $"Mark: {MarkCount()}";
        }

        public void MarkCorrect<T>(T ctrl) where T : Control
        {
            ctrl.BackColor = Color.Green;
        }

        public void MarkIncorrect<T>(T ctrl) where T : Control
        {
            ctrl.BackColor = Color.Red;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
