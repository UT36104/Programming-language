using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string slovo = Console.ReadLine();
            string[] massiv = slovo.Split(' ');
            int massiv_len = massiv.Length;
            for (int i = 0; i < massiv_len; i++)
            {
                if ((massiv[i].Substring(0, 1) == ("'") && (massiv[i].Substring(massiv[i].Length - 1, 1) == ("'"))))
                {
                    Console.WriteLine(massiv[i]);
                }
            }
            for (int i = 0; i < massiv_len; i++)
            {
                if ((massiv[i].Substring(0, 1) == ("\"") && (massiv[i].Substring(massiv[i].Length - 1, 1) == ("\""))))
                {
                    Console.WriteLine(massiv[i]);
                }
            }
            Console.ReadKey();
        }
    }
}