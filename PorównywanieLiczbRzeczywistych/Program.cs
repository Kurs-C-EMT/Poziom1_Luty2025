// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a = 0.3;
double b = 0.1 + 0.1 + 0.1;

double epsilon = 0.0001;

if(a == b)
{
    Console.WriteLine("a == b");
} else
{
    Console.WriteLine("{0} != {1:f3}", a, b);
    double bZaokrąglone = Math.Round(b, 3);
    Console.WriteLine("{0} != {1}", a, bZaokrąglone);
}

if (Math.Abs(a - b) < epsilon)
{
    Console.WriteLine("a == b");
}
else
{
    Console.WriteLine("{0} != {1}", a, b);
}