using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace ERP;

public partial class CompanyDatabase : SemiCommonDBModule<Virksomhed>, IDBrepository<Virksomhed>
{
    private readonly string dbName = "dbo.Virksomhed";
    private readonly string dbFields = "(FirmaNavn, Vej, HusNummer, PostNummer, [By], Land, Valuta)";
    
    private bool IsNumbersNull(Virksomhed obj) 
        => obj.HusNummer == null || obj.PostNummer == null;
    
    public bool Create(Virksomhed obj)
    {
        if (IsNumbersNull(obj))
            throw new ArgumentNullException("|Ikke Gyldigt hus eller postnummer");

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
        if (IsNumbersNull(obj))
            throw new ArgumentNullException("|Ikke Gyldigt hus eller postnummer");

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
