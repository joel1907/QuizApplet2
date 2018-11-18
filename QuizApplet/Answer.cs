using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    public class Answer : IAnswer
    {
        public string Antwoord { get; set; }
        public bool IsGoed { get; set; }
    }
}
