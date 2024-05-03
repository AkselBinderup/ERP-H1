
using System.Xml.Linq;

namespace ERP;

public class KundeRepository : CommonDBModule<Kunde>, IDBrepository<Kunde>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";
    public bool Create(Kunde obj)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} WHERE Id = '{obj}'");
    }
    public Kunde ReadSingle(int id)
    {
        return ExecuteDapperSingleQuery<Kunde>($"SELECT * FROM {dbName} WHERE Id = '{id}");
    }
    public List<Kunde> Read()
    {
        return ExecuteDapperQuery<Kunde>($"SELECT * FROM {dbName}");
    }

    public bool Update(Kunde obj, int id)
    {
        throw new NotImplementedException();
    }
}
