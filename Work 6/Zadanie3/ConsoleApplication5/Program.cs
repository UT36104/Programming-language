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
            string word = "";
            int chislo;
            string[] words = stroka.Split(' ');
            int words_len = words.Length;
            for (int z = 0; z < words_len; z++)
            {
                int len_massiv_now = words[z].Length;
                for (int i = 0; i < len_massiv_now; i++)
                {
                    chislo = words.Length;
                    word = word + words[z][len_massiv_now - 1 - i];
                }
                words[z] = word;
                word = "";
            }
            for (int z = 0; z < words_len; z++)
            {
                Console.Write(words[z] + " ");
            }
            Console.ReadKey();
        }
    }
}
