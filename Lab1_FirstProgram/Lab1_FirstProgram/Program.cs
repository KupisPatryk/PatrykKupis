// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swoje imie:");
        string imie = Console.ReadLine();
        Console.WriteLine("podaj swój rok urodzenia: ");
        int rok= int.Parse(Console.ReadLine());
        int aktualnyrok = 2026;
        int wiek = aktualnyrok - rok;
        Console.WriteLine("jaki jest twoj ulubiony jezyk programowania?");
        string jezyk = Console.ReadLine();
        


        Console.WriteLine("Czesc " + imie + "!");
        Console.WriteLine("Masz około: " + wiek + "lat");
        Console.WriteLine("A twoj ulubiony jezyk programowania to: " + jezyk);
        








        










    }
}