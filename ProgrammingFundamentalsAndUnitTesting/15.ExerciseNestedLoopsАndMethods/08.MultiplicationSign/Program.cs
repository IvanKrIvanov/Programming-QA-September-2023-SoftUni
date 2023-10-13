int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

PrintSign(number1, number2, number3);

static void PrintSign (int n1, int n2, int n3)
{
	//   int product = n1 * n2 * n3;
	//if (product < 0)
	//{
	//       Console.WriteLine("negative");
	//   }
	//else if (product > 0)
	//{
	//       Console.WriteLine("positive");
	//   }
	//else
	//{
	//       Console.WriteLine("zero");
	//   }

	if (n1 ==0 || n2 == 0 || n3 == 0)
	{
        Console.WriteLine("zero");
    }
	else if (n1 > 0 && n2 > 0 && n3 > 0)
	{
        Console.WriteLine("positive");
    }
	else if (n1 < 0 && n2 < 0 && n3 > 0)
	{
        Console.WriteLine("positive");
    }
    else if (n1 > 0 && n2 < 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 < 0 && n2 > 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else
	{
        Console.WriteLine("negative");
    }
}
