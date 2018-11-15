using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    public class Quiz
    {
        List<IQuestion> questions = new List<IQuestion>();
        public int index { get; set; }

        public void AddQuestion(IQuestion question)
        {
            questions.Add(question);
        }

        public bool CheckAntwoord(string antwoord)
        {
            return questions[index].Compare(antwoord);
        }

        public IQuestion getCurrent()
        {
            return questions[index];
        }
    }
}
