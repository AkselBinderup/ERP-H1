using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace ERP;

public partial class Database<T>
{
	private SqlConnection GetConnection()
	{
		SqlConnection connection = new(ConfigSettings.ConnectionString);
		connection.Open();
		return connection;
	}

	public List<T> Reader(string queryString, Func<IDataRecord, T> mapFuncion)
	{
		List<T> list = new List<T>();

		using (SqlConnection sqlConnection = GetConnection())
		{
			SqlCommand sqlCommand = new(queryString, sqlConnection);

			using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
			{
				while (sqlDataReader.Read())
				{
					T data = mapFuncion(sqlDataReader);
					list.Add(data);
				}
				return list;
			}
		}
	}

	public void ExecuteCommand(string queryString)
	{
		using (SqlConnection sqlConnection = GetConnection())
		{
			SqlCommand sqlCommand = new(queryString, sqlConnection);
			sqlCommand.ExecuteNonQuery();
		}
	}


}
