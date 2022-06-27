using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_1_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("И еще одно ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("В этом случае " + a + " больше");
            }

            else if (a < b)
            {
                Console.WriteLine("В этом случае " + b + " больше");
            }

            else
            {
                Console.WriteLine("Введены одинаковые числа");
            }
        }
    }
}
