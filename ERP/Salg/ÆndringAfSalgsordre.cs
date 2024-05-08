using TECHCOOL.UI;
namespace ERP;
public class ÆndringAfSalgsordre : Screen
{
    public override string Title { get; set; } = "Ændring af salgsordre";
    SalgsOrdreHoved salgsOrdreHoved = new();

    public ÆndringAfSalgsordre(SalgsOrdreHoved salgsOrdreHoved)
    {
        Title = "Redigerer for " + salgsOrdreHoved.FuldeNavn;
        this.salgsOrdreHoved = salgsOrdreHoved;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<SalgsOrdreHoved> form = new();

        form.TextBox("Fornavn", nameof(salgsOrdreHoved.Fornavn));
        form.TextBox("Efternavn", nameof(salgsOrdreHoved.Efternavn));
        form.TextBox("VejNavn", nameof(salgsOrdreHoved.Adresse.VejNavn));
        form.TextBox("Vejnummer", nameof(salgsOrdreHoved.Adresse.VejNummer));
        form.TextBox("PostNummer", nameof(salgsOrdreHoved.Adresse.PostNummer));
        form.TextBox("By", nameof(salgsOrdreHoved.Adresse.By));
        form.TextBox("Telefonnummer", nameof(salgsOrdreHoved.TelefonNummer));
        form.TextBox("Email", nameof(salgsOrdreHoved.EmailAdresse));

        if (form.Edit(salgsOrdreHoved))
        {
            Console.WriteLine("Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("Ingen ændringer");
        }

    }
}

