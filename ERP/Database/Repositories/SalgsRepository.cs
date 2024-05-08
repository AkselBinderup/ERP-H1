namespace ERP;

public class Salgs_Crud : CommonDBModule<SalgsOrdreHoved>, IDBrepository<SalgsOrdreHoved>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";
    public bool Create(SalgsOrdreHoved obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.OrdreNummer}'," +
            $"'{obj.OprettelsesTidspunkt}'," +
            $"'{obj.GennemførelsesTidspunkt}'," +
            $"'{obj.KundeNummer}'," +
            $"'{obj.Tilstand}'," +
            $"'{obj.Ordrebeløb}',");
    }

    public List<SalgsOrdreHoved> Read()
    {
        return ExecuteDapperQuery<SalgsOrdreHoved>($"Select * from {dbName}");
    }

    public bool Update(SalgsOrdreHoved obj)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET OrdreNummer = {obj.OrdreNummer}," +
            $"OprettelsesTidspunkt = {obj.OprettelsesTidspunkt}," +
            $"GennemførelsesTidspunkt = {obj.GennemførelsesTidspunkt}," +
            $"KundeNummer = {obj.KundeNummer}," +
            $"Tilstand = {obj.Tilstand}," +
            $"Ordrebeløb = {obj.Ordrebeløb}," + "WHERE Id = {id}");
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
