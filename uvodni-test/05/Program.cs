namespace _05;

class Program
{
    static void Main(string[] args)
    {
        // Seznam znamych hracek
        string[] hracky = new string[5];
        // Seznam cen k prislusne hracce
        int[] ceny = new int[5];

        // Nacti inventar hrackarstvi
        for(int i = 0; i < hracky.Length; i++)
        {
            Console.WriteLine((i + 1) + ". hracka:");
            hracky[i] = Console.ReadLine();
            Console.WriteLine("Cena " + (i + 1) + ". hracky:");
            ceny[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Kolik mas penez?");
        double penize = Convert.ToDouble(Console.ReadLine());

        // Projdi kazdou cenu hracky
        for(int i = 0; i < ceny.Length; i++)
        {
            if(penize >= ceny[i]) // Pokud si hracku muzu dovolit
                Console.WriteLine(hracky[i] + " (" + ceny[i] + ")"); // Vypis jeji jmeno a cenu
        }
    }
}
