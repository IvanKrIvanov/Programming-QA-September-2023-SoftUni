using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int amountNylon = int.Parse(Console.ReadLine());
            int amountPaint = int.Parse(Console.ReadLine());
            int quantityThineer = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());




            double priceNylon = (amountNylon + 2) * 1.50;
            double pricePaint = amountPaint * 1.1 * 14.50;
            double priceThineer = quantityThineer * 5.00;

            double totalPrice = priceNylon + pricePaint + priceThineer + 0.40;

            double priceCraftman = totalPrice * 0.3;

            double finalPrice = totalPrice + priceCraftman * neededHours;

            Console.WriteLine(finalPrice);
        }
        }
}