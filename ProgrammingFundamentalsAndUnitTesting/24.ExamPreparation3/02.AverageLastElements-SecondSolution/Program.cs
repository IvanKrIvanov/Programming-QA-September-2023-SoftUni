List <int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();

int selection = int.Parse(Console.ReadLine());

ints.Reverse();
List<int> intSelection = ints.Take(selection).ToList();
double average = intSelection.Average();

Console.WriteLine($"{average:F2}");