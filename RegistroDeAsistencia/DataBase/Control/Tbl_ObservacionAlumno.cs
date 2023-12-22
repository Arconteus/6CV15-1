using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Tbl_ObservacionAlumno
    {

        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase ObservacionAlumno, que contiene toda la lista de
         * todas las observaciones de cada alumno que han sido registradas.
         * Sintaxis: Tbl_ObservacionAlumno.GetList()
         * Return Type: List<ObservacionAlumno>
         **/
        public static List<ObservacionAlumno> GetList()
        {
            List<ObservacionAlumno> output = GetListWhere("");
            return output;
        }
        public static List<ObservacionAlumno> GetList(string extraParameters)
        {
            List<ObservacionAlumno> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta funcion añade una observacion asociaco a un alumno, regresando un valor verdadero
         * si la adicion fue exitosa, en caso contrario devolvera un valor falso
         * Sintaxis: Tbl_ObservacionAlumno.Add([observacionAlumnoInput])
         * Variables: [observacionAlumnoInput] = ObservacionAlumno()
         * {
         *      id_relacion_observacion = [int],
         *      observacion = [string]
         * }
         * Return Type: [bool]
         **/
        public static bool Add(ObservacionAlumno observacionAlumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO tbl_observacionAlumno 
                        (id_relacion_observacion,observacion) 
                        values 
                        (@id_relacion_observacion,@observacion)";
                    command.Parameters.AddWithValue("@id_relacion_observacion", observacionAlumnoInput.id_relacion_observacion);
                    command.Parameters.AddWithValue("@observacion", observacionAlumnoInput.observacion);
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
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de ObservacionAlumno que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Tbl_ObservacionAlumno.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<ObservacionAlumno>
         **/
        private static List<ObservacionAlumno> GetListWhere(string extraParameters)
        {
            List<ObservacionAlumno> output = new List<ObservacionAlumno>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_observacionAlumno " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new ObservacionAlumno()
                            {
                                id_observacionAlumno = int.Parse(reader["id_observacionAlumno"].ToString()),
                                id_relacion_observacion = int.Parse(reader["id_relacion_observacion"].ToString()),
                                observacion = reader["observacion"].ToString()
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
