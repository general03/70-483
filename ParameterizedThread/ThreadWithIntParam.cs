using System;
using System.Threading;

namespace ParameterizedThread
{
    class ThreadWithIntParam
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Thread : {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            try
            {
                Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
                t.Start(5);

                // Abort is DANGEROUS : use shared variable to do this
                t.Abort();
                
            }
            catch (ThreadAbortException exception)
            {
                Console.WriteLine(exception.ToString());
            }

            // To stop the program and see the result
            Console.ReadLine();
        }
    }
}
