
/*The program will read three types of scores(quiz score, mid-term score, and final score) and determine the
grade based on the following rules:
-if the average score =90% : then display grade-A
-if the average score >= 70% and <90% :then display grade-B
-if the average score>=50% and <70% :then display grade-C
-if the average score<50% :then display grade-F
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quizscore, Midtermscore, finalscore, avg;

            quizscore = int.Parse(Console.ReadLine());
            Midtermscore = int.Parse(Console.ReadLine());
            finalscore = int.Parse(Console.ReadLine());

            avg = (quizscore + Midtermscore + finalscore) / 3;

            Console.WriteLine("The Average is : " + avg);

            if ( avg >= 90 )
                Console.WriteLine("The Grade is A" );
            else if (avg >= 70 && avg <= 90)
                Console.WriteLine("The Grade is B");
            else if (avg >= 50 && avg <= 70)
                Console.WriteLine("The Grade is C");
            else
                Console.WriteLine("The Grade is F");

                

        }
    }
}
