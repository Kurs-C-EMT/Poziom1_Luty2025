namespace Działania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dzialania działania = new Dzialania();

            działania.Dodaj(3,6);
            działania.Odejmij(7, 6);
            działania.CofnijOstatniaOperacje();
            działania.Silnia(5);
        }
    }
}
