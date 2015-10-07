using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 42;
            int length = 25;
            int yard = (length * width) / 9;
            Console.WriteLine("The floor is {0} square feet.", yard);
        }
    }
}
