int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int lastElement = numbers[numbers.Length - 1];

    for (int j = numbers.Length - 1; j > 0; j--)
    {
        numbers[j] = numbers[j - 1];
    }

    numbers[0] = lastElement;
}

Console.WriteLine(string.Join(", ", numbers));

