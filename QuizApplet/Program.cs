using System;

namespace QuizApplet
{
    class Program
    {

        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            
            OpenQ q1 = new OpenQ()
            {
                Vraag = "\"test\".length",
                Antwoord = "4"

            };
            quiz.AddQuestion(q1);

            string a = "5";
            Console.WriteLine("vraag: "+quiz.getCurrent().Vraag);
            Console.WriteLine("antwoord: "+quiz.getCurrent().Antwoord);
            Console.WriteLine("gegeven antwoord: "+a);
            Console.WriteLine(quiz.CheckAntwoord(a));
            
            Console.ReadLine();
        }
    }
}
