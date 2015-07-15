using System;
using System.Threading.Tasks;

namespace Pool
{
    class TaskChildFactory
    {
        public static void LaunchThread()
        {
            Task<Int32[]> parent = new Task<int[]>(() =>
            {
                var results = new Int32[3];
                // Use this factory configuration...
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
                // ... to create tasks
                tf.StartNew(() => results[0] = 4);
                tf.StartNew(() => results[1] = 5);
                tf.StartNew(() => results[2] = 6);
                return results;
            });

            parent.Start();

            var finalTask = parent.ContinueWith(
            parentTask =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            // Wait the task parent finished (and the child tasks finished)
            finalTask.Wait();

            // Result :
            // 4
            // 5
            // 6
            Console.ReadKey();
            
        }
    }
}
