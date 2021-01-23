using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    class DataAccess
    {
        private IEnumerable<Person> persons = new List<Person>();

        public IEnumerable<Person> GetData()
        {
            Console.WriteLine("GetData returned properly");
            return persons;

        }
    }
}
