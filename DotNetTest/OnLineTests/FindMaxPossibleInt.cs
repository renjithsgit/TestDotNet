using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.OnLineTests
{
    class FindMaxPossibleInt
    {
        public static int MaxPossible(int N)
        {

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int insertingDigit = 5;
            int flag = N >= 0 ? 1 : -1;
            int num = Math.Abs(N);
            int maxValue = int.MinValue;

            int result = 0;
            //List<int> inDigits = GetDigits(N);
            StringBuilder sb = new StringBuilder(Math.Abs(N).ToString());
            int position = 1;

            for (int i = 0; i <= sb.Length; i++)
            {
                result = ((num / position) * (position * 10)) + (insertingDigit * position) + (num % position);
                result = result * flag;
                if ((result) > maxValue) maxValue = result;
                position = position * 10;
            }


            return maxValue;

        }
    }
}
