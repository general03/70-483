using System;
// For manage thread
using System.Threading;

namespace _70_483
{
    class SimpleThread
    {
        // Added thread
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread added : {0}", i);
                // Stop immediately this thread without waiting the  whole time slice ended
                Thread.Sleep(0);
            }
        }

        // Main thread
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread");
                // Stop immediately this thread without waiting the  whole time slice ended
                Thread.Sleep(0);
            }
            // Wait the other thread finished
            t.Join();

            // To stop the program and see the result
            Console.ReadLine();
        }
        
    }
}
