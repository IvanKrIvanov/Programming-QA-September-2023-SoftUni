int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

double factorial1 = CalculateFactorial(number1);
double factorial2 = CalculateFactorial(number2);

double result = factorial1 / factorial2;
Console.WriteLine(result);

static double CalculateFactorial(double n)
{
    double output = 1;
	for (int factorial = 1; factorial <= n; factorial++)
	{
		output = output * factorial;
	}
	return output;
}