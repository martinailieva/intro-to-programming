using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1_BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Please, insert first number");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, insert second number");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, insert third number");
            c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }

                else
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            Console.ReadKey(true);
        }
    }
    
}
