﻿using System;
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
            Console.WriteLine("Массив в зеркальном порядке: ");
            for (int i = massivD - 1; -1 < i; i--)
            {
                Console.Write(massiv[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
