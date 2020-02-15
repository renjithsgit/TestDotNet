using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class StackHeapTest
    {
        //https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-iii/
        public void Go()
        {
            Thing x = new Animal();
            Switcharoo(x);
            Console.WriteLine(
              "x is Animal    :   "
              + (x is Animal).ToString());
            Console.WriteLine(
                "x is Vegetable :   "
                + (x is Vegetable).ToString());
        }
        public void Switcharoo(Thing pValue)
        {
            pValue = new Vegetable();
            Console.WriteLine(
               "pValue is Vegetable :   "
               + (pValue is Vegetable).ToString());
        }
        public void SwitchWithRef(ref Thing pValue)
        {
            pValue = new Vegetable();
            Console.WriteLine(
               "pValue is Vegetable :   "
               + (pValue is Vegetable).ToString());
        }
        public void GoValueType()
        {
            int x = 5;
            AddFive(x);
            Console.WriteLine(x.ToString());
        }
        public int AddFive(int pValue)
        {
            pValue += 5;
            return pValue;
        }
    }
    
    public class Thing
    {
    }
    public class Animal : Thing
    {
        public int Weight;
    }
    public class Vegetable : Thing
    {
        public int Length;
    }
}
