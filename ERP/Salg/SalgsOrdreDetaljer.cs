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
    }
}
