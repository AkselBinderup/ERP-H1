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

        side.AddKey(ConsoleKey.F2, EditCompany);
        Console.WriteLine("Tryk F2 for at redigere virksomhed");

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

        void EditCompany(SalgsOrdreHoved virksomhed)
        {
            Display(new ÆndringAfSalgsordre(virksomhed));
        }

    }



}
