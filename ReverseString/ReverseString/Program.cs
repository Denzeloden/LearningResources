using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS412_OdenW2LabReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "";
            string name = "";
            line = Console.ReadLine();
            Console.WriteLine("What is your name? " + line);
            Console.ReadKey();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                name = name + line[i];
            }

            Console.WriteLine("Your name in reverse is: " + name);
            Console.ReadLine();
        }
    }
}
