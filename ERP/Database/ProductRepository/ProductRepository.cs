using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL;

namespace ERP;

public class ProductRepository : CommonDBModule<Produkt>, IDBrepository<Produkt>
{
    private readonly string dbName = "";
    private readonly string dbFields = "";

    public bool Create(Produkt obj)
    {
        return ExecuteCommand($"INSERT INTO {dbName} {dbFields} VALUES" +
            $"('{obj.VareNummer}'," +
            $"'{obj.Navn}'," +
            $"'{obj.Beskrivelse}'," +
            $"'{obj.SalgsPris}'," +
            $"'{obj.IndkøbsPris}'," +
            $"'{obj.Lokation}'," +
            $"'{obj.AntalLager}'," +
            $"'{obj.AntalLager}'");
    }
    public List<Produkt> Read()
    {
        return ExecuteDapperQuery<Produkt>($"Select * from {dbName}");
    }
    public bool Update(Produkt obj, int id)
    {
        return ExecuteCommand($"UPDATE {dbName} " +
            $"SET VareNummer = {obj.VareNummer}," +
            $"Navn = {obj.Navn}," +
            $"Beskrivelse = {obj.Beskrivelse}," +
            $"SalgsPris = {obj.SalgsPris}," +
            $"IndkøbsPris = {obj.IndkøbsPris}," +
            $"Lokation = {obj.Lokation}," +
            $"AntalLager = {obj.AntalLager}," +
            $"Enhed = {obj.AntalLager} WHERE Id = {id}");
    }
    public bool Delete(int obj)
    {
        return ExecuteCommand($"DELETE * FROM {dbName} where Id = '{obj}'");
    }
}
