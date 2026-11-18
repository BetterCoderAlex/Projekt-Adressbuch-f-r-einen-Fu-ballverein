// ========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Main.cs
// Beschreibung: Verwaltet Kunden und deren Daten.
// Autor:    	 BetterCoderAlex
// Erstellt:     04.11.2026
// 
// History: 	 04.11.2026 Testing Player Base (BCA)
// History:      11.11.2026 Testing the Sponsors Base (BCA)
// History:      18.11.2026 Testing the File Writing (BCA)
// =========================================================
using Library;
using System.Text;

public class Programtest1
{
    public static int Main(string[] args)
    {
        // path to where the information gets saved
        string path_p = "../Vereinskontakte/Players.txt";
        string path_s = "../Vereinskontakte/Sponsors.txt";
        string path_t = "../Vereinskontakte/Trainer.txt";

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
        Knapp.firmenAdresse = "Günter-Knapp-Straße 5-7";
        Knapp.firmenPLZ = "8075 Hart bei Graz";

        Sponsors Reifeisen = new Sponsors("Reifeisen", "direct@raiffeisen.ch");
        Reifeisen.firmenAdresse = "Stadtpark 9";
        Reifeisen.firmenPLZ = "1030 Wien";

        List<Sponsors> sponsors = new();
        sponsors.Add(Knapp);
        sponsors.Add(Reifeisen);

        Trainer trainer_1 = new Trainer("Adolf", "Brückler");
        trainer_1.Adresse = "Straße Muster 91375";
        trainer_1.PLZ = "8364";
        trainer_1.Telefonnummer = "+43 664 7654312";
        
        Trainer trainer_2 = new Trainer("Eva", "Teichtal");
        trainer_2.Adresse = "Baumweg 12";
        trainer_2.PLZ = "1982";
        trainer_2.Email = "eva.teichtal@example.com";

        var text_t = new StringBuilder();

        var text_s = new StringBuilder();

        text_s.AppendLine(
            "SponsorID".PadRight(11) +
            "Firmenname".PadRight(15) +
            "Firmenemail".PadRight(25) +
            "Firmenadresse".PadRight(20) +
            "FirmenPLZ"
        );

        text_s.AppendLine();

        foreach (Sponsors s in sponsors){
            text_s.AppendLine(
                $"{s.SponsorID.ToString().PadRight(11)}" +
                $"{s.getFirmenname().PadRight(15)}" +
                $"{s.getFirmenEmail().PadRight(25)}" +
                $"{s.firmenAdresse.PadRight(20)}" +
                $"{s.firmenPLZ}"
            );
            text_s.AppendLine();
        }

        var text_p = new StringBuilder();

        text_p.AppendLine(
            "SpielerID".PadRight(11) +
            "Vorname".PadRight(15) +
            "Nachname".PadRight(17) +
            "Rückennummer".PadRight(15) +
            "PLZ".PadRight(8) +
            "Adresse"
        );

            text_p.AppendLine();

        foreach(Player player in players)
        {
            text_p.AppendLine(
                $"{player.SpielerID.ToString().PadRight(11)}" +
                $"{(player.GetVorname() ?? "-").PadRight(15)}" +
                $"{(player.GetNachname() ?? "-").PadRight(17)}" +
                $"{(player.Rückennummer ?? "-").PadRight(15)}" +
                $"{(player.PLZ ?? "-").PadRight(8)}" +
                $"{player.Adresse ?? "-"}"
            );
                text_p.AppendLine();
        }
        
        File.WriteAllText(path_p, text_p.ToString());
        File.WriteAllText(path_s, text_s.ToString());
        return 0;
    }
    
}
