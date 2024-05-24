
using Org.BouncyCastle.Crypto.Signers;
using System.Xml.Linq;

namespace ERP;

public class AdresseRepository : CommonDBModule<Adresse>, IDBrepository<Adresse>
{
    private readonly string dbName = "dbo.Adresse";
    private readonly string dbFields = "(VejNavn, VejNummer, ByNavn, PostNummer)";

    public bool Create(Adresse obj)
    {
        throw new NotImplementedException();
    }

    public int GetSingleId(Adresse obj)
    {
        return ExecuteDapperSingleQuery<int>($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.VejNavn}'," +
            $"'{obj.VejNummer}'," +
            $"'{obj.By}'," +
            $"'{obj.PostNummer}') SELECT SCOPE_IDENTITY()");
        
    }

    public List<Adresse> Read()
    {
        throw new NotImplementedException();
    }

    public bool Update(Adresse obj)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
