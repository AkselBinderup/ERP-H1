namespace ERP.Domain_model.Entiteter;

public class Salgsordrehoved
{
    public int OrdreNummer {  get; set; }
    public DateTime OprettelsesTidspunkt { get; set; }
    public DateTime GennemførelsesTidspunkt { get; set; }
    public int KundeNummer {  get; set; }
    public Tilstand _Tilstand{ get; set; }
    public List<SalgsOrdreLinje> OrdreLinjer { get; set; }
}
