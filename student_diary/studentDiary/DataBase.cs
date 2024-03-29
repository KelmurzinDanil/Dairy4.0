using MySql.Data.MySqlClient;

namespace studentDiary
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server = localhost;port = 3306;username = root;password = root;database = testdb");

    }
}
