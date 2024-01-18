using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphabets;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        public Scrabble() {
            ILanguage a = new Alphabet();
            ILanguage b = new Greek();
            ILanguage c = new Russian();
            this.letterScores = a.getLetterScores();
            this.letterScores = this.letterScores.Concat(b.getLetterScores()).ToDictionary(x => x.Key, x => x.Value);
            this.letterScores = this.letterScores.Concat(c.getLetterScores()).ToDictionary(x => x.Key, x => x.Value);
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
