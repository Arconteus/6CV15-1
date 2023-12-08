using RegistroDeAsistencia.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Control
{
    internal class Tbl_ObservacionRegistro
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase ObservacionRegistro, que contiene toda la lista de
         * todas las observaciones de cada registros dados de alta.
         * Sintaxis: tbl_observacionRegistro.GetList()
         * Return Type: List<ObservacionRegistro>
         **/
        public static List<ObservacionRegistro> GetList()
        {
            List<ObservacionRegistro> output = new List<ObservacionRegistro>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_observacionRegistro";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new ObservacionRegistro()
                            {
                                id_observacionRegistro = int.Parse(reader["id_observacionRegistro"].ToString()),
                                id_registro_observacion = int.Parse(reader["id_registro_observacion"].ToString()),
                                observacion = reader["observacion"].ToString()
                            });
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion añade una observacion asociaco a un registro de asistencia, regresando un valor verdadero
         * si la adicion fue exitosa, en caso contrario devolvera un valor falso
         * Sintaxis: Tbl_ObservacionRegistro.Add([observacionRegistroInput])
         * Variables: [observacionRegistroInput] = ObservacionRegistro()
         * {
         *      id_registro_observacion = [int],
         *      observacion = [string]
         * }
         * Return Type: [bool]
         **/
        public static bool Add(ObservacionRegistro observacionRegistroInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO tbl_observacionRegistro 
                        (id_registro_observacion,observacion) 
                        values 
                        (@id_registro_observacion,@observacion)";
                    command.Parameters.AddWithValue("@id_registro_observacion", observacionRegistroInput.id_registro_observacion);
                    command.Parameters.AddWithValue("@observacion", observacionRegistroInput.observacion);
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
         * Esta funcion retorna una lista de ObservacionRegistro que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Tbl_ObservacionRegistro.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<RegistroAsistencia>
         **/
        public static List<ObservacionRegistro> GetListWhere(string parameter, string value)
        {
            List<ObservacionRegistro> output = new List<ObservacionRegistro>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_observacionRegistro where @parameter = @value";
                    command.Parameters.AddWithValue("@parameter", parameter);
                    command.Parameters.AddWithValue("@value", value);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new ObservacionRegistro()
                            {
                                id_observacionRegistro = int.Parse(reader["id_observacionRegistro"].ToString()),
                                id_registro_observacion = int.Parse(reader["id_registro_observacion"].ToString()),
                                observacion = reader["observacion"].ToString()
                            });
                        }
                    }
                }
            }
            return output;
        }

    }
}
