using TECHCOOL.UI;
namespace ERP;

public class KundeInfoScreen(Kunde kunde) : Screen
{
    public override string Title { get; set; } = "Detaljer for " + kunde.FuldeNavn;
    private readonly Kunde Kunde = kunde;

    protected override void Draw()
    {
        ExitOnEscape();
        Console.WriteLine($"Fulde navn: {Kunde.FuldeNavn}\n" +
                    $"VejNavn: {Kunde.VejNavn} " +
                    $"Vejnummer: {Kunde.VejNummer} " +
                    $"Postnummer: {Kunde.PostNummer}\n" +
                    $"Dato for sidste køb: {Kunde.SidsteKøb}\n");
    }
}
