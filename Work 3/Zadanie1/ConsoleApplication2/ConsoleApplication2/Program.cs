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
            Console.Write("Введите первое число - ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число - ");
            int second = Convert.ToInt32(Console.ReadLine());
            int buffer = first;
            first = second;
            second = buffer;
            Console.WriteLine("Результат:");
            Console.WriteLine("Первое число = " + first);
            Console.WriteLine("Второе число = " + second);
            Console.ReadKey();
        }
    }
}
