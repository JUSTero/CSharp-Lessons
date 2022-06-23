using System;                                      //еврейское решение
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_1_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваши четные числа");

            for (int i = 2; i <= number; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

/*using System;                                         //законное решение
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_1_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваши четные числа");

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}*/