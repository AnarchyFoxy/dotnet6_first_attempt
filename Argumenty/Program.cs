using static System.Console;

WriteLine($"Otrzymano {args.Length} argumentów");
// Output:
// Otrzymano 0 argumentów

if (args.Length < 3)
{
    WriteLine("Musisz podać dwa kolory oraz wielkość kursora, np.:");
    WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch(PlatformNotSupportedException)
{
    WriteLine("Aktualna platforma nie pozwala na zmianę wielkości kursora.");
}


//Write(
//    format: "{0, -8} {1,6} {2, 6} {3, 6}",
//    arg0: "Typ",
//    arg1: "wielkość",
//    arg2: "Min");

//WriteLine($"Typ int zajmuje {sizeof(int)} bajtów i może przechowywać liczby z zakresu od {int.MinValue:N0} do {int.MaxValue:N0}.");