// See https://aka.ms/new-console-template for more information
using System.Reflection;

//Console.WriteLine();

//Console.WriteLine("Witaj, Astrydziu");

//Console.WriteLine("Dnia {0:D} temperatura wynosi {1}oC.", DateTime.Today, -4);
System.Data.DataSet ds;
HttpClient client;

Assembly? zestaw = Assembly.GetEntryAssembly();
if (zestaw == null) return;

foreach (AssemblyName nazwa in zestaw.GetReferencedAssemblies())
{
    var a = Assembly.Load(nazwa);
    int liczba_metod = 0;

    foreach (var t in a.DefinedTypes)
    {
        liczba_metod += t.GetMethods().Count();
    }

    Console.WriteLine(
        "W zestawie {0} jest {1:N0} typów i {2:N0} metod.",
        arg0: nazwa.Name,
        arg1: a.DefinedTypes.Count(),
        arg2: liczba_metod);
}
Console.ReadKey();

//Output:
/*
W zestawie System.Runtime jest 0 typó w i 0 metod.
W zestawie System.Data.Common jest 400 typó w i 7,038 metod.
W zestawie System.Net.Http jest 429 typó w i 4,650 metod.
W zestawie System.Linq jest 108 typó w i 1,141 metod.
W zestawie System.Console jest 54 typó w i 676 metod.
*/

double wysokosc_w_metrach = 1.88;
Console.WriteLine($"Zmienna {nameof(wysokosc_w_metrach)} ma wartość {wysokosc_w_metrach}");