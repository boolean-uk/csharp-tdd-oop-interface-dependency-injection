using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble
    {
        private Dictionary<Char, int> letterScores;

        private List<IAlphabet> alphabets = new List<IAlphabet>();


		public Scrabble(IAlphabet a)
        {
            //Task asks not to instantiate classes here! oops!
	        //alphabets.Add(new AlphabetEng());
	        //alphabets.Add(new AlphabetRus());
	        //alphabets.Add(new AlphabetGreek());

	        letterScores = a.getLetterScores();
        }

        public int score(String word) 
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

            //Old Attempt
			//foreach (var ch in word.ToCharArray())
   //         {
	  //          foreach (var alphabet in alphabets)
	  //          {
   //                 letterScores = alphabet.getLetterScores();
   //                 if (letterScores.ContainsKey(ch))
   //                 {
   //                     total += letterScores[ch];
   //                     break;
   //                 }
	  //          }
   //         }

            return total;
        }
    }
}
