using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_1_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте ваше число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число " + number + " четное");
            }

            else
            {
                Console.WriteLine("Число " + number + " нечетное");
            }
        }
    }
}
