using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public interface IAlphabet
    {
        Dictionary<Char, int> GetLetterScores();
    }
}