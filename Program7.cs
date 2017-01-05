using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 1; j <= 7 - i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
}
