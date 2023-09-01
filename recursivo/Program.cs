using System;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de la Secuencia de Fibonacci");
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            long result = Fibonacci(n);
            Console.WriteLine($"El término Fibonacci en la posición {n} es: {result}");
        }

        static long Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
