namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int c = 0; c < count; c++)
            {
                int cur = int.Parse(Console.ReadLine());

                sum += cur; 

                if (cur > max)
                    max = cur;
            }

            sum -= max; 

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int diff = Math.Abs(sum - max); 
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}