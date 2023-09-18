using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_public_interface_dependency_injection.CSharp.Main
{
    public class Russian : ILetters
    {
        public Dictionary<Char, int> LetterScores
        {
            get
            {
                Dictionary<Char, int> RussianWords = new Dictionary<Char, int>();
                RussianWords.Add('а', 1);
                RussianWords.Add('б', 1);
                RussianWords.Add('в', 1);
                RussianWords.Add('г', 1);
                RussianWords.Add('д', 1);
                RussianWords.Add('е', 2);
                RussianWords.Add('ё', 2);
                RussianWords.Add('ж', 2);
                RussianWords.Add('з', 2);
                RussianWords.Add('и', 2);
                RussianWords.Add('й', 3);
                RussianWords.Add('к', 3);
                RussianWords.Add('л', 3);
                RussianWords.Add('м', 3);
                RussianWords.Add('н', 3);
                RussianWords.Add('о', 4);
                RussianWords.Add('п', 4);
                RussianWords.Add('р', 4);
                RussianWords.Add('с', 4);
                RussianWords.Add('т', 4);
                RussianWords.Add('у', 4);
                RussianWords.Add('ф', 4);
                RussianWords.Add('х', 5);
                RussianWords.Add('ц', 5);
                RussianWords.Add('ч', 5);
                RussianWords.Add('ш', 5);
                RussianWords.Add('щ', 8);
                RussianWords.Add('ъ', 8);
                RussianWords.Add('ы', 8);
                RussianWords.Add('ь', 10);
                RussianWords.Add('э', 10);
                RussianWords.Add('ю', 10);
                return RussianWords;

            }
            
        }
    }
}
