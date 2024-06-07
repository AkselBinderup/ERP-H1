using TECHCOOL.UI;
namespace ERP;

public class ProduktRedigering(Produkt produkt) : Screen
{
    public override string Title { get; set; } = "Redigerer for" + produkt.Navn;
    private readonly Produkt Produkt = produkt;

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Produkt> form = new();

        form.TextBox("Navn", nameof(Produkt.Navn));
        form.TextBox("Beskrivelse", nameof(Produkt.Beskrivelse));
        form.TextBox("Salgspris", nameof(Produkt.SalgsPris));
        form.TextBox("Indkøbspris", nameof(Produkt.IndkøbsPris));
        form.TextBox("Lokation", nameof(Produkt.Lokation));
        form.TextBox("Antal på Lager", nameof(Produkt.AntalLager));
        form.SelectBox("Enhed", nameof(Produkt.Enhed));
        form.AddOption("Enhed", "Styk", Enheder.Styk);
        form.AddOption("Enhed", "Meter", Enheder.Meter);
        form.AddOption("Enhed", "Timer", Enheder.Timer);
        try
        {

            if (form.Edit(Produkt))
            {
                if (Produkt.VareNummer != 0)
                    Database.ProductRepository.Update(Produkt);
                else
                    Database.ProductRepository.Create(Produkt);

                Console.WriteLine("|Ændringerne blev gemt");
            }
            else
                Console.WriteLine("|Ingen ændringer");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("|Ikke Gyldigt indkøbspris");
        }
        catch 
        {
            Console.WriteLine("|Indkøbspris og Salgspris må ikke værer ens");
        }

	}
}
