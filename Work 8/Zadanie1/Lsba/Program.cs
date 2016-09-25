using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.log");
            string stroka = file.ReadLine();
            Console.WriteLine("Файл: " + stroka);
            StreamWriter info = new StreamWriter("inf.log", false, Encoding.UTF8);
            string[] glasnii = { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я" };
            string[] soglasnii = { "б", "в", "г", "д", "ж", "з", "й", "к", "л", "м", "н", "п", "р", "с", "т", "ф", "x", "ч", "ц", "ч", "ш", "щ", "ъ", "ь" };
            int chet_g = 0;
            int chet_s = 0;
            int stroka_L = stroka.Length;
            int glasnii_L = glasnii.Length;
            int soglasnii_L = soglasnii.Length;
            string format_without_probel = stroka;
            for (int i = 0; i < stroka_L; i++)
                for (int j = 0; j < glasnii_L; j++)
                {
                    if (stroka[i] == Convert.ToChar(glasnii[j]))
                    {
                        chet_g++;
                    }
                }
            info.WriteLine("Кол-во гласных: " + chet_g);
            for (int i = 0; i < stroka_L; i++)
                for (int j = 0; j < soglasnii_L; j++)
                {
                    if (stroka[i] == Convert.ToChar(soglasnii[j]))
                    {
                        chet_s++;
                    }
                }
            info.WriteLine("Кол-во согласных: " + chet_s);
            info.WriteLine("Общее кол-во символов: " + stroka_L);
            format_without_probel = format_without_probel.Replace(" ", "");
            int format_without_probel_L = format_without_probel.Length;
            info.WriteLine("Общее кол-во символов без пробелов: " + format_without_probel_L);
            string[] slova = stroka.Split(' ');
            info.WriteLine("Кол-во слов: " + slova.Length);
            string[] tochka = stroka.Split('.');
            string[] voskl = stroka.Split('!');
            string[] vopros = stroka.Split('?');
            int suma = tochka.Length + voskl.Length + vopros.Length;
            info.WriteLine("Кол-во предложений: " + (suma - 3));
            info.Close();
            file.Close();
            Console.ReadKey();
        }

    }
}