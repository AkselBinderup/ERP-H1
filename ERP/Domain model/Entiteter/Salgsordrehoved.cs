using System.Diagnostics.CodeAnalysis;

namespace ERP;
public class SalgsOrdreHoved : Kunde
{
    public int OrdreNummer { get; private set; }
    public DateTime? OprettelsesTidspunkt { get; private set; }
    public DateTime? GennemførelsesTidspunkt { get; private set; }
    public float Ordrebeløb { get; private set; }
    public Tilstand? Tilstand { get; private set; }
    public List<SalgsOrdreLinje>? OrdreLinjer { get; private set; }

    public SalgsOrdreHoved() { }

    //tilføjet til at kunne vælge bruger fra liste med tidligere data
    public SalgsOrdreHoved(Kunde kunde)
    {
        Fornavn = kunde.Fornavn;
        Efternavn = kunde.Efternavn;
        Adresse = kunde.Adresse;
        Email = kunde.Email;
        TelefonNummer = kunde.TelefonNummer;
        SidsteKøb = kunde.SidsteKøb;
        KundeId = kunde.KundeId;
    }
    public SalgsOrdreHoved(
        string fornavn, string efternavn, Adresse adresse, string emailAdresse, int telefonNummer, DateTime sidsteKøb,
        int ordreNummer, DateTime oprettelseTid, DateTime gennemførtTid, int kundeNummer, Tilstand tilstand, float ordreBeløb
    )
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
        Adresse = adresse;
        Email = emailAdresse;
        TelefonNummer = telefonNummer;
        SidsteKøb = sidsteKøb;
        OrdreNummer = ordreNummer;
        OprettelsesTidspunkt = oprettelseTid;
        GennemførelsesTidspunkt = gennemførtTid;
        KundeId = kundeNummer;
        Tilstand = tilstand;
        Ordrebeløb = ordreBeløb;
    }
}
