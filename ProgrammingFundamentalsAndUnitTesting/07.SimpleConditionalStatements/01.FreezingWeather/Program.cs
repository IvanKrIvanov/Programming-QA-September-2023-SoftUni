using System.ComponentModel;
using System.Reflection.Metadata;

namespace _01.FreezingWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperatureC = double.Parse(Console.ReadLine());
            if (temperatureC <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }

        }
    }
}