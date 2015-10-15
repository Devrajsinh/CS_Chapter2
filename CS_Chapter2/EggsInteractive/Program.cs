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
            string chicken, chicken2, chicken3, chicken4;
            int egg, egg2, egg3, egg4, total, dozen, eggs;
            Console.WriteLine("Enter the first integer");
            chicken = Console.ReadLine();
            egg = Convert.ToInt32(chicken);
            Console.WriteLine("Enter the second integer");
            chicken2 = Console.ReadLine();
            egg2 = Convert.ToInt32(chicken2);
            Console.WriteLine("Enter the third integer");
            chicken3 = Console.ReadLine();
            egg3 = Convert.ToInt32(chicken3);
            Console.WriteLine("Enter the fourth integer");
            chicken4 = Console.ReadLine();
            egg4 = Convert.ToInt32(chicken4);
            total = egg + egg2 + egg3 + egg4;
            dozen = total % 12;
            eggs = total / 12;
            Console.WriteLine ("Out of {0} eggs, there are {1} dozens and {2} eggs.", total, dozen, eggs); 
        }
    }
}
