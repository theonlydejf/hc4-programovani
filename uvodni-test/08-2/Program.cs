namespace _08_2;

class Program
{
    const string ZNAKY_SLOVA = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM_1234567890";

    static void Main(string[] args)
    {
        string text1 = "Mam rad programovani";
        Console.WriteLine(SpoctiSlova(text1));
        string text2 = "? NechaPu, kdo_by.Takhle     psal -- achjo??";
        Console.WriteLine(SpoctiSlova(text2));
    }

    static bool JeZnakSlova(char znak)
    {
        foreach(char c in ZNAKY_SLOVA) // Pokud je znak obsazen ve stringu, je to znak patrici do slova
        {
            if(c == znak)
                return true;
        }

        return false;
    }

    static int SpoctiSlova(string text)
    {
        int pocet = 0;

        char predchozi = ' '; // Mezera at se pocita prvni slovo
        foreach(char znak in text)
        {
            if(!JeZnakSlova(predchozi) && JeZnakSlova(znak)) // Narazil jsi na zacatek slova?
                pocet++;
            predchozi = znak;
        }

        return pocet;
    }
}
