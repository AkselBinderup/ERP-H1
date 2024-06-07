using Org.BouncyCastle.Bcpg;
using System;
using TECHCOOL.UI;
namespace ERP;
public class VaelgProdukt(SalgsOrdreHoved salgsOrdreHoved) : Screen
{
    public override string Title { get; set; } = "Vælg produkt for " + salgsOrdreHoved.FuldeNavn;
    private readonly SalgsOrdreHoved SalgsOrdreHoved = salgsOrdreHoved;

    protected override void Draw()
    {
        ExitOnEscape();

        Console.CursorVisible = false;

        ListPage<Produkt> listPage = new();

        listPage.AddColumn("Varenummer:", nameof(Produkt.VareNummer), 40);
        listPage.AddColumn("Navn", nameof(Produkt.Navn));
        listPage.AddColumn("Lagerantal", nameof(Produkt.AntalLager), 12);
        listPage.AddColumn("Inkøbspris", nameof(Produkt.IndkøbsPris));
        listPage.AddColumn("Salgs pris", nameof(Produkt.SalgsPris));
        listPage.AddColumn("Avance i Procent", nameof(Produkt.Avance));

        var db = Database.ProductRepository.Read();

        foreach (Produkt model in db)
            listPage.Add(model);

        var produkt = listPage.Select();
        if (produkt != null)
        {
            SalgsOrdreHoved nyorder = new(SalgsOrdreHoved);
            nyorder.Produkt = produkt;
            Display(new ÆndringAfSalgsordre(nyorder));
        }
    }
}

