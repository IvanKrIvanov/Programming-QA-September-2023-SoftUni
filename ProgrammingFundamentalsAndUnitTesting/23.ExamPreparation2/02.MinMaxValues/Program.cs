int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

int selection = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < selection; i++)
{
	int currentInt = ints[i];
	if (max < currentInt)
	{
		max = currentInt;
	}
    if (min > currentInt)
    {
        min = currentInt;
    }
}
Console.WriteLine(max);
Console.WriteLine(min);