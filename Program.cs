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
            // ������ ��� ��������� ���� ������
            using (var db = new AppDbContext())
            {
                db.Database.Migrate(); // ������� ��, ���� � ���
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}