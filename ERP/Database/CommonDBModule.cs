using System.Data.SqlClient;

namespace ERP;

public partial class CommonDBModule
{
    public SqlConnection GetConnection()
    {
        SqlConnection sqlConnection = new SqlConnection("Indsæt connstræng");
        sqlConnection.Open();
        return sqlConnection;
    }

    public bool ExecuteCommand()
    {
        //laver lige en hurtig execute senere
        return true;
    }
}
