// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

unsafe
{
    int wartość = 10;
    int* wskInt = &wartość;

    int wartość2 = 30;
    int* wskInt2 = &wartość2;

    Console.WriteLine("wartość wskaźnika: {0}", *wskInt);
    Console.WriteLine("wartość wskaźnika: {0}", (IntPtr)wskInt);
    Console.WriteLine("odległość pomiędzy wskaźnikami: {0}", (IntPtr)wskInt - (IntPtr)wskInt2);

    string tekst = "Ala ma kota";

    fixed (char* wskChar = tekst)
    {
        Console.WriteLine("{0}", *wskChar);
        Console.WriteLine("{0}", *(wskChar + 1));
        Console.WriteLine("{0}", *(wskChar + 2));
        Console.WriteLine("{0}", *(wskChar + 3));
        Console.WriteLine("{0}", *(wskChar + 4));
    }
}
