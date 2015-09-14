using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1;
            double x;
            double f;
            Console.Write("Введите x: ");
            x1 = Console.ReadLine();
            x = Convert.ToInt32(x1);
            if (-5 <= x && x < 10)
            {
                if (-5 <= x && x < 5)
                {
                    f = (x * x) / (x + 2);
                    Console.WriteLine("f(x) = " + f);
                }
                if (5 <= x && x < 10)
                {
                    f = Math.Pow((x + 3), 3);
                    Console.WriteLine("f(x) = " + f);
                }
            }
            else
            {
                f = x;
                Console.WriteLine("f(x) = " + f);
            }
            Console.ReadKey();
        }
    }
}
