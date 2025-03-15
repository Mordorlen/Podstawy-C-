using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący wartość liczby naturalnej n(n >= 0), obliczający wartość 2 ^ n(2 do potęgi n) i wypisujący wynik na ekranie w
            // formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            // wartości wyrażenia użyj pętli for

            Console.WriteLine("Podaj liczbę naturalną n: ");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }
            Console.WriteLine($"2^{n} = {result}");
        }
    }
}
