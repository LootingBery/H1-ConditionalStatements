using System;

class Program
{
    static void Main()
    {
        // Hard coded sætninger
        Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
        Console.WriteLine(IfConsistsOfUppercaseLetters("DOG")); 
        Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));

        // Holder konsollen åben
        Console.ReadLine();
    }

    // Funktion der tjekker om en streng består af tre store bogstaver
    static bool IfConsistsOfUppercaseLetters(string input)
    {
        if (input.Length != 3)
            return false;

        foreach (char c in input)
        {
            if (!char.IsUpper(c))
            return false;
        }

        return true;
    }
}
