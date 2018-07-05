using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalSpecies> animalSpeciesList = GetAnimalSpeciesList();
            List<AnimalAge> animalAgeList = GetAnimalAgeList();

            List<Species> speciesList = CreateAnimalSpeciesList(animalAgeList, animalSpeciesList);
            if(speciesList!=null)
            {
            foreach (Species species in speciesList)
            {
                Console.WriteLine(species.ToString());
            }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.Read();
        }

        public static List<AnimalSpecies> GetAnimalSpeciesList()
        {
            List<AnimalSpecies> AnimalSpeciesList = new List<AnimalSpecies>();
            AnimalSpeciesList.Add(new AnimalSpecies("Jessica", "dog"));
            AnimalSpeciesList.Add(new AnimalSpecies("Jacky", "owl"));
            AnimalSpeciesList.Add(new AnimalSpecies("Luke", "fish"));
            AnimalSpeciesList.Add(new AnimalSpecies("Jason", "rabbit"));
            AnimalSpeciesList.Add(new AnimalSpecies("Thomas", "cat"));
            AnimalSpeciesList.Add(new AnimalSpecies("Junior", "cat"));
            return AnimalSpeciesList;
        }

        public static List<AnimalAge> GetAnimalAgeList()
        {
            List<AnimalAge> AnimalAgeList = new List<AnimalAge>();
            AnimalAgeList.Add(new AnimalAge("Jessica", 12));
            AnimalAgeList.Add(new AnimalAge("Jacky", 4));
            AnimalAgeList.Add(new AnimalAge("Luke", 2));
            AnimalAgeList.Add(new AnimalAge("Jason", 2));
            AnimalAgeList.Add(new AnimalAge("Thomas", 6));
            AnimalAgeList.Add(new AnimalAge("Junior", 12));
            return AnimalAgeList;
        }

        public static List<Species> CreateAnimalSpeciesList(List<AnimalAge> animalAgeList, List<AnimalSpecies> animalSpeciesList)
        {
            List<Species> specieslist = null;

            if (animalAgeList != null && animalSpeciesList != null)
            {
                specieslist = new List<Species>();
                foreach (AnimalSpecies animalspeciestype in animalSpeciesList)
                {
                    foreach (AnimalAge animalagetype in animalAgeList)
                    {
                        if (animalspeciestype.Name.Equals(animalagetype.Name))
                        {
                            specieslist.Add(new Species(animalspeciestype.Name, animalspeciestype.Species, animalagetype.Age));
                        }
                    }
                }
            }
            return specieslist;
        }
    }
}
