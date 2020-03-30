using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope()) 
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
                //var bussinessLogic = scope.Resolve<IBussinessLogic>();
                //bussinessLogic.ProcessData();
            }

            Console.ReadLine();
        }
    }
}
