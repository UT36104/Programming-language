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
            //Главные переменные
            string line_1 = Console.ReadLine();
            string line_2 = Console.ReadLine();
            //Вторичные перевернутые
            string line_1_rev = ReverseArray(line_1);
            string line_2_rev = ReverseArray(line_2);
            //Длины строк
            int line_1_L = line_1.Length;
            int line_2_L = line_2.Length;
            //Буферные массивы, с размерностью треугольных чисел
            int treug_1 = TriangularNumber(line_1_L);
            int treug_2 = TriangularNumber(line_2_L);
            string[] buffer_line_1 = new string[treug_1];
            string[] buffer_line_2 = new string[treug_2];
            string[] buffer_line_rev_1 = new string[treug_1];
            string[] buffer_line_rev_2 = new string[treug_2];
            //Длинна буферных массивов
            int buffer_line_1_L = buffer_line_1.Length;
            int buffer_line_2_L = buffer_line_2.Length;
            int buffer_line_rev_1_L = buffer_line_rev_1.Length;
            int buffer_line_rev_2_L = buffer_line_rev_2.Length;
            //Код вывода
            Console.WriteLine();
            Console.WriteLine("Первая строка: " + line_1);
            Console.WriteLine("Вторая строка: " + line_2);
            Console.WriteLine("Первая строка наоборот: " + line_1_rev);
            Console.WriteLine("Вторая строка наоборот: " + line_2_rev);
            EnumerationValues(ref line_1_L, ref buffer_line_1, ref line_1);
            EnumerationValues(ref line_2_L, ref buffer_line_2, ref line_2);
            EnumerationValues(ref line_1_L, ref buffer_line_rev_1, ref line_1_rev);
            EnumerationValues(ref line_2_L, ref buffer_line_rev_2, ref line_2_rev);
            Console.WriteLine();
            PrintArray(buffer_line_1);
            PrintArray(buffer_line_2);
            PrintArray(buffer_line_rev_1);
            PrintArray(buffer_line_rev_2);
            //Цикл сравнения
            string buffer_slovo = "";
            int bufer_slovo_len = 0;
            for (int a = 0; a < buffer_line_1_L; a++)
            {
                for (int b = 0; b < buffer_line_2_L; b++)
                {
                    for (int c = 0; c < buffer_line_rev_1_L; c++)
                    {
                        for (int s = 0; s < buffer_line_rev_2_L; s++)
                        {

                            if (buffer_line_1[a] == buffer_line_2[b])
                            {
                                if (buffer_line_1[a].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_1[a].Length;
                                    buffer_slovo = buffer_line_1[a];
                                }
                            }

                            if (buffer_line_1[a] == buffer_line_rev_2[s])
                            {
                                if (buffer_line_1[a].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_1[a].Length;
                                    buffer_slovo = buffer_line_1[a];
                                }
                            }

                            if (buffer_line_1[a] == buffer_line_rev_1[c])
                            {
                                if (buffer_line_1[a].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_1[a].Length;
                                    buffer_slovo = buffer_line_1[a];
                                }
                            }

                            if (buffer_line_2[b] == buffer_line_rev_1[c])
                            {
                                if (buffer_line_2[b].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_2[b].Length;
                                    buffer_slovo = buffer_line_2[b];
                                }
                            }

                            if (buffer_line_2[b] == buffer_line_rev_2[s])
                            {
                                if (buffer_line_2[b].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_2[b].Length;
                                    buffer_slovo = buffer_line_2[b];
                                }
                            }

                            if (buffer_line_rev_1[c] == buffer_line_rev_2[s])
                            {
                                if (buffer_line_rev_1[c].Length > bufer_slovo_len)
                                {
                                    bufer_slovo_len = buffer_line_rev_1[c].Length;
                                    buffer_slovo = buffer_line_rev_1[c];
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine("Комбинация часто встречающаяся: " + ReverseArray(buffer_slovo));
            Console.ReadKey();
        }
        //Функция переворота
        static string ReverseArray(string line)
        {
            string buffer = "";
            int line_L = line.Length;
            for (int i = 0; i < line_L; i++)
            {
                buffer = buffer + line[line_L - i - 1];
            }
            line = buffer;
            return line;
        }
        //Цикл перебора
        static string[] EnumerationValues(ref int len, ref string[] buffer, ref string line)
        {
            int z = 0;
            for (int x = 0; x < len; x++)
            {
                for (int y = len - x; y > 0; y--)
                {
                    buffer[z] = line.Substring(x, y);
                    z++;
                }
            }
            return buffer;
        }
        //Печать на экран
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        //Получение треугольных чисел
        static int TriangularNumber(int n)
        {
            double n1 = (0.5) * n * (n + 1);
            n = Convert.ToInt32(n1);
            return n;
        }
    }
}
