namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());

            int numberPoorGrades = 0;
            double gradesTotal = 0;
            int gradesNum = 0;
            string lastProblem = "";

            while (numberPoorGrades < maxPoorGrades)
            {
                String curProblem = Console.ReadLine();

                if (curProblem == "Enough")
                    break; 

                lastProblem = curProblem;
                int curGrade = int.Parse(Console.ReadLine());

                gradesTotal += curGrade; 
                gradesNum++;

                if (curGrade <= 4) 
                    numberPoorGrades++; 
            }

            if (numberPoorGrades >= maxPoorGrades)
            {
                Console.WriteLine($"You need a break, {numberPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesTotal / gradesNum:f2}");
                Console.WriteLine($"Number of problems: {gradesNum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}