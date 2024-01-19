using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{


    // Scrabble class: Uses dependency injection with IAlphabet interface
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        // Constructor accepts an IAlphabet interface
       public Scrabble(IAlphabet ialphabet) {
            this.letterScores = ialphabet.GetLetterScores();
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
