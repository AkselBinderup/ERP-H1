using System.Diagnostics;
using TECHCOOL.UI;

namespace ERP;

public partial class KundeRedigering : Screen
{
    public override string Title { get; set; } = "Kunde";
    Kunde Kunde = new();

    public KundeRedigering(Kunde kunde)
    {
        Title = "Redigerer for " + kunde.FuldeNavn;
        Kunde = kunde;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Kunde> form = new();

        form.TextBox("Fornavn", nameof(Kunde.Fornavn));
        form.TextBox("Efternavn", nameof(Kunde.Efternavn));
        form.TextBox("Vejnavn", nameof(Kunde.VejNavn));
        form.TextBox("Vejnummer", nameof(Kunde.VejNummer));
        form.TextBox("Postnummer", nameof(Kunde.PostNummer));
        form.TextBox("by", nameof(Kunde.By));
        form.TextBox("Email", nameof(Kunde.EmailAdresse));
        form.TextBox("TLF nummer", nameof(Kunde.TelefonNummer));


        if (form.Edit(Kunde))
        {
            if (Kunde.KundeNummer != 0)
            {
                Database.KundeRepository.Update(Kunde);
            }
            else
            {
                Debug.WriteLine(Kunde.VejNavn);
                Debug.WriteLine(Kunde.VejNummer);
                Debug.WriteLine(Kunde.By);
                Debug.WriteLine(Kunde.PostNummer);
                Adresse opdateretAdresse = new Adresse(Kunde.VejNavn, Kunde.VejNummer,
                    Kunde.By, Kunde.PostNummer);
                var adresseId = Database.AdresseRepository.GetSingleId(opdateretAdresse);
                Person opdateretPerson = new(Kunde.Fornavn, Kunde.Efternavn, Kunde.EmailAdresse, Kunde.TelefonNummer);
                var personID = Database.PersonRepository.GetIntFromPerson(opdateretPerson, adresseId);
                Database.KundeRepository.CreateWithId(Kunde, personID);
            }
            Console.WriteLine("Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("Ingen ændringer");
        }
    }
}
