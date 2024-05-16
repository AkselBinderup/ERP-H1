using TECHCOOL.UI;

namespace ERP;

public class SalgsOrdreListe : Screen
{
    public override string Title { get; set; } = "Salgs ordre liste";

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<SalgsOrdreHoved> side = new ListPage<SalgsOrdreHoved>();

        side.AddKey(ConsoleKey.F2, EditOrder);
        Console.WriteLine("Tryk F2 for at redigere ordre");

        side.AddKey(ConsoleKey.F3, CreateNewOrder);
        Console.WriteLine("Tryk F3 for at oprette en ny ordre");
        
        side.AddKey(ConsoleKey.F5, DeleteOrder);
        Console.WriteLine("Tryk F5 for at slette den valgte ordre");

        side.AddColumn("Salgsodrenummer", nameof(SalgsOrdreHoved.OrdreNummer));
        side.AddColumn("Dato", nameof(SalgsOrdreHoved.OprettelsesTidspunkt), 20);
        side.AddColumn("Kundenummer", nameof(SalgsOrdreHoved.KundeNummer));
        side.AddColumn("Fuldenavn", nameof(SalgsOrdreHoved.FuldeNavn));
        side.AddColumn("Beløb", nameof(SalgsOrdreHoved.Ordrebeløb), 15);


        TempSalgsOrdreHovedDataBase db = new();
        var salgsOrdreHoved = db.GetData();

        foreach (SalgsOrdreHoved model in salgsOrdreHoved)
        {
            side.Add(model);
        }

        var vælgSalgOdreHoved = side.Select();
        if (vælgSalgOdreHoved != null)
        {
            Display(new SalgsOrdreDetaljer(vælgSalgOdreHoved));
        }

        void EditOrder(SalgsOrdreHoved vælgSalgOdreHoved)
        {
            Display(new ÆndringAfSalgsordre(vælgSalgOdreHoved));
        }
        
        void CreateNewOrder(SalgsOrdreHoved vælgSalgOdreHoved)
        {
            SalgsOrdreHoved nyorder = new SalgsOrdreHoved();
            Display(new ÆndringAfSalgsordre(nyorder));
        }
    }

    private void DeleteOrder(SalgsOrdreHoved hoved)
    {
        throw new NotImplementedException();
    }
}
