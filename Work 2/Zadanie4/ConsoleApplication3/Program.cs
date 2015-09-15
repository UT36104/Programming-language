using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
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
            Console.WriteLine("Введите третье число");
            int c;
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Большее число " + a);
            }
            if (b > c && b > a)
            {
                Console.WriteLine("Большее число " + b);
            }
            if (c > b && c > a)
            {
                Console.WriteLine("Большее число " + c);
            }
                Console.ReadKey();
            }
        }
    } 
