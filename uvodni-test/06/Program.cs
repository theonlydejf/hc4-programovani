namespace _06;

class Program
{
    static void Main(string[] args)
    {
        // Promenne do kterych ulozim jednotliva cisla
        double cislo1, cislo2;

        Console.WriteLine("Zadej prvni cislo:");
        // Pokud se nepovedlo prevadeni cisla -> chyba 
        if(!double.TryParse(Console.ReadLine(), out cislo1))
        {
            Console.WriteLine("Prvni vstupni cislo neni platna ciselna hodnota");
            return;
        }

        Console.WriteLine("Zadej druhe cislo:");
        if(!double.TryParse(Console.ReadLine(), out cislo2))
        {
            Console.WriteLine("Druhe vstupni cislo neni platna ciselna hodnota");
            return;
        }

        Console.WriteLine("Zadej operaci:");
        string operace = Console.ReadLine();

        switch(operace)
        {
            case "+":
                Console.WriteLine(cislo1 + cislo2);
                break;

            case "-":
                Console.WriteLine(cislo1 - cislo2);
                break;
            
            case "*":
                Console.WriteLine(cislo1 * cislo2);
                break;

            case "/":
                Console.WriteLine(cislo1 / cislo2);
                break;

            default:
                Console.WriteLine("Neznama operace");
                break;
        }
    }
}
