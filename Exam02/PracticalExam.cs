using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(DateTime timeOfExam, int numberOfQuestions, Question[] questions)
            : base(timeOfExam, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                if (question is MCQQuestion mcq)
                {
                    Console.WriteLine($"Correct Answer: {mcq.CorrectAnswer.AnswerText}");
                }
            }
        }
    }
}
