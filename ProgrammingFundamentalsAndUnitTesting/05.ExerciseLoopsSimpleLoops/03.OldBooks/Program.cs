namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();

            string current = Console.ReadLine();
            int checkedBooks = 0;

            while (current != "No More Books" && current != favorite)
            {
                checkedBooks++; 
                current = Console.ReadLine(); 
            }

            if (current == favorite)
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}