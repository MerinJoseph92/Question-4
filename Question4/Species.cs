using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Species
    {
        public string Name { get; set; }
        public string AnimalSpecies { get; set; }
        public int Age { get; set; }

        public Species(string name, string animalspecies, int age)
        {
            this.Name = name;
            this.AnimalSpecies = animalspecies;
            this.Age = age;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Species:" + AnimalSpecies + " Age:" + Age;
        }
    }
}
