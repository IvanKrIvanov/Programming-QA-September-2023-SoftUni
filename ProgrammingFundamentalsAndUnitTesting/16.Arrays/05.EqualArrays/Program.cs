int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;


for (int i = 0; i < firstArray.Length; i++)
{
	if (firstArray[i] != secondArray[i])
	{
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}