namespace ERP;

public class PersonRepository : CommonDBModule<Person>, IDBrepository<Person>
{
    private readonly string dbName = "dbo.Person";
    private readonly string dbFields = "(Fornavn, Efternavn, Email, TelefonNummer, AdresseId)";

    public bool Create(Person obj)
    {
        throw new NotImplementedException();
    }

    public int GetIntFromPerson(Person obj, int id) {
        return ExecuteDapperSingleQuery<int>($"INSERT INTO {dbName} {dbFields} VALUES" +
        $"('{obj.Fornavn}'," +
        $"'{obj.Efternavn}'," +
        $"'{obj.Email}'," +
        $"{obj.TelefonNummer}," +
        $"{id})SELECT SCOPE_IDENTITY()");
    }

    public List<Person> Read()
    {
        return ExecuteDapperQuery($"SELECT * FROM {dbName}");
    }

    public bool Update(Person obj)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
