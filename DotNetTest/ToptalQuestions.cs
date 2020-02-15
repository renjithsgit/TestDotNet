using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class ToptalQuestions
    {
        //https://www.toptal.com/c-sharp/interview-questions

        public long SumOfEvenLambda(int[] intArray)
        {
            var res = intArray.Where(x => x % 2 == 0).Sum(x => (long) x);
            return res;
        }

        public long SumOfEvenLinq(int[] intArray)
        {
            
            var res = (from r in intArray where r % 2 == 0 select r).Sum(x=> (long) x);
            return res;

            
        }
    }
}
