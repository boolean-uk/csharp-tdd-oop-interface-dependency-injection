using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class GreekAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();

            string greekAlphabet = "αειοφξβδπγηντζκρψλθχμσυω";

            foreach (char c in greekAlphabet.ToCharArray())
            {
                if (c == 'α' || c == 'ε' || c == 'ι' || c == 'ο' || c == 'φ' || c == 'ξ')
                {
                    words.Add(c, 1);
                }
                else if (c == 'β' || c == 'δ' || c == 'π')
                {
                    words.Add(c, 2);
                }
                else if (c == 'γ' || c == 'η' || c == 'ν' || c == 'τ')
                {
                    words.Add(c, 3);
                }
                else if (c == 'ζ' || c == 'κ' || c == 'ρ' || c == 'ψ' || c == 'λ')
                {
                    words.Add(c, 4);
                }
                else if (c == 'θ' || c == 'χ')
                {
                    words.Add(c, 5);
                }
                else if (c == 'μ' || c == 'σ')
                {
                    words.Add(c, 8);
                }
                else if (c == 'υ' || c == 'ω')
                {
                    words.Add(c, 10);
                }
            }

            return words;
        }
    }
}
