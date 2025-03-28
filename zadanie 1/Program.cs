using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i
            //wypisujący wczytane liczby na ekranie
            int n;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
        }
    }
}
