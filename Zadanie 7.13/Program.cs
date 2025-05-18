using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._13
{
    internal class Program
    {
        //. Napisz funkcję o nazwie czy_kw, która stwierdza, czy zadana jako parametr liczba całkowita
        //jest kwadratem pewnej liczby całkowitej.Liczby będące kwadratami liczb całkowitych to 1, 4,
        //9, 16, 25, itd. Wartością funkcji ma być jeden, jeśli liczba spełnia warunek lub zero w
        //przeciwnym przypadku.Napisz program testujący utworzoną funkcję czy_kw.
        //Proszę nie korzystać z funkcji matematycznej Math.Sqrt().

        static int CzyKwadrat(int n)
        {
            if (n < 0) return 0; // liczba ujemna nie może być kwadratem
            for (int i = 0; i * i <= n; i++)
            {
                if (i * i == n) return 1; // liczba jest kwadratem
            }
            return 0; // liczba nie jest kwadratem
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 16 jest kwadratem? {0}", CzyKwadrat(16)); // 1
            Console.WriteLine("Czy 20 jest kwadratem? {0}", CzyKwadrat(20)); // 0
            Console.WriteLine("Czy -4 jest kwadratem? {0}", CzyKwadrat(-4)); // 0
            Console.ReadKey();
        }
    }
}
