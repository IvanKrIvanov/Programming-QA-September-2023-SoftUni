namespace _03.SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int side = int.Parse(input);
            int area = side * side;
            Console.WriteLine(area);
        }
    }
}