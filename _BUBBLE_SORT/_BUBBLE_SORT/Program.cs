using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BUBBLE_SORT
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
        }
        private static void BubbleSort()
        {
            Console.WriteLine("----------BUBBLE SORT----------");
            int[] a = { 4, 10, 0, 6, -3, 5, 1 };
            int t;
            Console.WriteLine("Original array :");
            foreach (int number in a)
                Console.Write(number + " ");
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int number in a)
                Console.Write(number + " ");
            Console.Write("\n");
        }
    }
}
