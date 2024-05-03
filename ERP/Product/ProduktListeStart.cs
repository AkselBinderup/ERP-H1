using TECHCOOL.UI;

namespace ERP;
public partial class ProduktListeStart : Screen
{
    public override string Title { get; set; } = "Vælg Product";

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<Produkt> listPage = new ListPage<Produkt>();
        listPage.AddColumn("Varenummer:", nameof(Produkt.VareNummer), 40);
        listPage.AddColumn("Navn", nameof(Produkt.Navn));
        listPage.AddColumn("Lagerantal", nameof(Produkt.AntalLager), 8);
        listPage.AddColumn("Inkøbspris", nameof(Produkt.IndkøbsPris));
        listPage.AddColumn("Salgs pris", nameof(Produkt.SalgsPris));
        listPage.AddColumn("Advance i Procent", nameof(Produkt.BeregnAvanceProcent));

        TempDataBase db = new TempDataBase();

        var Produkter = db.GetProducts();
        foreach (Produkt model in Produkter)
        {
            listPage.Add(model);
        }

        //todo: implementer databasehent

        var vælgProdukt = listPage.Select();
        if (vælgProdukt != null)
        {
            Display(new ProductListeSide(vælgProdukt));
        }
    }
}
