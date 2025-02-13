// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//for(int i = 0; i < 100; i++)
//{
//    Console.WriteLine("Synchroniczna: {0}", i);
//    Thread.Sleep(100);
//}

string a = "";
var opcje = new ParallelOptions();
opcje.MaxDegreeOfParallelism = Environment.ProcessorCount;

string katalog = Environment.CurrentDirectory;
Console.WriteLine("Katlog {0}", katalog);

//Parallel.For(0, 1000, opcje, i =>
//{
//    lock (a)
//    {
//        a = i.ToString();
//        Console.WriteLine("Asynchroniczna: {0}", a);
//    }
    
//    Thread.Sleep(100);
//});

a = "";