namespace ERP;

public class Kunde : Person
{
    public int KundeNummer { get; set; }
    public new string Fornavn { get; set; }
    public new string Efternavn { get; set; }
    public string? SidsteKøb { get; set; }
    public new string? VejNavn { get; set; }
    public new int VejNummer { get; set; }
    public new string? ByNavn { get; set; }
    public new int PostNummer { get; set; }
    public new string? FuldeNavn { get; set; }
    
    public Kunde() { }

    public Kunde(Adresse adresse)
    {
        VejNavn = adresse.VejNavn;
        VejNummer = adresse.VejNummer;
        ByNavn = adresse.By;
        PostNummer = adresse.PostNummer;
    }
}
