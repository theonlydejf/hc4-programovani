namespace _04;

class Program
{
    static void Main(string[] args)
    {
        // Pole na ukladani polozek seznamu
        string[] seznam = new string[5];

        for(int i = 0; i < seznam.Length; i++)
        {
            Console.WriteLine((i + 1) + ". polozka:");
            // Uloz si polozku na urcene misto v seznamu
            seznam[i] = Console.ReadLine();
        }

        Console.WriteLine("Kterou polozku hledas?");
        string hledanaPolozka = Console.ReadLine();
        
        int indexPolozky = -1; // -1 je neplatny index, pokud tedy zustane polozka se nenasla
        for(int i = 0; i < seznam.Length; i++) // Projdi nakupni seznam
        {
            if(seznam[i] == hledanaPolozka) // Pokud se polozka jmenuje jako hledana polozka
            {
                indexPolozky = i; // Zapamatuj si jeji index
                break; // Ukonci hledani
            }
        }

        if(indexPolozky < 0) // Pokud platny index (neboli pokud se polozka nasla)
            Console.WriteLine("Polozka se v seznamu nenachazi");
        else
            Console.WriteLine(indexPolozky + 1);
    }
}
