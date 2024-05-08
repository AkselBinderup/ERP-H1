namespace ERP;

public class Adresse
{
	public string? VejNavn {  get; set; }
	public int VejNummer {  get; set; }
	public int PostNummer {  get; set; }
    public string by {  get; set; }
	public Adresse(string? vejNavn, int vejNummer, int postNummer, string by)
    {
        VejNavn = vejNavn;
        VejNummer = vejNummer;
        PostNummer = postNummer;
        this.by = by;
    }
}
