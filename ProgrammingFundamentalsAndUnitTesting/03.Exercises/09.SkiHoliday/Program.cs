namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            int nightsToStay = daysToStay - 1;
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();
            double costPerNight = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    costPerNight = 118;
                    break;
                case "apartment":
                    costPerNight = 155;
                    if (daysToStay < 10)
                    {
                        costPerNight = costPerNight * 0.7;
                    }
                    else if (daysToStay >= 10 && daysToStay <= 15)
                    {
                        costPerNight = costPerNight * 0.65;
                    }
                    else if (daysToStay > 15)
                    {
                        costPerNight = costPerNight * 0.5;
                    }
                    break;
                case "president apartment":
                    costPerNight = 235;
                    if (daysToStay < 10)
                    {
                        costPerNight = costPerNight * 0.9;
                    }
                    else if (daysToStay >= 10 && daysToStay <= 15)
                    {
                        costPerNight = costPerNight * 0.85;
                    }
                    else if (daysToStay > 15)
                    {
                        costPerNight = costPerNight * 0.8;
                    }
                    break;
            }

            double total = costPerNight * nightsToStay;

            if (assessment == "positive")
            {
                total = total * 1.25;
            }
            else
            {
                total = total * 0.9;
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}