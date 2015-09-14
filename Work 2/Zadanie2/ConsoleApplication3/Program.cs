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
            string c;
            c = Console.ReadLine();
            int a1; 
            a1 = Convert.ToInt32(a);
            int b1;
            b1 = Convert.ToInt32(b);
            int c1;
            c1 = Convert.ToInt32(c);
            int s;
            s = a1 + b1;
            s = s + c1;
            Console.WriteLine("Сумма данных чисел равна ");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
