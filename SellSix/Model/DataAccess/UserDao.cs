using SellSix.Model.Entities;

namespace SellSix.Model.DataAccess
{
    public static class UserDao
    {
        static DatabaseManager databaseManager;

        public static List<User> GetUsersList()
        {
            string fullPath = Path.GetFullPath("../../../Data/Reg.db");
            databaseManager = DatabaseManager.GetInstance($"Data Source={fullPath};Version=3;");

            List<User> users = new List<User>();

            string query = "SELECT * FROM users";

            using (var reader = databaseManager.ExecuteQuery(query))
            {
                while (reader.Read())
                {

                    User user = new User
                    {
                        _id = reader.GetInt64(reader.GetOrdinal("id")),
                        _name = reader.GetString(reader.GetOrdinal("username")),
                        _email = reader.GetString(reader.GetOrdinal("email")),
                        _password = reader.GetString(reader.GetOrdinal("password")),
                        _document = reader.GetString(reader.GetOrdinal("document")),
                        _accesslevel = reader.GetInt32(reader.GetOrdinal("accesslevel")),
                        _address = reader.GetString(reader.GetOrdinal("address")),
                        _city = reader.GetString(reader.GetOrdinal("city")),
                        _phone = reader.GetString(reader.GetOrdinal("phone"))

                    };

                    users.Add(user);
                }
            }

            databaseManager.Close();

            return users;
        }

        public static void AddUser(User user)
        {
            databaseManager = DatabaseManager.GetInstance("../../Data/Reg.db");
            string query = $"INSERT INTO users (username, email, password, document, accesslevel, address, city, phone) " +
                           $"VALUES ('{user._name}', '{user._email}', '{user._password}', '{user._document}', {user._accesslevel}, '{user._address}', '{user._city}', '{user._phone}')";
            databaseManager.ExecuteNonQuery(query);
            databaseManager.Close();
        }

        public static void UpdateUser(User user)
        {
            databaseManager = DatabaseManager.GetInstance("../../Data/Reg.db");
            string query = $"UPDATE users SET username = '{user._name}', email = '{user._email}', password = '{user._password}', " +
                           $"document = '{user._document}', accesslevel = {user._accesslevel}, address = '{user._address}', city = '{user._city}', phone = '{user._phone}' " +
                           $"WHERE id = {user._id}";
            databaseManager.ExecuteNonQuery(query);
            databaseManager.Close();
        }

        public static void DeleteUser(long userId)
        {
            databaseManager = DatabaseManager.GetInstance("../../Data/Reg.db");
            string query = $"DELETE FROM users WHERE id = {userId}";
            databaseManager.ExecuteNonQuery(query);
            databaseManager.Close();

        }
        public static User GetUser(long userId) {
            databaseManager = DatabaseManager.GetInstance("../../Data/Reg.db");
            string query = $"SELECT * FROM users WHERE id = {userId}";

            using (var reader = databaseManager.ExecuteQuery(query))
            {
                if (reader.Read())
                {
                    User user = new User
                    {
                        _id = reader.GetInt64(reader.GetOrdinal("id")),
                        _name = reader.GetString(reader.GetOrdinal("username")),
                        _email = reader.GetString(reader.GetOrdinal("email")),
                        _password = reader.GetString(reader.GetOrdinal("password")),
                        _document = reader.GetString(reader.GetOrdinal("document")),
                        _accesslevel = reader.GetInt32(reader.GetOrdinal("accesslevel")),
                        _address = reader.GetString(reader.GetOrdinal("address")),
                        _city = reader.GetString(reader.GetOrdinal("city")),
                        _phone = reader.GetString(reader.GetOrdinal("phone"))
                    };

                    databaseManager.Close();
                    return user;
                }
            }

            databaseManager.Close();
            return new User();
        }
    }
}