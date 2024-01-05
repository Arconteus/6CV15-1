using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Dia
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
        public static List<Dia> GetList()
        {
            List<Dia> output = GetListWhere("");
            return output;
        }
        public static List<Dia> GetList(string extraParameters)
        {
            List<Dia> output = GetListWhere(extraParameters);
            return output;
        }

        public static bool ForceAdd(Dia DiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_diasSemana (desc_dia) values (@desc_dia)";
                    command.Parameters.AddWithValue("@desc_dia", DiaInput.desc_dia);
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
        private static List<Dia> GetListWhere(string extraParameters)
        {
            List<Dia> output = new List<Dia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_diasSemana " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Dia()
                            {
                                id_diaSemena = int.Parse(reader["id_diaSemena"].ToString()),
                                desc_dia = reader["desc_dia"].ToString()
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
