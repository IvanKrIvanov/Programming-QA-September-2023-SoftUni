namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());

            double studentGradesSum = 0;
            int numberOfPresentations = 0;

            for (; ; numberOfPresentations++)
            {
                String presName = Console.ReadLine();

                if (presName == "Finish")
                    break; 

                double presentationGrades = 0;


                for (int curJury = 0; curJury < juryMembers; curJury++)
                    presentationGrades += double.Parse(Console.ReadLine());


                Console.WriteLine($"{presName} - {presentationGrades / juryMembers:f2}.");


                studentGradesSum += presentationGrades;
            }


            Console.WriteLine($"Student's final assessment is {studentGradesSum / numberOfPresentations / juryMembers:f2}.");
        }
    }
}