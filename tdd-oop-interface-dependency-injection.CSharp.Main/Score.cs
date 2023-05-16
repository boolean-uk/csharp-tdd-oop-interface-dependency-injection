using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_internal_interface_dependency_injection.CSharp.Main
{
    public interface Score
    {
        Dictionary<string, int> letterScores { get; set; }
        Alphabet alphabet { get; set; }
        public int score(string word);
    }
}
