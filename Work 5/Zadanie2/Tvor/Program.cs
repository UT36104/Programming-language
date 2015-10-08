using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tvor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());//строка
            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());//столбец
            if (n != m)
            {
                Console.WriteLine("УПС! ОШИБОСИК! Количество строк не равно количеству стобцов!");
            }
            else
            {
                int[,] massiv = new int[n, m];
                int massiv_strok = massiv.GetLength(0);
                int massiv_stolb = massiv.GetLength(1);
                Random rnd = new Random();
                for (int i = 0; i < massiv_strok; i++)
                {
                    for (int j = 0; j < massiv_stolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-5, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //Сложение
                int summa = 0;
                int k = 0;
                for (int i = 0; i < massiv_strok; i++)
                {
                    summa = summa + massiv[i, k];
                    k++;
                }
                Console.WriteLine("Сумма элементов по диагонали: " + summa);
                //Умножение
                int umnoj = 1;
                int z = massiv_strok;
                for (int i = 0; i < massiv_strok; i++)
                {
                    umnoj = umnoj * massiv[i, z-1];
                    z--;
                }
                Console.WriteLine("Произвидение элементов по диагонали: " + umnoj);
            }
            Console.ReadKey();
        }
    }
}
