using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble 
    {


        private readonly Dictionary<char, int> letterScores;

        public Scrabble(IAlphabet alphabet)
        {
            this.letterScores = alphabet.GetLetterScores();
        }

        //private Dictionary<Char, int> letterScores;

        /* public Scrabble() {
             Alphabet a = new Alphabet();
             this.letterScores = a.getLetterScores();
         }*/


        public int Score(string word)
        {
            int total = 0;

            foreach (char ch in word.ToCharArray())
            {
                if (this.letterScores.ContainsKey(ch))
                {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
      
    }
}
