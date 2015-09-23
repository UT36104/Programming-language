using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Поменяем значения введенных чисел местами и получим…");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadKey();
        }
    }
}
