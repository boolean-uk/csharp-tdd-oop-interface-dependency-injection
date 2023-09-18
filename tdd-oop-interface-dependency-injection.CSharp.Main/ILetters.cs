using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tdd_oop_public_interface_dependency_injection.CSharp.Main
{
    public interface ILetters
    {
            Dictionary<Char, int> LetterScores{ get; } 
    }
}
