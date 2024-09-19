namespace _08_1;

class Program
{
    static void Main(string[] args)
    {
        string text = "Why java programmers wear glasses? Beacuse they can't C#";
        Console.WriteLine(SpoctiSlova(text));
    }

    static int SpoctiSlova(string text)
    {
        int pocet = 0;

        char predchozi = ' '; // Mezera at se pocita prvni slovo
        foreach(char znak in text)
        {
            if(predchozi == ' ' && znak != ' ') // Narazil jsi na zacatek slova?
                pocet++;
            predchozi = znak;
        }

        return pocet;
    }
}
