using System;
using System.Diagnostics.Metrics;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesPens = int.Parse(Console.ReadLine());
            int packagesMarker = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double pricePens = 5.8 * packagesPens;
            double priceMarkers = 7.2 * packagesMarker;
            double priceCleaner = 1.2 * litersCleaner;
            double allPrice = priceCleaner + priceMarkers + pricePens;
            double calcilationDiscount = allPrice * discountPercentage / 100;

            double finalPrice = allPrice - calcilationDiscount;
            Console.WriteLine(finalPrice);


        }
    }
}