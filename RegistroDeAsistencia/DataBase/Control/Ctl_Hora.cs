using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Hora
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Carrera, que contiene toda la lista de
         * carreras dadas de alta.
         * Sintaxis: Ctl_Carrera.GetList()
         * Return Type: List<Carrera>
         **/
        public static List<Hora> GetList()
        {
            List<Hora> output = GetListWhere("");
            return output;
        }
        public static List<Hora> GetList(string extraParameters)
        {
            List<Hora> output = GetListWhere(extraParameters);
            return output;
        }

        public static bool ForceAdd(Hora HoraInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_horas (desc_horas) values (@desc_horas)";
                    command.Parameters.AddWithValue("@desc_horas", HoraInput.desc_horas);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        //=============================================================================================================
        // Metodos privados
        //=============================================================================================================

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/


        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static List<Hora> GetListWhere(string extraParameters)
        {
            List<Hora> output = new List<Hora>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_horas " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Hora()
                            {
                                id_horas = int.Parse(reader["id_horas"].ToString()),
                                desc_horas = reader["desc_horas"].ToString()
                            });
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }


    }
}
