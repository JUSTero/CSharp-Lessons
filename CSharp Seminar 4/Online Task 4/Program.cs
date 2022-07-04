using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] RandomArrayGenerate(int N, int start, int end)
            {
                Random random = new Random();
                int[] RandomArray = new int[N];
                for (int i = 0; i < N; i++)
                {
                    RandomArray[i] = random.Next(start, end + 1);
                }
                return RandomArray;
            }
            void ShowArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите количество элементов массива");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число случайного генерируемого диапазона");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите последнее число случайного генерируемого диапазона");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] myRandomArray = RandomArrayGenerate(num, min, max);
            ShowArray(myRandomArray);
        }

    }
}
