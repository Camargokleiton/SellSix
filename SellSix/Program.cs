using SellSix.Model.Entities;
using SellSix.Model.DataAccess;

namespace SellSix
{
    internal static class Program
    {
        public static List<User> _savedUsers = new List<User>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _savedUsers = UserDao.GetUsersList();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen());
        }
    }
}