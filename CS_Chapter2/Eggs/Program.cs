using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int egg1 = 19;
            int egg2 = 12;
            int egg3 = 23;
            int egg4 = 28;
            
            int all = (egg1 + egg2 + egg3 + egg4);

            Console.WriteLine("{0} eggs is equals to {1} dozens and {2} eggs", all, all /12, all % 12);

        }
    }
}
