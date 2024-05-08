using TECHCOOL.UI;

namespace ERP;

class SalgsOrdreDetaljer : Screen
{
	public override string Title { get; set; } = "Salgs Ordre Hoveder";
	SalgsOrdreHoved SalgsOrdreHoved = new();
	public SalgsOrdreDetaljer(SalgsOrdreHoved salgsOrdreHoved)
	{
		Title = "Detaljer for Odrenummer " + salgsOrdreHoved.OrdreNummer;
		SalgsOrdreHoved = salgsOrdreHoved;
	}

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
