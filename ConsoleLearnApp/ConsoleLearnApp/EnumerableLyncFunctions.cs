using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    public class EnumerableLyncFunctions
    {

        public static void AggreageteTest()
        {
            string[] fruits = { "apple", "mango", "orangess", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".
            string longestName =
                fruits.Aggregate("banana",
                                (longest, next) =>
                                    next.Length > longest.Length ? next : longest,
                                // Return the final result as an upper case string.
                                fruit => fruit.ToUpper());

            Console.WriteLine(
                "The fruit with the longest name is {0}.",
                longestName);

            // This code produces the following output:
            //
            // The fruit with the longest name is PASSIONFRUIT.
        }

        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void AllEx()
        {
            // Create an array of Pets.
            Pet[] pets = { new Pet { Name="Barley", Age=10 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=6 } };

            // Determine whether all pet names
            // in the array start with 'B'.
            bool allStartWithB = pets.All(pet =>
                                              pet.Name.StartsWith("B"));

            Console.WriteLine(
                "{0} pet names start with 'B'.",
                allStartWithB ? "All" : "Not all");
        }

        // This code produces the following output:
        //
        //  Not all pet names start with 'B'.

        public void DistinctExample()
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAges = ages.Distinct();

            Console.WriteLine("Distinct ages:");

            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }

            /*
             This code produces the following output:

             Distinct ages:
             21
             46
             55
             17
            */
        }
    }
}
