
// ========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Player.cs
// Beschreibung: Verwaltet Daten von Spielern
// Autor:    	 BetterCoderAlex
// Erstellt:     04.11.2026
// 
// History: 	 04.11.2026 Grundbaustein des Spielers
// =========================================================

namespace Library;

public class Player
{
    private string _Vorname;
    private string _Nachname;
    private string _Adresse;
    private string ? _Telefonnummer;
    private string _PLZ;
    private string ? _RückenNummer;
    private static int nächsteSpielerID = 1;

    public int SpielerID{get;}
    public Player(string Vorname, string Nachname)
    {   
        _Vorname = Vorname;
        _Nachname = Nachname;
        SpielerID = nächsteSpielerID++;
    }

    public string Adresse {get;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Adress mustn`t be null");
            }
            _Adresse = value;
        }
    }
    public string Telefonnummer {get;
        set
        {
          if (value == null)
            {
                Console.WriteLine($"Player {_Nachname} doesnt have a Phonenumber");
            }
            _Telefonnummer = value;  
        }
    }
    public string PLZ {get;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("PLZ mustn`t be null");
            }
            _PLZ = value;
        }
    }
    public string Rückennummer {get;
        set
        {
            if (value == "")
            {
                Console.WriteLine($"Player {_Nachname} doenst have a Playernumber yet");
            }
            else
            {
            _RückenNummer = value;
            }
        }
    }

}
