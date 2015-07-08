using System;
using System.Threading.Tasks;

namespace Pool
{
    class TaskContinuation
    {
        public static void LaunchThread()
        {
            Task<int> t = Task.Run(() =>
            {
                return 1336;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();       
            
            // Wait the end of task for read the result (and continue the program)
            Console.WriteLine(t.Result); // Displays 2672

            Console.ReadKey();
        }
    }
}
