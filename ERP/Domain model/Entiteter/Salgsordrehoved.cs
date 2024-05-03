namespace ERP;

public class Salgsordrehoved
{
    public int OrdreNummer { get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public int KundeNummer {  get; set; }
    public float Ordrebeløb { get; set; }
    public Tilstand Tilstand { get; set; }
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }

    public Salgsordrehoved(int ordreNummer, DateTime oprettelseTid, DateTime gennemførtTid,
        int kundeNummer, Tilstand tilstand,float ordreBeløb)
    {
        OrdreNummer = ordreNummer;
        OprettelsesTidspunkt = oprettelseTid;
        GennemførelsesTidspunkt = gennemførtTid;
        KundeNummer = kundeNummer;
        Tilstand = tilstand;
        Ordrebeløb = ordreBeløb;
    }
}
