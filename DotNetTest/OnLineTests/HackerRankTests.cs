using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.OnLineTests
{
    class HackerRankTests
    {
public static void TestMethod()
        {


            ///
            int n = Int32.Parse(Console.ReadLine());
            string[] s = new string[n];
            for (int j = 0; j < n; j++)
            {
                s[j] = Console.ReadLine();
            }
            for (int j = 0; j < n; j++)
            {

                StringBuilder sb = new StringBuilder(s[j]);
                StringBuilder sbOdd = new StringBuilder();
                StringBuilder sbEven = new StringBuilder();
                for (int i = 0; i < sb.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sbEven.Append(sb[i]);
                    }
                    else
                    {
                        sbOdd.Append(sb[i]);
                    }
                }

                Console.WriteLine($"{sbEven.ToString()} {sbOdd.ToString()}");
            }
        }
       
    }
}
