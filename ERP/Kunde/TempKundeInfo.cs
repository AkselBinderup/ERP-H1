namespace ERP;
public class TempKundeInfo
{
    public static Adresse AdresseEksempel = new Adresse("Struervej",70,"Aalborg", 9000);

    public List<Kunde> Kunder = new() {
        new Kunde {KundeNummer = 1, Fornavn = "Jon", Efternavn="Hedegaard", TelefonNummer = 88888888, EmailAdresse = "Jon@gmail.com",  Adresse = AdresseEksempel, SidsteKøb = DateTime.Now },
        new Kunde {KundeNummer = 2, Fornavn = "Aksel", Efternavn="Kristensen", TelefonNummer = 88888888, EmailAdresse = "Aksel@gmail.com", Adresse = AdresseEksempel, SidsteKøb = DateTime.Now },
        new Kunde {KundeNummer = 3, Fornavn = "Victor", Efternavn="Frandsen", TelefonNummer = 88888888, EmailAdresse = "Victor@gmail.com", Adresse = AdresseEksempel, SidsteKøb = DateTime.Now }
    };

    public List<Kunde> GetData()
    {
        List<Kunde> data = new List<Kunde>();
        data.AddRange(Kunder);
        return data;
    }
}

