using MySql.Data.MySqlClient;

namespace studentDiary
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 8889; username = root; password = root; database = testdb");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
