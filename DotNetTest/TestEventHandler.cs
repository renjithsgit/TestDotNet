using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    
    //sunscriber
    class TestEventHandler
    {
        public void TestHandler()
        {
            EventHandlerSample ts = new EventHandlerSample();
            ts.MyEvent += Ts_MyEvent;
            ts.MyEvent += NEWMethod;
            string res = ts.WelcomeUser("test program");
            Console.WriteLine("result: " + res);

            ts.MyEvent -= NEWMethod;
            ts.WelcomeUser("test2222");
        }

        private string NEWMethod(string str)
        {
            Console.WriteLine("inside subscriber2" + str);
            return "testng " + str;
        }

        private string Ts_MyEvent(string str)
        {
            Console.WriteLine("inside Ts_MyEvent.After event" + str);
            return "testng " + str;
        }

    }
}
