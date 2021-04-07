using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    public static class CanAddNullToCollection
    {
        public static void CreateAStringCollectionAndCheckNull ()
        {
            var s = new List<string>(){"aaaa","bbbb"};
            var ss = AddNullToCollection(s);
            Console.WriteLine("count : " + ss.Count());

            //Yes we can add null to string collection.
        }

        public static IEnumerable<string> AddNullToCollection(IReadOnlyCollection<string> stringCollection)
        {
            return stringCollection
                .Select(p => p.Equals("dddd") ? p : null);
        }
    }
}
