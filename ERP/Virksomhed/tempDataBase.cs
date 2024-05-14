namespace ERP;

public class TempDataBase
{
    List<Virksomhed> Virksomheder = new() {
            new Virksomhed {Id = 1, FirmaNavn = "Techcollege ", Vej = "Årestrupsvej", HusNummer = "2", PostNummer = "9000", By = "Aalborg", Land = "Danmark", Valuta = Currency.DKK },
            new Virksomhed {Id = 2, FirmaNavn = "Lichtenstein PD", Vej = "Årestrupsvej", HusNummer = "2", PostNummer = "9000", By = "Aalborg", Land = "Lichenstein", Valuta = Currency.SEK}
    };

    public List<Virksomhed> GetData()
    {
        List<Virksomhed> data = new List<Virksomhed>();

        data.AddRange(Virksomheder);
        return data;
    }
    public List<Produkt> GetProducts()
    {
        List<Produkt> data = new List<Produkt>();

        data.AddRange(Produkter);
        return data;
    }

    List<Produkt> Produkter = new()
    {
        new Produkt {VareNummer = 1, Navn ="produkt lol",Beskrivelse ="hehehoho", SalgsPris = 808,IndkøbsPris = 490,Lokation = "karl's hus",AntalLager = 88,Enhed = Enheder.Timer}
    };
}
