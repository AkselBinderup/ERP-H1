using TECHCOOL.UI;

namespace ERP;

public partial class VirksomhedDetaljer : Screen
{
    public override string Title { get; set; } = "Informationer";

    Virksomhed Virksomhed = new();

    public VirksomhedDetaljer(Virksomhed virksomhed)
    {
        Title = "Detaljer for " + virksomhed.FirmaNavn;
        Virksomhed = virksomhed;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Console.WriteLine($"Firmanavn: {Virksomhed.FirmaNavn}\n" +
            $"Vej: {Virksomhed.Vej}\n" +
            $"Hus nummer: {Virksomhed.HusNummer}\n" +
            $"Post nummer: {Virksomhed.PostNummer}\n" +
            $"By: {Virksomhed.By}\n" +
            $"Land: {Virksomhed.Land}\n" +
            $"Valuta: {Virksomhed.Valuta}");
    }
}
