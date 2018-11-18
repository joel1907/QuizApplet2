using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    class OpenQ : IQuestion
    {
        public string Vraag { get; set; }
        public string Category { get; set; }
        public int Moeilijkheid { get; set; }

        List<IAnswer> Answers = new List<IAnswer>();

        public bool Compare(string ans)
        {
            return ans == Answers[0].Antwoord;
        }

        public void AddAnswer(Answer ans)
        {
            if (Answers.Count < 1)
            {
                Answers.Add(ans);
            }
            else
            {
                throw new Exception("Open vraag heeft maar een antwoord");
            }
        }

        public void PrintAnswers() { }

        public void PrintCorrect()
        {
            Console.WriteLine("goede antwoord: " + Answers[0].Antwoord + "\n");
        }
    }
}
