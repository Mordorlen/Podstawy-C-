using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny czy też nie.
            Console.WriteLine("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }
            Console.ReadLine();
           

        }
    }
}
