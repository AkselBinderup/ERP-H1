using TECHCOOL.UI;

namespace ERP;

class SalgsOrdreDetaljer(SalgsOrdreHoved salgsOrdreHoved) : Screen
{
    public override string Title { get; set; } = "Detaljer for Odrenummer " + salgsOrdreHoved.OrdreNummer;
    private readonly SalgsOrdreHoved SalgsOrdreHoved = salgsOrdreHoved;

    protected override void Draw()
    {
        ExitOnEscape();

        Console.WriteLine($"Ordre Nummer: {SalgsOrdreHoved.KundeNummer}\n" +
            $"Oprettelses tidspunkt: {SalgsOrdreHoved.OprettelsesTidspunkt}\n" +
            $"gennemført tidspunkt: {SalgsOrdreHoved.GennemførelsesTidspunkt}\n" +
            $"Kunde nummer: {SalgsOrdreHoved.KundeNummer} \n" +
            $"Fulde navn: {SalgsOrdreHoved.FuldeNavn} \n"
            );
        if(SalgsOrdreHoved.Produkt!= null)
        {
            Console.WriteLine(
            $"Produkt detaljer:" +
            $"Navn: {SalgsOrdreHoved.Produkt.Navn} \n" +
            $"Beskrivelse: {SalgsOrdreHoved.Produkt.Beskrivelse}\n" +
            $"Salgsspris: {SalgsOrdreHoved.Produkt.SalgsPris}\n" +
            $"Indkøbspris: {SalgsOrdreHoved.Produkt.IndkøbsPris}\n" +
            $"Lokation: {SalgsOrdreHoved.Produkt.Lokation}\n" +
            $"Antal på lager: {SalgsOrdreHoved.Produkt.AntalLager}\n" +
            $"Enhed: {SalgsOrdreHoved.Produkt.Enhed}");
        }
        //Console.WriteLine($"Varenummer: {Produkt.VareNummer}\n" +
        //                  $"Navn: {Produkt.Navn}\n" +
        //                  $"Beskrivelse: {Produkt.Beskrivelse}\n" +
        //                  $"Salgsspris: {Produkt.SalgsPris}\n" +
        //                  $"Indkøbspris: {Produkt.IndkøbsPris}\n" +
        //                  $"Lokation: {Produkt.Lokation}\n" +
        //                  $"Antal på lager: {Produkt.AntalLager}\n" +
        //                  $"Enhed: {Produkt.Enhed}\n" +
        //                  $"Avance i Procent: {Produkt.Avance}\n" +
        //                  $"Avance i kr: {Produkt.BeregnFortjeneste()}\n");

    }
}
