using TECHCOOL.UI;
namespace ERP;

public class KundeInfoScreen : Screen
{
    public override string Title { get; set; } = "Kunde info";
    public Kunde Kunde = new();
    public KundeInfoScreen(Kunde kunde)
    {
        Title = "Detaljer for " + kunde.FuldeNavn;
        this.Kunde = kunde;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Console.WriteLine($"Fulde navn: {Kunde.FuldeNavn}\n" +
                    $"Addresse: {Kunde.Adresse.VejNavn} " +
                    $"{Kunde.Adresse.VejNummer} " +
                    $"{Kunde.Adresse.PostNummer}\n" +
                    $"Dato for sidste køb: {Kunde.SidsteKøb}\n");
    }
}
