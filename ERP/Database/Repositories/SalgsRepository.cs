namespace ERP;

public class SalgsRepository : CommonDBModule<SalgsOrdreHoved>, IDBrepository<SalgsOrdreHoved>
{
    private readonly string dbName = "dbo.SalgsOrdreHoved";
    private readonly string dbFields = "(OrdreNummer, OprettelsesTidspunkt, GennemførlsesTidspunkt, " +
        "KundeNummer, Tilstand, OrdreBeløb, OrdreLinjer)";

    public bool Create(SalgsOrdreHoved obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.OrdreNummer}'," +
            $"'{obj.OprettelsesTidspunkt}'," +
            $"'{obj.GennemførelsesTidspunkt}'," +
            $"'{obj.KundeId}'," +
            $"'{obj.Tilstand}'," +
            $"'{obj.Ordrebeløb}'," +
            $"'{obj.OrdreLinjer}'");
    }

    public List<SalgsOrdreHoved> Read()
    {
        return ExecuteDapperQuery($"Select * from {dbName}");
    }

    public bool Update(SalgsOrdreHoved obj)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET OrdreNummer = {obj.OrdreNummer}," +
            $"OprettelsesTidspunkt = GETDATE()," +
            $"GennemførelsesTidspunkt = GETDATE()," +
            $"KundeNummer = {obj.KundeId}," +
            $"Tilstand = {obj.Tilstand}," +
            $"Ordrebeløb = {obj.Ordrebeløb}," + "WHERE Id = {id}");
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
