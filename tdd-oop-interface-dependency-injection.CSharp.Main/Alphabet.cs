using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public interface Alphabet
    {
        public Dictionary<Char, int> getLetterScores();
    }
    public class LatinAlphabet : Alphabet
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
    public class GreekAlphabet : Alphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('α', 1);
            words.Add('ε', 1);
            words.Add('ι', 1);
            words.Add('ο', 1);
            words.Add('φ', 1);
            words.Add('ξ', 1);
            words.Add('β', 2);
            words.Add('δ', 2);
            words.Add('π', 2);
            words.Add('γ', 3);
            words.Add('η', 3);
            words.Add('ν', 3);
            words.Add('τ', 3);
            words.Add('ζ', 4);
            words.Add('κ', 4);
            words.Add('ρ', 4);
            words.Add('ψ', 4);
            words.Add('λ', 4);
            words.Add('θ', 5);
            words.Add('χ', 5);
            words.Add('μ', 8);
            words.Add('σ', 8);
            words.Add('υ', 10);
            words.Add('ω', 10);
            return words;
        }
    }
    public class CyrillicAlphabet : Alphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('а', 1);
            words.Add('б', 1);
            words.Add('в', 1);
            words.Add('г', 1);
            words.Add('д', 1);
            words.Add('е', 2);
            words.Add('ё', 2);
            words.Add('ж', 2);
            words.Add('з', 2);
            words.Add('и', 2);
            words.Add('й', 3); 
            words.Add('к', 3);
            words.Add('л', 3);
            words.Add('м', 3);
            words.Add('н', 3);
            words.Add('о', 4);
            words.Add('п', 4);
            words.Add('р', 4);
            words.Add('с', 4);
            words.Add('т', 4);
            words.Add('у', 4);
            words.Add('ф', 4);
            words.Add('х', 5);
            words.Add('ц', 5);
            words.Add('ч', 5);
            words.Add('ш', 5);
            words.Add('щ', 8);
            words.Add('ъ', 8);
            words.Add('ы', 8);
            words.Add('ь', 10);
            words.Add('э', 10);
            words.Add('ю', 10);
            return words;
        }
    }
}
