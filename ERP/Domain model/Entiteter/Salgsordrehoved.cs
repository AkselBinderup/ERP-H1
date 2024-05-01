namespace ERP.Domain_model.Entiteter;

public class Salgsordrehoved
{
    public int OrdreNummer {  get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public int KundeNummer {  get; set; }
    public Enum Tilstand { get; set; }
//    Tilstand kan være en af følgende
    //• Ingen
    //• Oprettet
    //• Bekræftet
    //• Pakket
    //• Færdig
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }
}
