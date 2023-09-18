namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double boatRentPrice = 0.0;

            switch (season)
            {
                case "Spring":
                    boatRentPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatRentPrice = 4200;
                    break;
                case "Winter":
                    boatRentPrice = 2600;
                    break;
            }

            if (fishermenCount <= 6)
            {
                boatRentPrice *= 0.9; // 10% discount
            }
            else if (fishermenCount <= 11)
            {
                boatRentPrice *= 0.85; // 15% discount
            }
            else
            {
                boatRentPrice *= 0.75; // 25% discount
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                boatRentPrice *= 0.95; // Additional 5% discount for even number of fishermen
            }

            double remainingBudget = groupBudget - boatRentPrice;

            if (remainingBudget >= 0)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", remainingBudget);
            }
            else
            {
                double moneyNeeded = Math.Abs(remainingBudget);
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyNeeded);
            }
        }
    }
}