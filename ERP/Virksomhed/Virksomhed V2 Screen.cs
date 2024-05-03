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
        ExitOnEscape();
        Console.WriteLine($"Firmanavn: {virksomhed.FirmaNavn}\n" +
            $"Vej: {virksomhed.Vej}\n" +
            $"Hus nummer: {virksomhed.HusNummer}\n" +
            $"Post nummer: {virksomhed.PostNummer}\n" +
            $"By: {virksomhed.By}\n" +
            $"Land: {virksomhed.Land}\n" +
            $"Valuta: {virksomhed.Valuta}");
    }
}
