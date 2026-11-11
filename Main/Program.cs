// ========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Main.cs
// Beschreibung: Verwaltet Kunden und deren Daten.
// Autor:    	 BetterCoderAlex
// Erstellt:     04.11.2026
// 
// History: 	 04.11.2026 Testing Player Base
// History:      11.11.2026 Testing the Sponsors Base
// =========================================================
using Library;
using System.IO;
using System.Text;

public class Programtest1
{
    public static int Main(string[] args)
    {
        // path to where the information gets saved
        string path_p = "../Vereinskontakte/Players.txt";
        string path_s = "../Vereinskontakte/Sponsors.txt";

        // Player are created here
        Player player_1 = new Player("Alexander", "Preinsberger");
        player_1.Adresse = "Musterstraße 123";
        player_1.PLZ = "8224";
        player_1.Rückennummer = "10";
        player_1.Telefonnummer = "+43 664 12345678";

        Player player_2 = new Player("Nikolai", "Andrejek");
        player_2.Adresse = "Musterstraße 321";
        player_2.PLZ = "8243";
        player_2.Rückennummer = "11";
        player_2.Telefonnummer = "+43 664 21345678";

        List<Player> players = new();
        players.Add(player_1);
        players.Add(player_2);

        Sponsors Knapp = new Sponsors("Knapp", "kin.office@knapp.com");

        List<Sponsors> sponsors = new();

        var text = new StringBuilder();

        text.AppendLine(
            "SpielerID".PadRight(11) +
            "Vorname".PadRight(15) +
            "Nachname".PadRight(17) +
            "Rückennummer".PadRight(15) +
            "PLZ".PadRight(8) +
            "Adresse"
        );

            text.AppendLine();

        foreach(Player player in players)
        {
            text.AppendLine(
                $"{player.SpielerID.ToString().PadRight(11)}" +
                $"{(player.GetVorname() ?? "-").PadRight(15)}" +
                $"{(player.GetNachname() ?? "-").PadRight(17)}" +
                $"{(player.Rückennummer ?? "-").PadRight(15)}" +
                $"{(player.PLZ ?? "-").PadRight(8)}" +
                $"{player.Adresse ?? "-"}"
            );
                text.AppendLine();
        }
        
        File.WriteAllText(path_p, text.ToString());
        return 0;
    }
    
}
