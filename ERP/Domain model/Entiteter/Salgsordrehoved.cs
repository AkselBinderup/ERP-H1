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
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }

    float Ordrebeløb {  get; set; }


}
