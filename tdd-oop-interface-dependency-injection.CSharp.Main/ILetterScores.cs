using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_dependency_injection.CSharp.Main
{
    public interface ILetterScores
    {
        Dictionary<Char, int> getLetterScores();
    }
}
