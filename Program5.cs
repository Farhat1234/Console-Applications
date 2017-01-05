using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            float degree,fahrenheit;
            degree = int.Parse(Console.ReadLine());
            fahrenheit = (((degree*9)/5)+32);
            Console.WriteLine("The Value in Fahrenheit is " + fahrenheit);
        }
    }
}
