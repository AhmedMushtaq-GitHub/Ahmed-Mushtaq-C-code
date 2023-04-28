//C# Conditions and If Statements
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 24;
            if (time <= 11)
            {
                Console.WriteLine("Good Morning.");
            }
            else if (time <= 15)
            {
                Console.WriteLine("Good Noon.");
            }
            else if (time <= 17)
            {
                Console.WriteLine("Good Afternoon.");
            }
            else if (time <= 22)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good Night.");
            }
        }
    }
    /*class Variables
    {
       static void Main () {
            int x;
            int y;
            x = 67;
            y = x / 6;


            Console.WriteLine(y);
            Console.ReadLine();
        }
    }*/
}
