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
            string temp = string.Empty;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                temp += num[i];
            }
            
            if (temp == num)
            {
                Console.WriteLine("Число является палиндромом");
            }

            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
        }
    }
}
