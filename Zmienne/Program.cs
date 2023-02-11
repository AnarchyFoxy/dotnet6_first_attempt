using System.Xml;

object wysokosc = 1.84;
object imie = "Astryda";
Console.WriteLine($"{imie} ma {wysokosc} centymetrów wzrostu");

//int dlugosc1 = imie.Length;
int dlugosc2 = ((string)imie).Length;
Console.WriteLine($"{imie} ma {dlugosc2} znaków");

/*
 Astryda ma 1.84 centymetrów wzrostu
 Astryda ma 7 znaków
*/

dynamic cos = "Astryda";
cos = 12;
cos = new[] { 3, 5, 7 };

Console.WriteLine($"Długość to {cos.Length}");
/*
 * Dł ugość to 3
 */

var populacja = 38_000_000;
var waga = 1.88;
var cena = 4.99M;
var owoce = "Jabłka";
var litera = 'Z';
var radosc = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

//var plik1 = File.CreateText(@"/plik.txt");
//StreamWriter plik2 = File.CreateText(@"/plik.txt");

XmlDocument xml3 = new();

//class Individual
//{
//    public DateTime BirthTime;
//}

//Individual Astryda = new();
//Astryda.BirthTime(1992, 03, 16);

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");
//Output:
/*
 default(int) = 0
 default(bool) = False
 default(DateTime) = 1/1/0001 12:00:00 AM
 default(string) =
 */

int liczba = 31;
Console.WriteLine($"Zmienna liczba ma wartość {liczba}");
liczba = default;
Console.WriteLine($"Teraz zmienna liczba ma wartość: {liczba}");
// Output:
/*
 * Zmienna liczba ma wartość 31
Teraz zmienna liczba ma wartość: 0
 */

string[] imiona;

imiona = new string[4];

imiona[0] = "Astryda";
imiona[1] = "Astrydzia";
imiona[2] = "Gazela";
imiona[3] = "Gazelka";

for (int i = 0; i < imiona.Length; i++)
{
    Console.WriteLine(imiona[i]);
}
// Output:
/*
Astryda
Astrydzia
Gazela
Gazelka
*/



Console.ReadKey();