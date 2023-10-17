int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

var commonElements = firstArray.Intersect(secondArray);

foreach (int element in commonElements)
{
    Console.Write(element + " ");
}

Console.WriteLine();
