using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    public interface IQuestion
    {
        string Vraag { get; set; }
        string Antwoord { get; set; }

        bool Compare(string ans);
    }
}
