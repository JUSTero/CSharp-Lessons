using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_2_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ага, еще одно");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("И последнее");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine("Здесь " + a + " больше");
            }

            else if (b > c & b > a)
            {
                Console.WriteLine("Здесь " + b + " обходит оппонентов");
            }

            else
            {
                Console.WriteLine("Здесь " + c + " побеждает");
            }
        }
    }
}
