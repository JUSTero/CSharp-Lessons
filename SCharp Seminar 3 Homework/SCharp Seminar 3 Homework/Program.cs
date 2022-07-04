using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharp_Seminar_3_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число");
            string num = (Console.ReadLine());
            int size = num.Length;
            int count = 0;
            for (int i = 0; i <= size / 2; i++)
            {
                if (num[i] == num[size - 1])
                {
                    size--;
                    count++;
                }

                else
                {
                    Console.WriteLine("Число не является палиндромом");
                    break;
                }

                if (count < size / 2)
                Console.WriteLine("Число является палиндромом");
            }
        }
    }
}
