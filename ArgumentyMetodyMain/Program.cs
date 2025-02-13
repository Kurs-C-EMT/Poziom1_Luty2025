namespace ArgumentyMetodyMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(string a in args)
            {
                Console.WriteLine("Zadano parametr: {0}", a);
                if(a == "hej")
                {
                    Console.WriteLine("HEJ");
                }
            }

            Console.WriteLine("Koniec programu");
            Console.ReadKey();
        }
    }
}
