using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            string b;
            b = Console.ReadLine();
            int a1;
            a1 = Convert.ToInt32(a);
            int b1;
            b1 = Convert.ToInt32(b);
            int s;
            s = a1 + b1;
            Console.WriteLine("Сумма данных чисел равна ");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
