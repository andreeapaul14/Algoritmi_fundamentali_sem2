using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, nr = 1;
            Console.Write("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            

            Console.WriteLine();

            int nrElem = n * n;
            int currElem = 0;



            for (int k = 0; k < n / 2 && currElem < nrElem; k++)
            {
                if (currElem < nrElem)
                {
                    for (j = k; j < n - k; j++)
                    {
                        a[n-k, j] = nr++;
                    }
                }

                if (currElem < nrElem)
                {
                    for (i = 1 + k; i < n - k; i++)
                    {
                        a[i, n-k] = nr++;
                    }
                }

                if (currElem < nrElem)
                {
                    for (j = n - 2 - k; j >= k; j--)
                    {
                        a[n-k, j] = nr++;
                    }
                }

                if (currElem < nrElem)
                {
                    for (i = n - 2 - k; i >= 1 + k; i--)
                    {
                        a[i, n-k] = nr++;

                    }
                }

            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
