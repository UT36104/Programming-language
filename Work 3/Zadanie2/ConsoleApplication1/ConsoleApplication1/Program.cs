using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел - ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Число должно быть положителным");
            }
            else
            {
                int suma = 0;
                for (int i = 1; i <= n; i = i + 1)
                {
                    suma = suma + i;
                }
                Console.WriteLine(suma);
            }
            Console.ReadKey();
        }
    }
}