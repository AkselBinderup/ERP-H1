﻿using System.Data.SqlClient;
using Dapper;

namespace ERP;

public partial class CommonDBModule<T>
{
    protected SqlConnection GetConnection()
    {
        SqlConnection sqlConnection = new SqlConnection("Indsæt connstræng");
        sqlConnection.Open();
        return sqlConnection;
    }

    protected bool ExecuteCommand(string command)
    {
        using (var con = GetConnection())
        {
            var rowsaffected = con.Execute(command);
            return rowsaffected > 0;
        }

    }
    protected List<T> ExecuteDapperQuery<T>(string command)
    {
        using (var con = GetConnection())
        {
            List<T> results = con.Query<T>(command).ToList();
            return results;
        }
    }
}
