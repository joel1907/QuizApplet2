using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    public interface IQuestion
    {
        string Vraag { get; set; }
        string Category { get; set; }
        int Moeilijkheid { get; set; }

        void PrintAnswers();
        void PrintCorrect();
        void AddAnswer(Answer ans);
        bool Compare(string ans);
    }
}
