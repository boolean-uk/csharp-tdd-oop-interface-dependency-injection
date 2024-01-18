using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        IAlphabet _ialphabet;

        public Scrabble(IAlphabet ialphabet) {

            _ialphabet = ialphabet;
        }
  
        public int score(String word) {
            int total = 0;
            foreach (char ch in word.ToCharArray()) {
                if (_ialphabet.GetLetterScores().ContainsKey(ch)) {
                    int score = _ialphabet.GetLetterScores()[ch];
                    total += score;
                }
            }

            return total;
        }
    
    }
     
}
