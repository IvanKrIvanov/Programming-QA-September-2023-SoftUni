namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int seatsCount = int.Parse(Console.ReadLine());

            if (movieType == "Premiere")
            {
                double totalSum = rowsCount * seatsCount * 12.00;
                Console.WriteLine(totalSum);
            }
            else if (movieType == "Normal")
            {
                double totalSum = rowsCount * seatsCount * 7.50;
                Console.WriteLine(totalSum);
            }
            else if (movieType == "Discount")
            {
                double totalSum = rowsCount * seatsCount * 5.00;
                Console.WriteLine(totalSum);
            }
        }
    }
}