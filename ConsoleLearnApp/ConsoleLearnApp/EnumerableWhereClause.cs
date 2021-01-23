using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    public class EnumerableWhereClause
    {
        public static void WhereTest()
        {
            // Create an array of Pets.
            Pet[] pets = { new Pet { Name="Barley", Age=10 },
                new Pet { Name="Boots", Age=4 },
                new Pet { Name="Whiskers", Age=6 } };

            var p = pets.Where(x => IsTrue(x.Age)).ToList();

            p.ForEach(x => Console.WriteLine(
                "The name is {0}.", x.Name));
        }


        private static bool IsTrue(int age)
        {
            return age == 10;
        }

        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }


}
