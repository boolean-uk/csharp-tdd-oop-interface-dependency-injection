 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class EnglishAlphabet : ILanguage
    {
        private Dictionary<char, int> letterScores;
        public EnglishAlphabet()
        {
            letterScores = new Dictionary<char, int> {
            { 'A', 1 }, { 'B', 3 }, { 'C', 3 }, { 'D', 2 },
            { 'E', 1 }, { 'F', 4 }, { 'G', 2 }, { 'H', 4 },
            { 'I', 1 }, { 'J', 8 }, { 'K', 5 }, { 'L', 1 },
            { 'M', 3 }, { 'N', 1 }, { 'O', 1 }, { 'P', 3 },
            { 'Q', 10 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 },
            { 'U', 1 }, { 'V', 4 }, { 'W', 4 }, { 'X', 8 },
            { 'Y', 4 }, { 'Z', 10 }
        };
        }

        public Dictionary<char, int> GetLetterScores()
        {
            return letterScores;

        }
    }
}


