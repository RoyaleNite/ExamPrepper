using ExamPrepper.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamPrepper.Classes
{

    public class ExamFormData
    {

        public class AnswerInfo : IEquatable<AnswerInfo>
        {
            public string Answer { get; set; }
            public float CorrectMarkCount { get; set; }

            public AnswerInfo(string Answer = null, float CorrectMarkCount = 0)
            {
                this.Answer = Answer;
                this.CorrectMarkCount = CorrectMarkCount;
            }

            public AnswerInfo() { }
            public override bool Equals(Object obj)
            {
                var other = obj as AnswerInfo;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(AnswerInfo other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.Answer.ToUpper() == this.Answer.ToUpper()) return true;
                else return false;
            }

        }

        public enum QuestionTypeList
        {
            MultipleChoice,
            TrueFalse,
            MatchColumn,
            FillBlank,
            BasicQuestion,
        }

        public class MemoInfo
        {

            public string Answer { get; set; }
            public bool CaseSensitive { get; set; }

            public MemoInfo() { }
            
            public MemoInfo(string Answer, bool CaseSensitive = false)
            {
                this.Answer= Answer;
                this.CaseSensitive = CaseSensitive;
            }

            public bool Test(String answer)
            {
                if (CaseSensitive)
                {
                    if (this.Answer.Trim() == answer.Trim()) return true;
                    else return false;
                }
                else
                {
                    if (this.Answer.ToUpper().Trim() == answer.ToUpper().Trim()) return true;
                    else return false;
                }
            }
        }

        public class QuestionInfo : IEquatable<QuestionInfo>
        {
            public string Question { get; set; }
            public List<MemoInfo> Memo { get; set; }
            public List<string> Distractors { get; set; }
            public float MarkCount { get; set; }
            public string QuestionType { get; set; }

            public QuestionInfo(string Question, List<MemoInfo> Memo, float MarkCount = 1, QuestionTypeList QuestionType = QuestionTypeList.BasicQuestion)
            {
                this.Question = Question;
                this.MarkCount = MarkCount;
                this.QuestionType = QuestionType.ToString();
                this.Memo = Memo;
            }

            public QuestionInfo(string Question, List<MemoInfo> Memo, List<string> Distractors, float MarkCount = 1, QuestionTypeList QuestionType = QuestionTypeList.BasicQuestion)
            {
                this.Question = Question;
                this.MarkCount = MarkCount;
                this.Memo = Memo;
                this.QuestionType = QuestionType.ToString();
                this.Distractors = Distractors;
            }

            public QuestionInfo()
            {
                this.MarkCount = 1;
            }

            public MemoInfo GetMemo()
            {
                return Memo[0];
            }

            public override bool Equals(Object obj)
            {
                var other = obj as QuestionInfo;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(QuestionInfo other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.Question.ToUpper() == this.Question.ToUpper()) return true;
                else return false;
            }
        }

        public class ExamTask : IEquatable<ExamTask>
        {
            public string Task_ID { get; set; }
            public string Task_Name { get; set; }
            public Subject Task_Subject { get; set; }
            public List<QuestionInfo> Question { get; set; }
            public List<AnswerInfo> Answer { get; set; }

            public ExamTask(List<QuestionInfo> Question, List<AnswerInfo> Answer, string Task_Name, Subject task_Subject)
            {
                this.Question = Question;
                this.Answer = Answer;
                this.Task_Name = Task_Name;
                this.Task_ID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
                this.Task_Subject = task_Subject;
            }

            public ExamTask(List<QuestionInfo> Question, string Task_Name, Subject task_Subject)
            {
                this.Question = Question;
                this.Task_Name = Task_Name;
                this.Task_ID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
                this.Task_Subject = task_Subject;
            }

            public ExamTask()
            {
                this.Task_ID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            }

            public QuestionInfo GetQuestion()
            {
                if (this.Question.Count > 0)
                    return this.Question[0];
                else
                    return new QuestionInfo();
            }

            public override bool Equals(Object obj)
            {
                var other = obj as ExamTask;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(ExamTask other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.Task_ID == this.Task_ID) return true;
                else return false;
            }

            public void createFile(string filePath)
            {
                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);
                JSONHandler.DataToJSON<ExamTask>(this, $"{filePath}/{this.Task_ID}.json");
            }

        }

        public class ExamInfo : IEquatable<ExamInfo>
        {
            public string Exam_ID { get; set; }
            public string Exam_Name { get; set; }
            public ExamInfo(string Exam_Name = null)
            {
                this.Exam_Name = Exam_Name;
                this.Exam_ID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            }
            public ExamInfo()
            {
                this.Exam_ID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            }

            public override bool Equals(Object obj)
            {
                var other = obj as ExamInfo;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(ExamInfo other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.Exam_ID == this.Exam_ID) return true;
                else return false;
            }

        }

        public class Exam : IEquatable<Exam>
        {
            public ExamInfo Exam_Info { get; set; }
            public List<ExamSection> Sections { get; set; }
            public Exam(ExamInfo Exam_Info, List<ExamSection> Sections)
            {
                this.Exam_Info = Exam_Info;
                this.Sections = Sections;
            }

            public Exam() { }

            public override bool Equals(Object obj)
            {
                var other = obj as Exam;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(Exam other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.Exam_Info.Exam_ID == this.Exam_Info.Exam_ID) return true;
                else return false;
            }

            public bool isExam()
            {
                if (Sections == null) return false;
                if (Sections[0].Section == "Quiz") return false;
                else return true;
            }

            public void createFile(string filePath)
            {
                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);
                JSONHandler.DataToJSON<Exam>(this, $"{filePath}/{this.Exam_Info.Exam_ID}.json");
            }

        }

        public class ExamSection
        {
            public string Section { get; set; }
            public List<ExamTask> Section_Tasks { get; set; }
            public Results Results { get; set; }

            public ExamSection() { }

            public ExamSection(string section, List<ExamTask> Section_Tasks)
            {
                this.Section = section;
                this.Section_Tasks = Section_Tasks;
            }
        }

        public class Results
        {
            public string ResultID { get; set; }
            public string ExamID { get; set; }
            public double MarkPercentage { get; set; }
            public float TotalMarks { get; set; }
            public float TotalCorrectMarks { get; set; }
            public List<AnswerInfo> Answers { get; set; }
            public Results(double MarkPercentage, float TotalMarks, string ExamID, float TotalCorrectMarks, List<AnswerInfo> answers) 
            { 
                this.MarkPercentage = MarkPercentage;
                this.TotalMarks = TotalMarks;
                this.TotalCorrectMarks = TotalCorrectMarks;
                this.ExamID = ExamID;
                this.Answers = answers;
                this.ResultID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            }

            public Results() 
            {
                this.ResultID = DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            }

            public void createFile(string filePath)
            {
                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);
                JSONHandler.DataToJSON<Results>(this, $"{filePath}/{this.ResultID}.json");
            }
        }

        public class Subject : IEquatable<Subject>
        {
            public string SubjectID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public Subject(string subjectID, string name, string description)
            {
                Name = name;
                Description = description;
                SubjectID = subjectID;
            }

            public Subject() { }

            public override bool Equals(Object obj)
            {
                var other = obj as Subject;
                if (other == null) return false;

                return Equals(other);
            }

            public bool Equals(Subject other)
            {
                if (other == null)
                {
                    return false;
                }

                if (other.SubjectID == this.SubjectID) return true;
                else return false;
            }

            public static string getSubjectName(string subjectId)
            {
                string subjectName = "";

                List<Subject> subs = JSONHandler.JSONToData<List<Subject>>("./Data/Subjects.json");

                int index = subs.FindIndex(sub => sub.SubjectID == subjectId);
                if (index == -1) { return null; }
                else
                {
                    return subs[index].Name;
                }
            }

            public static Subject getSubjectByID(string subjectId)
            {
                string subjectName = "";

                List<Subject> subs = JSONHandler.JSONToData<List<Subject>>("./Data/Subjects.json");

                int index = subs.FindIndex(sub => sub.SubjectID == subjectId);
                if (index == -1) { return null; }
                else
                {
                    return subs[index];
                }
            }
        }
    }
}
