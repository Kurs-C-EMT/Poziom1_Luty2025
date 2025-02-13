// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while (true)
{
    string tekst = Console.ReadLine();
    bool czySukces = int.TryParse(tekst, out int liczba);
    if (czySukces)
    {
        Console.WriteLine(liczba);
    }
    else
    {
        Console.WriteLine("Podano nieprawidłową liczbę");
    }
}
