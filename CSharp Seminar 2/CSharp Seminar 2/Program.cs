using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Seminar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*void numberRandom(int min, int max)
            {
                int num = new Random().Next(min, max + 1);

                if (num / 10 > num % 10)
                {
                    Console.WriteLine(num + " ==> " + num / 10);
                }

                else
                {
                    Console.WriteLine(num + " ==> " + num % 10);
                }
            }

            Console.WriteLine("Введите нижний предел");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхний предел");
            int end = Convert.ToInt32(Console.ReadLine());
            numberRandom(start, end);*/

            int sumTwoNumbers(int a, int b)
            {
                int sum = a + b;
                return sum;
            }
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма = " + sumTwoNumbers(number1, number2));
        }

    }
}
