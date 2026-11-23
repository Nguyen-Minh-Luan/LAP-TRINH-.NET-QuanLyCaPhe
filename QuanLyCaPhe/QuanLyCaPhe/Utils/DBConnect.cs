using Microsoft.Data.Sqlite;

namespace QuanLyCaPhe.Utils;

public class DBConnect
{
    private static readonly string DbPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Database\QuanLyCaPhe.db"));
    private static readonly string ConnectionString = $"Data Source={DbPath};";
    
    static DBConnect()
    {
        KiemTraVaCapNhatBang();
    }

    private static void KiemTraVaCapNhatBang()
    {
        try
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            using var cmd = connection.CreateCommand();
            cmd.CommandText = "PRAGMA table_info(MON_AN);";
            using var reader = cmd.ExecuteReader();
            bool coCotHinhAnh = false;
            while (reader.Read())
            {
                if (reader["name"].ToString() == "HinhAnh")
                {
                    coCotHinhAnh = true;
                    break;
                }
            }
            reader.Close();

            if (!coCotHinhAnh)
            {
                using var alterCmd = connection.CreateCommand();
                alterCmd.CommandText = "ALTER TABLE MON_AN ADD COLUMN HinhAnh BLOB;";
                alterCmd.ExecuteNonQuery();
            }
        }
        catch
        {
        }
    }

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
