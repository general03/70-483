using System;
using System.Threading.Tasks;

namespace Pool
{
    class TaskThread
    {
        public static void LaunchThread()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine("Loop {0}", x);
                }
            });

            // The same thing that .join() in thread
            t.Wait();

            Console.ReadKey();
        }
    }
}
