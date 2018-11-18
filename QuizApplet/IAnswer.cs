using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplet
{
    interface IAnswer
    {
        string Antwoord { get; set; }
        bool IsGoed { get; set; }
    }
}
