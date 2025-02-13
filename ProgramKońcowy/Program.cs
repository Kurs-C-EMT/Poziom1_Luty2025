using Biblioteka;

namespace ProgramKońcowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokąt[] tablica = new Prostokąt[20];

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                try
                {
                    Console.WriteLine("1. Prostokąt");
                    Console.WriteLine("2. Kwadrat");
                    Console.WriteLine("3. Kolorowy Prostokąt");

                    string wybór = Console.ReadLine();
                    int wybranaOpcja = int.Parse(wybór);
                    Prostokąt prostokąt;

                    switch (wybranaOpcja)
                    {
                        case 1:
                            prostokąt = UtwórzProstokąt();
                            break;
                        case 2:
                            prostokąt = UtwórzKwadrat();
                            break;
                        case 3:
                            prostokąt = UtwórzKolorowyProstokąt();
                            break;
                        default:
                            prostokąt = null;
                            break;
                    }

                    if (prostokąt is not null)
                    {
                        bool czyDodano = false;
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            if (tablica[i] is null)
                            {
                                czyDodano = true;
                                tablica[i] = prostokąt;
                                break;
                            }
                        }

                        if (!czyDodano)
                        {
                            Console.WriteLine("Tablica jest pełna");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd: {0}", ex.Message);
                }
            }
        }

        static Prostokąt UtwórzProstokąt()
        {
            Console.WriteLine("Podaj x");
            string wybór = Console.ReadLine();
            int x = int.Parse(wybór);
            Console.WriteLine("Podaj y");
            wybór = Console.ReadLine();
            int y = int.Parse(wybór);
            Console.WriteLine("Podaj a");
            wybór = Console.ReadLine();
            int a = int.Parse(wybór);
            Console.WriteLine("Podaj b");
            wybór = Console.ReadLine();
            int b = int.Parse(wybór);

            Punkt punkt = new Punkt(x, y);
            Prostokąt prostokąt = new Prostokąt(punkt, a, b);
            return prostokąt;
        }

        static Kwadrat UtwórzKwadrat()
        {
            Console.WriteLine("Podaj x");
            string wybór = Console.ReadLine();
            int x = int.Parse(wybór);
            Console.WriteLine("Podaj y");
            wybór = Console.ReadLine();
            int y = int.Parse(wybór);
            Console.WriteLine("Podaj a");
            wybór = Console.ReadLine();
            int a = int.Parse(wybór);

            Punkt punkt = new Punkt(x, y);
            Kwadrat kwadrat = new Kwadrat(punkt, a);
            return kwadrat;
        }

        static KolorowyProstokąt UtwórzKolorowyProstokąt()
        {
            Console.WriteLine("Podaj x");
            string wybór = Console.ReadLine();
            int x = int.Parse(wybór);
            Console.WriteLine("Podaj y");
            wybór = Console.ReadLine();
            int y = int.Parse(wybór);
            Console.WriteLine("Podaj a");
            wybór = Console.ReadLine();
            int a = int.Parse(wybór);
            Console.WriteLine("Podaj b");
            wybór = Console.ReadLine();
            int b = int.Parse(wybór);
            Console.WriteLine("Podaj kolor");
            wybór = Console.ReadLine();

            Punkt punkt = new Punkt(x, y);
            KolorowyProstokąt kolorowyProstokąt = new KolorowyProstokąt(punkt, a, b, wybór);
            return kolorowyProstokąt;
        }
    }
}
