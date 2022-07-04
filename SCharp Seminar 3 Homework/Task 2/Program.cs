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
            Console.WriteLine("Введите координату Х первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Z первой точки");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Х второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Z второй точки");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine(lenght);
        }
    }
}
