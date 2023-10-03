using System.Diagnostics.CodeAnalysis;

int numberOfNumbers = int.Parse(Console.ReadLine());
double sum = 0;


for (int i = 0; i < numberOfNumbers; i++)
{
    double number = double.Parse(Console.ReadLine());

    sum = sum + number; 
}

Console.WriteLine(sum);