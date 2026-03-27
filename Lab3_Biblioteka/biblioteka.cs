using System;
using System.Collections.Generic;





class biblioteka
{

    static void Main()
    {


        int wybor;
        string ksiazka;
        string rok;
        int i;
      
        
       
        List<string> lista = new List<string>();
        List<string> rok_ksiazka = new List<string>();



        Console.WriteLine("Witaj w bibliotece");
        do
        {
            Console.WriteLine("Aby kontynuowac dokonaj wyboru: ");
            Console.WriteLine("1. Dodaj ksiazke");
            Console.WriteLine("2. Wyswietl dodane ksiazki");
            Console.WriteLine("3. Wypozycz ksiazke");
            Console.WriteLine("0. Wyjdz z biblioteki");


            wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
            {

                Console.WriteLine("Podaj nazwe ksiazki ");
                ksiazka = Console.ReadLine();
                lista.Add(ksiazka);
                Console.WriteLine("Podaj rok napisania ksiazki ");
                rok = Console.ReadLine();
                rok_ksiazka.Add(rok);
                Console.WriteLine("Dodano ksiazke: " + ksiazka + " " + rok + "r");
                Console.WriteLine();
            }
            if (wybor == 2)
            {
                if (lista.Count < 1)
                {
                    Console.WriteLine("W bibliotece nie ma ksiazek ");

                }
                else
                {
                    Console.WriteLine("Liczba dodanych ksiazek: " + lista.Count);
                    Console.WriteLine();
                    Console.WriteLine("Dodane ksiazki to: ");
                    for(int j=0; j < lista.Count; j++)
                    {
                        Console.WriteLine((j + 1) + ". " + lista[j] + " " + rok_ksiazka[j]);
                        


                    }
                    
                }
            }
            if (wybor == 3)
            {
                if (lista.Count < 1)
                {
                    Console.WriteLine("W bibliotece nie ma ksiazek ");

                }
                else
                {
                    Console.WriteLine("Ktora ksiazke chcesz wypozyczyc? ");
                    for (int k = 0; k < lista.Count; k++)
                    {
                        Console.WriteLine((k + 1) + ". " + lista[k] + " " + rok_ksiazka[k]);


                    }

                    i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wypozyczono ksiazke: " + lista[i-1] + " Milego czytania!"); 
                    lista.RemoveAt(i - 1);
                    rok_ksiazka.RemoveAt(i - 1);
                    
                }

            }












        }
        while (wybor != 0);

    }

 }





