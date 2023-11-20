using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using domain.models;
namespace Infrastruktur.Databas
{
    // detta är för att mocka yani skapa fake data att jobba med 
    public class mockDatabas   
    {
        public List<Dog> allDogs
        {
            get { return allDogsFromockDatabas; }
            set { allDogsFromockDatabas = value; }
        }


        private static List<Dog> allDogsFromockDatabas = new()
        {
            new Dog
            {
                animalId = Guid.NewGuid(), Name = "mjau"
            },

            new Dog
            {
                animalId = Guid.NewGuid(), Name = "Pandis"
            },

            new Dog
            {
                animalId = Guid.NewGuid(), Name = "ABOW"
            },
            new Dog
            {
                animalId = Guid.NewGuid(), Name = "MANNEN"
            },

        };
    }
}
