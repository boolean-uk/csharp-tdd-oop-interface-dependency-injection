using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets
{
    public class RussianAlphabet : IAlphabet
    {
        public RussianAlphabet()
        {

        }
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            string threePoints = "йклмн";
            string twoPoints = "еёжзи";
            string onePoints = "абвгд";
            string fourPoints = "опрстуф";
            string fivePoints = "хцчш";
            string eightPoints = "щъы";
            string tenPoints = "ьэю";

            foreach (char c in threePoints) {
                words.Add(c, 3);
            }
            foreach (char c in onePoints) { 
            words.Add(c, 1);
            }
            foreach (char c in twoPoints)
            {
                words.Add(c, 2);
            }
            foreach (char c in fourPoints)
            {
                words.Add(c, 4);
            }
            foreach (char c in fivePoints)
            {
                words.Add(c, 5);
            }
            foreach (char c in eightPoints)
            {
                words.Add(c, 8);
            }
            foreach (char c in tenPoints)
            {
                words.Add(c, 10);
            }
            
            return words;
        }
    }
}
