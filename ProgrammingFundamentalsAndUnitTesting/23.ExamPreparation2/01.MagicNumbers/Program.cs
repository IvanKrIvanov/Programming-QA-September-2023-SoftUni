using System.Xml.Linq;

int n = int.Parse(Console.ReadLine());

bool isThereNoMatchNumbers = true;

for (int i = 1; i <= n; i++)
{
    int workNum = i;
    int digitSum = 0;
    bool isAllDigitPrime = true;

    while (workNum > 0)
    {
        int digit = workNum % 10;
        workNum = workNum / 10;

        bool isDigitPrime = digit == 2 || digit == 3 || digit == 5 || digit == 7;

        if (isDigitPrime)
        {
            digitSum += digit;
        }
        else
        {
            isAllDigitPrime = false;
            break;
        }
    }
    if (isAllDigitPrime && digitSum % 2 == 0)
    {
        Console.Write(i + " ");
        isThereNoMatchNumbers = false;
    }
}
if (isThereNoMatchNumbers)
{
    Console.WriteLine("no");
}