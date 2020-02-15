using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class LamdaConversion
    {
        public void PrintAsRequiredLamda()
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


            var res = products.GroupBy(x => x.Category)
                 .Select(y => new { Categ = y.Key, SUmSold = y.Sum(k => k.Sold) });

            Console.WriteLine(res.ToList());
        }
    }
}
