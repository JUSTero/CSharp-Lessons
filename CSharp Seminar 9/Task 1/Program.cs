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
            Console.WriteLine("Enter the number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write($"N = {N} -> ");
            int i = 1;

            void Subsequence(int n)
            {
                if (i < n)
                {
                    Console.Write($"{i} ");
                    i++;
                    Subsequence(n);
                }

                else
                {
                    Console.Write(i);
                }
            }

            Subsequence(N);
            Console.WriteLine();
        }
    }
}
