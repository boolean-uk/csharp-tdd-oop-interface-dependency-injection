using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public interface IAlphabet
    {
        Dictionary<Char, int> getLetterScores();
    }
    public class EnglishAlphabet : IAlphabet
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

    public class RussianAlphabet : IAlphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('д', 1);
            words.Add('в', 1);
            words.Add('р', 4);
            words.Add('ф', 4);
            words.Add('ъ', 8);

            return words;
        }
    }

    public class GreekAlphabet : IAlphabet
    {
        public Dictionary<Char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('φ', 1);
            words.Add('ε', 1);
            words.Add('ψ', 4);
            words.Add('ω', 10);
            words.Add('λ', 4);

            return words;
        }
    }
}
