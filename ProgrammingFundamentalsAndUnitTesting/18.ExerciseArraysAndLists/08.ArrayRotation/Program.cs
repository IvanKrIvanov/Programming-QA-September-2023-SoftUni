List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int cirrentNum = input[0];
    input.RemoveAt(0);
    input.Add(cirrentNum);
}
Console.WriteLine(string.Join(" ", input));