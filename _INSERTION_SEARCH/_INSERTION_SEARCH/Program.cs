using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _INSERTION_SEARCH
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort();
        }
        private static void InsertionSort()
        {
            Console.WriteLine("**********INSERTION SORT********** ");
            Console.WriteLine();
            int[] array = { 5, 1, 6, 2, 4, 3 };
            Console.WriteLine("Vectorul initial: ");
            printArray(array, array.Length);
            Console.WriteLine();
            insertionSort(array, array.Length);
            Console.ReadKey();
        }
        private static void insertionSort(int[] array, int length)
        {
            int i, j, insertedElement;
            for (i = 1; i < length; i++)
            {
                insertedElement = array[i]; ///salvam elementul pe care vrem sa il inseram
                j = i - 1;
                while (j >= 0 && array[j] > insertedElement)
                {
                    array[j + 1] = array[j]; /// mutam elementul mai la dreapta daca este mai mare decat cel pec are vrem sa il inseram
                    j--;
                }
                array[j + 1] = insertedElement;
                if (i != length - 1)
                    Console.WriteLine("Vectorul dupa urmatoarea iteratie: ");
                else
                    Console.WriteLine("Vectorul dupa ultima iteratie, gata SORTAT: ");
                printArray(array, length);
            }
        }
        private static void printArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
