using System.Drawing;

namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;
                Console.WriteLine($"{area:F2}");
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine($"{area:F2}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}