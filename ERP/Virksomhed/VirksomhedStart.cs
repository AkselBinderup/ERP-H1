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

        var vælgVirksomhed = listPage.Select();
        if(vælgVirksomhed != null)
        {
            Display(new VirksomhedDetaljer(vælgVirksomhed));
        }
    }
    //    Der laves en skærm med en liste over virksomheder.
    //Listen skal vise følgende kolonner
    //• Firmanavn
    //• Land
    //• Valut
}
