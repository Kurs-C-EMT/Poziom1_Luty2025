using Biblioteka;

namespace Prostokąty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokąt prostokąt = new Prostokąt(new Punkt(2,4), new Punkt(5,7));
            Prostokąt prostokąt2 = new Prostokąt(new Punkt(2,4), 7, 9);

            Prostokąt[] tab = new Prostokąt[10];
            tab[4] = prostokąt;


            for (int i = 0; i < tab.Length; i++) 
            {
                if (tab[i] is null)
                {
                    Console.WriteLine("{0}: null", i);
                } else
                {
                    Console.WriteLine("{0}: ma wartość", i);
                }
            }


        }
    }
}
