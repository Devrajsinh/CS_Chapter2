using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer");
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);

            Console.WriteLine("Enter the second integer");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);

            sum = first + second;
            Console.WriteLine ("{0}, the sum of {1} and {2} is {3}", first, second, sum; 
        }
    }
}
