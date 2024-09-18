namespace _07;

class Program
{
    static void Main(string[] args)
    {
        // Priklad z testu
        int cislo = 919;
        if (JePalindrom(cislo))
            Console.WriteLine("Je to palindrom");
        else
            Console.WriteLine("Neni to palindrom");
    }

    static bool JePalindrom(int cislo)
    {
        string cisloStr = cislo.ToString(); // Preved cislo na text -> muzu prochazet jednotlive znaky

        // Staci projit pulku cisla. Deleni dvou Integeru je zaokrouhlene vzdy dolu,
        // tedy nevznika mi problem pri lichem poctu cifer. Prostredni cifru navic neni
        // potreba kontrolovat, protoze to zda-li je cislo palindrom je na ni nezavisle
        // (ofc v pripade sudeho poctu cifer na dvou prostrednich cifrach zalezi :D)
        for(int i = 0; i < cisloStr.Length / 2; i++)
        {
            // Porovnej aktualni cifru s ni symetrickou, pokud nejsou stejne -> neni to palindrom.
            if(cisloStr[i] != cisloStr[cisloStr.Length - i - 1])
                return false;
        }

        return true;
    }
}
