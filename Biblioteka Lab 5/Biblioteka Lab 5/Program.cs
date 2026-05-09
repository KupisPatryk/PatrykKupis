using System;
using System.Collections.Generic;


abstract class MaterialBiblioteczny
{
    public string Tytul;

    public abstract void WyswietlInfo();

    public abstract int MaksCzasWypozyczenia();
}
class Ksiazka : MaterialBiblioteczny
{
    public string Autor;

    public override void WyswietlInfo()
    {
        Console.WriteLine("Książka: " + Tytul + ", autor: " + Autor);
    }

    public override int MaksCzasWypozyczenia()
    {
        return 30;
    }
}
class Czasopismo : MaterialBiblioteczny
{
    public int Numer;

    public override void WyswietlInfo()
    {
        Console.WriteLine("Czasopismo: " + Tytul + ", numer: " + Numer);
    }

    public override int MaksCzasWypozyczenia()
    {
        return 7;
    }
}
class Ebook : MaterialBiblioteczny
{
    public string Format;

    public override void WyswietlInfo()
    {
        Console.WriteLine("Ebook: " + Tytul + ", format: " + Format);
    }

    public override int MaksCzasWypozyczenia()
    {
        return 14;
    }
}



class biblioteka
{
    static void Main()
    {
        int wybor;
        int i;

        List<MaterialBiblioteczny> lista = new List<MaterialBiblioteczny>();

        Console.WriteLine("Witaj w bibliotece");

        do
        {
            Console.WriteLine("Aby kontynuowac dokonaj wyboru: ");
            Console.WriteLine("1. Dodaj ksiazke");
            Console.WriteLine("2. Dodaj czasopismo");
            Console.WriteLine("3. Dodaj ebook");
            Console.WriteLine("4. Wyswietl dodane materialy");
            Console.WriteLine("5. Wypozycz material");
            Console.WriteLine("0. Wyjdz z biblioteki");

            wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
            {
                Ksiazka k = new Ksiazka();

                Console.WriteLine("Podaj tytul ksiazki");
                k.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj autora");
                k.Autor = Console.ReadLine();

                lista.Add(k);

                Console.WriteLine("Dodano ksiazke");
                Console.WriteLine();
            }

            if (wybor == 2)
            {
                Czasopismo c = new Czasopismo();

                Console.WriteLine("Podaj tytul czasopisma");
                c.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj numer czasopisma");
                c.Numer = int.Parse(Console.ReadLine());

                lista.Add(c);

                Console.WriteLine("Dodano czasopismo");
                Console.WriteLine();
            }

            if (wybor == 3)
            {
                Ebook e = new Ebook();

                Console.WriteLine("Podaj tytul ebooka");
                e.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj format ebooka");
                e.Format = Console.ReadLine();

                lista.Add(e);

                Console.WriteLine("Dodano ebook");
                Console.WriteLine();
            }

            if (wybor == 4)
            {
                if (lista.Count < 1)
                {
                    Console.WriteLine("W bibliotece nie ma materialow");
                }
                else
                {
                    Console.WriteLine("Liczba dodanych materialow: " + lista.Count);
                    Console.WriteLine();

                    for (int j = 0; j < lista.Count; j++)
                    {
                        Console.Write((j + 1) + ". ");
                        lista[j].WyswietlInfo();
                    }
                }
            }

            if (wybor == 5)
            {
                if (lista.Count < 1)
                {
                    Console.WriteLine("W bibliotece nie ma materialow");
                }
                else
                {
                    Console.WriteLine("Ktory material chcesz wypozyczyc?");

                    for (int k = 0; k < lista.Count; k++)
                    {
                        Console.Write((k + 1) + ". ");
                        lista[k].WyswietlInfo();
                    }

                    i = int.Parse(Console.ReadLine());

                    Console.WriteLine("Wypozyczono: " + lista[i - 1].Tytul);
                    Console.WriteLine("Mozesz trzymac przez: " + lista[i - 1].MaksCzasWypozyczenia() + " dni");

                    lista.RemoveAt(i - 1);
                }
            }
        }
        while (wybor != 0);
    }
}