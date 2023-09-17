namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int termDeposit = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());

            double accumulatedInterest = depositAmount * (annualRate / 100);
            double interesMonth = accumulatedInterest / 12;
            double totalAmount = depositAmount + termDeposit * interesMonth;

            

            Console.WriteLine(totalAmount);
        }
    }
}
