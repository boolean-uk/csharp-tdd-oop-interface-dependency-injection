using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private readonly IAlphabet alphabet;

        public Scrabble(IAlphabet alphabet) 
        {
           this.alphabet = alphabet;   
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) 
            {
                if (this.alphabet.getLetterScores().ContainsKey(ch)) 
                {
                    int score = this.alphabet.getLetterScores()[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
