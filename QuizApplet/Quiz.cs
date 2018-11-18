using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public void play()
        {
            SetSettings();

            while (index < questions.Count)
            {
                Console.WriteLine("vraag: " + questions[index].Vraag);
                questions[index].PrintAnswers();
                string ans = Console.ReadLine();
                Console.WriteLine("Correct: " + CheckAntwoord(ans));
                questions[index].PrintCorrect();
                index++;
            }
            Console.ReadLine();
        }

        public void SetSettings()
        {
            Console.WriteLine("waarop moet gesoorteerd worden:\ncategory, moeilijkheid, niet (bij ongelige invoer wordt \"niet\" gekozen)");
            string setting = Console.ReadLine();
            if (setting == "category")
            {
                SorteerCategory();
            }
            else if (setting == "moeilijkheid")
            {
                SorteerMoeilijkheid();
            }

            Console.WriteLine("Kies een category:");
            List<String> categorys = GetCategorys();
            PrintCategorys(categorys);
            setting = Console.ReadLine();

            foreach (String s in categorys)
            {
                if (s == setting)
                {
                    PakCategory(s);
                }
            }

            Console.WriteLine("Kies een moeilijkheid:\n1, 2, 3, niet (bij ongelige invoer wordt \"niet\" gekozen)");
            setting = Console.ReadLine();
            if (setting == "1" || setting == "2" || setting == "3")
            {
                PakMoeilijkheid(int.Parse(setting));
            }
            Console.WriteLine("");
        }

        public void SorteerCategory()
        {
            var newQuestions = questions.OrderBy(s => s.Category);
            questions = new List<IQuestion>(newQuestions.ToList());
        }

        public void SorteerMoeilijkheid()
        {
            var newQuestions = questions.OrderBy(s => s.Moeilijkheid);
            questions = new List<IQuestion>(newQuestions.ToList());
        }

        public void PakCategory(string category)
        {
            var newQuestions = questions.Where(s => s.Category == category);
            questions = new List<IQuestion>(newQuestions.ToList());
        }

        public void PakMoeilijkheid(int moeilijkheid)
        {
            var newQuestions = questions.Where(s => s.Moeilijkheid == moeilijkheid);
            questions = new List<IQuestion>(newQuestions.ToList());
        }

        public List<string> GetCategorys()
        {
            List<string> categorys = new List<string>();

            foreach (IQuestion question in questions)
            {
                if (!categorys.Contains(question.Category))
                {
                    categorys.Add(question.Category);
                }
            }
            return categorys;
        }

        public void PrintCategorys(List<string> categorys)
        {
            foreach (string s in categorys)
            {
                Console.Write(s + ", ");
            }
            Console.Write("niet (bij ongelige invoer wordt \"niet\" gekozen)");
            Console.WriteLine("");
        }

    }
}
