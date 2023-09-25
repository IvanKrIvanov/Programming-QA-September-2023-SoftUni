namespace _02.EqualSumsOfEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine()); 

            for (int i = firstNum; i <= secondNum; i++) 
            {
                String currentNum = i.ToString();

                int oddSum = 0; 
                int evenSum = 0; 
                for (int j = 0; j < currentNum.Length; j++) 
                {
                    Char c = currentNum[j];
                    int currentDigit = int.Parse(c.ToString()); 

                    if (j % 2 == 0) 
                        oddSum += currentDigit;
                    else
                        evenSum += currentDigit;
                }

                if (oddSum == evenSum) 
                    Console.Write(i + " ");
            }
        }
    }
}