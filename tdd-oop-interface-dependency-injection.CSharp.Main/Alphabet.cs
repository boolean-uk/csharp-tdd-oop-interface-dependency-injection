using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Alphabet : AlphabetInterface
    {
        public Dictionary<string,int> fillAlphabet(string language)
        {
            Dictionary<string, int> alphabet = new Dictionary<string, int>();
            if (language.Equals("Greek"))
            {
                alphabet.Add("αειοφξ", 1);
                alphabet.Add("βδπ", 2);
                alphabet.Add("γηντ", 3);
                alphabet.Add("ζκρψλ", 4);
                alphabet.Add("θχ", 5);
                alphabet.Add("μσ", 8);
                alphabet.Add("υω", 10);
            }
            if (language.Equals("Russian"))
            {
                alphabet.Add("абвгд", 1);
                alphabet.Add("еёжзи", 2);
                alphabet.Add("йклмн", 3);
                alphabet.Add("опрстуф", 4);
                alphabet.Add("хцчш", 5);
                alphabet.Add("щъы", 8);
                alphabet.Add("ьэю", 10);
            }
            if (language.Equals("English"))
            {
                alphabet.Add("aeilnostru", 1);
                alphabet.Add("dg", 2);
                alphabet.Add("bcmp", 3);
                alphabet.Add("fhvwy", 4);
                alphabet.Add("k", 5);
                alphabet.Add("jx", 8);
                alphabet.Add("qz", 10);
            }
            return alphabet;
        }

    }
}
