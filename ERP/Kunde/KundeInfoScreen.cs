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
                    $"Adresse: {Kunde.Adresse.VejNavn} " +
                    $"{Kunde.Adresse.VejNummer} " +
                    $"{Kunde.Adresse.PostNummer}\n" +
                    $"Dato for sidste køb: {Kunde.SidsteKøb}\n");
    }
}
