using TECHCOOL.UI;

namespace ERP;

public partial class KundeRedigering : Screen
{
    public override string Title { get; set; } = "Kunde";
    Kunde Kunde = new();

    public KundeRedigering(Kunde kunde)
    {
        Title = "Redigerer for " + kunde.FuldeNavn;
        this.Kunde = kunde;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Kunde> form = new();

        form.TextBox("kundenummer", nameof(Kunde.KundeNummer));
        form.TextBox("Fornavn", nameof(Kunde.Fornavn));
        form.TextBox("Efternavn", nameof(Kunde.Efternavn));
        form.TextBox("Vejnavn", nameof(Kunde.Adresse.VejNavn));
        form.TextBox("Vejnummer", nameof(Kunde.Adresse.VejNummer));
        form.TextBox("Postnummer", nameof(Kunde.Adresse.PostNummer));
        form.TextBox("by", nameof(Kunde.Adresse.By));
        form.TextBox("Email", nameof(Kunde.EmailAdresse));
        form.TextBox("TLF nummer", nameof(Kunde.TelefonNummer));


        if (form.Edit(Kunde))
        {
            //if (kunde.KundeNummer != 0)
            //{
            //    database.Update(kunde);
            //}
            //else
            //{
            //    database.Create(kunde);
            //}
            Console.WriteLine("Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("Ingen ændringer");
        }

    }
}
