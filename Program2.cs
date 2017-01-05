
/*Write a C# program that prompts the user to input three integer values and find the greatest value of the
three values */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, avg;
            Console.WriteLine("Enter values");

            a = int.Parse(Console.ReadLine());
            // Console.WriteLine(a);

            b = int.Parse(Console.ReadLine());
            // Console.WriteLine(b);

            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " is Greater");
                }
                else
                {
                    Console.WriteLine(c + " is Greater");
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b + " is Greater");

            }
            else
            {
                Console.WriteLine(c + " is Greater");
            }
          
        }
    }
}

