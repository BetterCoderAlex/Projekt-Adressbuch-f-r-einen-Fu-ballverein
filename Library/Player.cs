
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
    private string _vorname;
    private string _nachname;
    private string ? _adresse;
    private string ? _telefonnummer;
    private string ? _PLZ;
    private string ? _rückennummer;
    private static int nächsteSpielerID = 1;

    public int SpielerID{get;}
    public Player(string Vorname, string Nachname)
    {   
        _vorname = Vorname;
        _nachname = Nachname;
        SpielerID = nächsteSpielerID++;
    }

    public string GetVorname()
    {
        return this._vorname;
    }
    public string GetNachname()
    {
        return this._nachname;
    }

    public string ? Adresse {
        get
        {
            if (_adresse == null)
            {
                throw new NullReferenceException("Adress mustn`t be null");
            }
            return _adresse;
        }
        set
        {
            _adresse = value;
        }
    }
    public string ? Telefonnummer
    {
        get
        {
            if (_telefonnummer == null)
            {
                Console.WriteLine($"Player {_nachname} doesnt have a Phonenumber");
            }
            return _telefonnummer;
        }
        set
        {
            _telefonnummer = value;  
        }
    }
    public string PLZ
    {
        get
        {
            if (_PLZ == null)
            {
                throw new NullReferenceException("PLZ mustn`t be null");
            }
            return _PLZ;
        }
        set
        {
            
            _PLZ = value;
        }
    }
    public string ? Rückennummer
    {
        get
        {
            if (_rückennummer == null)
            {
                Console.WriteLine($"Player {_nachname} doenst have a Playernumber yet");
            }
            return _rückennummer;
        }
        set
        {
            _rückennummer = value;
        }
    }

}
