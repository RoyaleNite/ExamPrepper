using ExamPrepper.Classes;
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

namespace ExamPrepper.Forms.QuestionForms
{
    public partial class qfrmMultiChoice : Form, qfrmInterface
    {

        public ExamTask _data;
        public ExamTask data
        {
            get { return _data; }
            set { _data = value; }
        }
        public int showDistractions = -1;

        #region Form Variables
        //Form Variables
        public int minRowHeight = 35;
        private int wrapTxtHeight = 20;
        private int minFormWidth = 585;

        private int minExtraTLPHeight = 80;

        private int txtFontSize = 14;

        public List<AnswerOption> answerOptions = new List<AnswerOption>();

        public struct AnswerOption
        {
            public Label answerBox;
            public CheckBox correctAnswer;
            public Button removeChoice;

            public AnswerOption(Label answerBox, CheckBox correctAnswer, Button removeChoice)
            {
                this.answerBox = answerBox;
                this.correctAnswer = correctAnswer;
                this.removeChoice = removeChoice;
            }

            public AnswerOption()
            {
                #region TextBoxes
                this.answerBox = new Label();
                this.answerBox.Text = "";
                this.answerBox.Name = "txtAnswer";
                this.answerBox.Dock = DockStyle.Fill;
                this.answerBox.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
                #endregion TextBoxes

                #region CheckBoxes
                this.correctAnswer = new CheckBox();
                this.correctAnswer.Text = "";
                this.correctAnswer.Name = "chbCC";
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
                this.removeChoice.Name = "btnRC";
                this.removeChoice.Text = "X";
                this.removeChoice.UseVisualStyleBackColor = false;
                #endregion Buttons
            }
        }
        #endregion Form Variables

        public qfrmMultiChoice()
        {
            InitializeComponent();
        }

        private void qfrmMultiChoice_Load(object sender, EventArgs e)
        {
            nudMarks.Controls[0].Visible = false;

            #region Loading Form with Data
            if (data != null)
            {
                nudMarks.Value = (decimal)data.GetQuestion().MarkCount;
                rtbQuestion.Text = data.GetQuestion().Question;

                if (data.GetQuestion().Memo.Count() < 4 && showDistractions == -1) showDistractions = 4 - data.GetQuestion().Memo.Count();
                if (showDistractions > data.GetQuestion().Distractors.Count()) showDistractions = data.GetQuestion().Distractors.Count();

                int totalAnswers = data.GetQuestion().Memo.Count();
                totalAnswers += showDistractions == -1 ? 1 : showDistractions;

                tlpAnswerHolder.RowCount = totalAnswers;

                List<string> ansAndDistractions = new List<string>();
                foreach (MemoInfo ansI in data.GetQuestion().Memo)
                {
                    ansAndDistractions.Add(ansI.Answer);
                }

                Random _rand = new Random();
                var randDistractors = data.GetQuestion().Distractors.OrderBy(_ => _rand.Next()).ToList();

                for (int a = 0; a < showDistractions; a++)
                {
                    ansAndDistractions.Add(randDistractors[a]);
                }

                ansAndDistractions = ansAndDistractions.OrderBy(_ => _rand.Next()).ToList();

                for (int a = 0; a < totalAnswers; a++)
                {
                    Label txtAns = new Label();
                    txtAns.Text = ansAndDistractions[a];
                    txtAns.Name = "lblAns" + a;
                    txtAns.Dock = DockStyle.Top;
                    txtAns.AutoSize = true;
                    txtAns.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);

                    tlpAnswerHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, minRowHeight));

                    txtAns.TabIndex = a;

                    CheckBox chbSelect = new CheckBox();
                    chbSelect.Text = "";
                    chbSelect.Name = "chbCC" + a;

                    if (data.Answer != null)
                    {
                        if (data.Answer.Find(ans => ans.Answer == txtAns.Text) != null) chbSelect.Checked = true; ;
                    }
                    else
                    {
                        chbSelect.Checked = false;
                    }

                    chbSelect.Font = new Font("Calibri Light", 14F, FontStyle.Regular, GraphicsUnit.Point);

                    AnswerOption opt = new AnswerOption(txtAns, chbSelect, new Button());

                    answerOptions.Add(opt);
                    tlpAnswerHolder.Controls.Add(opt.answerBox, 2, a + 1);
                    tlpAnswerHolder.Controls.Add(opt.correctAnswer, 1, a + 1);
                }
                updateLabels();
            }
            #endregion Loading Form with Data
        }

        private void qfrmMultiChoice_ResizeEnd(object sender, EventArgs e)
        {
            updateLabels();
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
                    int spacing = 0;
                    if (extraSize > 0)
                    {
                        spacing = 6;
                        totalSPacing += spacing;
                    }

                    tlpAnswerHolder.RowStyles[cellPos.Row] = new RowStyle(SizeType.Absolute, (((txtWidth / ctrl.Width)) * wrapTxtHeight) + spacing + minRowHeight);
                }
            }

            tlpMHolder.RowStyles[2] = new RowStyle(SizeType.Absolute, (minExtraTLPHeight + ((float)extraSize * wrapTxtHeight) + totalSPacing + (totCtrl * minRowHeight)));
            int minFrmHeight = 490 + (int)((float)extraSize * wrapTxtHeight) + (totCtrl * minRowHeight);

            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFrmHeight);
        }

        public bool noEmptyAnswers()
        {
            return true;
        }

        public List<AnswerInfo> genAnswers()
        {
            List<AnswerInfo> answers = new List<AnswerInfo>();
            foreach (AnswerOption opt in answerOptions)
            {
                opt.answerBox.Enabled = false;
                opt.correctAnswer.Enabled = false;
                if (opt.correctAnswer.Checked) answers.Add(new AnswerInfo(opt.answerBox.Text));
            }
            return answers;
        }

        public void MarkPage()
        {
            float markCount = 0;

            foreach (AnswerOption opt in answerOptions)
            {
                if (opt.correctAnswer.Checked && data.GetQuestion().Memo.Find(memo => memo.Test(opt.answerBox.Text)) != null)
                {
                    MarkCorrect<Label>(opt.answerBox, opt.correctAnswer);
                    markCount = (float)Math.Round((double)(data.GetQuestion().MarkCount / (float)data.Answer.Count), 2); ;
                }
                else if (opt.correctAnswer.Checked && data.GetQuestion().Memo.Find(memo => memo.Test(opt.answerBox.Text)) == null)
                {
                    MarkIncorrect<Label>(opt.answerBox, opt.correctAnswer);
                    markCount = (float)Math.Round((double)(data.GetQuestion().MarkCount / (float)data.Answer.Count), 2) * -1.0f;
                }
            }
        }

        public float MarkCount()
        {
            float count = 0;
            foreach (AnswerInfo ans in data.Answer)
            {
                count += ans.CorrectMarkCount;
            }
            if (count < 0) count = 0;
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

            float markCount = 0;
            List<AnswerInfo> answerInfos = new List<AnswerInfo>();
            foreach (AnswerOption opt in answerOptions)
            {
                if (opt.correctAnswer.Checked && data.GetQuestion().Memo.Find(memo => memo.Answer.ToUpper().Trim().Equals(opt.answerBox.Text.ToUpper().Trim())) != null)
                {
                    MarkCorrect<Label>(opt.answerBox, opt.correctAnswer);
                    markCount = data.GetQuestion().MarkCount / answerOptions.Count;
                }
                else if (opt.correctAnswer.Checked && data.GetQuestion().Memo.Find(memo => memo.Answer.ToUpper().Trim().Equals(opt.answerBox.Text.ToUpper().Trim())) == null)
                {
                    MarkIncorrect<Label>(opt.answerBox, opt.correctAnswer);
                    markCount = data.GetQuestion().MarkCount / answerOptions.Count * -1;
                }
                opt.answerBox.Enabled = false;
                opt.correctAnswer.Enabled = false;
                answerInfos.Add(new AnswerInfo(opt.answerBox.Text, CorrectMarkCount: markCount));
            }

            data.Answer = answerInfos;

            lblReceived.Text = $"Mark: {MarkCount()}";
        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }

        public void MarkCorrect<T>(T ctrl, CheckBox chkCheck) where T : Control
        {
            ctrl.ForeColor = Color.Green;
            chkCheck.BackColor = Color.Green;
        }

        public void MarkIncorrect<T>(T ctrl, CheckBox chkCheck) where T : Control
        {
            ctrl.ForeColor = Color.Red;
            chkCheck.BackColor = Color.Red;
        }

    }
}
