using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.models
{
    // egenskapaer som vovven ska ha men den ärver också från animal klass som innehåll id och namn

    public class Dog: Animal

    {
        public string Bark()
        {
            return "mjao";
        }
    }
}
