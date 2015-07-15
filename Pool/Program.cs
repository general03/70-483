using System;
using System.Threading;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launch \r\n (C)reatePool.cs, \r\n (T)askThread.cs, \r\n (T)ask(R)esult.cs, \r\n (T)ask(C)ontinuation.cs, \r\n (T)ask(Ch)ild.cs, \r\n (T)askChild(F)actory.cs or \r\n (T)askChild(W)aitAll ?");
            string letter = Console.ReadLine();
            if (letter.ToLower().Equals("c"))
            {
                CreatePool.LaunchThread();
            }
            else if (letter.ToLower().Equals("t"))
            {
                TaskThread.LaunchThread();
            }
            else if (letter.ToLower().Equals("tr"))
            {
                TaskResult.LaunchThread();
            }
            else if (letter.ToLower().Equals("tc"))
            {
                TaskContinuation.LaunchThread();
            } 
            else if (letter.ToLower().Equals("tch"))
            {
                TaskChild.LaunchThread();
            }
            else if (letter.ToLower().Equals("tf"))
            {
                TaskChildFactory.LaunchThread();

            }
            else if (letter.ToLower().Equals("tw"))
            {
                TaskChildWaitAll.LaunchThread();
            }
            else
            {
                Console.WriteLine("Wrong input! Press any press to exit");
                Console.ReadLine();
            } 
        }
    }
}
