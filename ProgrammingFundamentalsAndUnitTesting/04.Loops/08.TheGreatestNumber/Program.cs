namespace _08.TheGreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}