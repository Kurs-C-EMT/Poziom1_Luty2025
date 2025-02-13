using Biblioteka;

namespace OdczytZPliku2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę pliku:");
            string nazwa = Console.ReadLine();

            Prostokąt[] tablica = new Prostokąt[11];

            try
            {
                using (StreamReader streamReader = new StreamReader($"C:\\Users\\Piotr\\OneDrive\\Pulpit\\PR3-1\\{nazwa}.csv"))
                {
                    string odczyt = streamReader.ReadLine();
                    odczyt = streamReader.ReadLine();
                    int i = 0;

                    while (odczyt is not null)
                    {
                        string[] kolumny = odczyt.Split(";");
                        int x = int.Parse(kolumny[1]);
                        int y = int.Parse(kolumny[2]);
                        int x2 = int.Parse(kolumny[3]);
                        int y2 = int.Parse(kolumny[4]);
                        tablica[i] = new Prostokąt(new Punkt(x, y), new Punkt(x2, y2));
                        i++;
                        odczyt = streamReader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            foreach(Prostokąt p in tablica)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine(p.Serializuj());
            }
        }
    }
}
