using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    internal class Ctl_Materias
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Materia, que contiene toda la lista de
         * Materia dados de alta.
         * Sintaxis: Ctl_Materias.GetList()
         * Return Type: List<Materia>
         **/
        public static List<Materia> GetList()
        {
            List<Materia> output = new List<Materia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_materias";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Materia()
                            {
                                id_materia = int.Parse(reader["id_materia"].ToString()),
                                nom_materia = reader["nom_materia"].ToString()
                            });
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe la materia,
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_Materias.Contain([materiaInput])
         * Variables: [materiaInput] -> Materia(){nom_materia=[string]}
         * Return type: bool
         **/
        public static bool Contain(Materia materiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_materias where nom_materia = @nom_materia";
                    command.Parameters.AddWithValue("@nom_materia", materiaInput.nom_materia);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["nom_materia"].ToString() == materiaInput.nom_materia)
                            {
                                output = true;
                            }
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        /**
         * Esta funcion añade la materia si y solo no esta registrado esta antes, cuando la adicion
         * es exitosa regresa un valor verdadero, pero si la materia ya existe no se añadira la
         * misma materia dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Materias.add([materiaInput])
         * Variables: [materia] -> Materia(){nom_materia=[string]}
         * Return type: bool
         **/
        public static bool Add(Materia materiaInput)
        {
            bool output = false;
            if (!Contain(materiaInput))
            {
                output = ForceAdd(materiaInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de Carreas que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Ctl_Materias.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<Carrera>
         **/
        public static List<Materia> GetListWhere(string parameter, string value)
        {
            List<Materia> output = new List<Materia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_materias where @parameter = @value";
                    command.Parameters.AddWithValue("@parameter", parameter);
                    command.Parameters.AddWithValue("@value", value);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Materia()
                            {
                                id_materia = int.Parse(reader["id_materia"].ToString()),
                                nom_materia = reader["nom_materia"].ToString()
                            });
                        }
                    }
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
        private static bool ForceAdd(Materia materiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_materias (nom_carrera) values (@nom_carrera)";
                    command.Parameters.AddWithValue("@nom_carrera", materiaInput.nom_materia);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }
    }
}
