using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_Dependency_injection.CSharp.Main
{
    public interface ILanguagePack
    {
        public Dictionary<Char, int> GetLetterScores();
    }
}
