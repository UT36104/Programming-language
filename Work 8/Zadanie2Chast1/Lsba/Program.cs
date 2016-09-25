using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lsba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу: ");
            string HightWayToFile = Console.ReadLine();
            StreamWriter FileWriter = new StreamWriter(HightWayToFile + "\\matrix.log");
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] massiv1 = new int[n, m];
            int massiv1_n = massiv1.GetLength(0);
            int massiv1_m = massiv1.GetLength(1);
            FileWriter.WriteLine(n);
            FileWriter.WriteLine(m);
            for (int i = 0; i < massiv1_n; i++)
            {
                for (int k = 0; k < massiv1_m; k++)
                {
                    massiv1[i,k] = rnd.Next(-5, 20);
                    FileWriter.Write(massiv1[i, k] + " ");
                }
                FileWriter.WriteLine();
            }
            FileWriter.WriteLine("*");
            int[,] massiv2 = new int[n, m];
            int massiv2_n = massiv1.GetLength(0);
            int massiv2_m = massiv1.GetLength(1);
            for (int i = 0; i < massiv2_n; i++)
            {
                for (int k = 0; k < massiv2_m; k++)
                {
                    massiv2[i, k] = rnd.Next(-5, 20);
                    FileWriter.Write(massiv2[i, k] + " ");
                }
                FileWriter.WriteLine();
            }
            FileWriter.Close();
            Console.Write("Готово!");
            Console.ReadKey();
        }
    }
}
