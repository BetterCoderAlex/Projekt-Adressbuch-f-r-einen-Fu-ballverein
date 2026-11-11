// ========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Sponsors.cs
// Beschreibung: Verwaltet die Daten der Sponsoren
// Autor:    	 BetterCoderAlex
// Erstellt:     11.11.2026
// 
// History:      11.11.2026 Implementing the Sponsors Base
// =========================================================
namespace Library;

public class Sponsors
{
    private int nächsteSponsorID = 1;
    public int SponsorID{get;}
    private string _adresse;
    private string _PLZ;
    private string _firmenname;
    private string _firmenEmail;

    public Sponsors(string firmenname, string firmenemail){
        this._firmenname = firmenname;
        this._firmenEmail = firmenemail;
        SponsorID = nächsteSponsorID++;
    }

    public string getFirmenname()
    {
        return this._firmenname;
    }

    public string getFirmenEmail()
    {
        return this._firmenEmail;
    }

    public string ? firmenAdresse
    {
        get
        {
            if (this._adresse == null)
            {
                throw new NullReferenceException("Company Address can't be null!");
            }
            return this._adresse;
        }
        set
        {
          this._adresse = value;  
        }
    }

    public string ? firmenPLZ
    {
        get
        {
            if (this._PLZ == null)
            {
                throw new NullReferenceException("Company PLZ can't be null!");
            }
            return this._adresse;
        }
        set
        {
          this._PLZ = value;
        }
    }
}