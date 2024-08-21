using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main{

        public class RussianAlphabet : ILanguage
        {
            private Dictionary<char, int> letterScores;

            public RussianAlphabet()
            {
                letterScores = new Dictionary<char, int> {
            { 'А', 1 }, { 'Б', 1 }, { 'В', 1 }, { 'Г', 1 }, { 'Д', 1 },
            { 'Е', 2 }, { 'Ё', 2 }, { 'Ж', 2 }, { 'З', 2 }, { 'И', 2 },
            { 'Й', 3 }, { 'К', 3 }, { 'Л', 3 }, { 'М', 3 }, { 'Н', 3 },
            { 'О', 4 }, { 'П', 4 }, { 'Р', 4 }, { 'С', 4 }, { 'Т', 4 }, { 'У', 4 }, { 'Ф', 4 },
            { 'Х', 5 }, { 'Ц', 5 }, { 'Ч', 5 }, { 'Ш', 5 },
            { 'Щ', 8 }, { 'Ъ', 8 }, { 'Ы', 8 },
            { 'Ь', 10 }, { 'Э', 10 }, { 'Ю', 10 }
        };
            }

            public Dictionary<char, int> GetLetterScores()
            {
                return letterScores;
            }
        }
    }

