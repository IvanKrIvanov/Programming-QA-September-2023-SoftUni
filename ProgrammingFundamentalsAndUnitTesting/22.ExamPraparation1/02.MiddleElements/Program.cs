double[] inputArray = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

int middleRightElementIndex = inputArray.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;

double middleElementsAverage = (inputArray[middleRightElementIndex] + inputArray[middleLeftElementIndex]) / 2;

Console.WriteLine($"{middleElementsAverage:F2}");