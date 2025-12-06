using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            { 
                Console.WriteLine(fibonacci(i));
            }
            Console.ReadKey();
        }
        static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
