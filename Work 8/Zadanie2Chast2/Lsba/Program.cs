using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Lsba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу: ");
            string HightWayToFile = Console.ReadLine();
            string HightWayToFileFull = HightWayToFile + "\\matrix.log";
            int AlreadyReady = 0;
            if (File.Exists(HightWayToFileFull))
            {
                StreamReader FileReader = new StreamReader(HightWayToFileFull);
                string[] StrArray = File.ReadAllLines(HightWayToFileFull);
                int StrArray_L = StrArray.Length;
                int n = Convert.ToInt32(StrArray[0]);
                int m = Convert.ToInt32(StrArray[1]);
                Console.WriteLine("Исходные матрицы имели размер: " + n + " столбца и " + m + " строк");
                int[,] buffer1 = new int[n, m];
                int[,] buffer2 = new int[n, m];
                int[,] final = new int[n, m];
                int buffer1_l_n = buffer1.GetLength(0);
                int buffer1_l_m = buffer1.GetLength(1);
                int buffer2_l_n = buffer2.GetLength(0);
                int buffer2_l_m = buffer2.GetLength(1);
                int final_l_n = final.GetLength(0);
                int final_l_m = final.GetLength(1);
                int z = 0;
                for (int i = 2; i < StrArray_L; i++)
                {
                    if (StrArray[i] == "*")
                    {
                        AlreadyReady = i + 1;
                        break;
                    }
                    string[] gag = StrArray[i].Split(' ');
                    for (int p = 0; p < gag.Length; p++)
                    {
                        if (gag[p] != "")
                        {
                            buffer1[z, p] = Convert.ToInt32(gag[p]);
                        }
                    }
                    z++;
                }
                z = 0;
                for (int i = AlreadyReady; i < StrArray_L; i++)
                {
                    string[] gag = StrArray[i].Split(' ');
                    for (int p = 0; p < gag.Length; p++)
                    {
                        if (gag[p] != "")
                        {
                            buffer2[z, p] = Convert.ToInt32(gag[p]);
                        }
                    }
                    z++;
                }
                FileReader.Close();
                for (int i = 0; i < final_l_n; i++)
                {
                    for (int k = 0; k < final_l_m; k++)
                    {
                        for (int j = 0; j < buffer1_l_m; j++)
                        {
                            final[i, j] += buffer1[i, k] * buffer2[k, j];
                        }
                    }
                }
                StreamWriter FileWriter = new StreamWriter(HightWayToFile + "\\matrix_mumnoj.log");
                for (int i = 0; i < final_l_n; i++)
                {
                    for (int k = 0; k < final_l_m; k++)
                    {
                        FileWriter.Write(final[i, k] + " ");
                    }
                    FileWriter.WriteLine();
                }
                FileWriter.Close();
                Console.Write("Готово!");
            }
            else
            {
                Console.WriteLine("Файла не существует");
            }
            Console.ReadKey();
        }
    }
}
