using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharp_seminar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Input()
            {
                int[] Array = new int[2];
                Console.WriteLine("Введите координату Х");
                int x = Convert.ToInt32(Console.ReadLine());
                Array[0] = x;
                Console.WriteLine("Введите координату У");
                int y = Convert.ToInt32(Console.ReadLine());
                Array[1] = y;
                return Array;
            }
            int[] mini = Input();
            while (mini[0] == 0 || mini[1] == 0)
            {
                Console.WriteLine("Точка находится на оси");
                mini = Input();
            }

            if (mini[0] > 0 && mini[1] > 0)
            {
                Console.WriteLine("Точка находится в первой четверти");
            }

            else if (mini[0] < 0 && mini[1] < 0)
            {
                Console.WriteLine("Точка находится в третьей четверти");
            }

            else if (mini[1] < 0 && mini[0] > 0)
            {
                Console.WriteLine("Точка находится в четвертой четверти");
            }

            else
            {
                Console.WriteLine("Точка находится во второй четверти");
            }
        }
    }
}
