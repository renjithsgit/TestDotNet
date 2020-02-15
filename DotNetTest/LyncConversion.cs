using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class LyncConversion
    {
        public void PrintAsRequiredLync()
        {
            List<Product> products = new List<Product>() {
                new Product(){ Name = "AAA", Sold = 200, Category = "X" },
                new Product(){ Name = "BBB", Sold = 124, Category = "X" },
                new Product(){ Name = "CCC", Sold = 150, Category = "y" },
                                                    };

            //output as 
            //category : x SumOf :324
            //   Name = AAA  Sold = 200   
            //   Name = BBB  Sold = 124


            var res = from product in products
                      group product by product.Category
                      into k
                      select new { cat = k.Key, sumOf = k.Sum(x => x.Sold) };


        }

        public void TestDefferedAndImmediateExecution()
        {
            List<Product> products = new List<Product>() {
                new Product(){ Name = "AAA", Sold = 200, Category = "X" },
                new Product(){ Name = "BBB", Sold = 124, Category = "X" },
                new Product(){ Name = "CCC", Sold = 150, Category = "y" },
                                                    };

            var deffferedExecution = from product in products
                                     where product.Category == "X"
                                     select product;

            foreach(var eachVal in deffferedExecution)
            {
                Console.WriteLine(eachVal.Name);
            }

            var immediateExecution = (from product in products
                                      where product.Category == "X"
                                      select product).Count();
            Console.WriteLine(immediateExecution);

        }
    }
}
