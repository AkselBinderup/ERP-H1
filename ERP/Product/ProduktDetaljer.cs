using TECHCOOL.UI;


namespace ERP;

public partial class ProductDetaljer : Screen
{
    public override string Title { get; set; } = "Informationer";
    private Produkt Produkt;

    public ProductDetaljer(Produkt produkt)
    {
        Title = "Detaljer for " + produkt.Navn;
        Produkt = produkt;
    }

    protected override void Draw()
    {
        ExitOnEscape();

        Console.WriteLine($"Varenummer: {Produkt.VareNummer}\n" +
                          $"Navn: {Produkt.Navn}\n" +
                          $"Beskrivelse: {Produkt.Beskrivelse}\n" +
                          $"Salgsspris: {Produkt.SalgsPris}\n" +
                          $"Indkøbspris: {Produkt.IndkøbsPris}\n" +
                          $"Lokation: {Produkt.Lokation}\n" +
                          $"Antal på lager: {Produkt.AntalLager}\n" +
                          $"Enhed: {Produkt.Enhed}\n" +
                          $"Avance i Procent: {Produkt.Avance}\n" +
                          $"Avance i kr: {Produkt.BeregnFortjeneste()}\n");
    }
}
