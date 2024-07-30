using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExamPrepper.Classes.ExamFormData;
    
namespace ExamPrepper.Forms
{
    internal interface qfrmInterface
    {
        public void getFeedback() { }
        public void MarkPage() { }
        public ExamTask data { get; set; }
        public float MarkCount() { return MarkCount(); }
        public List<AnswerInfo> genAnswers();
        public bool noEmptyAnswers();
    }
}
