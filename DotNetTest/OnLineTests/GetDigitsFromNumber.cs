using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.OnLineTests
{
    class GetDigitsFromNumber
    {
        static List<int> GetDigits(int input)
        {
            List<int> ret = new List<int>();
            while (input > 0)
            {
                int rem = input % 10;
                ret.Add(rem);
                input = input / 10;
            }
            ret.Reverse();
            return ret;
        }
    }
}
