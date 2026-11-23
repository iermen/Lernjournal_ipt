string artikelname;
decimal einzelpreis;
int menge;
 
decimal zwischentotal;
decimal rabattProzent;
decimal rabattbetrag;
decimal endtotal;
 
// Eingaben
Console.WriteLine("Artikelname eingeben:");
artikelname = Console.ReadLine();
 
Console.WriteLine("Einzelpreis eingeben:");
einzelpreis = decimal.Parse(Console.ReadLine());
 
Console.WriteLine("Menge eingeben:");
menge = int.Parse(Console.ReadLine());
 
// Menge überprüfen
if (menge < 1)
{
    Console.WriteLine("Fehler: Ungültige Menge!");
}
else
{
    // Zwischentotal berechnen
    zwischentotal = einzelpreis * menge;
 
    // Rabatt bestimmen
    if (menge >= 5)
    {
        rabattProzent = 20;
    }
    else if (menge >= 3)
    {
        rabattProzent = 10;
    }
    else
    {
        rabattProzent = 0;
    }
 
    // Rabattbetrag und Endtotal berechnen
    rabattbetrag = zwischentotal * rabattProzent / 100;
    endtotal = zwischentotal - rabattbetrag;
 
    // Kassenbeleg ausgeben
    Console.WriteLine("----- Kassenbeleg -----");
    Console.WriteLine("Artikel: " + artikelname);
    Console.WriteLine("Einzelpreis: CHF " + einzelpreis);
    Console.WriteLine("Menge: " + menge);
    Console.WriteLine("Zwischentotal: CHF " + zwischentotal);
    Console.WriteLine("Rabatt: " + rabattProzent + "%");
    Console.WriteLine("Rabattbetrag: CHF " + rabattbetrag);
    Console.WriteLine("Endtotal: CHF " + endtotal);
}