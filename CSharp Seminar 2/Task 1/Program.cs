﻿using System;
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
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num / 10 % 10);
        }
    }
}
