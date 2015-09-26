using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stosik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введити длинну массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[n];
            int massivD = massiv.Length;
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < massivD; i++)
            {
                massiv[i] = random.Next(-6, 25);
                Console.Write(massiv[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Меняем части массива местами: ");
            int pol_massiva = massivD / 2;
            int vtoraya_pol_massiva = pol_massiva + massivD % 2;
            if (massivD % 2 == 0)
            {
                for (int i = 0; i < pol_massiva; i++)
                {
                    Console.Write(massiv[vtoraya_pol_massiva + i] + " ");
                }
                for (int v = 0; v < vtoraya_pol_massiva; v++)
                {
                    Console.Write(massiv[v] + " ");
                }
            }
            else
            {
                for (int i = 0; i < pol_massiva; i++)
                {
                    Console.Write(massiv[vtoraya_pol_massiva + i] + " ");
                }
                Console.Write(massiv[pol_massiva] + " ");
                for (int v = 0; v+1 < vtoraya_pol_massiva; v++)
                {
                    Console.Write(massiv[v] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
