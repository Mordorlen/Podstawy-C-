using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._1
{
    class Program
    {
        //Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
        //Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
        //użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.
        struct Osoba
        {
            public string imie;
            public string nazwisko;
            public int rok_urodzenia;
            public Osoba(string imie, string nazwisko, int rok_urodzenia)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.rok_urodzenia = rok_urodzenia;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia:");
            int rokUrodzenia = int.Parse(Console.ReadLine());
            Osoba o = new Osoba(imie, nazwisko, rokUrodzenia);
            Console.WriteLine($"Imię: {o.imie}, Nazwisko: {o.nazwisko}, Rok urodzenia: {o.rok_urodzenia}");
        }


    }
}
