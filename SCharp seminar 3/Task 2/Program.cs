using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int Input()
            {
                Console.WriteLine("Введите номер четверти");
                a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
            Input();
            while (a > 4 || a < 1)
            {
                Console.WriteLine("Введено недопустимое значение");
                Input();
            }

            if (a == 1)
            {
                Console.WriteLine("x > 0");
                Console.WriteLine("y > 0");
            }

            else if (a == 2)
            {
                Console.WriteLine("x < 0");
                Console.WriteLine("y > 0");
            }

            else if (a == 3)
            {
                Console.WriteLine("x < 0");
                Console.WriteLine("y < 0");
            }

            else
            {
                Console.WriteLine("x > 0");
                Console.WriteLine("y < 0");
            }
        }
    }
}
