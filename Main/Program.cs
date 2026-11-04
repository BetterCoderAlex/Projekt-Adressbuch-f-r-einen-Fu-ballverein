// ========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Main.cs
// Beschreibung: Verwaltet Kunden und deren Daten.
// Autor:    	 BetterCoderAlex
// Erstellt:     04.11.2026
// 
// History: 	 04.11.2026 Testing Player Base
// =========================================================
using Library;

public class Programtest1
{
    public static int Main(string[] args)
    {
        Player player_1 = new Player("Alexander", "Preinsberger");
        player_1.Adresse = "Musterstraße 123";
        player_1.PLZ = "8224";
        player_1.Rückennummer = 10;
        player_1.Telefonnummer = "+43 664 12345678";

        Player player_2 = new Player("Nikolai", "Andrejek");
        
        Console.WriteLine(player_1.Adresse);
        Console.WriteLine(player_2.Adresse);
        return 0;
    }
    
}
