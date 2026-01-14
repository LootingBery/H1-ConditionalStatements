namespace IfNumberIsEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tillader brugeren at give et tal
            Console.WriteLine("Please input a number: ");
            int number = int.Parse(Console.ReadLine());

            // Tjekker om tallet er lige eller ulige, ved at bruge modulus operatoren (%)
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
                Main(args);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
                Main(args);
                Console.ReadLine();
            }

        }
    }
}
