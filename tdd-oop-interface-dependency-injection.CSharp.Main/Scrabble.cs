using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        public Scrabble(ILetterScoresProvider letterScoresProvider)
        {
            this.letterScores = letterScoresProvider.GetLetterScores();
        }

        public int Score(string word)
        {
            int total = 0;

            foreach (char ch in word.ToLower())
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
