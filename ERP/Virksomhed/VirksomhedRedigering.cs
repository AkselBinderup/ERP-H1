using TECHCOOL.UI;

namespace ERP;

public partial class VirksomhedRedigering : Screen
{
    public override string Title { get; set; } = "Selskab";
    Virksomhed Virksomhed = new();

    public VirksomhedRedigering(Virksomhed virksomhed)
    {
        Title = "Redigerer for " + virksomhed.FirmaNavn;
        Virksomhed = virksomhed;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Virksomhed> form = new();

        form.TextBox("Name", nameof(Virksomhed.FirmaNavn));
        form.TextBox("vej", nameof(Virksomhed.Vej));
        form.TextBox("Husnummer", nameof(Virksomhed.HusNummer));
        form.TextBox("Postnummer", nameof(Virksomhed.PostNummer));
        form.TextBox("By", nameof(Virksomhed.By));
        form.TextBox("Land", nameof(Virksomhed.Land));
        form.SelectBox("Currency", nameof(Virksomhed.Valuta));
        form.AddOption("Currency", "DKK", Currency.DKK);
        form.AddOption("Currency", "EUR", Currency.EUR);
        form.AddOption("Currency", "USD", Currency.USD);
        form.AddOption("Currency", "SEK", Currency.SEK);

        if (form.Edit(Virksomhed))
        {
            if (Virksomhed.Id != 0)
                Database.CompanyDatabase.Update(Virksomhed);
            else
                Database.CompanyDatabase.Create(Virksomhed);

            Console.WriteLine("|Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("|Ingen ændringer");
        }
    }
}
