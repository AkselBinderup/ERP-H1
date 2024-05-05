namespace ERP;

public class Adresse
{
	public string? VejNavn {  get; set; }
	public int VejNummer {  get; set; }
	public int PostNummer {  get; set; }
	public Adresse(string? vejNavn, int vejNummer, int postNummer)
    {
        VejNavn = vejNavn;
        VejNummer = vejNummer;
        PostNummer = postNummer;
    }
}
