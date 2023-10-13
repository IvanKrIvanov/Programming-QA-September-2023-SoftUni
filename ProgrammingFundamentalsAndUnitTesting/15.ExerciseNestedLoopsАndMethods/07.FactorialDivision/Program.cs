int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int factorial1 = CalculateFactorial(number1);
int factorial2 = CalculateFactorial(number2);

double result = (double)factorial1 / factorial2;
Console.WriteLine(result);

static int CalculateFactorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }

    return n * CalculateFactorial(n - 1);
}