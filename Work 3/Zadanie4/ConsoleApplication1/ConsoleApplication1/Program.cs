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
            Console.Write("Введите число, в результате будет количество цифр в числе - ");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            int kolvo_result = 0;
            while (kolvo > 0)
            {
                kolvo = kolvo / 10;
                kolvo_result = kolvo_result + 1;
            }
            Console.WriteLine("Количество цифр в этом числе равно " + kolvo_result);
            Console.ReadKey();
   
        }
    }
}