namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numberPages = int.Parse(Console.ReadLine());
            int pagerPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            double numberOfHours = (numberPages / pagerPerHour) / numberOfDays;
            Console.WriteLine(numberOfHours);


        }
    }
}