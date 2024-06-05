using Mysqlx.Crud;
using TECHCOOL.UI;

namespace ERP;

public class SalgsRepository : SemiCommonDBModule<SalgsOrdreHoved>, IDBrepository<SalgsOrdreHoved>
{
    private readonly string dbName = "dbo.SalgsOrdreHoved";
    private readonly string dbFields = "(OprettelsesTidspunkt, " +
        "KundeNummer, Tilstand, OrdreBeløb)";

    public bool Create(SalgsOrdreHoved obj)
    {
        bool isCreated = ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES(" +
            $" GETDATE()," +
            $"{obj.KundeNummer}," +
            $"'{obj.Tilstand}'," +
            $"{obj.Ordrebeløb})"
            );
		
        CheckGennemFørt(obj);

        return isCreated;
	}

    public List<SalgsOrdreHoved> Read()
    {
        return Reader<SalgsOrdreHoved>($"Select * from {dbName}");
    }

    public bool Update(SalgsOrdreHoved obj)
    {
        CheckGennemFørt(obj);

        return ExecuteCommand($"UPDATE {dbName} Set " +
            $"Tilstand = '{obj.Tilstand}'," +
            $"Ordrebeløb = {obj.Ordrebeløb}, " +
			$"KundeNummer = {obj.KundeNummer} " +
			$"WHERE OrdreNummer = {obj.OrdreNummer}");
    }

    private void CheckGennemFørt(SalgsOrdreHoved obj)
    {
		if (obj.Tilstand == Tilstand.Færdig)
		{
			ExecuteCommand($"UPDATE {dbName} SET " +
				$"GennemførelsesTidspunkt = GETDATE() " +
				$"WHERE OrdreNummer = {obj.OrdreNummer}");
		}
	}

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE {dbName} WHERE OrdreNummer = {obj}");
    }
}
