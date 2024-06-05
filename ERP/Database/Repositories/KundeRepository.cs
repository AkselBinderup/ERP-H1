namespace ERP;

public class KundeRepository : SemiCommonDBModule<Kunde>, IDBrepository<Kunde>
{
    private readonly string dbName = "dbo.Kunde";
    private readonly string dbFields = "(SidsteKøb, PersonId)";
    //private readonly string dbFields = "(KundeId, SidsteKøb, ProduktId, personId)";

    public bool Create(Kunde obj)
    {
        throw new NotImplementedException();
    }

    public bool CreateWithId(Kunde _, int personId)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"(GETDATE()," +
            $"{personId})");
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE {dbName} WHERE KundeNummer = '{obj}'");
    }

    //public Kunde ReadSingle(int id)
    //{  
    //    return ExecuteDapperSingleQuery<Kunde>($"SELECT * FROM {dbName} WHERE Id = '{id}");
    //}

    public List<Kunde> Read()
    {

        return Reader<Kunde>($"SELECT * FROM {dbName}");
    }
    public bool Update(Kunde obj)
    {
        return ExecuteCommand($"UPDATE {dbName} SET" +
            $"KundeNummer = '({obj.KundeNummer}'," +
            $"SidsteKøb = '({obj.SidsteKøb}'" +
            $"WHERE KundeNummer = {obj.KundeNummer}");
    }
}
