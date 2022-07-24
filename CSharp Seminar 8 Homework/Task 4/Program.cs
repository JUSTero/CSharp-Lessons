using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter index 1");
            int index1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter index 2");
            int index2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter index 3");
            int index3 = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,,] numbers = new int[index1, index2, index3];
            void PrintArray(int[,,] array, int m, int n, int l)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            Console.Write($"{array[i, j, k],3} ({i}, {j}, {k})  ");
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }
            }
            int CreateArray(int[,,] array, int m, int n, int l)
            {
                int[] test = new int[m * n * l];
                int count = -1;

                for (int i = 0; i < test.Length; i++)
                {
                    int temp = random.Next(10, 99);
                    if (test.Contains(temp))
                    {
                        i--;
                    }

                    else
                    {
                        test[i] = temp;
                        count++;
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            array[i, j, k] = test[count];
                            count--;
                        }
                    }
                }

                return array[m - 1, n - 1, l - 1];
            }

            CreateArray(numbers, index1, index2, index3);
            Console.WriteLine("Created array:");
            PrintArray(numbers, index1, index2, index3);
        }
    }
}