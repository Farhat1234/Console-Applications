using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("The Value of a is " + a);
            Console.WriteLine("......................");
            Console.WriteLine("The Value of ++a is " + ++a);
            Console.WriteLine("The Value of a is " + a);
            Console.WriteLine("The Value of a++ is " + a++);
            Console.WriteLine("The Value of a is " + a);
            Console.WriteLine("The Value of -a is " + (--a));
            Console.WriteLine("The Value of a is " + a);
            Console.WriteLine("The Value of a- is " + (a--));
            Console.WriteLine("The Value of a is " + a);
        }
    }
}
