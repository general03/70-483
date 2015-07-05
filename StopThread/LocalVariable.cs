using System;
using System.Threading;

namespace StopThread
{
    class LocalVariable
    { 
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                // Thread.CurrentThread contains informations about current thread, so the context
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void LaunchThread()
        {
            new Thread(() =>
            {
                for(int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
        
    }
}
