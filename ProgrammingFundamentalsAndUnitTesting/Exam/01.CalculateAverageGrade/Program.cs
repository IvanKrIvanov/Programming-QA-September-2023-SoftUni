
int n = int.Parse(Console.ReadLine());

double sumOfGrades = 0.0;
int numberOfStudents = 0;

for (int i = 0; i < n; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sumOfGrades += grade;
    numberOfStudents++;
}
double averageGrade = sumOfGrades / numberOfStudents;


Console.WriteLine($"{averageGrade:F2}");