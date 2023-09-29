namespace _03.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = int.Parse(Console.ReadLine());
            if (point >= 0 && point <= 3)
            {
                point += 5;
            }
            else if (point >= 4 && point <= 6)
            {
                point += 15;
            }
            else if (point >= 7 && point <= 9)
            {
                point += 20;
            }
            Console.WriteLine(point);
        }
    }
}