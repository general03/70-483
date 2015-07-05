using System;
using System.Threading;

namespace StopThread
{
    class StaticVariable
    {
        // Local data init for each thread
        [ThreadStatic]
        public static int _loop;
        public static void LaunchThread()
        {
            new Thread(() =>
            {
                for(int x = 0; x < 20; x++)
                {
                    _loop++;
                    Console.WriteLine("Thread A: {0}", _loop);
                }
            }).Start();

            new Thread(() =>
            {
                for(int x = 0; x < 20; x++)
                {
                    _loop++;
                    Console.WriteLine("Thread B: {0}", _loop);
                }
            }).Start();
         
            Console.ReadKey();
        }
    }
}
