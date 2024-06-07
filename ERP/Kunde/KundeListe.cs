using TECHCOOL.UI;

namespace ERP;

public class KundeListe : Screen
{
    public override string Title { get; set; } = "Kundeliste";

    protected override void Draw()
    {
        try
        {
            ExitOnEscape();

            ListPage<Kunde> side = new();

            side.AddKey(ConsoleKey.F1, CreateNewKunde);
            Console.WriteLine("Tryk F1 for at oprette ny kunde");

            side.AddKey(ConsoleKey.F2, EditKunde);
            Console.WriteLine("Tryk F2 for at ændre kunden");

            side.AddKey(ConsoleKey.F5, DeleteKunde);
            Console.WriteLine("Tryk F5 for at Slette kunde");

            side.AddColumn("Kundenummer", nameof(Kunde.KundeNummer));
            side.AddColumn("Fornavn og Efternavn", nameof(Kunde.FuldeNavn), 20);
            side.AddColumn("Telefonnummer", nameof(Kunde.TelefonNummer), 15);
            side.AddColumn("Email", nameof(Kunde.Email), 20);

            var db = Database.KundeRepository.Read();

            foreach (Kunde obj in db)
            {
                obj.Adresse = new(obj.VejNavn, obj.VejNummer, obj.ByNavn, obj.PostNummer);
                side.Add(obj);
            }

            var kunde = side.Select();
            var person = Database.PersonRepository.Read();
            if (kunde != null)
                Display(new KundeInfoScreen(kunde));
        }
        catch (Exception ex)
        {
            Program.logWriter.LogWrite(ex.Message);
        }
        
    }

	private void CreateNewKunde(Kunde _)
	{
		Kunde nyKunde = new();
		Display(new KundeRedigering(nyKunde));
	}

	private void EditKunde(Kunde kunde)
	{
		Display(new KundeRedigering(kunde));
	}

	private void DeleteKunde(Kunde kunde)
	{
		Database.KundeRepository.Delete(kunde.KundeNummer);
	}
}
