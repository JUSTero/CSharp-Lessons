using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower number");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper number");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int Akkerman(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }

                else if (m > 0 && n == 0)
                {
                    return Akkerman(m - 1, 1);
                }

                else if (m > 0 && n > 0)
                {
                    return Akkerman(m - 1, Akkerman(m, n -1));
                }

                else
                {
                    return 0;
                }    
            }

            int akkermanFunction = Akkerman(lowerNumber, upperNumber);
            Console.WriteLine($"Result = {akkermanFunction}");
            Console.WriteLine();

        }
    }
}
