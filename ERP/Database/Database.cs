namespace ERP;
public partial class Database
{
    public static Database instance { get; private set; } = new Database();
    public static CompanyDatabase CompanyDatabase { get; private set; } = new CompanyDatabase();
    public static KundeRepository KundeRepository { get; private set; } = new KundeRepository();
    public static ProductRepository ProductRepository { get; private set; } = new ProductRepository();
    public static SalgsRepository SalgsRepository { get; private set; } = new SalgsRepository();
    public static AdresseRepository AdresseRepository { get; private set; } = new AdresseRepository();
    public static PersonRepository PersonRepository { get; private set; } = new PersonRepository();
    private Database()
    {

    }
}

