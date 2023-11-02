int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

int selection = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = ints.Length - 1; i > ints.Length - 1 - selection; i--)
{
    int currentNum = ints[i];

    sum += currentNum;
}

double average = (double) sum / selection;

Console.WriteLine($"{average:F2}");