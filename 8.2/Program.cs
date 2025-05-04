using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        //Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument
        //wywołania funkcji wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
        //Napisz program testowy wykorzystujący napisaną funkcję.

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"n-ty wyraz ciągu Fibonacciego wynosi {Fibonacci(n)}");
            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
