using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    public class Application : IApplication
    {
        private IBussinessLogic _bussinessLogic;
        public Application(IBussinessLogic bussinessLogic)
        {
            this._bussinessLogic = bussinessLogic;
        }
        public void Run()
        {
            _bussinessLogic.ProcessData();

        }
    }
}
