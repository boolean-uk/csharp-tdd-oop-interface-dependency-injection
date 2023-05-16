using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble : Score{
        public Dictionary<string, int> letterScores { get; set; }
        public Alphabet alphabet { get; set; }

        public Scrabble(Alphabet a, string language) {
            alphabet = a;
            this.letterScores = a.fillAlphabet(language);
        }

        public int score(String word) {
            int score = 0;
            foreach (KeyValuePair<string, int> pair in letterScores)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (pair.Key.Contains(word[i]))
                    {
                        score += pair.Value;
                    }
                }
            }
            return score;
        }
    }
}
