namespace ERP;

public class ProductRepository : CommonDBModule<Produkt>, IDBrepository<Produkt>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";

    public bool Create(Produkt obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.VareNummer}'," +
            $"'{obj.Navn}'," +
            $"'{obj.Beskrivelse}'," +
            $"'{obj.SalgsPris}'," +
            $"'{obj.IndkøbsPris}'," +
            $"'{obj.Lokation}'," +
            $"'{obj.AntalLager}'," +
            $"'{obj.AntalLager}'");
    }
    public List<Produkt> Read()
    {
        return ExecuteDapperQuery<Produkt>($"SELECT * FROM {dbName}");
    }
    public bool Update(Produkt obj)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET VareNummer = {obj.VareNummer}," +
            $"Navn = {obj.Navn}," +
            $"Beskrivelse = {obj.Beskrivelse}," +
            $"SalgsPris = {obj.SalgsPris}," +
            $"IndkøbsPris = {obj.IndkøbsPris}," +
            $"Lokation = {obj.Lokation}," +
            $"AntalLager = {obj.AntalLager}," +
            $"Enhed = {obj.AntalLager} WHERE Id = {obj.VareNummer}");
    }
    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} WHERE Id = '{obj}'");
    }
}
