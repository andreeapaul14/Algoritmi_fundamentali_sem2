using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LINEAR_SEARCH
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearSearch();
        }
        private static void LinearSearch()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;
            // Apelarea functiei
            int result = search(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Elementul nu este prezent in tablou");
            else
                Console.WriteLine("Elementul este prezent in index "
                                + result);
        }
        public static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
