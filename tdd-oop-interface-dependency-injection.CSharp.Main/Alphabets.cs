using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class EnglishAlphabet : AlphabetInterface.IAlphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('a', 1);
            words.Add('b', 3);
            words.Add('c', 3);
            words.Add('d', 2);
            words.Add('e', 1);
            words.Add('f', 4);
            words.Add('g', 2);
            words.Add('h', 4);
            words.Add('i', 1);
            words.Add('j', 8);
            words.Add('k', 5);
            words.Add('l', 1);
            words.Add('m', 3);
            words.Add('n', 1);
            words.Add('o', 1);
            words.Add('p', 3);
            words.Add('q', 10);
            words.Add('r', 1);
            words.Add('s', 1);
            words.Add('t', 1);
            words.Add('u', 1);
            words.Add('v', 4);
            words.Add('w', 4);
            words.Add('x', 8);
            words.Add('y', 4);
            words.Add('z', 10);
            return words;
        }
    }

    public class GreekAlphabet : AlphabetInterface.IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            return new Dictionary<char, int>
            {
                {'α', 1}, {'ε', 1}, {'ι', 1}, {'ο', 1}, {'φ', 1}, {'ξ', 1},
                {'β', 2}, {'δ', 2}, {'π', 2},
                {'γ', 3}, {'η', 3}, {'ν', 3}, {'τ', 3},
                {'ζ', 4}, {'κ', 4}, {'ρ', 4}, {'ψ', 4}, {'λ', 4},
                {'θ', 5}, {'χ', 5},
                {'μ', 8}, {'σ', 8},
                {'υ', 10}, {'ω', 10}
            };
        }
    }

    public class RussianAlphabet : AlphabetInterface.IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            return new Dictionary<char, int>
            {
                {'а', 1}, {'б', 1}, {'в', 1}, {'г', 1}, {'д', 1},
                {'е', 2}, {'ё', 2}, {'ж', 2}, {'з', 2}, {'и', 2},
                {'й', 3}, {'к', 3}, {'л', 3}, {'м', 3}, {'н', 3},
                {'о', 4}, {'п', 4}, {'р', 4}, {'с', 4}, {'т', 4}, {'у', 4}, {'ф', 4},
                {'х', 5}, {'ц', 5}, {'ч', 5}, {'ш', 5},
                {'щ', 8}, {'ъ', 8}, {'ы', 8},
                {'ь', 10}, {'э', 10}, {'ю', 10}
            };
        }
    }
}
