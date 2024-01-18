using System;
using System.Collections.Generic;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble
    {
        private readonly Dictionary<Char, int> letterScores;

        public Scrabble(ILetterScoresProvider letterScoresProvider)
        {
            this.letterScores = letterScoresProvider.GetLetterScores();
        }

        public int Score(String word)
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
