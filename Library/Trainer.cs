// ==========================================================
// Projekt:      Adressbuch für den Fußballverein Weiz
// Datei:        Trainer.cs
// Beschreibung: Verwaltet Trainer und deren Daten.
// Autor:    	 BetterCoderAlex
// Erstellt:     18.11.2026
// 
// History: 	 18.11.2026 Creating the Base for the Trainers
// ===========================================================

namespace Library;
public class Trainer
{
    private string _vorname;
    private string _nachname;
    private string? _adresse;
    private string? _PLZ;
    private string? _email;
    private string? _telefonnummer;
    private int nächsteTrainerID = 1;
    public int TrainerID{get;}

    public Trainer(string Vorname, string Nachname){
        this._vorname = Vorname;
        this._nachname = Nachname;
        TrainerID = nächsteTrainerID++;
    }

    public string getVorname()
    {
        return this._vorname;
    }
    
    public string getNachname()
    {
        return this._nachname;
    }

    public string? Adresse
    {
        get
        {
            if(this._adresse == null)
            {
                throw new NullReferenceException("Adress can't be null here");
            }
            return this._adresse;
        }
        set
        {
            _adresse = value;
        }
    }

    public string PLZ
    {
        get
        {
            if(this._PLZ == null)
            {
                throw new NullReferenceException("PLZ can't ne null here");
            }
            return this._PLZ;
        }
        set
        {
            _PLZ = value;
        }
    }    

    public string? Telefonnummer
    {
        get
        {
            return _telefonnummer;
        }
        set
        {
           this._telefonnummer = value;
        }
    }

    public string? Email
    {
        get
        {
            return _email;
        }
        set
        {
           this._email = value;
        }
    }
}