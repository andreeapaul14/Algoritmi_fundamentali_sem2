using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FIBONACCI_RECURSIV
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }
        private static void Fibonacci()
        {
            Console.WriteLine("Introduceti numarul pe care doriti sa-l aflati");
            int n = int.Parse(Console.ReadLine());
            int fib = fibon(n);
            Console.WriteLine($"Al {n}-lea numar Fibonacci este {fib}");
        }

        public static int fibon(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return fibon(n - 1) + fibon(n - 2);
        }

    }
}
