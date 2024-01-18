﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Localizations;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;
        private ILocalization _a;

        public Scrabble(ILocalization a) {
            _a = a;         
            letterScores = a.GetLetterScores();
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (letterScores.ContainsKey(ch)) {
                    int score = letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
