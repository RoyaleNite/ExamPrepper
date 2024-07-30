using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamPrepper.Classes.ExamFormData;
using static ExamPrepper.frmMainForm;

namespace ExamPrepper.Forms.QuestionForms
{
    public partial class qfrmQuestion : Form, qfrmInterface
    {
        //Form Variables
        public ExamTask _data;
        public ExamTask data
        {
            get { return _data; }
            set { _data = value; }
        }

        private hfrmHelp hfrmHelp = null;

        public qfrmQuestion()
        {
            InitializeComponent();
        }

        private void qfrmQuestion_Load(object sender, EventArgs e)
        {
            nudMarks.Controls[0].Visible = false;

            #region Loading Form with Data
            if (_data != null)
            {
                nudMarks.Value = (decimal)_data.GetQuestion().MarkCount;
                rtbQuestion.Text = _data.GetQuestion().Question;
                if (data.Answer?.Count > 0)
                {
                    rtbAnswer.Text = data.Answer[0].Answer;
                    if (data.Answer[0].CorrectMarkCount > 0)
                        MarkCorrect<RichTextBox>(rtbAnswer);
                    else
                        MarkIncorrect<RichTextBox>(rtbAnswer);
                    lblReceived.Text = $"Mark: {MarkCount()}";
                }

                this.AutoScroll = true;
                this.AutoScrollMinSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
            }
            #endregion Loading Form with Data
        }

        private void tlpMHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCorrect_VisibleChanged(object sender, EventArgs e)
        {
            btnCorrect.Text = ((char)0x221A).ToString();
        }

        public void MarkPage()
        {

        }

        public List<AnswerInfo> genAnswers()
        {
            data.Answer = new List<AnswerInfo>() { new AnswerInfo(rtbAnswer.Text) };
            return data.Answer;
        }

        public void getFeedback()
        {
            btnCorrect.Visible = true;
            btnWrong.Visible = true;
            btnViewAnswer.Visible = true;
            btnViewAnswer.PerformClick();
            Feedback(data);
            tlpMHolder.RowStyles[4] = new RowStyle(SizeType.Absolute, 125);
        }

        public float MarkCount()
        {
            float count = 0;
            foreach (AnswerInfo ans in _data.Answer)
            {
                count += ans.CorrectMarkCount;
            }
            return count;
        }

        public void Feedback(ExamTask task)
        {
            genAnswers();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            MarkCorrect<RichTextBox>(rtbAnswer);
            data.Answer[0].CorrectMarkCount = data.GetQuestion().MarkCount;
            rtbAnswer.ReadOnly = true;
            lblReceived.Text = $"Mark: {MarkCount()}";
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            MarkIncorrect<RichTextBox>(rtbAnswer);
            data.Answer[0].CorrectMarkCount = 0;
            rtbAnswer.ReadOnly = true;
            lblReceived.Text = $"Mark: {MarkCount()}";
        }

        private void pnlHeadingHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            if (hfrmHelp == null)
            {
                hfrmHelp = new hfrmHelp();
                hfrmHelp.MinimumSize = new System.Drawing.Size(400, 300);
                hfrmHelp.Size = hfrmHelp.MinimumSize;
                hfrmHelp.rtbHelp.Text = data.GetQuestion().GetMemo().Answer;
                hfrmHelp.Text = "Answer";
                hfrmHelp.FormClosing += (s, e) =>
                {
                    hfrmHelp = null;
                };
                FormHandler(hfrmHelp, normalShow: true);
            }
        }

        private void qfrmQuestion_Leave(object sender, EventArgs e)
        {
            if (hfrmHelp != null)
            {
                hfrmHelp.Close();
                hfrmHelp = null;
            }
        }

        private void qfrmQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hfrmHelp != null)
            {
                hfrmHelp.Close();
                hfrmHelp = null;
            }
        }

        public bool noEmptyAnswers()
        {
            if (rtbAnswer.Text.Length == 0)
            {
                DialogResult res = MessageBox.Show("Some fields have been left empty, are you sure you want to submit empty answers?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    rtbAnswer.Focus();
                    return false;
                }
                else
                    return true;
            }
            else return true;
        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }

        private void rtbAnswer_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Answer");
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
