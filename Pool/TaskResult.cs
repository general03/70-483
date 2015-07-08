using System;
using System.Threading.Tasks;

namespace Pool
{
    class TaskResult
    {
        public static void LaunchThread()
        {
            Task<int> t = Task.Run(() =>
            {
                return 1336;
            });
            
            // Wait the end of task for read the result (and continue the program)
            Console.WriteLine(t.Result); // Displays 1336

            Console.ReadKey();
        }
    }
}
