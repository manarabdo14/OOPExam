using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public FinalExam(DateTime timeOfExam, int numberOfQuestions, Question[] questions)
            : base(timeOfExam, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("-----------------------------------------------------");
            }

        }
    }
}
