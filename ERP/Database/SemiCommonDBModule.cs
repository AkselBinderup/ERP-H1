using MySql.Data.MySqlClient;
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

	public List<T> Reader(string queryString, int[] collumns)
	{
		using (SqlConnection sqlConnection = GetConnection())
		{
			SqlCommand sqlCommand = new(queryString, sqlConnection);

			using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
			{
				List<T> list = new List<T>();
				while (sqlDataReader.Read())
				{
					foreach (int collumn in collumns) 
					{
						list.Add((T)sqlDataReader[collumn]);
					}
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
