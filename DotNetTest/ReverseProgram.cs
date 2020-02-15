using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class ReverseProgram
    {
        public void ReverseUisngReverse(int[] tmp)
        {
            Array.Reverse(tmp); ;
            for (int i = 0; i < tmp.Count(); i++)
            {
                Console.WriteLine(tmp[i]);
            }
            
        }
        public void ReverseUisngLength(int[] tmp)
        {
            for (int i = tmp.Length -1; i >= 0; i--)
            {
                Console.WriteLine(tmp[i]);
            }
        }

        public void ReverseGeneric<T>(IList<T> tmp)
        {
            for (int i = tmp.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine(tmp[i]);
            }
        }
        public IList<T> GetReverseGeneric<T>(IList<T> tmp)
        {
            //IList<T> revList = new List<T>();
            IList<T> revList = tmp.Reverse().ToList();
            //for (int i = tmp.Count() - 1; i >= 0; i--)
            //{
            //       revList.Add(tmp[i]);
            //}
            return revList;
        }

        public bool IsPalindrome(String str)
        {
            IList<char> strList = str.ToLower().ToList();
            IList<char> revStrList = GetReverseGeneric(strList);
            if (strList.Equals(revStrList)) return true;

            if (strList.SequenceEqual(revStrList)) return true;

            return false;
        }
   

    }

}
