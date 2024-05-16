namespace ERP;

public partial class CompanyDatabase : CommonDBModule<Virksomhed>, IDBrepository<Virksomhed>
{
    private readonly string dbName = "dbo.Virksomhed";
    private readonly string dbFields = "(FirmaNavn, Vej, HusNummer, PostNummer, ByNavn, Land, Valuta)";
    public bool Create(Virksomhed obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.FirmaNavn}'," +
            $"'{obj.Vej}'," +
            $"'{obj.HusNummer}'," +
            $"'{obj.PostNummer}'," +
            $"'{obj.By}'," +
            $"'{obj.Land}'," +
            $"'{obj.Valuta}')");
    }
    public List<Virksomhed> Read()
    {
        return ExecuteDapperQuery<Virksomhed>($"SELECT * FROM {dbName}");
    }
    public Virksomhed ReadSingle(int id)
    {
        return ExecuteDapperSingleQuery<Virksomhed>($"SELECT * FROM {dbName} WHERE ID={id}");
    }

    public bool Update(Virksomhed obj)
    {
        if (obj.Id == 0)
            return false;

        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET FirmaNavn = '{obj.FirmaNavn}'," +
            $"PostNummer = '{obj.PostNummer}'," +
            $"HusNummer = '{obj.HusNummer}'," +
            $"Valuta = '{obj.Valuta}'," +
            $"By = '{obj.By}'," +
            $"Land = '{obj.Land}'," +
            $"Vej = '{obj.Vej}' WHERE Id = {obj.Id}");
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} WHERE Id = '{obj}'");
    }
}
