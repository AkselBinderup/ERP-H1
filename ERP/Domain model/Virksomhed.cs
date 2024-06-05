namespace ERP;

public class Virksomhed
{
    public int VirksomhedsId { get; set; }
    public string? FirmaNavn { get; set; }
    public string? Vej { get; set; }
    public string? HusNummer { get; set; }
    public string? PostNummer { get; set; }
    public string? By { get; set; }
    public string? Land { get; set; }
    public Currency Valuta { get; set; }
}
