using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter degree");
            int degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int i = 1;
            int result = 1;

            int Exponentiation(int n, int d)
            {
                if (i <= d)
                {
                    result *= n;
                    i++;
                    Exponentiation(n, d);
                }

                return result;
            }

            Console.Write($"{number} To the power of {degree} = ");
            Exponentiation(number, degree);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
