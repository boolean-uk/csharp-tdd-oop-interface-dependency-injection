using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddOopInternal.InterfaceDependencyInjection.CSharp.Main.Interfaces
{
    public interface Language
    {
        string Name { get; set; }

        int Caclcualte(string word);
    }
}
