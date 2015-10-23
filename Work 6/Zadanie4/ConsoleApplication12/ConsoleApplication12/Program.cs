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
            int i = 0;
            slovo = slovo.Replace(" ", "").Replace(",", "");
            for (int k = 0; k < slovo.Length; k++)
            {
                if (slovo.Substring(k, 1) == slovo.Substring(slovo.Length - k - 1, 1))
                {
                    i++;
                }   
            }
            if (i == slovo.Length)
            {
                Console.WriteLine("Фразу можно читать наоборот. Это палиндром.");
            }
            else
            {
                Console.WriteLine("Фразу нельзя читать наоборот. Это не палиндром.");
            }
            Console.ReadKey();
        }
    }
}