using Microsoft.Data.Sqlite;

namespace QuanLyCaPhe.Utils;

public class DBConnect
{
    private static readonly string DbPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Database\QuanLyCaPhe.db"));
    private static readonly string ConnectionString = $"Data Source={DbPath};";
    
    public static SqliteConnection GetConnection()
    {
        var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        using var pragmaCmd = connection.CreateCommand();
        pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
        pragmaCmd.ExecuteNonQuery();

        return connection;
    }
}
