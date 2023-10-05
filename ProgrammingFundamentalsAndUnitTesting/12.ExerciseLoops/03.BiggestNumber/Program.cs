int countnumbers = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;

for (int number = 1; number <= countnumbers; number++)
{
    int value = int.Parse(Console.ReadLine());

	if (value > maxNumber)
	{
		maxNumber = value;
	}
}
Console.WriteLine(maxNumber);