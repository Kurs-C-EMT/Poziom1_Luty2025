// See https://aka.ms/new-console-template for more information
using Druga;

Console.WriteLine("Hello, World 2!");
Console.ReadKey();


int a = 4;
int b = 5;

{
    int c = a;

    a = b;
    b = c;
}

TestEnum testEnum = TestEnum.Dwa;

int wartośćZEnum2;

switch(testEnum)
{
    case TestEnum.Jeden:
        wartośćZEnum2 = 1;
        break;
    case TestEnum.Dwa:
        wartośćZEnum2 = 2;
        break;
    case TestEnum.Trzy:
        wartośćZEnum2 = 3;
        break;
    default:
        wartośćZEnum2 = 0;
        break;
}

int wartośćZEnum = testEnum switch
{
    TestEnum.Trzy => 3,
    TestEnum.Dwa => 2,
    TestEnum.Jeden => 1,
    _ => 0
};

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

int? zmienna = 3;
int? zmienna2 = 4;

bool czyWartość = zmienna.HasValue;
int wynik = zmienna.HasValue && zmienna2.HasValue ? zmienna.Value + zmienna2.Value : 0;

if (zmienna.HasValue && zmienna2.HasValue)
{
    wynik = zmienna.Value + zmienna2.Value;
}
else
{
    wynik = 0;
}