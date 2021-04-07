using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearnApp
{
    public static class IsNullEmtyTest
    {

        public static void CanIsNullOrEmptyHndleSpace()
        {
            string s = " ";
            string message = string.IsNullOrEmpty(s)
                ? "can handle"
                : "can not handle";
            Console.WriteLine(message);
            message = string.IsNullOrWhiteSpace(s)
                ? "can handle"
                : "can not handle";
            Console.WriteLine(message);
        }
    }
}
