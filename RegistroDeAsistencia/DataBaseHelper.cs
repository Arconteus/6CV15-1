using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;

public class DataBaseHelper {
    private static string connectionString = @"Data Source=..\..\Files\LibraryManagementSystem.db;Version=3;";

    public static void InitializeDatabase()
    {
        string fileroot = @"..\..\Files\LibraryManagementSystem.db";
        if (!File.Exists(fileroot)) 
        {
            SQLiteConnection.CreateFile(fileroot);
            using(var connection = new SQLiteConnection(connectionString)) 
            {
                connection.Open();
                // create tables for your data
                string createBooksTableQuery = @"
                CREATE TABLE IF NOT EXISTS books(
                    
                )
                ";
            }
        }

    }
}