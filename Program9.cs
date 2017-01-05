using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;

            Console.WriteLine("Enter a number\n\n");

            int num = int.Parse(Console.ReadLine());
           
            Console.WriteLine("\n\n");

            while(i<=num)
            {
                if ((i % 3 == 0) && ( i % 5 == 0))
                    Console.WriteLine("foobar");
                else if ((i % 3) == 0)
                    Console.WriteLine("foo");
                else if ((i % 5) == 0)
                    Console.WriteLine("bar");        
                else
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
