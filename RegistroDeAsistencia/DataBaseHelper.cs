using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;

public class DataBaseHelper
{
    //==============================================
    // Variables de control de la base de datos
    //==============================================
    private static string connectionString = @"Data Source=..\..\..\Files\LibraryManagementSystem.db;Version=3;";
    private static string rootDataBase = @"..\..\..\Files\LibraryManagementSystem.db";
    private static string structureQueryPath = @"..\..\..\Files\structureQuery.txt";
    public static void InitializeDatabase()
    {
        if (!File.Exists(rootDataBase))
        {
            SQLiteConnection.CreateFile(rootDataBase);
            using(var connection = new SQLiteConnection(connectionString)) 
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection) )
                {
                    command.CommandText = File.ReadAllText(structureQueryPath);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}