namespace _10.ValidTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            bool isValidTriangle = true;
            if (sideA + sideB <= sideC)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (sideA + sideC <= sideB)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (sideB + sideC <= sideA)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else
            {
                Console.WriteLine("Valid Triangle");
            }
        }
    }
}