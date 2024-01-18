using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.Main;
using tdd_oop_interface_Dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        public Scrabble()
        {
            ILanguagePack english = new AlphabetEnglish();
            ILanguagePack greek = new AlphabetGreek();
            ILanguagePack russian = new AlphabetRussian();

            letterScores = english.GetLetterScores();
            letterScores = letterScores.Concat(greek.GetLetterScores()).ToDictionary(x => x.Key, x => x.Value);
            letterScores = letterScores.Concat(russian.GetLetterScores()).ToDictionary(x => x.Key, x => x.Value);
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
