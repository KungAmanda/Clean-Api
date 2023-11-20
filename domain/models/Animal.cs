using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.models
{
    // detta behöver vi för grunden yani så kommentera sen men glöm inte vad han sa

    public class Animal
    {
        public Guid animalId { get; set; }

       public string Name { get; set; } = string.Empty;
    }
}
