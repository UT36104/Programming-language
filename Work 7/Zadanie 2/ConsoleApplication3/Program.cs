
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            int mass_L = mass.Length;
            Random rand = new Random();
            for (int i = 0; i < mass_L; i++)
            {
                mass[i] = rand.Next(0, 20);
            }
            Console.Write("Массив: ");
            for (int i = 0; i < mass_L; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("Максимальный элемент: " + MaxFinder(mass));
            Console.ReadKey();
        }
        static int MaxFinder(int[] b)
        {
            int max = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (max < b[i])
                {
                    max = b[i];
                }
            }
            return max;
        }

    }
}