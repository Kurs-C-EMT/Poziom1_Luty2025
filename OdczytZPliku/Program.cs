using Biblioteka;

namespace OdczytZPliku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę pliku:");
            string nazwa = Console.ReadLine();

            StreamWriter streamWriter = new StreamWriter($"C:\\Users\\Piotr\\OneDrive\\Pulpit\\PR3-1\\{nazwa}.csv", false);

            Prostokąt[] tablica = new Prostokąt[11];

            for (int i = 0; i < tablica.Length - 1; i++) 
            {
                Punkt punkt = new Punkt(2 + i, 5 + i);
                Prostokąt prostokąt = new Prostokąt(punkt, 7 + 3*i, 9 + 4*i);
                tablica[i] = prostokąt;
            }

            KolorowyProstokąt kolorowyProstokąt = new KolorowyProstokąt(new Punkt(6, 7), 8, 11, "czarny");

            tablica[^1] = kolorowyProstokąt;



            try
            {
                streamWriter.WriteLine("typ;pdX;pdY;lgX;lgY;kolor");
                foreach(Prostokąt p in tablica)
                {
                    string zrzutDoPamięci = p.Serializuj();
                    streamWriter.WriteLine(zrzutDoPamięci);
                    streamWriter.Flush();
                }

                streamWriter.Close();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
