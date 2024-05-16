using TECHCOOL.UI;

namespace ERP;

public class KundeListe : Screen
{
    public override string Title { get; set; } = "Kundeliste";

    protected override void Draw()
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
        side.AddColumn("Email", nameof(Kunde.EmailAdresse), 20);

        var db = Database.KundeRepository.Read();
        foreach (Kunde virksomhed in db)
        {
            side.Add(item);
        }

        var kunde = side.Select();
        if (kunde != null)
        {
            Display(new KundeInfoScreen(kunde));
        }

        void CreateNewKunde(Kunde _)
        {
            Kunde nyKunde = new();
            Display(new KundeRedigering(nyKunde));
        }

        void EditKunde(Kunde kunde)
        {
            Display(new KundeRedigering(kunde));
        }
        
        void DeleteKunde(Kunde kunde)
        {
            //to be added
        }
    }
}
