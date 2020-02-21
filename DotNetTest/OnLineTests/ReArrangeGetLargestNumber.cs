using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.OnLineTests
{
    class ReArrangeGetLargestNumber
    {
        public static void GetLargetNumber(int input)
        {
            int ret;
            int[] nInArr = GetDigitsFromNumber.GetDigits(input).ToArray();

            int[] hash = new int[10];
            for (int i = 0; i < nInArr.Length; i++)
            {
                hash[nInArr[i]]++;
            }

            for (int i = 9; i >=0; i--)
            {
                for (int j = 0; j < hash[i]; j++)
                {
                    Console.WriteLine(i);
                }
            }
            //return ret;
        }

        public static void GetLargetNumberOld(int input)
        {
            int ret;
            int[] nInArr = GetDigitsFromNumber.GetDigits(input).ToArray();
            
            Array.Sort(nInArr);
            int num = 0;
            for (int i = nInArr.Length -1; i >= 0; i--)
            {
                num = num * 10 + nInArr[i];
            }
            Console.WriteLine(num);
        }
    }
}
