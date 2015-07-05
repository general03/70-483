using System;
using System.Threading;

namespace background
{
    class ThreadBackground
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread : {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            // The program stop immediately ...
            t.IsBackground = true;
            //... after this line
            t.Start(); 
        }
        
    }
}
