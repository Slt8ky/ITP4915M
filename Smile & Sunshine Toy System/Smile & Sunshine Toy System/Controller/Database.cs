using MySql.Data.MySqlClient;

public sealed class Database
{
    private static readonly Database instance = new Database();
    private MySqlConnection connection;
    private string connectionString = "server=127.0.0.1;uid=user;database=default;pwd=6wS1Ah753ylT;Convert Zero Datetime=true;";

    private Database()
    {
        connection = new MySqlConnection(connectionString);
        connection.Open(); // Open connection here
    }

    public static Database Instance => instance;

    public MySqlConnection Connection
    {
        get
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }

    public void CloseConnection()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}