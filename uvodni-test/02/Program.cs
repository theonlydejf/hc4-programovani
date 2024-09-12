namespace _02;

class Program
{
    static void Main(string[] args)
    {
        //// Nacitani vstupu ////
        // Prvni cislo
        Console.WriteLine("Zadej prvni cislo:"); // Napise uzivateli co ma udelat
        string cislo1Text = Console.ReadLine(); // Nacte hodnotu od uzivatele
        double cislo1 = Convert.ToDouble(cislo1Text); // Prevede textovou hodotu na cislo
        // Druhe cislo
        Console.WriteLine("Zadej druhe cislo:"); // Napise uzivateli co ma udelat
        string cislo2Text = Console.ReadLine(); // Nacte hodnotu od uzivatele
        double cislo2 = Convert.ToDouble(cislo2Text); // Prevede textovoud hodotu na cislo

        //// Spocitani vysledku ////
        // Spocitani vysledku
        double vysledek = cislo1 / cislo2;
        // Vypsani vysledku
        Console.WriteLine("Podil:");
        Console.WriteLine(vysledek);
    }
}
