using System.Diagnostics;
using TECHCOOL.UI;

namespace ERP;

public partial class KundeRedigering(Kunde kunde) : Screen
{
    public override string Title { get; set; } = "Redigerer for " + kunde.FuldeNavn;
    private readonly Kunde Kunde = kunde;

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Kunde> form = new();

        form.TextBox("Fornavn", nameof(Kunde.Fornavn));
        form.TextBox("Efternavn", nameof(Kunde.Efternavn));
        form.TextBox("Vejnavn", nameof(Kunde.VejNavn));
        form.TextBox("Vejnummer", nameof(Kunde.VejNummer));
        form.TextBox("Postnummer", nameof(Kunde.PostNummer));
        form.TextBox("By", nameof(Kunde.ByNavn));
        form.TextBox("Email", nameof(Kunde.Email));
        form.TextBox("Telefon nummer", nameof(Kunde.TelefonNummer));


        if (form.Edit(Kunde))
        {
            if (Kunde.KundeNummer != 0) 
            {
                Database.PersonRepository.Update(Kunde);
				Database.KundeRepository.Update(Kunde);
			}
			else
            {
                Adresse opdateretAdresse = new(Kunde.VejNavn, Kunde.VejNummer,
                    Kunde.ByNavn, Kunde.PostNummer);
                var adresseId = Database.AdresseRepository.GetSingleId(opdateretAdresse);

                Person opdateretPerson = new(Kunde.Fornavn, Kunde.Efternavn, Kunde.Email, Kunde.TelefonNummer);
                var personID = Database.PersonRepository.GetIntFromPerson(opdateretPerson, adresseId);

                Database.KundeRepository.CreateWithId(Kunde, personID);
            }

            Console.WriteLine("|Ændringerne blev gemt");
        }
        else
            Console.WriteLine("|Ingen ændringer");
    }
}
