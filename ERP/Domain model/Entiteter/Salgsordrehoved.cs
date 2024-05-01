namespace ERP.Domain_model.Entiteter;

public class Salgsordrehoved
{
    public int OrdreNummer {  get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public int KundeNummer {  get; set; }
    public enum Tilstand
    { 
        Ingen,
        Oprettet,
        Bekræftet,
        Pakket,
        Færdig
    }
    Tilstand Tilstand_ { get; set; }
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }

    float Ordrebeløb {  get; set; }

    public Salgsordrehoved(int ordrenummer,
                           DateTime oprettelsetid,
                           DateTime Gennemførttid,
                           int kodenummer,
                           Tilstand tilstand,
                           float ordrebeløb)
    {
        
        OrdreNummer = ordrenummer;
        OprettelsesTidspunkt = oprettelsetid;
        GennemførelsesTidspunkt = Gennemførttid;
        KundeNummer = kodenummer;
        Tilstand_ = tilstand;
        Ordrebeløb = ordrebeløb;

    }


}
