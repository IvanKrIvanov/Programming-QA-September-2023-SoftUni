namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.0;
                    apartmentPrice = 65.0;
                    if (nights > 14)
                    {
                        studioPrice *= 0.7; // 30% discount
                        apartmentPrice *= 0.9; // 10% discount
                    }
                    else if (nights > 7)
                    {
                        studioPrice *= 0.95; // 5% discount
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice *= 0.8; // 20% discount
                        apartmentPrice *= 0.9; // 10% discount
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.0;
                    apartmentPrice = 77.0;
                    if (nights > 14)
                    {
                        apartmentPrice *= 0.9; // 10% discount
                    }
                    break;
            }

            double studioTotalPrice = studioPrice * nights;
            double apartmentTotalPrice = apartmentPrice * nights;

            Console.WriteLine("Apartment: {0:F2} lv.", apartmentTotalPrice);
            Console.WriteLine("Studio: {0:F2} lv.", studioTotalPrice);
        }
    }
}