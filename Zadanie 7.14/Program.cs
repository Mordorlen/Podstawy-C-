using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._14
{
    internal class Program
    {
        //Napisz funkcję, która stwierdza, czy zadana jako argument liczba całkowita kończy się swoim
        //pierwiastkiem.Liczby kończące się swoim pierwiastkiem to np.: 25, 625.Wartością funkcji ma
        //być jeden, jeśli liczba spełnia warunek lub zero w przeciwnym przypadku.
        //Napisz program testujący utworzoną funkcję.
        
        static int CzyKwadrat(int n)
        {
            if (n < 0) return 0; // liczba ujemna nie może być kwadratem
            for (int i = 0; i * i <= n; i++)
            {
                if (i * i == n && n % 10 == i % 10) return 1; // liczba jest kwadratem i kończy się swoim pierwiastkiem
            }
            return 0; // liczba nie jest kwadratem lub nie kończy się swoim pierwiastkiem
        }
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Czy 25 kończy się swoim pierwiastkiem? {0}", CzyKwadrat(25)); // 1


        }
    }
}
