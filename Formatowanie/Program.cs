using static System.Console;
// Added System.Console - no need to use Console.WriteLine


int liczba_jablek = 12;
decimal cena_jablka = 0.25M;

WriteLine(
    format: "{0} jablek kosztuje {1:C}",
    arg0: liczba_jablek,
    arg1: cena_jablka * liczba_jablek);

string sformatowane = string.Format(
    format: "{0} jabłek kosztuje {1:C}",
    arg0: liczba_jablek,
    arg1: cena_jablka * liczba_jablek);

WriteLine(sformatowane);

// Output:
/*
 12 jablek kosztuje $3.00
 12 jabłek kosztuje $3.00
 */

WriteLine($"{liczba_jablek} jabłek kosztuje {cena_jablka * liczba_jablek:C}.");
// Output:
// 12 jabłek kosztuje $3.00.

string tekst_jablka = "Jabłka";
int ilosc_jablek = 1234;
string tekst_banany = "Banany";
int ilosc_banany = 56789;

WriteLine(
    format: "{0, -8} {1,6:N0}",
    arg0: "Nazwa",
    arg1: "Liczba");

WriteLine(
    format: "{0, -8} {1,6:N0}",
    arg0: tekst_jablka,
    arg1: ilosc_jablek);

WriteLine(
    format: "{0, -8} {1, 6:N0}",
    arg0: tekst_banany,
    arg1: ilosc_banany);

// Output:
/*
Nazwa    Liczba
Jabłka    1,234
Banany   56,789
 */

Write("Wpisz swoje imię i naciśnij ENTER:");
string imie = ReadLine();


Write("Podaj swój wiek i naciśnij ENTER:");
string wiek = ReadLine();

WriteLine($"Cześć, {imie}, dobrze wyglądasz jak na {wiek} lat.");

// Output:
/*
Wpisz swoje imię i naciśnij ENTER:Astryda
Podaj swó j wiek i naciśnij ENTER:30
Cześć, Astryda, dobrze wyglądasz jak na 30 lat.
 */

Write("Naciśnij dowolną sekwencję klawiszy:");
ConsoleKeyInfo klawisz = ReadKey();

WriteLine();
WriteLine("Klawisz: {0}, znak: {1}, modyfikatory: {2}.",
    arg0: klawisz.Key,
    arg1: klawisz.KeyChar,
    arg2: klawisz.Modifiers);

// Output:
/*
Naciśnij dowolną sekwencję klawiszy:K
Klawisz: K, znak: K, modyfikatory: Shift.
 */

