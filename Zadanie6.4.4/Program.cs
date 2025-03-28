using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb
            int n;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += tab[i];
            }
            Console.WriteLine("Suma liczb wynosi: " + suma);
            Console.ReadKey();
        }
    }
}
