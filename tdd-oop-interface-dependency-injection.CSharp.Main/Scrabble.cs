using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> _letterScores;

        public Scrabble(IAlphabet alphabet) {

            _letterScores = alphabet.getLetterScores();
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (_letterScores.ContainsKey(ch)) {
                    int score = _letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
