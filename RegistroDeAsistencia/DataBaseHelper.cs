using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Configuration;

public class DataBaseHelper
{
    //==============================================
    // Variables de control de la base de datos
    //==============================================
    private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
    private static string rootDataBase = ConfigurationManager.ConnectionStrings["rootDataBase"].ConnectionString;
    private static string structureScriptPath = ConfigurationManager.ConnectionStrings["structureScriptPath"].ConnectionString;
    /**
     * Esta funcion inicializa la base de datos si es que no existe.
     **/
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
                    command.CommandText = File.ReadAllText(structureScriptPath);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
    public static void addCodigoGrupo(string codigoGrupoToAdd) 
    {
        using(var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using(SQLiteCommand command = new SQLiteCommand(connection) )
            {
                command.CommandText=
                    @"INSERT INTO ctl_codigoGrupo (desc_grupo) values (@codigo_grupo)";
                command.Parameters.AddWithValue("@codigo_grupo",codigoGrupoToAdd);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
        }
    }
}