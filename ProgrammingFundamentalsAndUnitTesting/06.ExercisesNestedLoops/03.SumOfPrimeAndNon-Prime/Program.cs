namespace _03.SumOfPrimeAndNon_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfPrimes = 0;
            int sumOfNonPrimes = 0;

            while (true)
            {
                String input = Console.ReadLine(); 

                if (input == "stop")
                    break; 

                int number = int.Parse(input); 

                if (number < 0) 
                {
                    Console.WriteLine("Number is negative.");
                    continue; 
                }


                int divisors = 0;
                for (int i = 1; i <= number; i++)
                    if (number % i == 0)
                        divisors++;

                if (divisors == 2)

                    sumOfPrimes += number;
                else

                    sumOfNonPrimes += number;
            }

            Console.WriteLine("Sum of all prime numbers is: " + sumOfPrimes);
            Console.WriteLine("Sum of all non prime numbers is: " + sumOfNonPrimes);

        }
    }
}