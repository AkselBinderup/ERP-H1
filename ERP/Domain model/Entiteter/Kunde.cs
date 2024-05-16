namespace ERP;

public class Kunde : Person
{
    public int KundeNummer { get; set; }
    public DateTime SidsteKøb { get; set; }
    public string? VejNavn { get; set; }
    public int VejNummer { get; set; }
    public string By { get; set; }
    public int PostNummer { get; set; }
    public Kunde() { }

    public Kunde(Adresse adresse)
    {
        VejNavn = adresse.VejNavn;
        VejNummer = adresse.VejNummer;
        By = adresse.By;
        PostNummer = adresse.PostNummer;
    }
}
