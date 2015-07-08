using System;
using System.Threading;

namespace Pool
{
    class CreatePool
    {
        public static void LaunchThread()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("A thread from thread pool");
            });

            Console.ReadLine();
        }
    }
}
