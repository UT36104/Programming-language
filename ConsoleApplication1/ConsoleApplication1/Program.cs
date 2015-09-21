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
            int n, i;
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i != n; i = i + 1) ;
            Console.Write(i + 1);
            Console.ReadKey();
        }
    }
}
