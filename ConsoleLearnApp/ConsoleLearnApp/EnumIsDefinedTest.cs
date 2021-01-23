using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    public class EnumIsDefinedTest
    {
        public enum Pets
        {
            None = 0, Dog = 1, Cat = 2, Bird = 4,
            Rodent = 8, Other = 16
        };

        public static void TestForEnumISdefinedasDifferentValyue()
        {
            Pets value = Pets.Dog | Pets.Cat;
            Console.WriteLine("{0:D} Exists: {1}",
                              value, Pets.IsDefined(typeof(Pets), value));
            string name = value.ToString();
            Console.WriteLine("{0} Exists: {1}",
                              name, Pets.IsDefined(typeof(Pets), name));

            Pets val2 = Pets.Rodent;
            Console.WriteLine("{0:D} Exists: {1}",
                              val2, Pets.IsDefined(typeof(Pets), val2));
        }

        public static void TestForEnumWithOperator()
        {
            checks value = checks.Concentration;
            Console.WriteLine("{0:D} ", value);
            checks val2 = checks.Profile;
            Console.WriteLine("{0:D} ", val2);
            string name = checks.Concentration.ToString();
            Console.WriteLine("{0:D} ", name);
        }

        public enum checks
        {
            Maturity = 1 << 1, // = 2

            /// <summary>Concentration communication.</summary>
            Concentration = 1 << 2, // = 4

            /// <summary>Risk Profile client notification.</summary>
            Profile = 1 << 3, //
        }
    }
}
