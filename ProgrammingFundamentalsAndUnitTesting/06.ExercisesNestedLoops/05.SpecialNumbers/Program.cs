namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int digit = 1111; digit <= 9999; digit++)
            {

                String digits = digit.ToString();

                bool isSpecial = true;
                for (int curDigitIdx = 0; curDigitIdx < digits.Length; curDigitIdx++)
                {
                    int curDigit = int.Parse(digits[curDigitIdx].ToString());

                    if (curDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if (n % curDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                    Console.Write(digit + " ");
            }

            Console.WriteLine();
        }
    }
}