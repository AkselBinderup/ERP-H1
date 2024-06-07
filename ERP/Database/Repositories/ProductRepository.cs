namespace ERP;

public class ProductRepository : SemiCommonDBModule<Produkt>, IDBrepository<Produkt>
{
    private readonly string dbName = "dbo.Produkt";
    private readonly string dbFields = "(Navn, Beskrivelse, SalgsPris, " +
        "Indkøbspris, Lokation, AntalLager, Enhed, Avance)";

    private bool IsNumbersZero(Produkt obj)
        => obj.IndkøbsPris == 0;

    public bool Create(Produkt obj)
    {
        if (IsNumbersZero(obj))
            throw new ArgumentException("|Ikke Gyldigt indkøbspris");

        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.Navn}'," +
            $"'{obj.Beskrivelse}'," +
            $"{obj.SalgsPris}," +
            $"{obj.IndkøbsPris}," +
            $"'{obj.Lokation}'," +
            $"{obj.AntalLager}," +
            $"'{obj.Enhed}'," +
            $"{obj.Avance})");
    }

    public List<Produkt> Read()
    {
        return Reader<Produkt>($"SELECT * FROM dbo.Produkt WHERE [Status] = 'Eksisterer'");
    }

    public bool Update(Produkt obj)
    {
        if (IsNumbersZero(obj))
            throw new ArgumentException("|Ikke Gyldigt indkøbspris");

        return ExecuteCommand($"UPDATE {dbName} SET " +
            $"Navn = '{obj.Navn}'," +
            $"Beskrivelse = '{obj.Beskrivelse}'," +
            $"SalgsPris = {obj.SalgsPris}," +
            $"IndkøbsPris = {obj.IndkøbsPris}," +
            $"Lokation = '{obj.Lokation}'," +
            $"AntalLager = {obj.AntalLager}," +
            $"Enhed = '{obj.Enhed}'," +
            $"Avance = {obj.Avance} " +
            $"WHERE VareNummer = {obj.VareNummer}");
    }

    public bool Delete(int obj)
    {   
        return ExecuteCommand($"UPDATE {dbName} SET [Status] = 'Slettet' WHERE VareNummer = {obj}");
    }   
}
