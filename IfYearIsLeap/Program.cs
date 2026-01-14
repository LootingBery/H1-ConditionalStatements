namespace IfYearIsLeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hard coded årstal fordi at give brugeren mulighed for at indtaste et årstal giver ikke helt mening
            Console.WriteLine(IsALeapYear("2016"));
            Console.WriteLine(IsALeapYear("2018"));
            Console.ReadLine();
        }

        // Funktion der tjekker om et årstal er skudår eller ej
        static string IsALeapYear(string year)
        {
            int yearInt = int.Parse(year);
            if ((yearInt % 4 == 0 && yearInt % 100 != 0) || (yearInt % 400 == 0))
            {
                return $"{year} is a leap year.";
            }
            else
            {
                return $"{year} is not a leap year.";
            }
        }
    }
}
