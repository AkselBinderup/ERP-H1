using TECHCOOL.UI;

namespace ERP;
public partial class VirksomhedStart : Screen
{
    public override string Title { get; set; } = "Vælg virksomhed";

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<Virksomhed> side = new ListPage<Virksomhed>();
        side.AddColumn("Firmanavn", nameof(Virksomhed.FirmaNavn), 40);
        side.AddColumn("Land", nameof(Virksomhed.Land));
        side.AddColumn("Valuta", nameof(Virksomhed.Valuta), 8);

        TempDataBase db = new TempDataBase();
        var virksomhedder = db.GetData();
        foreach (Virksomhed model in virksomhedder)
        {
            side.Add(model);
        }

        //todo: implementer databasehent

        var vælgVirksomhed = side.Select();
        if(vælgVirksomhed != null)
        {
            Display(new VirksomhedSideTo(vælgVirksomhed));
        }
    }
   
}
