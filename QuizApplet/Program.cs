using System;

namespace QuizApplet
{
    class Program
    {

        static void Main(string[] args)
        {
            MakeQuiz().play();
        }

        public static Quiz MakeQuiz()
        {
            Quiz quiz = new Quiz();

            //---length---
            OpenQ length1 = new OpenQ()
            {
                Vraag = "\"test\".length",
                Category = "length",
                Moeilijkheid = 1
            };
            length1.AddAnswer(new Answer()
            {
                Antwoord = "4",
                IsGoed = true
            });
            MultiQ length2 = new MultiQ()
            {
                Vraag = "\"testString\".length",
                Category = "length",
                Moeilijkheid = 2
            };
            length2.AddAnswer(new Answer()
            {
                Antwoord = "12",
                IsGoed = false
            });
            length2.AddAnswer(new Answer()
            {
                Antwoord = "9",
                IsGoed = false
            });
            length2.AddAnswer(new Answer()
            {
                Antwoord = "10",
                IsGoed = true
            });

            //---pewd---
            MultiQ pewd1 = new MultiQ()
            {
                Vraag = "wie host pewnews",
                Category = "pewd",
                Moeilijkheid = 3
            };
            pewd1.AddAnswer(new Answer()
            {
                Antwoord = "poppy harlow",
                IsGoed = true
            });
            pewd1.AddAnswer(new Answer()
            {
                Antwoord = "gloria borger",
                IsGoed = false
            });
            pewd1.AddAnswer(new Answer()
            {
                Antwoord = "dr. phil",
                IsGoed = false
            });
            OpenQ pewd2 = new OpenQ()
            {
                Vraag = "gaat u subscriben op pewdiepie",
                Category = "pewd",
                Moeilijkheid = 1
            };
            pewd2.AddAnswer(new Answer()
            {
                Antwoord = "ja",
                IsGoed = true
            });

            //---smash--
            OpenQ smash1 = new OpenQ()
            {
                Vraag = "hoeveel characters zijn er in smash op 7 dec",
                Category = "smash",
                Moeilijkheid = 3
            };
            smash1.AddAnswer(new Answer()
            {
                Antwoord = "74",
                IsGoed = true
            });

            MultiQ smash2 = new MultiQ()
            {
                Vraag = "wie is geen dlc character",
                Category = "smash",
                Moeilijkheid = 2
            };
            smash2.AddAnswer(new Answer()
            {
                Antwoord = "geno",
                IsGoed = false
            });
            smash2.AddAnswer(new Answer()
            {
                Antwoord = "banjo & kazooie",
                IsGoed = false
            });
            smash2.AddAnswer(new Answer()
            {
                Antwoord = "shadow",
                IsGoed = true
            });

            quiz.AddQuestion(length1);
            quiz.AddQuestion(length2);
            quiz.AddQuestion(pewd1);
            quiz.AddQuestion(pewd2);
            quiz.AddQuestion(smash1);
            quiz.AddQuestion(smash2);

            return quiz;
        }
    }
}
