uint liczba_calkowita = 23;

int liczba_calkowita_ze_znakiem = -23;

float liczba_rzeczywista = 2.3F;

double inna_liczba_rzeczywista = 2.3;

Console.WriteLine("{0},\n{1},\n{2},\n{3}", liczba_calkowita, liczba_calkowita_ze_znakiem, liczba_rzeczywista, inna_liczba_rzeczywista);

int notacja_dziesietna = 2_000_000;
int notacja_binarna = 0b_0001_1110_1000_0100_1000_0000;
int notacja_szesnastkowa = 0x_001E_8480;

Console.WriteLine("{0},\n{1},\n{2}", notacja_dziesietna, notacja_binarna, notacja_szesnastkowa);

Console.WriteLine($"{notacja_dziesietna == notacja_binarna}");
Console.WriteLine($"{notacja_dziesietna == notacja_szesnastkowa}");

Console.WriteLine($"Typ int zajmuje {sizeof(int)} bajtów i może przechowywać liczby z zakresu od {int.MinValue:N0} do {int.MaxValue:N0}.");
Console.WriteLine($"Typ double zajmuje {sizeof(double)} bajtów i może przechowywać liczby z zakresu od {double.MinValue:N0} do {double.MaxValue:N0}.");
Console.WriteLine($"Typ decimal zajmuje {sizeof(decimal)} bajtów i może przechowywać liczby z zakresu od {decimal.MinValue:N0} do {decimal.MaxValue:N0}.");

Console.WriteLine("Używanie liczb typu double:");

float a = 0.1F;
float b = 0.2F;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} jest równe 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} NIE jest równe 0.3");
}
Console.WriteLine(a + b);

Console.WriteLine("Korzystanie z liczb typu decimal:");

decimal c = 0.1M;
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} jest równe 0.3");
}
else
{
    Console.WriteLine($"{c} + {d} NIE jest równe 0.3");
}




Console.ReadKey();

// Output:
/*
 23,
-23,
2.3,
2.3
2000000,
2000000,
2000000
True
True
Typ int zajmuje 4 bajtó w i może przechowywać liczby z zakresu od -2,147,483,648 do 2,147,483,647.
Typ double zajmuje 8 bajtó w i może przechowywać liczby z zakresu od -179,769,313,486,231,570,814,527,423,731,704,356,798,070,567,525,844,996,598,917,476,803,157,260,780,028,538,760,589,558,632,766,878,171,540,458,953,514,382,464,234,321,326,889,464,182,768,467,546,703,537,516,986,049,910,576,551,282,076,245,490,090,389,328,944,075,868,508,455,133,942,304,583,236,903,222,948,165,808,559,332,123,348,274,797,826,204,144,723,168,738,177,180,919,299,881,250,404,026,184,124,858,368 do 179,769,313,486,231,570,814,527,423,731,704,356,798,070,567,525,844,996,598,917,476,803,157,260,780,028,538,760,589,558,632,766,878,171,540,458,953,514,382,464,234,321,326,889,464,182,768,467,546,703,537,516,986,049,910,576,551,282,076,245,490,090,389,328,944,075,868,508,455,133,942,304,583,236,903,222,948,165,808,559,332,123,348,274,797,826,204,144,723,168,738,177,180,919,299,881,250,404,026,184,124,858,368.
Typ decimal zajmuje 16 bajtó w i może przechowywać liczby z zakresu od -79,228,162,514,264,337,593,543,950,335 do 79,228,162,514,264,337,593,543,950,335.

Używanie liczb typu double:
0.1 + 0.2 NIE jest ró wne 0.3
 */