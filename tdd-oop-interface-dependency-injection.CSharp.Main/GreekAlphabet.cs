using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class GreekAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<char, int> greek = new Dictionary<char, int>
            {
                {'α', 1},
                {'β', 2},
                {'γ', 3},
                {'δ', 2},
                {'ε', 1},
                {'ζ', 4},
                {'η', 3},
                {'θ', 5},
                {'ι', 1},
                {'κ', 4},
                {'λ', 4},
                {'μ', 8},
                {'ν', 3},
                {'ξ', 1},
                {'ο', 1},
                {'π', 2},
                {'ρ', 4},
                {'σ', 8},
                {'τ', 3},
                {'υ', 10},
                {'φ', 1},
                {'ψ', 4},
                {'χ', 5},
                {'ω', 10}
            };
            return greek;
        }
    }
}
