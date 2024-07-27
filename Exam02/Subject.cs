using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Subject : ICloneable, IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Exam = exam;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"SubjectId: {SubjectId} \nSubjectName: {SubjectName} \nExam: {Exam.GetType().Name}";
        }

        public object Clone()
        {
            return new Subject(SubjectId, SubjectName, Exam);

        }

        public int CompareTo(Subject? OBJ)
        {
            return SubjectId.CompareTo(OBJ.SubjectId);
        }
    }

}
