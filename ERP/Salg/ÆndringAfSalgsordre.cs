using Org.BouncyCastle.Bcpg;
using System;
using TECHCOOL.UI;
namespace ERP;
public class ÆndringAfSalgsordre(SalgsOrdreHoved salgsOrdreHoved) : Screen
{
    public override string Title { get; set; } = "Opretter salgsordre for " + salgsOrdreHoved.FuldeNavn;
    private readonly SalgsOrdreHoved SalgsOrdreHoved = salgsOrdreHoved;

    protected override void Draw()
    {
        ExitOnEscape();
        Form<SalgsOrdreHoved> form = new();
        
        form.TextBox("OrdreNummer", nameof(SalgsOrdreHoved.OrdreNummer));
        form.TextBox("KundeNummer", nameof(SalgsOrdreHoved.KundeId));
        form.TextBox("OrdreLinjer", nameof(SalgsOrdreHoved.OrdreLinjer));
        form.SelectBox("Tilstand", nameof(SalgsOrdreHoved.Tilstand));
        form.AddOption("Tilstand", "Ingen", nameof(Tilstand.Ingen));
        form.AddOption("Tilstand", "Oprettet", nameof(Tilstand.Oprettet));
        form.AddOption("Tilstand", "Bekræftet", nameof(Tilstand.Bekræftet));
        form.AddOption("Tilstand", "Pakket", nameof(Tilstand.Pakket));
        form.AddOption("Tilstand", "Færdig", nameof(Tilstand.Færdig));

        if (form.Edit(SalgsOrdreHoved))
        {
            if(SalgsOrdreHoved.SalgsOrdreHovedId != null)
            {
                Database.SalgsRepository.Update(SalgsOrdreHoved);
            }
            else
            {
                Database.SalgsRepository.Create(SalgsOrdreHoved);
            }

            Console.WriteLine("|Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("|Ingen ændringer");
        }
    }
}

