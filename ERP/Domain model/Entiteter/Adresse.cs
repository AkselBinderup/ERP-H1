namespace ERP;

public class Adresse
{
    public string? VejNavn { get; set; }
    public int VejNummer { get; set; }
    public string? ByNavn { get; set; }
    public int PostNummer { get; set; }

    public Adresse(string? vejNavn, int vejNummer, string? by, int postNummer)
    {
        ByNavn = by;
        VejNavn = vejNavn;
        VejNummer = vejNummer;
        PostNummer = postNummer;
    }

    public Adresse() { }
}
