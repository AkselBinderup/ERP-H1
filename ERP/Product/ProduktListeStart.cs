﻿using TECHCOOL.UI;

namespace ERP;
public partial class ProduktListeStart : Screen
{
    public override string Title { get; set; } = "Vælg Product";

    protected override void Draw()
    {
        try
        {
            ExitOnEscape();

            Console.CursorVisible = false;

            ListPage<Produkt> listPage = new();

            listPage.AddKey(ConsoleKey.F2, EditProduct);
            Console.WriteLine("Tryk F2 for at Ændre et produkt");
            listPage.AddKey(ConsoleKey.F3, CreateNewProduct);
            Console.WriteLine("Tryk F3 for at oprette et produkt");
            listPage.AddKey(ConsoleKey.F5, DeleteProduct);
            Console.WriteLine("Tryk F5 for at slette et produkt");

            listPage.AddColumn("Varenummer:", nameof(Produkt.VareNummer), 40);
            listPage.AddColumn("Navn", nameof(Produkt.Navn));
            listPage.AddColumn("Lagerantal", nameof(Produkt.AntalLager), 12);
            listPage.AddColumn("Inkøbspris", nameof(Produkt.IndkøbsPris));
            listPage.AddColumn("Salgs pris", nameof(Produkt.SalgsPris));
            listPage.AddColumn("Avance i Procent", nameof(Produkt.Avance));

            var db = Database.ProductRepository.Read();

            foreach (Produkt model in db)
                listPage.Add(model);

            var vælgProdukt = listPage.Select();

            if (vælgProdukt != null)
                Display(new ProductDetaljer(vælgProdukt));
        }
        catch (Exception ex)
        { Program.logWriter.LogWrite(ex.Message); }
    }
    
    private void CreateNewProduct(Produkt produkt)
	{
        Produkt newProdukt = new();
        Display(new ProduktRedigering(newProdukt));
	}

    private void EditProduct(Produkt produkt)
    {
        Display(new ProduktRedigering(produkt));
    }

    private void DeleteProduct(Produkt produkt)
    {
        Database.ProductRepository.Delete(produkt.VareNummer);
    }
}
