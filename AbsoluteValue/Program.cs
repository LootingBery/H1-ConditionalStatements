namespace AbsoluteValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tillader brugeren at ingive en tal
            Console.WriteLine("Please input you desired number: ");
            double Number = Convert.ToDouble(Console.ReadLine());

            // Skal tjekke om tallet er negativt
            if (Number < 0)
            {
                Math.Abs(Number);
                Console.WriteLine("The absolute value of your number is: " + Math.Abs(Number));
            }
            else // Tallet er allerede positivt
            {
                Console.WriteLine(Number + " is already an absolute value");
            }

            // Skal give brugeren mulighed for at prøve igen
            while (true)
            {
                Console.WriteLine("Do you want to try again? (y/n)");
                char userChoice = Console.ReadLine()[0];
                if (userChoice == 'y')
                {
                    Main(args);
                    break;
                }
                else if (userChoice == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please type y or n.");
                }
            }
        }
    }
}
