using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pool
{
    class TaskChildWaitAll
    {
        public static void LaunchThread()
        {
            Task<int>[] tasks = new Task<int>[3];
            
            tasks[0] = Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("7");
                return 7;
            });

            tasks[1] = Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("8");
                return 8;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("9");
                return 9; }
            );

            // Wait the first task finishes
            int i = Task.WaitAny(tasks);
            Console.WriteLine("The task {0} is finished.", i);

            // The 3 tasks are simultaneously launched, it takes 2000ms for the 3 threads
            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}
