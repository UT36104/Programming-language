using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tvorс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк для первой матрицы: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк для первой матрицы: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите количество строк для второй матрицы: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк для второй матрицы: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            if (n1 != n2 || m1 != m2)
            {
                Console.WriteLine("Матрицы не равны!");
            }
            else
            {
                int[,] massiv1 = new int[n1, m1];
                int massiv1_strok = massiv1.GetLength(0);
                int massiv1_stolb = massiv1.GetLength(1);

                int[,] massiv2 = new int[n2, m2];
                int massiv2_strok = massiv2.GetLength(0);
                int massiv2_stolb = massiv2.GetLength(1);

                int umnoj;
                int sloj;

                Random rnd = new Random();

                Console.WriteLine();
                Console.WriteLine("Первый массив");
                for (int i1 = 0; i1 < massiv1_strok; i1++)
                {
                    for (int j1 = 0; j1 < massiv1_stolb; j1++)
                    {
                        massiv1[i1, j1] = rnd.Next(-10, 15);
                        Console.Write(massiv1[i1, j1] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Второй массив");
                for (int i2 = 0; i2 < massiv2_strok; i2++)
                {
                    for (int j2 = 0; j2 < massiv2_stolb; j2++)
                    {
                        massiv2[i2, j2] = rnd.Next(-5, 10);
                        Console.Write(massiv2[i2, j2] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Перемножение массивов: ");
                for (int i3 = 0; i3 < massiv1_strok; i3++)
                {
                    for (int j3 = 0; j3 < massiv1_stolb; j3++)
                    {
                       umnoj = massiv1[i3, j3] * massiv2[i3, j3];
                       Console.Write(umnoj + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Сложение массивов: ");
                for (int i4 = 0; i4 < massiv2_strok; i4++)
                {
                    for (int j4 = 0; j4 < massiv2_stolb; j4++)
                    {
                        sloj = massiv1[i4, j4] + massiv2[i4, j4];
                        Console.Write(sloj + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
