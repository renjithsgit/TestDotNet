using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DotNetTest
{
    class DelegateTest
    {
        // The delegate must have the same signature as the method
        // it will call asynchronously.
        public delegate string AsyncMethodCaller(int callDuration, out int threadId);

        public void UseDelegate()
        {
            // The asynchronous method puts the thread id here.
            int threadId;

            // Create an instance of the test class.
            AsyncDemo ad = new AsyncDemo();

            // Create the delegate.
            AsyncMethodCaller caller = new AsyncMethodCaller(ad.TestMethod);

            // Initiate the asychronous call.
            IAsyncResult result = caller.BeginInvoke(3000,
                out threadId, null, null);

            Thread.Sleep(200);
            Console.WriteLine("Main thread {0} does some work.",
                Thread.CurrentThread.ManagedThreadId);

            // Call EndInvoke to wait for the asynchronous call to complete,
            // and to retrieve the results.
            string returnValue = caller.EndInvoke(out threadId, result);

            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".",
                threadId, returnValue);
        }

        public async void DoAsyncOperation()
        {

            var re = await TestMethodAsyncWithCallBAck(3000, SearchCompleted);
            //var res = await StartAsync(4000);
            Console.WriteLine("completed async operation.");

            

        }
        private static void SearchCompleted(Tuple<int, string> tuple)
        {
            // This method will be called whenever a file is processed.
            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".",
                     tuple.Item1, tuple.Item2);
        }

        public async Task<string> TestMethodAsyncWithCallBAck(int callDuration, Action<Tuple<int, string>> callback)
        {
            Console.WriteLine("Test method begins.");
            Thread.Sleep(callDuration);
            int threadId = Thread.CurrentThread.ManagedThreadId;
            callback(new Tuple<int, string>(threadId, string.Format("callback of Async. call time was {0}.", callDuration.ToString())));
            return "ok";
        }
        public async Task<Tuple<int, string>> StartAsync(int callDuration)
        {
            Console.WriteLine($"Main thread {0} does some work.",
             Thread.CurrentThread.ManagedThreadId);
            // Create an instance of the test class.
            AsyncDemo ad = new AsyncDemo();
            var tuple = await ad.TestMethodAsync(4000);
            //var tuple1 = await ad.TestMethodAsync(2000);

            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".",
                     tuple.Item1, tuple.Item2);
            return tuple;
        }
    }
    public class AsyncDemo
    {
        // The method to be executed asynchronously.
        public string TestMethod(int callDuration, out int threadId)
        {
            Console.WriteLine("Test method begins.");
            Thread.Sleep(callDuration);
            threadId = Thread.CurrentThread.ManagedThreadId;
            return String.Format("My call time was {0}.", callDuration.ToString());
        }

        public async Task<Tuple<int,string>> TestMethodAsync(int callDuration)
        {
            Console.WriteLine("Test method begins.");
            Thread.Sleep(callDuration);
            int threadId = Thread.CurrentThread.ManagedThreadId;
            return new Tuple<int, string>(threadId, string.Format("My Async call time was {0}.", callDuration.ToString()));
        }
    }

}
