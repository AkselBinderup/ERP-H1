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

        listPage.AddColumn("Firmanavn", nameof(Virksomhed.FirmaNavn), 40);
        listPage.AddColumn("Land", nameof(Virksomhed.Land));
        listPage.AddColumn("Valuta", nameof(Virksomhed.Valuta), 8);

        TempDataBase db = new TempDataBase();

        var virksomhedder = db.GetData();
        foreach (Virksomhed virksomhed in virksomhedder)
        {
            listPage.Add(virksomhed);
        }

        //todo: implementer databasehent

        listPage.AddKey(ConsoleKey.F2, EditCompany);
        Console.WriteLine("Tryk F2 for at redigere virksomhed");

        var vælgVirksomhed = listPage.Select();
        if(vælgVirksomhed != null)
        {
            Display(new VirksomhedDetaljer(vælgVirksomhed));
        }
        
        void CreateNewCompany(Virksomhed virksomhed)
        {
            Virksomhed NyVirksomhed = new();
            Display(new VirksomhedSideTre(NyVirksomhed));
        }

        void EditCompany(Virksomhed virksomhed)
        {
            Display(new VirksomhedSideTre(virksomhed));
        }
    }
}
