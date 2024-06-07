using TECHCOOL.UI;

namespace ERP;
public partial class VirksomhedStart : Screen
{
    public override string Title { get; set; } = "Vælg virksomhed";

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<Virksomhed> listPage = new ListPage<Virksomhed>();

        listPage.AddKey(ConsoleKey.F1, CreateNewCompany);
        Console.WriteLine("Tryk F1 for at oprette virksomhed");
        listPage.AddKey(ConsoleKey.F2, EditCompany);
        Console.WriteLine("Tryk F2 for at redigere virksomhed");
        listPage.AddKey(ConsoleKey.F5, DeleteCompany);
        Console.WriteLine("Tryk F5 for at fjerne virksomhed");

        listPage.AddColumn("Firmanavn", nameof(Virksomhed.FirmaNavn), 40);
        listPage.AddColumn("Land", nameof(Virksomhed.Land));
        listPage.AddColumn("Valuta", nameof(Virksomhed.Valuta), 8);

        var db = Database.CompanyDatabase.Read();
        foreach (Virksomhed virksomhed in db)
        {
            listPage.Add(virksomhed);
        }

        var vælgVirksomhed = listPage.Select();
        if (vælgVirksomhed != null)
        {
            Display(new VirksomhedDetaljer(vælgVirksomhed));
        }
    }
	private void CreateNewCompany(Virksomhed _)
	{
		Virksomhed NyVirksomhed = new();
		Display(new VirksomhedRedigering(NyVirksomhed));
	}

	private void EditCompany(Virksomhed virksomhed)
	{
		Display(new VirksomhedRedigering(virksomhed));
	}

	private void DeleteCompany(Virksomhed virksomhed)
	{
		Database.CompanyDatabase.Delete(virksomhed.VirksomhedsId);
	}
}
