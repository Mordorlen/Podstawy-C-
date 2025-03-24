using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury
            //liczby naturalnej n.Użyj pętli while.Np.: dla n = 5 wypisz wynik 5 != 120

            Console.WriteLine("Podaj liczbę naturalną n: ");
            Console.WriteLine(
                "Program obliczy wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury liczby naturalnej n.");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int silnia = 1;
            while (i <= n)
            {
                silnia *= i;
                i++;
            }
            Console.WriteLine(n + "! = " + silnia);
            Console.WriteLine(
                "Program obliczył wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury liczby naturalnej n.");
            Console.WriteLine(
                "Wynik to: " + silnia);


       


        }
    }
}
