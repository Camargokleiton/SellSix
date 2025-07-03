using System.Data.SQLite;

namespace SellSix.Model
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance = null;
        private string _connectionString;
        private SQLiteConnection _connection;

        private DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SQLiteConnection(_connectionString);
        }

        // Singleton
        public static DatabaseManager GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new DatabaseManager(connectionString);
            }
            return _instance;
        }

        public void Open()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
                _connection.Open();
        }

        public void Close()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
                _connection.Close();
        }

        public void ExecuteNonQuery(string query)
        {
            Open();
            using (var cmd = new SQLiteCommand(query, _connection))
            {
                cmd.ExecuteNonQuery();
            }
            Close();
        }

        public SQLiteDataReader ExecuteQuery(string query)
        {
            Open();
            var cmd = new SQLiteCommand(query, _connection);
            return cmd.ExecuteReader(); 
        }
    }
}
