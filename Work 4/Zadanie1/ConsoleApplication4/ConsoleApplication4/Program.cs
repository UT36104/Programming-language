using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kekas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[n];
            Console.Write("Введите массив с клавиатуры ");
            int i;
            for (i = 0; i < n; i++)
            {
                massiv[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив");
            for (i = 0; i < n; i++)
            {
                Console.Write(massiv[i] + " ");
            }
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                sum = sum + massiv[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов в массиве: " + sum);
            Console.WriteLine("Среднее арифметическое в массиве: " + sum / n);
            int massiv_min = 0;
            int massiv_max = 0;
            for (i = 0; i < n; i++)
            {
                if (massiv[i] < 0)
                {
                    massiv_min = massiv_min + 1;
                }
                else
                {
                    massiv_max = massiv_max + 1;
                }
            }
            Console.WriteLine("Количество отрицательных элементов в массиве: " + massiv_min);
            Console.WriteLine("Количество положительных элементов в массиве: " + massiv_max);
            int min_massiv = massiv[0];
            for (i = 0; i < n; i++)
            {
                if (min_massiv > massiv[i])
                {
                    min_massiv = massiv[i];
                }
            }
            Console.WriteLine("Минимальный элемент в массиве: " + min_massiv);
            int max_massiv = massiv[0];
            for (i = 0; i < n; i++)
            {
                if (max_massiv < massiv[i])
                {
                    max_massiv = massiv[i];
                }
            }
            Console.WriteLine("Максимальный элемент в массиве: " + max_massiv);
            Console.ReadKey();
        }
    }
}
