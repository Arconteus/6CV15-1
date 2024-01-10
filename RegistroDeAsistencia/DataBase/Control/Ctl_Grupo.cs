using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Grupo
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Grupo, que contiene toda la lista de
         * grupos dados de alta.
         * Sintaxis: Ctl_Grupo.GetList()
         * Return Type: List<Grupo>
         **/
        public static List<Grupo> GetList()
        {
            List<Grupo> output = GetListWhere("");
            return output;
        }
        public static List<Grupo> GetList(string extraParameters)
        {
            List<Grupo> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe el grupo,
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_Grupo.Contain([grupoInput])
         * Variables: [grupoInput] -> Grupo{codigo_grupo=[int],anio=[int],periodo=[int]}
         * Return type: bool
         **/
        public static bool Contain(Grupo grupoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from Ctl_Grupo where codigo_grupo = @codigo_grupo " +
                        "and anio = @anio " +
                        "and periodo = @periodo";
                    command.Parameters.AddWithValue("@codigo_grupo", grupoInput.codigo_grupo);
                    command.Parameters.AddWithValue("@anio", grupoInput.anio);
                    command.Parameters.AddWithValue("@periodo", grupoInput.periodo);
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
         * Sintaxis: ctl_grupo.add([Grupo])
         * Variables: [Grupo] -> Grupo()
         * {
         *      codigo_grupo = [int],
         *      anio,periodo = [int],
         *      id_materia_grupo = [int],
         *      id_profesor_grupo = [int]
         * }
         * Return type: bool
         **/
        public static bool Add(Grupo grupoInput)
        {
            bool output = false;
            if (!Contain(grupoInput))
            {
                output = ForceAdd(grupoInput);
            }
            return output;
        }

        public static bool Delete(Grupo grupoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "DELETE FROM ctl_grupo WHERE id_grupo = @id_grupo";
                    command.Parameters.AddWithValue("@id_grupo", grupoInput.id_grupo);
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
        private static bool ForceAdd(Grupo grupoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_grupo 
                        (codigo_grupo,anio,periodo,id_materia_grupo,id_profesor_grupo) 
                        values 
                        (@codigo_grupo,@anio,@periodo,@id_materia_grupo,@id_profesor_grupo)";
                    command.Parameters.AddWithValue("@codigo_grupo", grupoInput.codigo_grupo);
                    command.Parameters.AddWithValue("@anio", grupoInput.anio);
                    command.Parameters.AddWithValue("@periodo", grupoInput.periodo);
                    command.Parameters.AddWithValue("@id_materia_grupo", grupoInput.id_materia_grupo);
                    command.Parameters.AddWithValue("@id_profesor_grupo", grupoInput.id_profesor_grupo);
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
        private static List<Grupo> GetListWhere(string extraParameters)
        {
            List<Grupo> output = new List<Grupo>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_grupo "+ extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Grupo()
                            {
                                id_grupo = int.Parse(reader["id_grupo"].ToString()),
                                codigo_grupo = int.Parse(reader["codigo_grupo"].ToString()),
                                anio = int.Parse(reader["anio"].ToString()),
                                periodo = int.Parse(reader["periodo"].ToString()),
                                id_materia_grupo = int.Parse(reader["id_materia_grupo"].ToString()),
                                id_profesor_grupo = int.Parse(reader["id_profesor_grupo"].ToString())
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
