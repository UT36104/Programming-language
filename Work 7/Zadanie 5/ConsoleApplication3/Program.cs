using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] znaki = { ",", ".", "!", "?", " ", ":", ";", "'", "\"" };
            string str = Console.ReadLine();
            int znaki_m_L = znaki.Length;
            for (int i = 0; i < znaki_m_L; i++)
            {
                str = str.Replace(znaki[i], "");
            }
            makerStringBetter(str);
            Console.ReadKey();

        }
        static string makerStringBetter(string s)
        {
            string[] bukvi = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ч", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string[] buffer = new string[33];
            int bukvi_l = bukvi.Length;
            int buffer_m_L = buffer.Length;
            int s_L = s.Length;
            for (int i = 0; i < buffer_m_L; i++)
            {
                buffer[i] = "";
            }
            for (int i = 0; i < s_L; i++)
                for (int j = 0; j < bukvi_l; j++)
                {
                    if (s[i] == Convert.ToChar(bukvi[j]))
                    {
                        if (buffer[j] != "")
                        {
                            buffer[j] = buffer[j] + bukvi[j];
                        }
                        else
                        {
                            buffer[j] = bukvi[j];
                        }
                    }
                }
            for (int i = 0; i < buffer_m_L; i++)
            {
                Console.Write(buffer[i]);
            }
            return s;
        }

    }
}