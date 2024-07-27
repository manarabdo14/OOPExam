using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class MCQQuestion :Question
    {
        public Answer[] AnswerArray { get; set; }
        public Answer CorrectAnswer { get; set; }

        public MCQQuestion(string header, string body, int mark, Answer[] answerArray, Answer correctAnswer)
            : base(header, body, mark)
        {
            AnswerArray = answerArray;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            string answersStr = string.Join(", ", AnswerArray.Select(a => a.ToString()));
            return base.ToString() + $"\nAnswers: [{answersStr}]\nCorrect Answer: {CorrectAnswer}";
        }
    }
}
