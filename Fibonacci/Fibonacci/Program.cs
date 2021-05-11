using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Al catelea numar Fibonacci doriti sa-l aflati?");
            int n = Convert.ToInt32(Console.ReadLine());
            int fib = Fibonacci(n);
            Console.WriteLine($"Al {n} -lea numar Fibonacci este {fib}");
        }
    }
}