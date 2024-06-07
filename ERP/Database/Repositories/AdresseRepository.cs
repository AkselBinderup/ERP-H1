
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
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES ('{obj.VejNavn}', {obj.VejNummer}, '{obj.ByNavn}', {obj.PostNummer})");
    }

    public int GetSingleId(Adresse obj)
    {
        return ExecuteSingleQuery($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.VejNavn}'," +
            $"'{obj.VejNummer}'," +
            $"'{obj.ByNavn}'," +
            $"'{obj.PostNummer}') SELECT SCOPE_IDENTITY()");
    }

    public Adresse GetSingleAddress(Adresse obj)
    {
        return ReadSingle<Adresse>($"SELECT * FROM {dbName} " +
			$"WHERE VejNavn = '{obj.VejNavn}' AND " +
			$"Vejnummer = {obj.VejNummer} AND " +
			$"Bynavn = '{obj.ByNavn}' AND " +
			$"Postnummer = {obj.PostNummer}");
	}
public List<Adresse> Read()
    {
        return Reader<Adresse>($"SELECT * FROM {dbName}");
    }

    public bool Update(Adresse newAddress, Adresse oldAddress)
    {
        return ExecuteCommand($"UPDATE {dbName} SET " +
            $"VejNavn = '{newAddress.VejNavn}', " +
            $"VejNummer = {newAddress.VejNummer}, " +
            $"ByNavn = '{newAddress.ByNavn}', " +
            $"PostNummer = {newAddress.PostNummer}" +
            $"WHERE Vejnavn = '{oldAddress.VejNavn}' AND " +
            $"Vejnummer = {oldAddress.VejNummer} AND " +
            $"Bynavn = '{oldAddress.ByNavn}' AND " +
            $"Postnummer = {oldAddress.PostNummer}");
    }



    public bool Delete(Adresse obj)
    {
        return ExecuteCommand($"DELETE FROM {dbName} " +
            $"WHERE VejNavn = '{obj.VejNavn}' AND " +
            $"Vejnummer = {obj.VejNummer} AND " +
            $"Bynavn = '{obj.ByNavn}' AND " +
            $"Postnummer = {obj.PostNummer}");
    }
}
