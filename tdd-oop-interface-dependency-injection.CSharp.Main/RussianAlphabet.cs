using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class RussianAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();

            string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэю";

            foreach (char c in russianAlphabet.ToCharArray())
            {
                if (c == 'a' || c == 'б' || c == 'в' || c == 'г' || c == 'д')
                {
                    words.Add(c, 1);
                } else if (c == 'е' || c == 'ё' || c == 'ж' || c == 'з' || c == 'и')
                {
                    words.Add(c, 2);
                } else if (c == 'й' || c == 'к' || c == 'л' || c == 'м' || c == 'н')
                {
                    words.Add(c, 3);
                } else if (c == 'о' || c == 'п' || c == 'р' || c == 'с' || c == 'т' || c == 'у' || c == 'ф')
                {
                    words.Add(c, 4);
                } else if (c == 'х' || c == 'ц' || c == 'ч' || c == 'ш')
                {
                    words.Add(c, 5);
                } else if (c == 'щ' || c == 'ъ' || c == 'ы')
                {
                    words.Add(c, 8);
                } else if (c == 'ь' || c == 'э' || c == 'ю')
                {
                    words.Add(c, 10);
                }
            }

            return words;
        }
    }
}
