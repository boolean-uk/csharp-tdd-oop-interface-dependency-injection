using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class EnglishAlphabet : IAlphabet
    {
        private Dictionary<char, int> letters;

        // constructor
        public EnglishAlphabet() {
            letters = new Dictionary<char, int> {
                {'a',1}, {'b',3},{'c',3},{'d',2},{'e',1},{'f',4},{'g',2},{'h',4}, {'i',1},{'j',8},{'k',5},{'l',1},{'m',3},
                {'n',1},{'o',1},{'p',3},{'q',10}, {'r',1},{'s',1},{'t',1},{'u',1},{'v',4},{'w',4},{'x',8},{'y',4},{'z',10}
            };
        }
        public int GetLetterScore(char character)
        {
            return letters.ContainsKey(character) ? letters[character] : 0;
        }
    }
}

/*
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
*/