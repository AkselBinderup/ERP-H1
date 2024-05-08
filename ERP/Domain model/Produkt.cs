namespace ERP;

public class Produkt
{
    public int VareNummer{ get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public decimal SalgsPris { get; set; }
    public decimal IndkøbsPris { get; set; }
    public string Lokation { get; set; }
    public decimal AntalLager {  get; set; }
    public Enheder Enhed {  get; set; }
    public decimal BeregnAvanceProcent =>
        Math.Round(IndkøbsPris / BeregnFortjeneste() * 100);
    public decimal BeregnFortjeneste() => 
        SalgsPris - IndkøbsPris;

    
}
