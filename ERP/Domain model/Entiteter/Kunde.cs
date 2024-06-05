namespace ERP;

public class Kunde : Person
{
    public int KundeId { get; set; }
    public DateTime SidsteKøb { get; set; }
    public new string? VejNavn { get; set; }
    public new int VejNummer { get; set; }
    public new string? By { get; set; }
    public new int PostNummer { get; set; }
    
    public Kunde() { }

    public Kunde(Adresse adresse)
    {
        VejNavn = adresse.VejNavn;
        VejNummer = adresse.VejNummer;
        By = adresse.By;
        PostNummer = adresse.PostNummer;
    }
}
