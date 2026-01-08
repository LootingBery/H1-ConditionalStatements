using System;

class DivisibleBy2Or3
{
    static int DivisibleChecker(int a, int b)
    {
        // Skal bare fortælle brugeren hvad input værdierne er. Det er hard coded, så det er ikke nødvendigt at spørge brugeren.
        Console.WriteLine($"Input values: a = {a}, b = {b}");

        // Tjekker om a og b kan divideres med 2 eller 3
        if ((a % 2 == 0 || a % 3 == 0) &&
            (b % 2 == 0 || b % 3 == 0))
        {
            return a * b;
        }
        else
        {
            return a + b;
        }
    }

    // Eksempler på brug af funktionen
    static void Main()
    {
        Console.WriteLine(DivisibleChecker(15, 30));
        Console.WriteLine(DivisibleChecker(2, 90));  
        Console.WriteLine(DivisibleChecker(7, 12));  
    }
}
