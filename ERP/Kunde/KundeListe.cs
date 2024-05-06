using TECHCOOL.UI;

namespace ERP;

public class KundeListe : Screen
{
    public override string Title { get; set; } = "Kundeliste";

    protected override void Draw()
    {
        ExitOnEscape();

        
        ListPage<Kunde> side = new();
        
        side.AddColumn("Kundenummer", nameof(Kunde.KundeNummer));
        side.AddColumn("Fornavn og Efternavn", nameof(Kunde.FuldeNavn), 20);
        side.AddColumn("Telefonnummer", nameof(Kunde.TelefonNummer), 15);
        side.AddColumn("Email", nameof(Kunde.EmailAdresse), 20);

        TempKundeInfo db = new TempKundeInfo();
        var virksomheder = db.GetData();
        foreach (Kunde virksomhed in virksomheder)
        {
            side.Add(virksomhed);
        }

        var company = side.Select();
        if (company != null)
        {
            Display(new KundeInfoScreen(company));
        }
    }
}
