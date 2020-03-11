using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.OnLineTests
{
    class HackerRankTests
    {
        static int R = 5;
        static int C = 5;
     

        public int findMaxSum(int[][] mat)
        {
            if (R < 3 || C < 3)
                return -1;
   
            // Here loop runs (R-2)*(C-2)  
            // times considering different 
            // top left cells of hour glasses. 
            int max_sum = int.MinValue;
            for (int i = 0; i <= R - 2; i++)
            {
                for (int j = 0; j <= C - 2; j++)
                {
                    // Considering mat[i][j] as top  
                    // left cell of hour glass. 
                    int sum = (mat[i][j] + mat[i][j + 1] + mat[i][j + 2])
                                    + (mat[i + 1][j + 1]) +
                              (mat[i + 2][j] + mat[i + 2][j + 1] + mat[i + 2][j + 2]);

                    // If previous sum is less then  
                    // current sum then update 
                    // new sum in max_sum 
                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }

        public int GetBinaryOf(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int noOfConsecutive1s = 0;
            int newNoOfConsecutive1s = 0;
            while (n > 0)
            {
                d[l] = n % 2;

                    if (d[l] == 1)
                { 
                    newNoOfConsecutive1s++; }
                if (noOfConsecutive1s < newNoOfConsecutive1s) noOfConsecutive1s = newNoOfConsecutive1s;
                if (d[l] == 0)
                {
                   
                    newNoOfConsecutive1s = 0;
                }
                         
                n /= 2;
                l++;
            }
            return noOfConsecutive1s;

        }
        public int Factorial(int n)
        {
            if (n == 1) return 1;
            else
                return (n * Factorial(n - 1));
        }
public void TestMethod()
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
