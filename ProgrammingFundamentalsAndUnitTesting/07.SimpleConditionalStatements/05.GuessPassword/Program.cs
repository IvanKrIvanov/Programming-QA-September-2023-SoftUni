namespace _05.GuessPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            if (pass == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else
                Console.WriteLine("Wrong password!");

        }
    }
}