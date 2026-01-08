namespace IfGreaterThanThirdOne
{
    internal class Program
    {
        static void Main()
        {

            // hard coded arrays + "Console.ReadLine();" for at holde konsollen åben
            Console.WriteLine(IfGreaterThanThirdOneCode([2, 7, 12]));
            Console.WriteLine(IfGreaterThanThirdOneCode([-5, -8, 50]));
            Console.ReadLine();

        }

        // Funktion der tjekker om det ganget resultat eller summen af de to første tal er større end det tredje tal
        static bool IfGreaterThanThirdOneCode(int[] numbers)
        {
            if (numbers[0] * numbers[1] > numbers[2] || numbers[0] + numbers[1] > numbers[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
