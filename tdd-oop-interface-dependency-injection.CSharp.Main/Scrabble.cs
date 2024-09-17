using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        public Scrabble(IAlphabetPack alphabet)
        {
            letterScores = alphabet.GetLetterScores();
        }

        public Scrabble(List<IAlphabetPack> alphabetPacks)
        {
            foreach (var alphabet in alphabetPacks)
            {
                Dictionary<Char, int> alphabetPack = alphabet.GetLetterScores();
                foreach (var kvp in alphabetPack)
                {
                    letterScores.Add(kvp.Key, kvp.Value);
                }
            }
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (this.letterScores.ContainsKey(ch)) {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
