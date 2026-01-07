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
                Console.WriteLine(Number + "is already an absolute value");
            }
        }
    }
}
