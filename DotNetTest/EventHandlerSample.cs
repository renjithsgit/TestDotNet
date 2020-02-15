using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    //publisher

    public delegate string MyDel(string str);
    class EventHandlerSample
    {
        public event MyDel MyEvent;

        public EventHandlerSample()
        {

        }

        public string WelcomeUser(string username)
        {
            Console.WriteLine("before clalling event  " + username);
            MyEvent(username);
            Console.WriteLine("after raising event   ");
            return "Welcome " + username;
        }
    }
}
