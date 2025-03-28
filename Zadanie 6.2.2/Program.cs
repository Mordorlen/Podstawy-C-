using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie

            int n;
            Console.WriteLine("Podaj ilość liczb: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                tab[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(tab);   
            Console.WriteLine(
                "Posortowane liczby: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();


        }
    }
}
