using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddOopInternal.InterfaceDependencyInjection.CSharp.Main.Interfaces;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        Language _language;
        public Scrabble(Language language) {
            _language = language;
            
           
        }

        public int score(String word) {
            int total = _language.Caclcualte(word);

            

            return total;
        }
    }
}
