using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BUCKET_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            BucketSort();
        }
        private static void BucketSort()
        {

            int[] row = new int[] { 44, 98, 2, 31, 55, 26, 59, 20, 13, 68 };

            Console.WriteLine("\nSirul initial");

            for (int i = 0; i < row.Length; i++)
            {
                Console.Write(row[i] + "  ");

            }

            Console.WriteLine("\n\nSirul Sortat");

            List<int> inOrder = Sort(row);

            for (int i = 0; i < inOrder.Count; i++)
            {
                Console.Write(inOrder[i] + "  ");
            }

            Console.ReadLine();
        }
        public static List<int> Sort(params int[] x)
        {
            List<int> sortList = new List<int>();

            int n = 10;

            //Construim bucket-urile
            List<int>[] buckets = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int k = (x[i] / n);
                buckets[k].Add(x[i]);
            }

            //Sortam fiecare bucket si il adaugam in lista
            for (int i = 0; i < n; i++)
            {
                List<int> temp = InsertionSort(buckets[i]);
                sortList.AddRange(temp);
            }
            return sortList;
        }

        //insertare sort
        public static List<int> InsertionSort(List<int> imput)
        {
            for (int i = 1; i < imput.Count; i++)
            {
                int value = imput[i];
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (value < imput[pointer])
                    {
                        imput[pointer + 1] = imput[pointer];
                        imput[pointer] = value;
                    }
                    else break;
                }
            }

            return imput;
        }
    }
}
