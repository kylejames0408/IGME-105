using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class NameGenerator
    {
        // Initialize variables
        private int longestName;
        private int shortestName;
        private int numberOfNames;
        private List<string> firstHalfFirstNames;
        private List<string> secondHalfFirstNames;
        private List<string> firstThirdSurnames;
        private List<string> secondThirdSurnames;
        private List<string> thirdThirdSurnames;
        private Random generator;

        // Create constructor
        public NameGenerator(Random rng)
        {
            // Assign passed values
            generator = rng;

            // Assign default values
            longestName = int.MinValue;
            shortestName = int.MaxValue;
            numberOfNames = 0;

            // Instantiate lists
            firstHalfFirstNames = new List<string>();
            secondHalfFirstNames = new List<string>();
            firstThirdSurnames = new List<string>();
            secondThirdSurnames = new List<string>();
            thirdThirdSurnames = new List<string>();

            // Add strings to first half of first names
            firstHalfFirstNames.Add("Bob");
            firstHalfFirstNames.Add("Tom");
            firstHalfFirstNames.Add("Jim");
            firstHalfFirstNames.Add("Sal");
            firstHalfFirstNames.Add("Scan");
            firstHalfFirstNames.Add("Lee");

            // Add strings to second half of first names
            secondHalfFirstNames.Add("bert");
            secondHalfFirstNames.Add("othy");
            secondHalfFirstNames.Add("bo");
            secondHalfFirstNames.Add("lan");

            // Add strings to first third of surnames
            firstThirdSurnames.Add("Flo");
            firstThirdSurnames.Add("Reg");
            firstThirdSurnames.Add("Smi");
            firstThirdSurnames.Add("Pru");
            firstThirdSurnames.Add("Sho");

            // Add strings to second third of surnames
            secondThirdSurnames.Add("gon");
            secondThirdSurnames.Add("spin");
            secondThirdSurnames.Add("jum");
            secondThirdSurnames.Add("a");

            // Add strings to third third of surnames
            thirdThirdSurnames.Add("lerg");
            thirdThirdSurnames.Add("ong");
            thirdThirdSurnames.Add("kin");
            thirdThirdSurnames.Add("floon");
            thirdThirdSurnames.Add("ski");
        }

        // Methods
        public string GenerateName()
        {
            int index;
            string name = "";
            // Get a random first half of first name
            index = generator.Next(firstHalfFirstNames.Count);
            name += firstHalfFirstNames[index];

            // Get a random second half of first name
            index = generator.Next(secondHalfFirstNames.Count);
            name += secondHalfFirstNames[index] + " ";

            // Get a random first third of surname
            index = generator.Next(firstThirdSurnames.Count);
            name += firstThirdSurnames[index];

            // Get a random second third of surname
            index = generator.Next(secondThirdSurnames.Count);
            name += secondThirdSurnames[index];

            // Get a random third third of surname
            index = generator.Next(thirdThirdSurnames.Count);
            name += thirdThirdSurnames[index];

            // Alter variables
            numberOfNames++;
            if(name.Length > longestName)
            {
                longestName = name.Length;
            }
            if(name.Length < shortestName)
            {
                shortestName = name.Length;
            }

            return name;
        }

        public void PrintStatistics()
        {
            Console.WriteLine($"\nShortest generated name is {shortestName} characters.");
            Console.WriteLine($"Longest generated name is {longestName} characters.");
            Console.WriteLine($"{numberOfNames} character names were generated.");
        }
    }
}
