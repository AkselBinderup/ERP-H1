namespace ERP;

public partial class Database : CommonDBModule<Virksomhed>, IDBrepository<Virksomhed>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";

    public bool Create(Virksomhed obj)
    {
        if (obj.Id == 0)
            return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
                    $"('{obj.FirmaNavn}'," +
                    $"'{obj.PostNummer}'," +
                    $"'{obj.HusNummer}'," +
                    $"'{obj.Valuta}'," +
                    $"'{obj.Id}'," +
                    $"'{obj.By}'," +
                    $"'{obj.Land},'" +
                    $"'{obj.Vej}'");
        else return false;
    }

    public List<Virksomhed> Read()
    {
        return ExecuteDapperQuery($"SELECT * FROM {dbName}");
    }

    public Virksomhed ReadSingle(int id)
    {
        return ExecuteDapperSingleQuery<Virksomhed>($"SELECT * FROM {dbName} WHERE ID={id}");
    }

    public bool Update(Virksomhed obj)
    {
        if (obj.Id != 0)
            return ExecuteCommand($"UPDATE {dbName} " +
              $"SET FirmaNavn = '{obj.FirmaNavn}'," +
              $"PostNummer = '{obj.PostNummer}'," +
              $"HusNummer = '{obj.HusNummer}'," +
              $"Valuta = '{obj.Valuta}'," +
              $"By = '{obj.By}'," +
              $"Land = '{obj.Land}'," +
              $"Vej = '{obj.Vej}' WHERE Id = {obj.Id}");
        else
            return false;
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} WHERE Id = '{obj}'");
    }
}
