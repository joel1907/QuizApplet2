using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    class MultiQ : IQuestion
    {
        public string Vraag { get; set; }
        public string Category { get; set; }
        public int Moeilijkheid { get; set; }
        List<IAnswer> Answers = new List<IAnswer>();

        public void AddAnswer(Answer ans)
        {
            Answers.Add(ans);
        }

        public bool Compare(string ans)
        {
            bool isGoed = false;

            foreach (Answer answer in Answers)
            {
                isGoed = ans == answer.Antwoord;

                if (isGoed)
                {
                    break;
                }
            }
            return isGoed;
        }

        public void PrintAnswers()
        {
            Console.WriteLine("antwoorden: ");

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer.Antwoord);
            }
        }

        public void PrintCorrect()
        {
            foreach (Answer answer in Answers)
            {
                if (answer.IsGoed)
                {
                    Console.WriteLine("goede antwoord: " + answer.Antwoord + "\n");
                    break;
                }
            }
        }

    }
}
