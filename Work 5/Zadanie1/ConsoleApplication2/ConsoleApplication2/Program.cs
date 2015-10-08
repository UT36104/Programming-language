using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Количество строк массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] massiv = new int[n, m];
            int massiv_w = massiv.GetLength(0);
            int massiv_h = massiv.GetLength(1);
            Random rand = new Random();
            Console.WriteLine();
            for (int i = 0; i < massiv_w; i++)
            {
                for (int j = 0; j < massiv_h; j++)
                {
                    massiv[i, j] = rand.Next(-5, 25);
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int min = massiv[0, 0];
            int i_min_index = 0;
            int j_min_index = 0;
            for (int i = 0; i < massiv_w; i++)
            {
                for (int j = 0; j < massiv_h; j++)
                {
                    if (min > massiv[i, j])
                    {
                        min = massiv[i, j];
                        i_min_index = i;
                        j_min_index = j;
                    }

                }

            }
            int max = massiv[0, 0];
            int i_max_index = 0;
            int j_max_index = 0;
            for (int i = 0; i < massiv_w; i++)
            {
                for (int j = 0; j < massiv_h; j++)
                {
                    if (max < massiv[i, j])
                    {
                        max = massiv[i, j];
                        i_max_index = i;
                        j_max_index = j;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < massiv_w; i++)
            {
                for (int j = 0; j < massiv_w; j++)
                {
                    sum = sum + massiv[i, j];

                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Индекс миниального элемента: [" + i_min_index + "," + j_min_index + "]");
            Console.WriteLine("Индекс максимального элемента: [" + i_max_index + "," + j_max_index +"]");
            Console.WriteLine("Сумма всех элементов: " + sum);
            Console.ReadKey();
        }
    }
}