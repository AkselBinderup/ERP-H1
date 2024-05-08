using TECHCOOL.UI;
namespace ERP;

public class ProduktRedigering : Screen
{
	public override string Title { get; set; } = "Produkt redigering";
	Produkt Produkt = new();
	public ProduktRedigering(Produkt produkt)
	{
		Title = "Redigerer for" + produkt.Navn;
		Produkt = produkt;
	}
	
	protected override void Draw()
	{
		ExitOnEscape();
		Form<Produkt> form = new Form<Produkt>();

        form.TextBox("Varenummer", nameof(Produkt.VareNummer));
        form.TextBox("Navn", nameof(Produkt.Navn));
        form.TextBox("Beskrivelse", nameof(Produkt.Beskrivelse));
        form.TextBox("Salgspris", nameof(Produkt.SalgsPris));
        form.TextBox("Indkøbspris", nameof(Produkt.IndkøbsPris));
        form.TextBox("Lokation", nameof(Produkt.Lokation));
        form.TextBox("Antal på Lager", nameof(Produkt.AntalLager));
        form.TextBox("Enhed", nameof(Produkt.Enhed));

		if (form.Edit(Produkt))
		{
			//if (Produkt.Id != 0)
			//{
			//    database.Update(Produkt);
			//}
			//else
			//{
			//    database.Create(Produkt);
			//}
			Console.WriteLine("Ændringerne blev gemt");
		}
		else
		{
			Console.WriteLine("Ingen ændringer");
		}
	}

}
