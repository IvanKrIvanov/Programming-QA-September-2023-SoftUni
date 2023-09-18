using System.Net;

namespace _06.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();

            if (operat == "+" || operat == "-" || operat == "*")
            {
                int result = 0;
                string condition = "even";

                if (operat == "+")
                {
                    result  = N1 + N2;
                }
                else if (operat == "-")
                {
                    result = N1 - N2;
                }
                else if (operat == "*")
                {
                    result = N1 * N2;
                }
                if (result % 2 == 1)
                {
                    condition = "odd";
                }
                Console.WriteLine($"{N1} {operat} {N2} = {result} - {condition}");
            }
            else
            {

                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                    
                }
                else if (operat == "/")
                {
                    double result = (double)N1 / N2;
                    Console.WriteLine($"{N1} {operat} {N2} = {result:F2}");
                }
                else if (operat == "%")
                {
                    double result = N1 % N2;
                    Console.WriteLine($"{N1} {operat} {N2} = {result}");
                }
                
            }
        }
    }
}