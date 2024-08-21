using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_internal_interface_dependency_injection.CSharp.Main.Languages
{
    public class Greek : IScore
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('α', 1);
            words.Add('γ', 3);
            words.Add('η', 3);
            words.Add('β', 2);
            words.Add('ε', 1);
            words.Add('δ', 2);
            words.Add('ι', 1);
            words.Add('φ', 1);
            words.Add('ν', 3);
            words.Add('ξ', 1);
            words.Add('ο', 1);
            words.Add('τ', 3);
            words.Add('υ', 10);
            words.Add('χ', 5);
            words.Add('π', 2);
            words.Add('θ', 5);
            words.Add('μ', 8);
            words.Add('y', 4);
            words.Add('σ', 8);
            words.Add('ω', 10);
            words.Add('ψ', 4);
            words.Add('λ', 4);




            return words;

        }
    }
}
