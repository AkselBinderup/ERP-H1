using TECHCOOL.UI;

namespace ERP;

class SalgsOrdreDetaljer : Screen
{
	public override string Title { get; set; } = "Salgs Ordre Hoveder";
	SalgsOrdreHoved salgsOrdreHoved = new();
	public SalgsOrdreDetaljer(SalgsOrdreHoved salgsOrdreHoved)
	{
		Title = "Detaljer for Odrenummer " + salgsOrdreHoved.OrdreNummer;
		this.salgsOrdreHoved = salgsOrdreHoved;
	}

	protected override void Draw()
	{
		ExitOnEscape();

		Console.WriteLine($"Ordre Nummer: {salgsOrdreHoved.KundeNummer}\n" +
			$"Oprettelses tidspunkt: {salgsOrdreHoved.OprettelsesTidspunkt}\n" +
			$"gennemført tidspunkt: {salgsOrdreHoved.GennemførelsesTidspunkt}\n" +
			$"Kunde nummer: {salgsOrdreHoved.KundeNummer} \n" +
			$"Fulde navn: {salgsOrdreHoved.FuldeNavn} \n"
			);

	}
}
