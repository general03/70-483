using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelCLass
{
    class ParallelLoop
    {
        static void Main(string[] args)
        {
            // Launch this loop in parallel ...
            Parallel.For(0, 10, (int i, ParallelLoopState loopState) =>
            {
                Thread.Sleep(500);
                Console.WriteLine("For : {0}", i);

                if (i == 6)
                {
                    Console.WriteLine("i=6 : Wait the current iteration finish to Break()");
                    loopState.Break();
                }
            });

            // ... then this loop in parallel also
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, (int i, ParallelLoopState loopState) =>
            {
                Thread.Sleep(500);
                Console.WriteLine("ForEach : {0}", i);

                if (i == 4)
                {
                    Console.WriteLine("i=4 : Stop immediately with Stop()");
                    loopState.Stop();
                }
            });

            // For : 0
            // For : 5
            // For : 1
            // For : 2
            // For : 6
            // i=6 : Wait the current iteration finish to Break()
            // For : 4
            // For : 3
            // ForEach : 1
            // ForEach : 0
            // ForEach : 2
            // ForEach : 5
            // ForEach : 4
            // i=4 : Stop immediately with Stop()
            // ForEach : 3
            // ForEach : 6
            // ForEach : 7
            Console.ReadKey();
        }
    }
}
