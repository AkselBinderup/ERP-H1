namespace ERP.Domain_model.Entiteter;

public class Salgsordrehoved
{
    public int OrdreNummer {  get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public int KundeNummer {  get; set; }
    public float Ordrebeløb { get; set; }
    public Tilstand Tilstand_ { get; set; }
    public enum Tilstand
    { 
        Ingen,
        Oprettet,
        Bekræftet,
        Pakket,
        Færdig
    }

    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }

    public Salgsordrehoved(
        
        int ordrenummer,
        DateTime oprettelsetid,
        DateTime Gennemførttid,
        int kundeNummer,
        Tilstand tilstand,
        float ordrebeløb
        
        )
    {
        
        OrdreNummer = ordrenummer;
        OprettelsesTidspunkt = oprettelsetid;
        GennemførelsesTidspunkt = Gennemførttid;
        KundeNummer = kundeNummer;
        Tilstand_ = tilstand;
        Ordrebeløb = ordrebeløb;

    }


}
