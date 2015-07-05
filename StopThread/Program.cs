using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThread
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Launch (P)rivateVariable.cs, (S)taticVariable.cs or (L)ocalVariable.cs ?");
            string letter = Console.ReadLine();
            if (letter.ToLower().Equals("p"))
            {
                PrivateVariable.LaunchThread();
            }
            else if (letter.ToLower().Equals("s"))
            {
                StaticVariable.LaunchThread();
            }
            else if (letter.ToLower().Equals("l"))
            {
                LocalVariable.LaunchThread();
            }
            else
            {
                Console.WriteLine("Wrong input! Press any press to exit");
                Console.ReadLine();
            }
        }
    }
}
