using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            float percentage = float.Parse(Console.ReadLine());


            double volume = lenght * width * height;
            double liters = volume / 1000;
            double occupiedSpace = percentage * 0.01;
            double requiredLiters = liters * (1 - occupiedSpace);
            Console.WriteLine($"{requiredLiters:f2}");

        }
    }
}