using TECHCOOL.UI;
namespace ERP;
public class ÆndringAfSalgsordre : Screen
{
    public override string Title { get; set; } = "Ændring af salgsordre";
    SalgsOrdreHoved SalgsOrdreHoved = new();

    public ÆndringAfSalgsordre(SalgsOrdreHoved salgsOrdreHoved)
    {
        Title = "Redigerer for " + salgsOrdreHoved.FuldeNavn;
        SalgsOrdreHoved = salgsOrdreHoved;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<SalgsOrdreHoved> form = new();

        form.TextBox("Fornavn", nameof(SalgsOrdreHoved.Fornavn));
        form.TextBox("Efternavn", nameof(SalgsOrdreHoved.Efternavn));
        form.TextBox("VejNavn", nameof(SalgsOrdreHoved.Adresse.VejNavn));
        form.TextBox("Vejnummer", nameof(SalgsOrdreHoved.Adresse.VejNummer));
        form.TextBox("PostNummer", nameof(SalgsOrdreHoved.Adresse.PostNummer));
        form.TextBox("By", nameof(SalgsOrdreHoved.Adresse.By));
        form.TextBox("Telefonnummer", nameof(SalgsOrdreHoved.TelefonNummer));
        form.TextBox("Email", nameof(SalgsOrdreHoved.EmailAdresse));

        if (form.Edit(SalgsOrdreHoved))
        {
            Console.WriteLine("Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("Ingen ændringer");
        }

    }
}

