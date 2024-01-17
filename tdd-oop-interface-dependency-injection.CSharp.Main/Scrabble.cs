using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;

        public Scrabble(string language) {
            if(language.Equals("english") )
            {
                IAlphabet english = new EnglishAlphabet();
                this.letterScores = english.getLetterScores();
            } else if(language.Equals("russian"))
            {
                IAlphabet russian = new RussianAlphabet();
                this.letterScores = russian.getLetterScores();

            } else if (language.Equals("greek"))
            {
                IAlphabet greek = new GreekAlphabet();
                this.letterScores = greek.getLetterScores();
            } else { throw new Exception("Wrong language input"); }
            

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
