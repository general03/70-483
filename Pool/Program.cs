using System;
using System.Threading;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launch (C)reatePool.cs, (T)askThread.cs, (T)ask(R)esult.cs, (T)ask(C)ontinuation.cs or (T)ask(Ch)ild.cs ?");
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
            else
            {
                Console.WriteLine("Wrong input! Press any press to exit");
                Console.ReadLine();
            } 
        }
    }
}
