using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    //Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji
    //wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
    //Napisz program testowy wykorzystujący napisaną funkcję.
    //Wskazówka: Definicja rekurencyjna funkcji silnia:

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Silnia z {n} wynosi {Silnia(n)}");
            Console.ReadKey();
        }
        static int Silnia(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Silnia(n - 1);
        }
    }
}


