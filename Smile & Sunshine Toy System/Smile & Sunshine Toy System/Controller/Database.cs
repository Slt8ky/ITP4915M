using MySql.Data.MySqlClient;

public sealed class Database
{
    private static readonly Database instance = new Database();
    private MySqlConnection connection;
    private string connectionString = "server=172.26.45.216;uid=root;database=default;pwd=Vx|T77(6\"&bM;Convert Zero Datetime=true;";

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