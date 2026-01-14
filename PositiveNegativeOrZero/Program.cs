namespace PositiveNegativeOrZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");
            int number = int.Parse(Console.ReadLine());

            // Hvis brugerens tal er større end 0 skal det retuneres som "Postive", ellers skal det retuerenes som "Negative" med mindre det tallet er 0.
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
