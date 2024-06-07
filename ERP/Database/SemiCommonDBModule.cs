using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace ERP;

public class SemiCommonDBModule<T>
{
    private T Map<T>(IDataRecord record) where T : new()
    {
        T obj = new T();
        var type = typeof(T);
        var properties = type.GetProperties();

        foreach (var property in properties)
        {
            try
            {
                if (record[property.Name] != DBNull.Value)
                {
                    try
                    {
                        property.SetValue(obj, Convert.ChangeType(record[property.Name], property.PropertyType));
                    }
                    catch
                    {
                        property.SetValue(obj, Enum.Parse(property.PropertyType, record[property.Name].ToString()));
                    }
                }
            }
            catch{ Program.logWriter.LogWrite("Error in SemiCommonDBModule - Map"); }
        }
        return obj;
    }
    private SqlConnection GetConnection()
	{
		SqlConnection connection = new(ConfigSettings.ConnectionString);
		connection.Open();
		return connection;
	}
    protected T ReadSingle<T>(string queryString) where T : new()
    {
        try
        {
            using (SqlConnection sqlConnection = GetConnection())
            {
                SqlCommand sqlCommand = new(queryString, sqlConnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                        return Map<T>(sqlDataReader);
                }
            }
            return new T();
        }
        catch (Exception ex)
        {
            Program.logWriter.LogWrite(ex.Message);
        }
        return new T();
    }
    protected List<T> Reader<T>(string queryString) where T : new()
	{
        try
        {
            List<T> list = new List<T>();

            using (SqlConnection sqlConnection = GetConnection())
            {
                SqlCommand sqlCommand = new(queryString, sqlConnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        T data = Map<T>(sqlDataReader);
                        list.Add(data);
                    }
                    return list;
                }
            }
        }
        catch (Exception ex)
        {
            Program.logWriter.LogWrite(ex.Message);
        }
        return new List<T> { new() };
	}
    protected int ExecuteSingleQuery(string command)
    {
        using var connection = GetConnection();
        using var cmd = new SqlCommand(command, connection);

        using var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return Convert.ToInt32(reader.GetValue(0));
        }
        else
        {
            throw new InvalidOperationException("Query did not return any results.");
        }
    }

    protected bool ExecuteCommand(string queryString)
	{
        try
        {
            int rowsAffected = 0;
            using (SqlConnection sqlConnection = GetConnection())
            {
                SqlCommand sqlCommand = new(queryString, sqlConnection);
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            return rowsAffected >= 1;
        }
        catch (Exception ex)
        {
            Program.logWriter.LogWrite(ex.Message);
        }
        return false;
	}
}
