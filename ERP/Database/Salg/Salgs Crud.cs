using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using TECHCOOL;
using System.Xml.Linq;

namespace ERP;

public class Salgs_Crud : CommonDBModule<Salgsordrehoved>, IDBrepository<Salgsordrehoved>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";
    public bool Create(Salgsordrehoved obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.OrdreNummer}'," +
            $"'{obj.OprettelsesTidspunkt}'," +
            $"'{obj.GennemførelsesTidspunkt}'," +
            $"'{obj.KundeNummer}'," +
            $"'{obj.Tilstand_}'," +
            $"'{obj.Ordrebeløb}',");
    }

    public List<Salgsordrehoved> Read()
    {
        return ExecuteDapperQuery<Salgsordrehoved>($"Select * from {dbName}");
    }

    public bool Update(Salgsordrehoved obj, int id)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET OrdreNummer = {obj.OrdreNummer}," +
            $"OprettelsesTidspunkt = {obj.OprettelsesTidspunkt}," +
            $"GennemførelsesTidspunkt = {obj.GennemførelsesTidspunkt}," +
            $"KundeNummer = {obj.KundeNummer}," +
            $"Tilstand = {obj.Tilstand_}," +
            $"Ordrebeløb = {obj.Ordrebeløb}," + "WHERE Id = {id}");
    }

    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
