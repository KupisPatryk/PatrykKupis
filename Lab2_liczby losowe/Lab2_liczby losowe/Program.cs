// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


int proba = 0;
int strzal;
int wybor;
int los = 0;
int maxproba;
maxproba = 1;
int pozostalo;
Random rand = new Random();



Console.WriteLine("Wybierz poziom trudnosci! ");
Console.WriteLine("1. Poziom latwy liczba 1-50 i max 10 prob");
Console.WriteLine("2. Poziom sredni liczba 1-100 i max 7 prob");
Console.WriteLine("3. Poziom latwy liczba 1-200 i max 5 prob");

wybor = int.Parse(Console.ReadLine());

if (wybor == 1)
    {
    los = rand.Next(1, 51);
    maxproba = 10;
    Console.WriteLine("Wybranow poziom latwy!");
    }

if (wybor == 2)
    { 
     los = rand.Next(1, 101);
    maxproba = 7;
    Console.WriteLine("Wybranow poziom sredni!");
}

if (wybor == 3) 
    { 
    
     los = rand.Next(1, 201);
        maxproba = 5;
    Console.WriteLine("Wybranow poziom trudny!");
}



do
    {
        pozostalo = maxproba - proba;
        Console.WriteLine("pozostalo prob: " + pozostalo);
        Console.Write("podaj liczbe: ");
        strzal = int.Parse(Console.ReadLine());
        proba++;
        if (strzal < los)
        {
            Console.WriteLine(" za malo");
        }

        else if (strzal > los)

        {
            Console.WriteLine("za duzo");
        }
    } while (strzal != los && proba < maxproba );
if (strzal == los)
    {
    Console.WriteLine("brawo udało ci sie zgadnac w " + proba + " probach!");
    }
if (proba >= maxproba)
    {
    Console.WriteLine("Skonczyly ci sie proby!");
    }








