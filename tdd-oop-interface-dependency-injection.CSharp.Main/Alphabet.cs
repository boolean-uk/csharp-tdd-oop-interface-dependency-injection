using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public interface IAlphabet
    {
        Dictionary<char, int> GetLetterScores();
    }

    public class Alphabet : IAlphabet
    {
        public Dictionary<char, int> GetLetterScores()
        {
            Dictionary<char, int> words = new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'b', 3 },
                { 'c', 3 },
                { 'd', 2 },
                { 'e', 1 },
                { 'f', 4 },
                { 'g', 2 },
                { 'h', 4 },
                { 'i', 1 },
                { 'j', 8 },
                { 'k', 5 },
                { 'l', 1 },
                { 'm', 3 },
                { 'n', 1 },
                { 'o', 1 },
                { 'p', 3 },
                { 'q', 10 },
                { 'r', 1 },
                { 's', 1 },
                { 't', 1 },
                { 'u', 1 },
                { 'v', 4 },
                { 'w', 4 },
                { 'x', 8 },
                { 'y', 4 },
                { 'z', 10 },
                { 'д', 5 }, // Russian letter 'д' with score 5
                { 'ф', 8 }, // Russian letter 'ф' with score 8
                { 'р', 4}, //Russian letter 'р' with score 4
                { 'в', 1 }, //Russian letter 'в' with score 1
                { 'ε', 1 }, // Greek letter 'ε' with score 2
                { 'ψ', 4 }, // Greek letter 'ψ' with score 10
                { 'φ', 1 }, // Greek letter 'φ' with score 8
                { 'ω', 10 }, // Greek letter 'ω' with score 9
                { 'λ', 4 }, //Greek letter 'λ' with score 4
            };

            // greek φεψωλ
            return words;
        }
    }
}
