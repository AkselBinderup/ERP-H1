using ERP;

namespace UnitTest;

public class KundeGenerelTest
{
    [Fact]
    public void KundeInfoScreenUnitTest()
    {
        Adresse adresseEksempel = new Adresse(vejNavn: "Struervej", 70, 9000);

        Kunde jon = new Kunde { KundeNummer = 1, Fornavn = "Jon", Efternavn = "Hedegaard", TelefonNummer = 88888888, EmailAdresse = "Jon@gmail.com", Adresse = adresseEksempel, SidsteKøb = DateTime.Now };

        KundeInfoScreen kunde = new KundeInfoScreen(jon);

        Assert.True(kunde.Title == "Detaljer for " + jon.FuldeNavn) ;
    }
    [Fact]
    public void KundeListeUnitTest()
    {

    }
}
