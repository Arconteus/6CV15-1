using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Tbl_RegistroAsistencia
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase RegistroAsistencia, que contiene toda la lista de
         * todos los registros de asistencia dados de alta.
         * Sintaxis: tbl_registroAsistencia.GetList()
         * Return Type: List<RegistroAsistencia>
         **/
        public static List<RegistroAsistencia> GetList()
        {
            List<RegistroAsistencia> output = GetListWhere("");
            return output;
        }
        public static List<RegistroAsistencia> GetList(string extraParameters)
        {
            List<RegistroAsistencia> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe el registro de asistencia,
         * en caso contrario, regresara false.
         * Sintaxis: tbl_registroAsistencia.Contain([RegistroAsistencia])
         * Variables: [RegistroAsistencia] -> RegistroAsistencia{id_registro=[int]}
         * Return type: bool
         **/
        public static bool Contain(RegistroAsistencia registroAsistenciaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_registroAsistencia " +
                        "where id_registro = @id_grupo_registro " +
                        "and fecha_registro = @fecha_registro";
                    command.Parameters.AddWithValue("@id_grupo_registro", registroAsistenciaInput.id_grupo_registro);
                    command.Parameters.AddWithValue("@fecha_registro", registroAsistenciaInput.fecha_registro);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = true;
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        /**
         * Esta funcion añade un registro de asistencia si y solo no esta registrado antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si el registro ya existe no se añadira el
         * mismo registro dos veces y regresara un valor falso.
         * Sintaxis: tbl_registroAsistencia.add([RegistroAsistencia])
         * Variables: [RegistroAsistencia] -> RegistroAsistencia()
         * {
         *      id_grupo_registro = [int],
         *      fecha_registro = [string],
         *      hora_registro = [string]
         * }
         * Return type: bool
         **/
        public static bool Add(RegistroAsistencia registroAsistenciaInput)
        {
            bool output = false;
            if (!Contain(registroAsistenciaInput))
            {
                output = ForceAdd(registroAsistenciaInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos privados
        //=============================================================================================================

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static bool ForceAdd(RegistroAsistencia registroAsistenciaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO tbl_registroAsistencia 
                        (id_grupo_registro,fecha_registro,hora_registro) 
                        values 
                        (@id_grupo_registro,@fecha_registro,@hora_registro)";
                    command.Parameters.AddWithValue("@id_grupo_registro", registroAsistenciaInput.id_grupo_registro);
                    command.Parameters.AddWithValue("@fecha_registro", registroAsistenciaInput.fecha_registro);
                    command.Parameters.AddWithValue("@hora_registro", registroAsistenciaInput.hora_registro);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static List<RegistroAsistencia> GetListWhere(string extraParameters)
        {
            List<RegistroAsistencia> output = new List<RegistroAsistencia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_registroAsistencia "+ extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new RegistroAsistencia()
                            {
                                id_registro = int.Parse(reader["id_registro"].ToString()),
                                id_grupo_registro = int.Parse(reader["id_grupo_registro"].ToString()),
                                fecha_registro = reader["fecha_registro"].ToString(),
                                hora_registro = reader["hora_registro"].ToString()
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
