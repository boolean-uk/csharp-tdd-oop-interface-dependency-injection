using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_public_interface_dependency_injection.CSharp.Main
{
    public class Greek : ILetters
    {
        public Dictionary<Char, int> LetterScores 
        {
            get
            {
                Dictionary<Char, int> GreekWords = new Dictionary<Char, int>();
                GreekWords.Add('α', 1);
                GreekWords.Add('ε', 1);
                GreekWords.Add('ι', 1);
                GreekWords.Add('ο', 1);
                GreekWords.Add('φ', 1);
                GreekWords.Add('ξ', 1);
                GreekWords.Add('β', 2);
                GreekWords.Add('δ', 2);
                GreekWords.Add('π', 2);
                GreekWords.Add('γ', 3);
                GreekWords.Add('η', 3);
                GreekWords.Add('ν', 3);
                GreekWords.Add('τ', 3);
                GreekWords.Add('ζ', 4);
                GreekWords.Add('κ', 4);
                GreekWords.Add('ρ', 4);
                GreekWords.Add('ψ', 4);
                GreekWords.Add('λ', 4);
                GreekWords.Add('θ', 5);
                GreekWords.Add('χ', 5);
                GreekWords.Add('μ', 8);
                GreekWords.Add('σ', 8);
                GreekWords.Add('υ', 10);
                GreekWords.Add('ω', 10);
                return GreekWords;


            }




        }
    }
}
