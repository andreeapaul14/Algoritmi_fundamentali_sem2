using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ROTIRE_MATRICE
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotire();
        }
        private static void Rotire()
        {
            int[,] m = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            int n = m.GetLength(0), aux;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    aux = m[i, j];
                    m[i, j] = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = aux;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
