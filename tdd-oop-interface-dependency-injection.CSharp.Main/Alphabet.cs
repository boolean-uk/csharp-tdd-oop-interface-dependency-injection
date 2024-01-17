using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    interface IAlphabet
    {
        public Dictionary<char, int> getLetterScores();
    }

    public class EnglishAlphabet : IAlphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> letters = new Dictionary<Char, int>
            {
                { 'a', 1 },
                { 'b', 3 },
                { 'c', 3 },
                { 'd', 2 },
                { 'e', 1 },
                { 'f', 4 },
                { 'g', 2 },
                { 'h', 4 },
                { 'i', 1 },
                { 'j', 8 },
                { 'k', 5 },
                { 'l', 1 },
                { 'm', 3 },
                { 'n', 1 },
                { 'o', 1 },
                { 'p', 3 },
                { 'q', 10 },
                { 'r', 1 },
                { 's', 1 },
                { 't', 1 },
                { 'u', 1 },
                { 'v', 4 },
                { 'w', 4 },
                { 'x', 8 },
                { 'y', 4 },
                { 'z', 10 }
            };
            return letters;
        }
    }
}

public class RussianAlphabet : IAlphabet
{
    public Dictionary<char,int> getLetterScores()
    {
        Dictionary<char, int> letters = new Dictionary<char, int>()
        {
            {'а', 1}, {'б', 1}, {'в', 1}, {'г', 1}, {'д', 1},
            {'е', 2}, {'ё', 2}, {'ж', 2}, {'з', 2}, {'и', 2},
            {'й', 3}, {'к', 3}, {'л', 3}, {'м', 3}, {'н', 3},
            {'о', 4}, {'п', 4}, {'р', 4}, {'с', 4}, {'т', 4}, {'у', 4}, {'ф', 4},
            {'х', 5}, {'ц', 5}, {'ч', 5}, {'ш', 5},
            {'щ', 8}, {'ъ', 8}, {'ы', 8},
            {'ь', 10}, {'э', 10}, {'ю', 10}
        };
        return letters;
    }
}

public class GreekAlphabet : IAlphabet
{
    public Dictionary<char, int> getLetterScores()
    {
        Dictionary<char, int> letters = new Dictionary<char, int>()
        {
            { 'α', 1 }, { 'ε', 1 }, { 'ι', 1 }, { 'ο', 1 }, { 'φ', 1 }, { 'ξ', 1 },
            { 'β', 2 }, { 'δ', 2 }, { 'π', 2 },
            { 'γ', 3 }, { 'η', 3 }, { 'ν', 3 }, { 'τ', 3 },
            { 'ζ', 4 }, { 'κ', 4 }, { 'ρ', 4 }, { 'ψ', 4 }, { 'λ', 4 },
            { 'θ', 5 }, { 'χ', 5 },
            { 'μ', 8 }, { 'σ', 8 },
            { 'υ', 10 }, { 'ω', 10 }
        };
        return letters;
    }
}