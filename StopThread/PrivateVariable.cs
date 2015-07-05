using System;
using System.Threading;

namespace StopThread
{
    public static class PrivateVariable
    {
        public static void LaunchThread()
        {
            // Private thread variable
            bool stopped = false;
            // Init thread with lambda expression (other syntax of : Thread t = new Thread(new ThreadStart(ThreadMethod)); )
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();

            Console.WriteLine("Press any key to stop this thread");
            Console.ReadKey();
            stopped = true;
            // Wait the end of the thread, so the end of time slice 
            t.Join();
        }
    }
}
