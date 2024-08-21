using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets
{
    public class RussianAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            //а, б, в, г, д	1
            words.Add('а', 1);
            words.Add('б', 1);
            words.Add('в', 1);
            words.Add('г', 1);
            words.Add('д', 1);
            //е, ё, ж, з, и	2
            words.Add('е', 2);
            words.Add('ё', 2);
            words.Add('ж', 2);
            words.Add('з', 2);
            words.Add('и', 2);
            //й, к, л, м, н	3
            words.Add('й', 3);
            words.Add('к', 3);
            words.Add('л', 3);
            words.Add('м', 3);
            words.Add('н', 3);
            //о, п, р, с, т, у, ф 4
            words.Add('o', 4);
            words.Add('п', 4);
            words.Add('р', 4);
            words.Add('с', 4);
            words.Add('т', 4);
            words.Add('у', 4);
            words.Add('ф', 4);
            //х, ц, ч, ш  5
            words.Add('х', 5);
            words.Add('ц', 5);
            words.Add('ч', 5);
            words.Add('ш', 5);
            //щ, ъ, ы	8
            words.Add('щ', 8);
            words.Add('ъ', 8);
            words.Add('ы', 4);
            //ь, э, ю	10
            words.Add('ь', 10);
            words.Add('э', 10);
            words.Add('ю', 10);
            return words;
        }
    }
}
