namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = 0;

            int totalStudentTickets = 0;
            int totalKidTickets = 0;
            int totalStadardTickets = 0;

            while (true)
            {
                String movieName = Console.ReadLine();

                if (movieName == "Finish")
                    break;

                int movieSize = int.Parse(Console.ReadLine());

                int movieSoldTickets = 0;
                while (movieSoldTickets < movieSize)
                {
                    String ticketType = Console.ReadLine();

                    if (ticketType == "End")
                        break;

                    movieSoldTickets++;
                    switch (ticketType)
                    {
                        case "kid": totalKidTickets++; break;
                        case "student": totalStudentTickets++; break;
                        case "standard": totalStadardTickets++; break;
                    }
                }

                Console.WriteLine($"{movieName} - {movieSoldTickets * 100.0 / movieSize:f2}% full.");
            }

            int totalTickets = totalKidTickets + totalStadardTickets + totalStudentTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{totalStadardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{totalKidTickets * 100.0 / totalTickets:f2}% kids tickets.");
        }
    }
}