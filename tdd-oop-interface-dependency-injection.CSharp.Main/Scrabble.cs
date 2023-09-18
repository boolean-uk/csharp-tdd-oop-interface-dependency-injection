using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_public_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> _letterScores;

        public Scrabble(ILetters letters) {
            
            this._letterScores = letters.LetterScores;
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (this._letterScores.ContainsKey(ch)) {
                    int score = this._letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
