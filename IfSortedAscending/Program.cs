namespace IfSortedAscending
{
    internal class Program
    {

        // Hard coded arrays + "Console.Read();" for at holde konsollen åben
        static void Main(string[] args)
        {
            Console.WriteLine(SortedAscendingCode([3, 7, 10]));
            Console.WriteLine(SortedAscendingCode([74, 62, 99]));
            int numbers = Console.Read();
        }

        // Funktion der tjekker om tallene i arrayet er sorteret i stigende rækkefølge, hvis ikke det er det returneres false i konsolen
        static bool SortedAscendingCode(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
