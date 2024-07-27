using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, string body, int mark, bool correctAnswer)
                : base(header, body, mark)
            {
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCorrect Answer: {CorrectAnswer}";
        }
    }
}
