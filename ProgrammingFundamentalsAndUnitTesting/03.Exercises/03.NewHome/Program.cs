namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowers == "Roses")
            {
                totalPrice = flowersCount * 5;
                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                totalPrice = flowersCount * 3.80;
                if (flowersCount > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                totalPrice = flowersCount * 2.80;
                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                totalPrice = flowersCount * 3.00;
                if (flowersCount < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = flowersCount * 2.50;
                if (flowersCount < 80)
                {
                    totalPrice += totalPrice * 0.2;
                }
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {moneyLeft:F2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }

        }
    }
}