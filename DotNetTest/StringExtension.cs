using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    public static class StringExtension
    {
        public static string SampleExtensionString(this string str, string retString)
        {
            return retString;
        }
    }
}
