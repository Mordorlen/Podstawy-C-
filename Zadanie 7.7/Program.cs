using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._7
{
    internal class Program
    {
        //Napisz funkcję posiadającą dwa argumenty: p, q – długości przekątnych deltoidu. Funkcja ma
        //zwracać pole deltoidu dla zadanych argumentów.Napisz program testujący utworzoną
        //funkcję.
        //Wskazówka: P= p * q / 2.

        static int Pole(int q, int p)
        {
            return p * q / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2*9/2={0}", Pole(2, 9));
            Console.ReadKey();
        }
    }
}
