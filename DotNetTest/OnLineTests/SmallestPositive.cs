using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class SmallestPositive
    {

        public int solution(int[] A)
        {
            int i = 1;
            while(true)
            {
                if (A.Contains(i))
                    i++;
                else
                  return i;
            }

        }

        //https://www.geeksforgeeks.org/find-the-smallest-positive-number-missing-from-an-unsorted-array/
        //https://stackoverflow.com/questions/24690559/find-the-missing-integer-in-codility
        public int solution2(int[] A)
        {
            // the minimum possible answer is 1
            int result = 1;
            // let's keep track of what we find
            Dictionary<int, bool> found = new Dictionary<int, bool>();

            // loop through the given array  
            for (int i = 0; i < A.Length; i++)
            {
                // if we have a positive integer that we haven't found before
                if (A[i] > 0 && !found.ContainsKey(A[i]))
                {
                    // record the fact that we found it
                    found.Add(A[i], true);
                }
            }

            // crawl through what we found starting at 1
            while (found.ContainsKey(result))
            {
                // look for the next number
                result++;
            }

            // return the smallest positive number that we couldn't find.
            return result;

        }
    }
}
