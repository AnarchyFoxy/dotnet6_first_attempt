// See https://aka.ms/new-console-template for more information
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

Console.ReadKey();