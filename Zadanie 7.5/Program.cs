using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._5
{
    //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
    //utworzonej funkcji.
    class Program
    {

        static int CzyPierwsza(int liczba)
        {

            if (liczba < 2)
                return 0;
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                    return 0;
            }
            return 1;
        }
            
            static void Main(string[] args)
            {
                Console.WriteLine("Czy 7 jest liczbą pierwszą? {0}", CzyPierwsza(7));
                Console.WriteLine("Czy 10 jest liczbą pierwszą? {0}", CzyPierwsza(10));
                Console.WriteLine("Czy 13 jest liczbą pierwszą? {0}", CzyPierwsza(13));
                Console.WriteLine("Czy 15 jest liczbą pierwszą? {0}", CzyPierwsza(15));
                Console.ReadKey();
            }


        }
    }
