using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_internal_interface.CSharp.Main
{
    public interface IAlphabet
    {
        public Dictionary<Char, int> getLetterScores() 
        { 
            return new Dictionary<Char, int>(); 
        }
    }
}
