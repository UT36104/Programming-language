using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b;
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Большее число " + a);
            }
            else
            {
                Console.WriteLine("Большее число " + b);
            }
            Console.ReadKey();
        }
    }
}

