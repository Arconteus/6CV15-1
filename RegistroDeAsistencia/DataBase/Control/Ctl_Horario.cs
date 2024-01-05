using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public static class Ctl_Horario
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase CodigoGrupo, que contiene toda la lista de
         * codigos de grupo dados de alta.
         * Sintaxis: Ctl_CodigoGrupo.GetList()
         * Return Type: List<CodigoGrupo>
         **/
        public static List<Horario> GetList()
        {
            List<Horario> output = GetListWhere("");
            return output;
        }
        public static List<Horario> GetList(string extraParameters)
        {
            List<Horario> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe el codigo de grupo,
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_CodigoGrupo.Contain([codigoGrupo])
         * Variables: [codigoGrupoInput] -> CodigoGrupo{desc_grupo=[string]}
         * Return type: bool
         **/
        public static bool Contain(Horario HorarioInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_horario where grupo_horario = @grupo_horario" +
                        "and hora_horario = @hora_horario" +
                        "and dia_horario = @dia_horario";
                    command.Parameters.AddWithValue("@grupo_horario", HorarioInput.grupo_horario);
                    command.Parameters.AddWithValue("@hora_horario", HorarioInput.hora_horario);
                    command.Parameters.AddWithValue("@dia_horario", HorarioInput.dia_horario);
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
         * Esta funcion añade un codigo de grupo si y solo no esta registrado este codigo antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si el codigo ya existe no se añadira el
         * mismo codigo dos veces y regresara un valor falso.
         * Sintaxis: Ctl_CodigoGrupo.add([CodigoGrupo])
         * Variables: [CodigoGrupo] -> CodigoGrupo(){codigo_grupo=[string]}
         * Return type: bool
         **/
        public static bool Add(Horario HorarioInput)
        {
            bool output = false;
            if (!Contain(HorarioInput))
            {
                output = ForceAdd(HorarioInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos privados
        //=============================================================================================================

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static bool ForceAdd(Horario HorarioInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_horario (grupo_horario,hora_horario,dia_horario) values (@grupo_horario,@hora_horario,@dia_horario)";
                    command.Parameters.AddWithValue("@grupo_horario", HorarioInput.grupo_horario);
                    command.Parameters.AddWithValue("@hora_horario", HorarioInput.hora_horario);
                    command.Parameters.AddWithValue("@dia_horario", HorarioInput.dia_horario);
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
        private static List<Horario> GetListWhere(string extraParameters)
        {
            List<Horario> output = new List<Horario>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_horario " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Horario()
                            {
                                id_horario = int.Parse(reader["id_horario"].ToString()),
                                grupo_horario = int.Parse(reader["grupo_horario"].ToString()),
                                hora_horario = int.Parse(reader["hora_horario"].ToString()),
                                dia_horario = int.Parse(reader["dia_horario"].ToString()),
                            });
                        }
                    }
                }
            }
            return output;
        }
    }
}
