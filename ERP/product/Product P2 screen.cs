using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace ERP;

/// <summary>
/// Produktliste: Skærm der skal vises en liste over
/// produkter.Listen skal indeholde følgende kolonner
/// Varenummer
/// Navn
/// Lagerantal
/// Indkøbsspris
/// Salgspris
/// Avance i procent
/// Det skal være muligt at vælge et produkt fra listen og
/// få vist skærmen Produktdetajler i krav P3
/// </summary>
public partial class ProductListeStart : Screen
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

        //var Produkter = db.GetData();
        //foreach (Produkt model in Produkter)
        //{
        //    listPage.Add(model);
        //}

        //todo: implementer databasehent

        //var vælgProdukt = listPage.Select();
        //if (vælgProdukt != null)
        //{
        //    Screen.Display(new VirksomhedSideTo(vælgProdukt));
        //}
    }
}
