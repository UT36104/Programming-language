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
            
            Console.Write("Введите числа, для подсчета суммы крикните 'эпарнишастопэ': ");
            int a;
            string s;
            int summ = 0;
            do
            {
                Console.Write("Число = ");
                s = Console.ReadLine();
                if (s == "эпарнишастопэ")
                {
                    s = "эпарнишастопэ";
                    Console.WriteLine("Вы крикнули ЭПАРНИШАСТОПЭ. Парниша остоновился.");
                }
                else
                {
                    a = Convert.ToInt32(s);
                    summ = summ + a;
                }
            }
            while (s!= "эпарнишастопэ");
            Console.Write("Сумма чисел: " + summ);
            Console.ReadKey();
        }
    }
}
