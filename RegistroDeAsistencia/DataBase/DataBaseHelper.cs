using System.Configuration;
using System.Data.SQLite;
public static class DataBaseHelper
{
    //==============================================
    // Variables de control de la base de datos
    //==============================================
    private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
    private static string rootDataBase = ConfigurationManager.ConnectionStrings["rootDataBase"].ConnectionString;
    private static string structureScriptPath = ConfigurationManager.ConnectionStrings["structureScriptPath"].ConnectionString;
    //==============================================
    // Metodos de inicializacion de base de datos
    //==============================================
    /**
     * Esta funcion inicializa la base de datos si es que no existe.
     * Las rutas estan establecidad en el app.condif. No regresa ningun
     * tipo de dato.
     **/
    public static void InitializeDatabase()
    {
        if (!File.Exists(rootDataBase))
        {
            SQLiteConnection.CreateFile(rootDataBase);
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = File.ReadAllText(structureScriptPath);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}