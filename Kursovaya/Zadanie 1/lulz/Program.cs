using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace lulz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество точек = ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Формула центрированного треугольного числа
            int final_count_array = (3 * (n * n) + 3 * n + 2) / 2;
            if (n >= 3)
            {
                int[,] point = new int[n, 2];
                int point_h = point.GetLength(0);
                int point_w = point.GetLength(1);
                //Центрированное треугольное число равное количеству возможных комбинаций
                int[,] ploshad = new int[final_count_array, 7];
                //Собственный лист созданный в классе
                List<FinalPointer> all_pointers = new List<FinalPointer>();
                Random rnd = new Random();
                //Создаем массив точек где i,z соответсвенно равны x,y
                for (int i = 0; i < point_h; i++)
                {
                    for (int z = 0; z < point_w; z++)
                    {
                        point[i, z] = rnd.Next(-5, 25);
                        Console.Write(point[i, z] + " ");
                    }
                    Console.WriteLine();
                }
                int kokoko = 0;
                int zab = 0;
                //Перебор вариантов площади и вариантов вхождения
                for (int i = 0; i < point_h; i++)
                {
                    for (int g = 0; g < point_h; g++)
                    {
                        for (int z = 0; z < point_h; z++)
                        {
                            int x_a = point[i, 0];
                            int x_b = point[g, 0];
                            int x_c = point[z, 0];
                            int y_a = point[i, 1];
                            int y_b = point[g, 1];
                            int y_c = point[z, 1];
                            //Проверка на вхождение
                            for (int r = 0; r < point_h; r++)
                            {
                                int x = point[r, 0];
                                int y = point[r, 1];
                                //Проверка принадлежности точки треугольнику формулами Герона
                                int summa_s = 1 / 2 * Math.Abs((x_b - x_a) * (y_c - y_a) - (x_c - x_a) * (y_b - y_a));
                                int s1 = 1 / 2 * Math.Abs((x_b - x_a) * (y - y_a) - (x - x_a) * (y_b - y_a));
                                int s2 = 1 / 2 * Math.Abs((x - x_a) * (y_c - y_a) - (x_c - x_a) * (y - y_a));
                                int s3 = 1 / 2 * Math.Abs((x_b - x) * (y_c - y) - (x_c - x) * (y_b - y));
                                if (summa_s == s1 + s2 + s3)
                                {
                                    zab += 1;
                                };
                            }
                            //Площадь треугольника по координатам
                            int s = (Math.Abs((x_b - x_a) * (y_c - y_a) - (x_c - x_a) * (y_b - y_a))) / 2;
                            //Удаляет исключения т.к они равны 0
                            if (s != 0)
                            {
                                all_pointers.Add(new FinalPointer()
                                {
                                    Summa = s,
                                    Position_x_a = x_a,
                                    Position_x_b = x_b,
                                    Position_x_c = x_c,
                                    Position_y_a = y_a,
                                    Position_y_b = y_b,
                                    Position_y_c = y_c,
                                    Counter_point = zab
                                });
                            };
                            kokoko++;
                            zab = 0;
                        }
                    }
                }
                //Запись в файл
                string fileName = "final.txt";
                StreamWriter writer = new StreamWriter(fileName);
                //Сортируем массив по площади
                List<FinalPointer> SortedList_Counter_point = all_pointers.OrderBy(FinalPointer => FinalPointer.Counter_point).ToList();
                List<FinalPointer> SortedList_Pointers = all_pointers.OrderBy(FinalPointer => FinalPointer.Summa).ToList();
                int SortedList_Pointers_L = SortedList_Pointers.Count;
                //Запись в файл максимальную площадь и координаты
                for (int i = SortedList_Pointers_L - 3; i < SortedList_Pointers_L; i++)
                {
                    writer.WriteLine(Convert.ToString(SortedList_Pointers[i].Summa + " - [" + SortedList_Pointers[i].Position_x_a + "," + SortedList_Pointers[i].Position_y_a + "] [" + SortedList_Pointers[i].Position_x_b + "," + SortedList_Pointers[i].Position_y_b + "] [" + SortedList_Pointers[i].Position_x_c + "," + SortedList_Pointers[i].Position_y_c + "]"));
                }
                writer.WriteLine("--------------------------------------------------");
                for (int i = SortedList_Pointers_L - 3; i < SortedList_Pointers_L; i++)
                {
                    writer.WriteLine(Convert.ToString(SortedList_Counter_point[i].Summa + " - [" + SortedList_Counter_point[i].Position_x_a + "," + SortedList_Counter_point[i].Position_y_a + "] [" + SortedList_Counter_point[i].Position_x_b + "," + SortedList_Counter_point[i].Position_y_b + "] [" + SortedList_Counter_point[i].Position_x_c + "," + SortedList_Counter_point[i].Position_y_c + "] " + SortedList_Counter_point[i].Counter_point));
                }
                writer.Close();
                Console.WriteLine("Готово!");
            }
            else
            {
                Console.WriteLine("Количество точек не может быть меньше 3");
            };
            Console.ReadKey();
        }
    }
    //Кастомный лист с 8-ми столбцами
    public class FinalPointer
    {
        //Сумма чисел
        public int Summa { get; set; }
        //Точка x1
        public int Position_x_a { get; set; }
        //Точка x2
        public int Position_x_b { get; set; }
        //Точка x3
        public int Position_x_c { get; set; }
        //Точка y1
        public int Position_y_a { get; set; }
        //Точка y2
        public int Position_y_b { get; set; }
        //Точка y3
        public int Position_y_c { get; set; }
        //Количество точек входящих в треугольник
        public int Counter_point { get; set; }
    }
}