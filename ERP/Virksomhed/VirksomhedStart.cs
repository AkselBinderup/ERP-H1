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

        listPage.AddKey(ConsoleKey.F1, createNewCompany);
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

        listPage.AddKey(ConsoleKey.F2, editCompany);
        Console.WriteLine("Tryk F2 for at redigere virksomhed");

        var vælgVirksomhed = listPage.Select();
        if(vælgVirksomhed != null)
        {
            Display(new VirksomhedDetaljer(vælgVirksomhed));
        }
        
        void createNewCompany(Virksomhed virksomhed)
        {
            Virksomhed NyVirksomhed = new();
            Screen.Display(new VirksomhedSideTre(NyVirksomhed));
        }

        void editCompany(Virksomhed virksomhed)
        {
            Screen.Display(new VirksomhedSideTre(virksomhed));
        }
    }
    //    Der laves en skærm med en liste over virksomheder.
    //Listen skal vise følgende kolonner
    //• Firmanavn
    //• Land
    //• Valut
}
