using System;
using System.Threading.Tasks;

namespace Pool
{
    class TaskChild
    {
        public static void LaunchThread()
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];
                new Task(() => results[0] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 2, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 3, TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                }
            );

            // Wait the task parent finished (and the child tasks finished)
            finalTask.Wait();

            // Result :
            // 1
            // 2
            // 3
            Console.ReadKey();
            
        }
    }
}
