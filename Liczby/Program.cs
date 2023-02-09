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