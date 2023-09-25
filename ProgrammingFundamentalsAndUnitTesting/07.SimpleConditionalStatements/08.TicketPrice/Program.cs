namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "student")
            {
                Console.WriteLine("$1.00");
            }
            else if (type == "regular")
            {
                Console.WriteLine("$1.60");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}