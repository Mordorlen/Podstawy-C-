using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._9
{
    internal class Program
    {
        //Napisać funkcję, która posiada trzy argumenty będące współczynnikami a, b, c funkcji
        //kwadratowej y = ax2 + bx + c.Funkcja ma zwracać ilość pierwiastków zadanej funkcji
        //kwadratowej.Napisz program testujący utworzoną funkcję.
        //Wskazówka: Wykorzystaj wzór Δ = b2 - 4ac. Funkcja ma zwracać 0, jeśli funkcja nie ma
        //pierwiastków, 1, jeśli ma jeden pierwiastek i 2, jeśli ma dwa pierwiastki.
        static int Pierwiastki(int a, int b, int c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0) return 0; // brak pierwiastków
            else if (delta == 0) return 1; // jeden pierwiastek
            else return 2; // dwa pierwiastki
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                "Dla funkcji kwadratowej y = 2x^2 + 3x + 1, liczba pierwiastków wynosi: {0}",
                Pierwiastki(2, 3, 1)); // 2 pierwiastki
        }
    }
}
