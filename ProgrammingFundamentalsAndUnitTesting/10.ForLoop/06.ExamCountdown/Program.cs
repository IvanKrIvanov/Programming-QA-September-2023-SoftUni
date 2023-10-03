int dayToExam = int.Parse(Console.ReadLine());

for (int currentDay = dayToExam; currentDay > 0; currentDay -= 1)
{
    Console.WriteLine($"{currentDay} days before the exam");
}
Console.WriteLine("The exam has come");