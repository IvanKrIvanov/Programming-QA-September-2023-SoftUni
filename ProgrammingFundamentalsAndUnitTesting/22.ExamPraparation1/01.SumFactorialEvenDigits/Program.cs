int result = int.Parse(Console.ReadLine());

int totalResult = 0;

while (result != 0)
{
    int digit = result % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalsulateFactorial(digit);
        totalResult += resultFactorial;
    }

    result = result / 10;
}

Console.WriteLine(totalResult);

static int CalsulateFactorial(int number)
{
    int result = 1;

    while (number > 0)
    {
        result = result * number;
        number -= 1;
    }


    return result;
}