namespace Losowanie
{
    internal class Program
    {
        enum Kolory
        {
            Czerwony,
            Niebieski,
            Żółty
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Losowanie z ENUM");
                int losowyKolor = random.Next(3);
                Kolory kolor = (Kolory)losowyKolor;
                Console.WriteLine(kolor);
                Console.WriteLine("Losowanie z tablicy");
                string[] kolory = ["czerwony", "niebieski", "żółty"];

                losowyKolor = random.Next(kolory.Length);

                Console.WriteLine(kolory[losowyKolor]);

                string[] temp = new string[kolory.Length - 1];
                Console.ReadKey();
            }

        }
    }
}
