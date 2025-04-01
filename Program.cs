using LuffyMoney.DataBase;
using Microsoft.EntityFrameworkCore;

namespace LuffyMoney
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add-Migration InitialCreate
            // Создаём или обновляем базу данных
            using (var db = new AppDbContext())
            {
                db.Database.Migrate(); // Создаст БД, если её нет
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}