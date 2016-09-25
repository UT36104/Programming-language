using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n < 3)
            {
               return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int z = 10;
            Console.WriteLine("N = " + z);
            Console.WriteLine("Число Фибоначчи = " + Fibonacci(z));
            Console.WriteLine("Числа Фибоначчи = ");
            for (int i = 1; i < z + 1; i++)
            {
                Console.Write(Fibonacci(i) + ", ");
            };
            Console.Write("...");
            Console.ReadKey();
        }
    }
}
