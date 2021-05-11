using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema36
{
    class Program
    {
        static int[,] a;
        static int n, m;
        static bool[,] b;
        static int nr;
        static bool found1, found2;

        static void load(string file_name)
        {
            System.IO.TextReader data_load = new System.IO.StreamReader(file_name);
            List<string> data = new List<string>();
            string buffer;
            while ((buffer = data_load.ReadLine()) != null)
                data.Add(buffer);
            n = data.Count;
            m = data[0].Length;
            a = new int[n, m];
            b = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = (data[i])[j] - '0';
                    b[i, j] = false;
                }
            }
        }

        public static void pa(int i, int j)
        {
            if ((i >= 0) && (j >= 0) && (i < n) && (j < m) && (!b[i, j]))
            {
                if (a[i, j] == 0)
                {
                    nr++;
                    b[i, j] = true;
                    pa(i - 1, j);
                    pa(i, j + 1);
                    pa(i + 1, j);
                    pa(i, j - 1);
                }
                else
                {
                    if (a[i, j] == 1)
                        found1 = true;
                    if (a[i, j] == 2)
                        found2 = true;
                }
            }
        }

        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int nr1 = 0;
            int nr2 = 0;
            int nrn = 0;
            load(@"..\..\TextFile1.in");
            view();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if ((a[i, j] == 0) && (!b[i, j]))
                    {
                        nr = 0;
                        found1 = false;
                        found2 = false;

                        pa(i, j);

                        if (found1 && !found2)
                            nr1 += nr;
                        if (!found1 && found2)
                            nr2 += nr;
                        if (found1 && found2)
                            nrn += nr;
                        Console.WriteLine(" " + nr);
                    }
            Console.Write("T1 : " + nr1 + " T2 : " + nr2 + " TN : " + nrn);
            Console.ReadKey();
        }
    }
}