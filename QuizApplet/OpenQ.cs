using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    class OpenQ : IQuestion
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }

        public bool Compare(string ans)
        {
            return Antwoord == ans;
        }
    }
}
