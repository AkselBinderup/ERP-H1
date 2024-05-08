namespace ERP;

public class Kunde : Person
{
    public int KundeNummer { get; set; }
    public DateTime SidsteKøb {  get; set; }


    public Kunde(
        int kundeNummer
        , string fornavn
        , string efternavn
        , Adresse adresse
        , string emailAdresse
        , int telefonNummer
        , DateTime sidsteKøb
        )
    {
        KundeNummer = kundeNummer;
        SidsteKøb = sidsteKøb;
        Fornavn = fornavn;
        Efternavn = efternavn;
        Adresse = adresse;
        EmailAdresse = emailAdresse;
        TelefonNummer = telefonNummer;
        SidsteKøb = sidsteKøb;
        
    }
}
