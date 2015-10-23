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
            string[] words = stroka.Split(' ');
            int words_len = words.Length;
            string familya = words[0];
            string imya = words[1];
            char otchastvo_first = ' ';
            if (words_len == 3)
            {
                string otchastvo = words[2];
                otchastvo_first = otchastvo[0];
            }
            string fio = familya + " " + imya[0] + " " + otchastvo_first;
            Console.WriteLine(fio);
            Console.ReadKey();
        }
    }
}
