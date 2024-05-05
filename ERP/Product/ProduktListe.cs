namespace ERP;

public partial class ProduktListe
{
    public int VareNummer {  get; set; }
    public string? Navn { get; set; }
    public string? Beskrivelse { get; set; }
    public int LagerAntal { get; set; }
    public float IndkøbsPris {  get; set; }
	public float SalgsPris { get; set; }
    public int[] Procent = Enumerable.Range(1, 100).ToArray(); 
    public Enheder Enhed {  get; set; }
    public string? Lokation {  get; set; }

}
