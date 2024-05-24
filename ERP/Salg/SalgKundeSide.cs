using System.Reflection.Metadata;
using TECHCOOL.UI;

namespace ERP;

public class SalgKundeSide : Screen
{
    public override string Title { get; set; } = "Kundeliste";
    public static Kunde? ValgteKunde { get; set; }
    protected override void Draw()
    {
        ExitOnEscape();
        ListPage<Kunde> side = new();

        side.AddColumn("Kundenummer", nameof(Kunde.KundeId));
        side.AddColumn("Fornavn og Efternavn", nameof(Kunde.FuldeNavn), 20);
        side.AddColumn("Telefonnummer", nameof(Kunde.TelefonNummer), 15);
        side.AddColumn("Email", nameof(Kunde.Email), 20);

        var db = Database.KundeRepository.Read();
        foreach (Kunde kundeListe in db)
        {
            side.Add(kundeListe);
        }

        var kunde = side.Select();
        if (kunde != null)
        {
            SalgsOrdreHoved ordre = new(kunde);
            Display(new ÆndringAfSalgsordre(ordre));
        }
    }
}
