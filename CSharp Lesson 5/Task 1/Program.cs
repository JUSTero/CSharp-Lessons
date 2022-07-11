using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[12];
            Random random = new Random();
            int sum_negative = 0;
            int sum_positive = 0;
            Console.Write("Создан массив => ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-9, 10);
                Console.Write($"{numbers[i], 3}");
            }

            Console.WriteLine();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    sum_negative += numbers[i];
                }

                else
                {
                    sum_positive += numbers[i];
                }
            }
                Console.WriteLine($"Сумма положительных чисел => {sum_positive}");
                Console.WriteLine($"Сумма отрицательных чисел => {sum_negative}");
        }
    }
}
