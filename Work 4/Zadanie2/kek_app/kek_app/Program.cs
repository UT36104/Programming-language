using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kek_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы задали массив состоящий из " + n + " элементов");
            int[] massiv = new int[n];
            int len = massiv.Length;
            Random rnd = new Random();
            for (int i = 0; i < n; i = i + 1)
            {
                int random_number = rnd.Next(-5, 20);
                massiv[i] = random_number;
            };
            Console.WriteLine();
            Console.WriteLine("Сгенерированный массив: ");
            for (int z = 0; z < len; z = z + 1)
            {
                Console.Write(massiv[z] + " ");
            };
            Console.WriteLine();
            Console.WriteLine("Массив составленный из ТОЛЬКО ЧЕТНЫХ элементов: ");
            for (int r = 0; r < len; r = r + 1)
            {
                if (massiv[r]%2==0)
                {
                  Console.Write(massiv[r] + " ");
                };
            };
            Console.WriteLine();
            Console.WriteLine("Индексы ЧЕТНЫХ элементов: ");
            for (int r = 0; r < len; r = r + 1)
            {
                if (massiv[r] % 2 == 0)
                {
                    Console.Write("massiv[" + r + "] ");
                };
            };
            Console.ReadKey();
        }
    }
}
