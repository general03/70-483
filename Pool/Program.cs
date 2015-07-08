using System;
using System.Threading;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("A thread from thread pool");
            });

            Console.ReadLine();
        }
    }
}
