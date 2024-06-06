
using Org.BouncyCastle.Crypto.Signers;
using System.Data;
using System.Xml.Linq;

namespace ERP;

public class AdresseRepository : SemiCommonDBModule<Adresse>
{
    private readonly string dbName = "dbo.Adresse";
    private readonly string dbFields = "(VejNavn, VejNummer, ByNavn, PostNummer)";

    public bool Create(Adresse obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES ('{obj.VejNavn}', {obj.VejNummer}, '{obj.By}', {obj.PostNummer})");
    }

    public int GetSingleId(Adresse obj)
    {
        return ExecuteSingleQuery<int>($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.VejNavn}'," +
            $"'{obj.VejNummer}'," +
            $"'{obj.By}'," +
            $"'{obj.PostNummer}') SELECT SCOPE_IDENTITY()");
    }

public List<Adresse> Read()
    {
        return Reader<Adresse>($"SELECT * FROM {dbName}");
    }

    public bool Update(Adresse obj)
    {
        return ExecuteCommand($"UPDATE {dbName} SET " +
            $"VejNavn = {obj.VejNavn}," +
            $" VejNummer = {obj.VejNummer}, " +
            $"ByNavn = '{obj.By}', " +
            $"PostNummer = '{obj.By}'" +
            $"WHERE Vejnavn = '{obj.VejNavn}' AND " +
            $"Vejnummer = {obj.VejNummer} AND " +
            $"Bynavn = '{obj.By}' AND " +
            $"Postnummer = {obj.PostNummer}");
    }

    public bool Delete(Adresse obj)
    {
        return ExecuteCommand($"DELETE FROM {dbName} " +
            $"WHERE VejNavn = '{obj.VejNavn}' AND " +
            $"Vejnummer = {obj.VejNummer} AND " +
            $"Bynavn = '{obj.By}' AND " +
            $"Postnummer = {obj.PostNummer}");
    }
}
