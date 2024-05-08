using TECHCOOL.UI;
namespace ERP;

public class KundeInfoScreen : Screen
{
    public override string Title { get; set; } = "Kunde info";
    public Kunde kunde = new();
    public KundeInfoScreen(Kunde kunde)
    {
        Title = "Detaljer for " + kunde.FuldeNavn;
        this.kunde = kunde;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Console.WriteLine($"Fulde navn: {kunde.FuldeNavn}\n" +
                    $"Addresse: {kunde.Adresse.VejNavn} " +
                    $"{kunde.Adresse.VejNummer} " +
                    $"{kunde.Adresse.PostNummer}\n" +
                    $"Dato for sidste køb: {kunde.SidsteKøb}\n");
    }
}
