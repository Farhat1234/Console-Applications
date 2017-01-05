using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number\n\n");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            int n = (num % 10);

            if(n==1)
                Console.WriteLine("That is the " + num + "st item!\n" );
            else if (n == 2)
                Console.WriteLine("That is the " + num + "nd item!\n");
            else if (n == 1)
                Console.WriteLine("That is the " + num + "rd item!\n");
            else
                Console.WriteLine("That is the " + num + "th item!\n");
        }
    }
}
