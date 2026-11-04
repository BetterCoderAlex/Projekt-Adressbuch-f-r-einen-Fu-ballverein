
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
    private string ? _Adresse;
    private string ? _Telefonnummer;
    private string ? _PLZ;
    private string ? _RückenNummer;
    private static int nächsteSpielerID = 1;

    public int SpielerID{get;}
    public Player(string Vorname, string Nachname)
    {   
        _Vorname = Vorname;
        _Nachname = Nachname;
        SpielerID = nächsteSpielerID++;
    }

    public string GetVorname()
    {
        return this._Vorname;
    }
    public string GetNachname()
    {
        return this._Nachname;
    }

    public string ? Adresse {
        get
        {
            if (_Adresse == null)
            {
                throw new NullReferenceException("Adress mustn`t be null");
            }
            return _Adresse;
        }
        set
        {
            _Adresse = value;
        }
    }
    public string ? Telefonnummer
    {
        get
        {
            if (_Telefonnummer == null)
            {
                Console.WriteLine($"Player {_Nachname} doesnt have a Phonenumber");
            }
            return _Telefonnummer;
        }
        set
        {
            _Telefonnummer = value;  
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
            if (_RückenNummer == null)
            {
                Console.WriteLine($"Player {_Nachname} doenst have a Playernumber yet");
            }
            return _RückenNummer;
        }
        set
        {
            _RückenNummer = value;
        }
    }

}
