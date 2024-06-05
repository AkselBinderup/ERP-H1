namespace ERP;

public partial class CompanyDatabase : SemiCommonDBModule<Virksomhed>, IDBrepository<Virksomhed>
{
    private readonly string dbName = "dbo.Virksomhed";
    private readonly string dbFields = "(FirmaNavn, Vej, HusNummer, PostNummer, [By], Land, Valuta)";

    public bool Create(Virksomhed obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.FirmaNavn}'," +
            $"'{obj.Vej}'," +
            $"{obj.HusNummer}," +
            $"{obj.PostNummer}," +
            $"'{obj.By}'," +
            $"'{obj.Land}'," +
            $"'{obj.Valuta}')");
    }

    public List<Virksomhed> Read()
    {
        return Reader<Virksomhed>($"SELECT * FROM {dbName}");
    }

    //public Virksomhed ReadSingle(int id)
    //{
        //return ExecuteDapperSingleQuery<Virksomhed>($"SELECT * FROM {dbName} WHERE ID={id}");
    //}

    public bool Update(Virksomhed obj)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET FirmaNavn = '{obj.FirmaNavn}'," +
            $"PostNummer = {obj.PostNummer}," +
            $"HusNummer = {obj.HusNummer}," +
            $"Valuta = '{obj.Valuta}'," +
            $"[By] = '{obj.By}'," +
            $"Land = '{obj.Land}'," +
            $"Vej = '{obj.Vej}' " +
            $"WHERE VirksomhedsId = {obj.VirksomhedsId}");
    }

    public bool Delete(int id)
    {
        return ExecuteCommand($"DELETE {dbName} WHERE VirksomhedsId = {id}");
    }
}
