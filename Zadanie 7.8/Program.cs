using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._8
{
    internal class Program
    {
        //. Napisz funkcję, która posiada jeden parametr będący rokiem. Ma ona zwracać wartość 1, jeśli
        //rok jest przestępny i 0 w pozostałych przypadkach.Napisz program testujący utworzoną
        //funkcję.


        static int Przestepny(int rok)
        {
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Rok 2000: {0}", Przestepny(2000)); 
            Console.WriteLine("Rok 1900: {0}", Przestepny(1900)); 
            Console.WriteLine("Rok 2024: {0}", Przestepny(2024)); 
            Console.WriteLine("Rok 2023: {0}", Przestepny(2023)); 
            Console.ReadKey();

        }
    }
}
