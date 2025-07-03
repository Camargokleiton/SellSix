using SellSix.Model.Entities;

namespace SellSix.Model.DataAccess
{
    public static class UserDao
    {

        static DatabaseManager  databaseManager;

        public List<User> GetUsersList()
        {
            databaseManager = DatabaseManager.GetInstance("");

        }

    }
}
