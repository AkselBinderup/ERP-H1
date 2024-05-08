using TECHCOOL.UI;


namespace ERP;

public partial class ProductDetaljer : Screen
{
    public override string Title { get; set; } = "Informationer";
    private Produkt produkt;
    public ProductDetaljer(Produkt produkt)
    {
        Title = "Detaljer for " + produkt.Navn;
        this.produkt = produkt;
    }
    protected override void Draw()
    {
        ExitOnEscape();

        Console.WriteLine($"Varenummer: {produkt.VareNummer}\n" +
                          $"Navn: {produkt.Navn}\n" +
                          $"Beskrivelse: {produkt.Beskrivelse}\n" +
                          $"Salgsspris: {produkt.SalgsPris}\n" +
                          $"Indkøbspris: {produkt.IndkøbsPris}\n" +
                          $"Lokation: {produkt.Lokation}\n" +
                          $"Antal på lager: {produkt.AntalLager}\n" +
                          $"Enhed: {produkt.Enhed}\n" +
                          $"Avance i Procent: {produkt.BeregnAvanceProcent}\n" +
                          $"Avance i kr: {produkt.BeregnFortjeneste()}\n");
    }


}
