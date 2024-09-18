namespace _07;

class Program
{
    static void Main(string[] args)
    {
        int cislo = 919;
        if (JePalindrom(cislo))
            Console.WriteLine("Je to palindrom");
        else
            Console.WriteLine("Neni to palindrom");
    }

    static bool JePalindrom(int cislo)
    {
        string cisloStr = cislo.ToString();

        for(int i = 0; i < cisloStr.Length / 2; i++)
        {
            if(cisloStr[i] != cisloStr[cisloStr.Length - i - 1])
                return false;
        }

        return true;
    }
}
