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
        Console.WriteLine("Ksiazka: " + Tytul + ", autor: " + Autor);
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



abstract class Uzytkownik
{
    public string Imie;
    public int IleWypozyczono;

    public abstract int LimitWypozyczen();

    public abstract bool CzyMoznaWypozyczyc(MaterialBiblioteczny m);

    public void WyswietlInfo()
    {
        Console.WriteLine(Imie + ", wypozyczono: " + IleWypozyczono + "/" + LimitWypozyczen());
    }
}

class Student : Uzytkownik
{
    public override int LimitWypozyczen()
    {
        return 3;
    }

    public override bool CzyMoznaWypozyczyc(MaterialBiblioteczny m)
    {
        return true;
    }
}

class Nauczyciel : Uzytkownik
{
    public override int LimitWypozyczen()
    {
        return 5;
    }

    public override bool CzyMoznaWypozyczyc(MaterialBiblioteczny m)
    {
        return true;
    }
}

class Gosc : Uzytkownik
{
    public override int LimitWypozyczen()
    {
        return 1;
    }

    public override bool CzyMoznaWypozyczyc(MaterialBiblioteczny m)
    {
        if (m is Ebook)
        {
            return false;
        }

        return true;
    }
}



class biblioteka
{
    static void Main()
    {
        int wybor;
        int i;

        List<MaterialBiblioteczny> lista = new List<MaterialBiblioteczny>();
        List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();

        Console.WriteLine("Witaj w bibliotece");

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Dodaj ksiazke");
            Console.WriteLine("2. Dodaj czasopismo");
            Console.WriteLine("3. Dodaj ebook");
            Console.WriteLine("4. Wyswietl materialy");
            Console.WriteLine("5. Dodaj uzytkownika");
            Console.WriteLine("6. Wyswietl uzytkownikow");
            Console.WriteLine("7. Wypozycz material");
            Console.WriteLine("0. Wyjdz");

            wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
            {
                Ksiazka k = new Ksiazka();

                Console.WriteLine("Podaj tytul:");
                k.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj autora:");
                k.Autor = Console.ReadLine();

                lista.Add(k);

                Console.WriteLine("Dodano ksiazke");
            }

            if (wybor == 2)
            {
                Czasopismo c = new Czasopismo();

                Console.WriteLine("Podaj tytul:");
                c.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj numer:");
                c.Numer = int.Parse(Console.ReadLine());

                lista.Add(c);

                Console.WriteLine("Dodano czasopismo");
            }

            if (wybor == 3)
            {
                Ebook e = new Ebook();

                Console.WriteLine("Podaj tytul:");
                e.Tytul = Console.ReadLine();

                Console.WriteLine("Podaj format:");
                e.Format = Console.ReadLine();

                lista.Add(e);

                Console.WriteLine("Dodano ebook");
            }

            if (wybor == 4)
            {
                if (lista.Count == 0)
                {
                    Console.WriteLine("Brak materialow");
                }
                else
                {
                    for (int j = 0; j < lista.Count; j++)
                    {
                        Console.Write((j + 1) + ". ");
                        lista[j].WyswietlInfo();
                    }
                }
            }

            if (wybor == 5)
            {
                Console.WriteLine("Jaki uzytkownik?");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Nauczyciel");
                Console.WriteLine("3. Gosc");

                int typ = int.Parse(Console.ReadLine());

                Uzytkownik u = null;

                if (typ == 1)
                {
                    u = new Student();
                }

                if (typ == 2)
                {
                    u = new Nauczyciel();
                }

                if (typ == 3)
                {
                    u = new Gosc();
                }

                Console.WriteLine("Podaj imie:");
                u.Imie = Console.ReadLine();

                uzytkownicy.Add(u);

                Console.WriteLine("Dodano uzytkownika");
            }

            if (wybor == 6)
            {
                if (uzytkownicy.Count == 0)
                {
                    Console.WriteLine("Brak uzytkownikow");
                }
                else
                {
                    for (int j = 0; j < uzytkownicy.Count; j++)
                    {
                        Console.Write((j + 1) + ". ");
                        uzytkownicy[j].WyswietlInfo();
                    }
                }
            }

            if (wybor == 7)
            {
                if (lista.Count == 0)
                {
                    Console.WriteLine("Brak materialow");
                }
                else if (uzytkownicy.Count == 0)
                {
                    Console.WriteLine("Brak uzytkownikow");
                }
                else
                {
                    Console.WriteLine("Wybierz uzytkownika:");

                    for (int j = 0; j < uzytkownicy.Count; j++)
                    {
                        Console.Write((j + 1) + ". ");
                        uzytkownicy[j].WyswietlInfo();
                    }

                    int nrU = int.Parse(Console.ReadLine());

                    Console.WriteLine("Wybierz material:");

                    for (int j = 0; j < lista.Count; j++)
                    {
                        Console.Write((j + 1) + ". ");
                        lista[j].WyswietlInfo();
                    }

                    i = int.Parse(Console.ReadLine());

                    Uzytkownik u = uzytkownicy[nrU - 1];
                    MaterialBiblioteczny m = lista[i - 1];

                    if (u.IleWypozyczono >= u.LimitWypozyczen())
                    {
                        Console.WriteLine("Nie mozna wypozyczyc, limit osiagniety");
                    }
                    else if (u.CzyMoznaWypozyczyc(m) == false)
                    {
                        Console.WriteLine("Ten uzytkownik nie moze wypozyczyc tego materialu");
                    }
                    else
                    {
                        Console.WriteLine("Wypozyczono: " + m.Tytul);
                        Console.WriteLine("Na dni: " + m.MaksCzasWypozyczenia());

                        u.IleWypozyczono++;
                        lista.RemoveAt(i - 1);
                    }
                }
            }
        }
        while (wybor != 0);
    }
}