using System.Runtime.ConstrainedExecution;

namespace _03_jednoduche_reseni;

class Program
{
    static void Main(string[] args)
    {
        // Nacitani vstupu
        Console.WriteLine("Kolik mas penez?");
        double penize = Convert.ToDouble(Console.ReadLine());

        // Zpracovani vstupu
        Console.WriteLine("Muzes si dovolit nasledujici hracky:");

        if(penize >= 75)
            Console.WriteLine("Hot Wheels auticko (75)");

        if(penize >= 120)
            Console.WriteLine("Panenka (120)");
        
        if(penize >= 200)
            Console.WriteLine("LEGO stavebnice (200)");
    }
}
