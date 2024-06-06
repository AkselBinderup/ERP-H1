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
            catch
            {

            }

        }

        return obj;
    }

    private SqlConnection GetConnection()
	{
		SqlConnection connection = new(ConfigSettings.ConnectionString);
		connection.Open();
		return connection;
	}

	protected List<T> Reader<T>(string queryString) where T : new()
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
    protected Type ExecuteSingleQuery<Type>(string command)
    {
        using var connection = GetConnection();
        using var cmd = new SqlCommand(command, connection);

        using var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return (Type)reader.GetValue(0);
        }
        else
        {
            throw new InvalidOperationException("Query did not return any results.");
        }
    }

    protected bool ExecuteCommand(string queryString)
	{
		int rowsAffected = 0;
		using (SqlConnection sqlConnection = GetConnection())
		{
			SqlCommand sqlCommand = new(queryString, sqlConnection);
			rowsAffected = sqlCommand.ExecuteNonQuery();
		}
		return rowsAffected >= 1;
	}
}
