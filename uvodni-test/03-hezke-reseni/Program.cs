namespace _03_hezke_reseni;

class Program
{
    static void Main(string[] args)
    {
        // Zname hracky
        string[] hracky = new string[] { "LEGO stavebnice", "Hot Wheels auticko", "Panenka" };
        int[] ceny = new int[] { 200, 75, 120 };

        Console.WriteLine("Kolik mas penez?");
        double penize = Convert.ToDouble(Console.ReadLine());

        for(int i = 0; i < ceny.Length; i++)
        {
            if(penize > ceny[i])
                Console.WriteLine(hracky[i] + " (" + ceny[i] + ")");
        }
    }
}
