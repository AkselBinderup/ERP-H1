﻿using Dapper;
using System.Data.SqlClient;

namespace ERP;

public partial class CommonDBModule<T>
{
    protected SqlConnection GetConnection()
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigSettings.ConnectionString);
        sqlConnection.Open();
        return sqlConnection;
    }

    protected bool ExecuteCommand(string command)
    {
        using (var con = GetConnection())
        {
            var rowsAffected = con.Execute(command);
            return rowsAffected > 0;
        }
    }
    protected T ExecuteDapperSingleQuery(string command)
    {
        using (var con = GetConnection())
        {
            T results = con.QuerySingle<T>(command);
            return results;
        }
    }
    //protected IEnumerable<T> ExecuteObject<T>(string sql)
    //{
    //    List<T> items = new List<T>();
    //    var data = ExecuteDataTable(sql); 
    //    foreach (var row in data.Rows)
    //    {
    //        T item = (T)Activator.CreateInstance(typeof(T), row);
    //        items.Add(item);
    //    }
    //    return items;
    //}
    protected List<T> ExecuteDapperQuery<T>(string command)
    {
        using (var con = GetConnection())
        {
            List<T> results = con.Query<T>(command).ToList();
            return results;
        }
    }
}
