namespace _07.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());

            int coins = 0;


            int stotinki = (int)(value * 100);

            int curStotinkiCoin = 200;

            while (curStotinkiCoin != 0)
            {
                coins += stotinki / curStotinkiCoin;
                stotinki = stotinki % curStotinkiCoin;


                switch (curStotinkiCoin)
                {
                    case 200: curStotinkiCoin = 100; break;
                    case 100: curStotinkiCoin = 50; break;
                    case 50: curStotinkiCoin = 20; break;
                    case 20: curStotinkiCoin = 10; break;
                    case 10: curStotinkiCoin = 5; break;
                    case 5: curStotinkiCoin = 2; break;
                    case 2: curStotinkiCoin = 1; break;
                    case 1: curStotinkiCoin = 0; break;
                }
            }

            Console.WriteLine(coins);
        }
    }
}

