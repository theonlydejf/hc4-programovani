﻿namespace _01;
#pragma warning disable CS8600 // Ignoruje nepotrebne upozorneni u Console.ReadLine()
                               // Tento radek kodu neni potreba umet

class Program
{
    static void Main(string[] args)
    {
        //// Nacitani vstupu ////
        
        // Prvni cislo
        Console.WriteLine("Zadej prvni cislo:"); // Napise uzivateli co ma udelat
        string cislo1Text = Console.ReadLine(); // Nacte hodnotu od uzivatele
        int cislo1 = Convert.ToInt32(cislo1Text); // Prevede textovou hodotu na cislo
        // Druhe cislo
        Console.WriteLine("Zadej druhe cislo:"); // Napise uzivateli co ma udelat
        string cislo2Text = Console.ReadLine(); // Nacte hodnotu od uzivatele
        int cislo2 = Convert.ToInt32(cislo2Text); // Prevede textovoud hodotu na cislo

        // Spocitani vysledku
        int vysledek = cislo1 + cislo2;
        // Vypsani vysledku
        Console.WriteLine("Soucet:");
        Console.WriteLine(vysledek);
    }
}
