using TECHCOOL.UI;

namespace ERP;

public class SalgsOrdreListe : Screen
{
    public override string Title { get; set; } = "Salgs ordre liste";

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<SalgsOrdreHoved> side = new();

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
        

        var db = Database.SalgsRepository.Read();
        
        foreach (SalgsOrdreHoved model in db)
            side.Add(model);

        var vælgSalgOdreHoved = side.Select();
        
        if (vælgSalgOdreHoved != null)
            Display(new SalgsOrdreDetaljer(vælgSalgOdreHoved));
    }
    private void EditOrder(SalgsOrdreHoved vælgSalgOdreHoved)
    {
        Display(new ÆndringAfSalgsordre(vælgSalgOdreHoved));
    }   
    private void CreateNewOrder(SalgsOrdreHoved vælgSalgOdreHoved)
    {
        Display(new SalgKundeSide());
    }
	private void DeleteOrder(SalgsOrdreHoved hoved)
    {
        Database.SalgsRepository.Delete(hoved.OrdreNummer);
    }
}
