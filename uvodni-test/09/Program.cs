namespace _09;

class Program
{
    static void Main(string[] args)
    {
        string text = "Mam rad cisla 1 55 a 89 ale nemam rad cislo 1221";
        Console.WriteLine(SpoctiPalindromy(text));
    }

    static bool JePalindrom(int cislo) // Viz reseni ulohy 07
    {
        string cisloStr = cislo.ToString();
        for(int i = 0; i < cisloStr.Length / 2; i++)
        {
            if(cisloStr[i] != cisloStr[cisloStr.Length - i - 1])
                return false;
        }

        return true;
    }

    static int SpoctiPalindromy(string text)
    {
        int pocet = 0;
        string slovo = "";
        
        for(int i = 0; i < text.Length + 1; i++)
        {
            // Zaruci ze bude detekovan palindrom na konci textu
            char znak = ' ';
            if(i < text.Length)
                znak = text[i];

            if (znak != ' ') // Pokud je to znak slova, pridej ho do aktualniho slova
            {
                slovo += znak;
                continue; // Prejdi na dalsi znak
            }

            // --- Pokud jsme tady, narazili jsme na mezeru ---

            if (slovo != "" && int.TryParse(slovo, out int cislo)) // Pokud je aktualni slovo cislo
            {
                if (JePalindrom(cislo))
                    pocet++;
            }

            slovo = ""; // Protoze jsme narazili na mezeru, vymaz buffer slova
        }

        return pocet;
    }
}
