using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
        Console.WriteLine(IfConsistsOfUppercaseLetters("DOG")); 
        Console.WriteLine(IfConsistsOfUppercaseLetters("L9#")); 

        Console.ReadLine();
    }

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
