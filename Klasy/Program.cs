namespace Klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokąt prostokąt1 = new Prostokąt();
            Prostokąt prostokąt2 = new Prostokąt();
            Prostokąt prostokąt3 = new Prostokąt();

            prostokąt1.x1 = 1;
            prostokąt1.x2 = 10;
            prostokąt1.y1 = 11;
            prostokąt1.y2 = 9;

            prostokąt2.x1 = 33;
            prostokąt2.x2 = 1000;
            prostokąt2.y1 = 234;
            prostokąt2.y2 = 99;

            int pole = prostokąt1.ObliczPole();
            Console.WriteLine("Pole prostokąta 1 wynosi: {0}", pole);
            pole = prostokąt2.ObliczPole();
            Console.WriteLine("Pole prostokąta 2 wynosi: {0}", pole);
        }
    }
}
