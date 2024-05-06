namespace ERP;

public class SalgsOrdreHoved : Kunde
{
    public int OrdreNummer { get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public float Ordrebeløb { get; set; }
    public Tilstand Tilstand { get; set; }
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }

    public SalgsOrdreHoved() { }
    public SalgsOrdreHoved(
        string fornavn, string efternavn, Adresse adresse, string emailAdresse, int telefonNummer, DateTime sidsteKøb,
        int ordreNummer, DateTime oprettelseTid, DateTime gennemførtTid, int kundeNummer, Tilstand tilstand, float ordreBeløb
    )
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
        Adresse = adresse;
        EmailAdresse = emailAdresse;
        TelefonNummer = telefonNummer;
        SidsteKøb = sidsteKøb;
        OrdreNummer = ordreNummer;
        OprettelsesTidspunkt = oprettelseTid;
        GennemførelsesTidspunkt = gennemførtTid;
        KundeNummer = kundeNummer;
        Tilstand = tilstand;
        Ordrebeløb = ordreBeløb;

    }


}
