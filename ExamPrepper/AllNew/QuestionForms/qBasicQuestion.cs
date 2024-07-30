using ExamPrepper.AllNew.QuestionForms;
using ExamPrepper.Properties;
using MaterialSkin.Controls;
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

namespace ExamPrepper
{
    public partial class qBasicQuestion : FormTemplate
    {
        public qBasicQuestion()
        {
            InitializeComponent();
        }

        public qBasicQuestion(ExamTask data)
        {
            InitializeComponent();


            lblMarks.Text = $"({data?.Question?[0]?.MarkCount.ToString()})";
            mtbQuestion.Text = data?.Question?[0]?.Question;

            ucMarking marking = new ucMarking();
            this.tlpQuestionHolder.Controls.Add(marking, 2, 0);

            //nudMarks.Value = (decimal)_data.GetQuestion().MarkCount;
            //rtbQuestion.Text = _data.GetQuestion().Question;
            //if (data.Answer?.Count > 0)
            //{
            //    rtbAnswer.Text = data.Answer[0].Answer;
            //    if (data.Answer[0].CorrectMarkCount > 0)
            //        MarkCorrect<RichTextBox>(rtbAnswer);
            //    else
            //        MarkIncorrect<RichTextBox>(rtbAnswer);
            //    lblReceived.Text = $"Mark: {MarkCount()}";
            //}

            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);


        }
        public qBasicQuestion(UserControl customControls)
        {
            InitializeComponent();

            tlpMHolder.Controls.Add(customControls, 0, 0);
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
        }

    }
}
