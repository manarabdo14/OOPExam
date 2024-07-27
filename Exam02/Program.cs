namespace Exam02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Answer[] answers = new Answer[]
            {
            new Answer(1, "10"),
            new Answer(2, "11"),
            new Answer(3, "20"),
            new Answer(4, "47")
            };

            Question[] finalExamQuestions = new Question[]
            {
            new TrueFalseQuestion(" True False Question", " Q1: this equatin  is true ? 7 + 25 - 2 = 30  ", 1,true),
            new MCQQuestion("Choose one:", "4 + 7 = ....", 3, answers, answers[1])
            };

            Exam finalExam = new FinalExam(DateTime.Now,3, finalExamQuestions);

            Subject subject = new Subject(1, "Mathematics", finalExam);

            subject.CreateExam(finalExam);

            Console.WriteLine(subject);
            Console.WriteLine("-----------------------------------------------------");

            finalExam.ShowExam();
        }
    }

}
