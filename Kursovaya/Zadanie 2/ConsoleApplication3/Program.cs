using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число = ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger mumnoj = num1 * num2;
            BigInteger sloj = num1 + num2;
            BigInteger vihit = num1 - num2;
            BigInteger delenie = num1 / num2;
            Console.WriteLine("Результат умножения = " + mumnoj);
            Console.WriteLine("Результат сложения = " + sloj);
            Console.WriteLine("Результат вычитания = " + vihit);
            Console.WriteLine("Результат деления = " + delenie);
            Console.ReadKey();
        }
    }
}
