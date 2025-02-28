using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.
            double a, b, suma, iloraz, różnica, iloczyn;
            Console.WriteLine("Podaj liczbę");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę drugą");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloraz = a / b;
            iloczyn = a * b;
            Console.WriteLine($"{a}+{b}={suma}");
            Console.WriteLine($"{a}-{b}={różnica}" );
            Console.WriteLine($"{a}/{b}={iloraz}" );
            Console.WriteLine($"{a}*{b}={iloczyn}" );
            Console.ReadKey(true);
        }
    }
}
