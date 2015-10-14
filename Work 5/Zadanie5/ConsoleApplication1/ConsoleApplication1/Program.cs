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
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, m];
            int matrix_l = matrix.Length;
            int stroka = 0;
            int stolb = 0;
            int x = 1;
            int y = 0;
            int posesheniy = 0;
            double povtr = m;
            int temp;

            for (int i = 0; i < matrix_l; i++)
            {
                matrix[stroka, stolb] = i + 1; //значение

                if (--povtr == 0)
                {    
                    povtr = m * (posesheniy % 2) + n * ((posesheniy + 1) % 2) - (posesheniy / 2 - 1) - 2; //количество посещений. Если в первый раз ты двигаешься в горизонтальном направлении ты будешь делать 6 шагов, а следующий раз когда ты двигаешься в горизонтальном направлении ты будешь делать уже 5 шагов и т.д.
                    temp = x; //поворот по часовой стрелке 
                    x = -y; //сдвиг по диагонали
                    y = temp; //сдвиг по вертикали 
                    posesheniy++;
                }
                stolb = x + stolb; //позиция стобика
                stroka = y + stroka; //позиция строки
            }

            Console.WriteLine();
            Console.WriteLine("Массив заполненный змейкой");
            for (int i2 = 0; i2 < matrix.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < matrix.GetLength(1); j2++)
                {
                    Console.Write(matrix[i2, j2] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
