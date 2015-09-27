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
            int  i1, i2, i8, i10, i4, i6, m5, m7, m8,m4, m6;
            Console.Write("Введите размерность массива m1 = ");
            int n1 = int.Parse(Console.ReadLine());
            int[] m1 = new int[n1];
            Random rnd = new Random();
            int m1_l = m1.Length;
            for (int i = 0; i < m1_l; i = i + 1)
            {
                m1[i] = rnd.Next(-5, 5);
            };

            Console.Write("Введите размерность массива m2 = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] m2 = new int[n2];
            int m2_l = m2.Length;
            for (int j = 0; j < m2_l; j = j + 1)
            {
                m2[j] = rnd.Next(-5, 5);
            };

            Console.WriteLine("m1: ");
            for (int p = 0; p < m1_l; p = p + 1)
            {
                Console.Write(m1[p] + " ");
            };

            Console.WriteLine();
            Console.WriteLine("m2: ");
            for (int k = 0; k < m2_l; k = k + 1)
            {
                Console.Write(m2[k] + " ");
            };

            Console.WriteLine();
            Console.Write("Элементы, содержащиеся в m1, но не содержащиеся в m2: ");
            for (i1 = 0; i1 < m1_l; i1++)
            {
                m4 = 0;
                for (i2 = 0; i2 < m2_l; i2++)
                {
                    if (m1[i1] != m2[i2])
                    {
                        m4++;
                    }
                }
                if (m4 == (i2))
                {
                    Console.Write(m1[i1] + " ");

                }
            }

            Console.WriteLine();
            Console.Write("Элементы, содержащиеся в m2, но не содержащиеся в m1: ");
            for (int i3 = 0; i3 < m2_l; i3++)
            {
                m5 = 0;
                for (i4 = 0; i4 < m1_l; i4++)
                {
                    if (m2[i3] != m1[i4])
                    {
                        m5++;
                    }
                }
                if (m5 == (i4))
                {
                    Console.Write(m2[i3] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("Элементы, содержащиеся в m1 и m2: ");
            for (int i5 = 0; i5 < m1_l; i5++)
            {
                m6 = 0;
                for (i6 = 0; i6 < m2_l; i6++)
                {
                    if (m1[i5] == m2[i6])
                    {
                        m6++;
                    }

                }
                if (m6 > 0)
                {
                    Console.Write(m1[i5] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("Элементы, содержащиеся в первом и втором массивах без пересечения: ");
            for (int i7 = 0; i7 < m1_l; i7++)
            {
                m7 = 0;
                for (i8 = 0; i8 < m2_l; i8++)
                {
                    if (m1[i7] == m2[i8])
                    {
                        m7++;
                    }
                }
                if (m7 == 0)
                {
                    Console.Write(m1[i7] + " ");
                }
            }
            for (int i9 = 0; i9 < m2_l; i9++)
            {
                m8 = 0;
                for (i10 = 0; i10 < m1_l; i10++)
                {
                    if (m2[i9] == m1[i10])
                    {
                        m8++;
                    }
                }
                if (m8 == 0)
                {
                    Console.Write(m2[i9] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}