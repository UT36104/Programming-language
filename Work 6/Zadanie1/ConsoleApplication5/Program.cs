using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            stroka = stroka.Replace(" ", string.Empty);
            stroka = stroka.Replace(",", ", ");
            Console.WriteLine(stroka);
            Console.ReadKey();
        }
    }
}
