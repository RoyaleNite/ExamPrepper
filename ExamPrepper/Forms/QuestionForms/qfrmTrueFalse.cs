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
    public partial class qfrmTrueFalse : Form, qfrmInterface
    {
        public ExamTask _data;
        public ExamTask data
        {
            get { return _data; }
            set { _data = value; }
        }

        #region Form Variables
        private int minFormWidth = 585;
        private int minFormHeight = 500;
        #endregion Form Variables

        public qfrmTrueFalse()
        {
            InitializeComponent();
        }

        private void qfrmTrueFalse_Load(object sender, EventArgs e)
        {
            nudMarks.Controls[0].Visible = false;

            #region Loading Form with Data
            if (data != null)
            {
                nudMarks.Value = (decimal)data.GetQuestion().MarkCount;
                rtbQuestion.Text = data.GetQuestion().Question;
                if (data.Answer != null)
                    if (data.Answer[0].Answer.ToUpper() == "TRUE")
                        rbTrue.Checked = true;
                    else rbFalse.Checked = true;
            }
            #endregion Loading Form with Data

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(minFormWidth, minFormHeight);
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
            List<AnswerInfo> answers = new List<AnswerInfo>() { new AnswerInfo(rbTrue.Checked.ToString().ToUpper()) };
            return answers;
        }

        public void MarkPage()
        {
            RadioButton rbSelected = rbTrue.Checked ? rbTrue : rbFalsse;
            Label lblSelected = rbTrue.Checked ? lblTrue : lblFalsse;

            if (data.GetQuestion().GetMemo().Test(rbTrue.Checked.ToString()))
            {
                MarkCorrect<RadioButton>(rbSelected, lblSelected);
                data.Answer[0].CorrectMarkCount = data.GetQuestion().MarkCount;
            }
            else
            {
                MarkIncorrect<RadioButton>(rbSelected, lblSelected);
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

        public ExamTask Feedback(ExamTask task)
        {
            ExamTask returnTask = task;

            if (data.Answer == null)
                data.Answer = genAnswers();

            MarkPage();

            lblReceived.Text = $"Mark: {MarkCount()}";

            return returnTask;
        }

        public void MarkCorrect<T>(T ctrl, Label lblExtra) where T : Control
        {
            ctrl.BackColor = Color.Green;
            lblExtra.ForeColor = Color.Green;
        }

        public void MarkIncorrect<T>(T ctrl, Label lblExtra) where T : Control
        {
            ctrl.BackColor = Color.Red;
            lblExtra.ForeColor = Color.Red;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void rtbQuestion_MouseHover(object sender, EventArgs e)
        {
            mainForm.tt.SetToolTip(sender as RichTextBox, "Task Question");
        }
    }
}
