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
            Console.Write("Введите количество строк массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] massiv = new int[n, m];
            int m_w = massiv.GetLength(0);
            int m_h = massiv.GetLength(1);
            Random rnd = new Random();
            if (n != m)
            {
                Console.WriteLine("Нужна квадратная матрица");
            }
            else
            {
                for (int i = 0; i < m_w; i++)
                {
                    for (int j = 0; j < m_h; j++)
                    {
                        massiv[i, j] = rnd.Next(0, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int[,] massiv2 = new int[n, m];
                int m2_w = massiv2.GetLength(0);
                int m2_h = massiv2.GetLength(1);
                Console.WriteLine("Массив симметричный главной диагонали: ");
                for (int i = 0; i < m2_w; i++)
                {
                    for (int j = 0; j < m2_h; j++)
                    {
                        massiv2[i, j] = massiv[j, i];
                        Console.Write(massiv2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}