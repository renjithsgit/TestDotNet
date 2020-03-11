using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace DotNetTest
{
    public class CSharpNewFeatures
    {
        public void CheckNewFeatures()
        {
            //best practice1- name application name and classes well.
            //best practice2- 
            BestPractice1();
            Feature2();
            
            SpanCheck();
            //Product p = GetProductAsRef("aaa");

        }

        private void BestPractice1()
        {
            throw new NotImplementedException();
        }

        private void Feature3()
        {
            //non coallasce 
            //throw exception in expression.

        }

        private void Feature4()
        {
            //Switch case.

        }
        private void Feature5()
        {
            //Tuples.
            var name = SplitValues("John honay");
            Console.WriteLine($"firstname: {{name.firstName}} {{name.LastName}}");

        }
        private (string firstName, string LastName) SplitValues(string s)
        {
            string[] arr = s.Split(' ');
            return (arr[0], arr[1]);
        }
        private void Feature2()
        {
            //pattern matching . handling a number and a number inside a string.
            string ageFromConsole = "56";
            int ageFromDb = 22;
            object ageval = ageFromConsole;

            if(ageval is int age || (ageval is string ageText && int.TryParse(ageText, out age)))
            
            Console.WriteLine(age);
        }

        private void Feature1()
        {
            //TryParse can have the declaration
            string agetext = "Ten";

            ////old way
            //int age = 0;
            //bool isValid = Int32.TryParse(agetext, out age);

            //new way
            bool isValid = Int32.TryParse(agetext, out int age);

            Console.WriteLine(age);
        }

        //private ref Product GetProductAsRef(string v)
        //{
        //    Product pr = new Product() { Name = "AAA", Sold = 200, Category = "X" };
        //    return ref pr;
        //}

        /// <summary>
        /// Span<T> and ReadOnlySpan<T>, which are lightweight memory buffers that can be backed by managed or unmanaged memory.
        /// Because these types can only be stored on the stack, they are unsuitable for a number of scenarios,
        /// including asynchronous method calls
        /// </summary>
        public void SpanCheck()
        {
            // Create a span over an array.
            var array = new byte[100];
            array[2] = 100;
            var arraySpan = new Span<byte>(array); //install system.memory from nuget 

            byte data = 0;
            for (int ctr = 0; ctr < arraySpan.Length; ctr++)
                arraySpan[ctr] = data++;

            int arraySum = 0;
            foreach (var value in array)
                arraySum += value;

            Console.WriteLine($"The sum is {arraySum}");
            // Output:  The sum is 4950
        }
    }
}
