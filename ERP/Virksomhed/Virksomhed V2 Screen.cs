using System.Xml;
using TECHCOOL.UI;

namespace ERP;

public partial class VirksomhedSideTo : Screen
{
    public override string Title { get; set; } = "Informationer";

    Virksomhed virksomhed = new();
    public VirksomhedSideTo(Virksomhed virksomhed)
    {
        Title = "Detaljer for " + virksomhed.FirmaNavn;
        this.virksomhed = virksomhed;
    }
    protected override void Draw()
    {
        Console.WriteLine($"Firmanavn: {virksomhed.FirmaNavn}");
        Console.WriteLine($"Vej: {virksomhed.Vej}");
        Console.WriteLine($"Hus nummer: {virksomhed.HusNummer}");
        Console.WriteLine($"Post nummer: {virksomhed.PostNummer}");
        Console.WriteLine($"By: {virksomhed.By}");
        Console.WriteLine($"Land: {virksomhed.Land}");
        Console.WriteLine($"Valuta: {virksomhed.Valuta}");

    }
}
